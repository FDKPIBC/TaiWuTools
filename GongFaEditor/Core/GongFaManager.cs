using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Reflection;
using System.Diagnostics;

namespace GongFaEditor.Core
{
    public class GongFaManager
    {
        public string BasePath = AppDomain.CurrentDomain.BaseDirectory;

        public List<GongFa> GongFaList { get; set; }

        public Dictionary<int, Dictionary<int, string>> GongFaData { get; set; }

        private Dictionary<int, Dictionary<int, string>> textColor;

        public Dictionary<int, Dictionary<int, string>> MessageDate { get; set; }

        private List<int> textColorKeys;

        public GongFaManager()
        {
            GongFaData = new Dictionary<int, Dictionary<int, string>>();
            GongFaList = new List<GongFa>();
            MessageDate = new Dictionary<int, Dictionary<int, string>>();
            textColorKeys = new List<int>();
            textColor = new Dictionary<int, Dictionary<int, string>>();
            GetTextColor();
        }

        /// <summary>
        /// 获取颜色代码
        /// </summary>
        private void GetTextColor()
        {
            string path = string.Format("{0}\\{1}.txt", this.BasePath, "TextColor_Date");
            string text;
            if (File.Exists(path))
            {
                text = File.OpenText(path).ReadToEnd();
            }
            else
            {
                text = "";
            }
            string[] array = text.Replace("\r", "").Split(new char[]
            {
            "\n"[0]
            });
            string[] array2 = array[0].Split(new char[]
            {
            ','
            });
            for (int i = 0; i < array.Length; i++)
            {
                string[] array3 = array[i].Split(new char[]
                {
                ','
                });
                if (array3[0] != "#" && array3[0] != "")
                {
                    Dictionary<int, string> dictionary = new Dictionary<int, string>();
                    for (int j = 0; j < array2.Length; j++)
                    {
                        if (array2[j] != "#" && array2[j] != "")
                        {
                            dictionary.Add(int.Parse(array2[j]), Regex.Unescape(array3[j]));
                        }
                    }
                    this.textColor.Add(int.Parse(array3[0]), dictionary);
                }
            }
            this.textColorKeys = new List<int>(this.textColor.Keys);
        }

        /// <summary>
        /// 读取功法数据
        /// </summary>
        /// <param name="passDateIndex"></param>
        public void LoadGongFaData(int passDateIndex = -1)
        {
            string path = string.Format("{0}\\Data\\{1}.txt", this.BasePath, "GongFa_Date");
            LoadGongFaData(path, passDateIndex);
        }

        /// <summary>
        /// 读取功法数据
        /// </summary>
        /// <param name="path"></param>
        /// <param name="passDateIndex"></param>
        public void LoadGongFaData(string path, int passDateIndex = -1)
        {
            GongFaData = GetData(path,passDateIndex);
            Parallel.ForEach(GongFaData, (gongfa) => GongFaList.Add(GetGongFa(gongfa.Key, gongfa.Value)));
            GongFaList = GongFaList.OrderBy(t => t.GongFaId).ToList();
        }

        private Dictionary<int, Dictionary<int, string>> GetData(string path, int passDateIndex = -1)
        {
            var result = new Dictionary<int, Dictionary<int, string>>();
            string text;
            if (File.Exists(path))
            {
                text = File.OpenText(path).ReadToEnd();
            }
            else
            {
                text = "";
            }
            string[] array = text.Replace("\r", "").Split(new char[]
            {
            "\n"[0]
            });
            string[] array2 = array[0].Split(new char[]
            {
            ','
            });
            for (int i = 0; i < array.Length; i++)
            {
                string[] array3 = array[i].Split(new char[]
                {
                ','
                });
                if (array3[0] != "#" && array3[0] != "")
                {
                    Dictionary<int, string> dictionary = new Dictionary<int, string>();
                    for (int j = 0; j < array2.Length; j++)
                    {
                        if (array2[j] != "#" && array2[j] != "" && int.Parse(array2[j]) != passDateIndex)
                        {
                            if (array3[j].Contains("C_"))
                            {
                                for (int k = 0; k < this.textColorKeys.Count; k++)
                                {
                                    array3[j] = array3[j].Replace("C_" + this.textColorKeys[k], this.textColor[this.textColorKeys[k]][0]);
                                }
                                array3[j] = array3[j].Replace("C_D", "</color>");
                            }
                            dictionary.Add(int.Parse(array2[j]), Regex.Unescape(array3[j]));
                        }
                    }
                    lock (result)
                    {
                        result.Add(int.Parse(array3[0]), dictionary);
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// 读取message信息
        /// </summary>
        /// <param name="passDateIndex"></param>
        public void LoadMessageData(int passDateIndex = -1)
        {
            string path = string.Format("{0}\\Data\\{1}.txt", this.BasePath, "Massage_Date");
            MessageDate = GetData(path,passDateIndex);
        }
        
        /// <summary>
        /// 转化数据对象为功法
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public GongFa GetGongFa(int index, Dictionary<int, string> value)
        {
            var gf = new GongFa();
            var props = gf.GetType().GetProperties();
            gf.Original = value;
            gf.GongFaId = index;
            foreach (var prop in props)
            {
                try
                {
                    var attr = (GongFaAttribute)Attribute.GetCustomAttribute(prop, typeof(GongFaAttribute), true);
                    if (attr != null)
                    {
                        if (attr.Index == -1) continue;
                        var data = value[attr.Index];
                        prop.SetValue(gf, DataConvert(data, prop.PropertyType), null);
                    }

                }
                catch (Exception ex)
                {

                    continue;
                }
            }
            return gf;
        }

        /// <summary>
        /// 获取功法属性对象
        /// </summary>
        /// <param name="prop"></param>
        /// <returns></returns>
        public static GongFaAttribute GetGongFaAttribute(PropertyInfo prop) => (GongFaAttribute)Attribute.GetCustomAttribute(prop, typeof(GongFaAttribute), true);

        /// <summary>
        /// 数据转换
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static object DataConvert(string data,Type type)
        {
            if (typeof(int) == type)
            {
                return int.Parse(data);
            }
            if (typeof(decimal) == type)
            {
                return decimal.Parse(data);
            }
            return data;
        }

        /// <summary>
        /// 保存当前修改后的所有数据
        /// </summary>
        /// <param name="outpath"></param>
        public void SaveAll(string outpath)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("#,0,2,61,62,63,64,66,67,68,69,70,71,72,73,99,103,104,1,6,7,3,15,16,4,5,701,702,703,704,705,999,710,711,901,902,903,904,905,906,907,908,909,910,921,922,923,924,95,96,501,502,503,504,14,8,9,31,38,39,40,10,11,12,13,101,21,22,23,24,25,26,27,28,29,30,601,602,603,611,612,613,614,615,604,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,32,33,34,35,36,81,82,83,84,85,86,50041,50042,50043,50044,50045,50046,50032,50033,50022,50023,51110,51101,51102,51103,51104,51105,51106,51107,51108,51109,51111,50081,50082,50083,51367,51368,51369,50084,50085,50086,51370,51371,51372,50071,50072,50073,50092,50093,50094,50095,50096,50097,50098,98,37");
            foreach (var gongfa in GongFaList)
            {
                sb.AppendLine($"{gongfa.GongFaId},{string.Join(",",gongfa.Original.Values)}");
            }
            File.WriteAllText(outpath, sb.ToString());
        }
    }
}
