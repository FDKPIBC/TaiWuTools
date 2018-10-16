using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Reflection;
using System.Diagnostics;

namespace GongFaEditor.Utils
{
    public class GongFaManager
    {
        public string BasePath = AppDomain.CurrentDomain.BaseDirectory;

        public List<GongFa> GongFaList { get; set; }

        public Dictionary<int, Dictionary<int, string>> GongFaData { get; set; }

        private Dictionary<int, Dictionary<int, string>> textColor;

        private Dictionary<int, Dictionary<int, List<ArrCacheGongFaDateItem>>> arrCacheGongFaDate;

        public Dictionary<int, Dictionary<int, string>> messageDate;

        private List<int> textColorKeys;
        
        public struct ArrCacheGongFaDateItem
        {
            public int i0;
            
            public float f1;
        }

        public GongFaManager()
        {
            GongFaData = new Dictionary<int, Dictionary<int, string>>();
            GongFaList = new List<GongFa>(); 
            textColor = new Dictionary<int, Dictionary<int, string>>();
            arrCacheGongFaDate = new Dictionary<int, Dictionary<int, List<ArrCacheGongFaDateItem>>>();
            messageDate = new Dictionary<int, Dictionary<int, string>>();
            textColorKeys = new List<int>();
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
            Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();
            Parallel.ForEach(GongFaData, (gongfa) => GongFaList.Add(GetGongFa(gongfa.Key, gongfa.Value)));
            //stopwatch.Stop();
        }

        /// <summary>
        /// 读取功法数据
        /// </summary>
        /// <param name="path"></param>
        /// <param name="passDateIndex"></param>
        public void LoadGongFaData(string path, int passDateIndex = -1)
        {
            GongFaData = GetData(path,passDateIndex);
            //var dateList = new Dictionary<int, Dictionary<int, string>>();
            //string path = string.Format("{0}\\{1}.txt", this.BasePath, "GongFa_Date");
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
            messageDate = GetData(path,passDateIndex);
        }

        public List<ArrCacheGongFaDateItem> GetGongFaDateArr(int key, int index)
        {
            if (this.arrCacheGongFaDate.ContainsKey(key))
            {
                Dictionary<int, List<ArrCacheGongFaDateItem>> dictionary = this.arrCacheGongFaDate[key];
                if (dictionary.ContainsKey(index))
                {
                    return dictionary[index];
                }
            }
            string[] array = GongFaData[key][index].Split(new char[]
            {
            '|'
            });
            List<ArrCacheGongFaDateItem> list = new List<ArrCacheGongFaDateItem>();
            for (int i = 0; i < array.Length; i++)
            {
                string[] array2 = array[i].Split(new char[]
                {
                '&'
                });
                list.Add(new ArrCacheGongFaDateItem
                {
                    i0 = int.Parse(array2[0]),
                    f1 = float.Parse(array2[1])
                });
            }
            if (!this.arrCacheGongFaDate.ContainsKey(key))
            {
                this.arrCacheGongFaDate[key] = new Dictionary<int, List<ArrCacheGongFaDateItem>>();
            }
            this.arrCacheGongFaDate[key][index] = list;
            return list;
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
        public GongFaAttribute GetGongFaAttribute(PropertyInfo prop) => (GongFaAttribute)Attribute.GetCustomAttribute(prop, typeof(GongFaAttribute), true);

        public object DataConvert(string data,Type type)
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

        //0 名称
        //2 颜色代码(20001 + ?)
        //99 描述
        //70-72 

        //50041
        //50042
        //50043
        //50044
        //50045
        //50046

        //50032 外伤上限
        //50033 内伤上限

        //50022 守御效率
        //50023 疗伤效率

        //51110 驱毒效率
        //51101 
        //51102
        //51103
        //51104
        //51105
        //51106
        //51107
        //51108
        //51109
        //51111

        //50081
        //50082
        //50083

        //51367
        //51368
        //51369

        //50084
        //50085
        //50086

        //51370
        //51371
        //51372
        //51373

        //50092 力道发挥%
        //50093 精妙发挥%
        //50094
        //50095
        //50096
        //50097
        //50098
    }
}
