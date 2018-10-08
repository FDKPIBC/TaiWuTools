using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.IO;
using System.Security.Cryptography;

namespace TaiWuSaveEdit.Core
{
    public class SaveFileManager
    {
        private string _saveDir;

        public static string SaveDate = "TW_Save_Date_0.tw";
        public static string GameSetting = "TW_Save_Date_1.tw";
        public static string HomeBuilding = "TW_Save_Date_2.tw";
        public static string PlaceResource = "TW_Save_Date_3.tw";
        public static string WorldDate1 = "TW_Save_Date_4.tw";
        public static string WorldDate2 = "TW_Save_Date_5.tw";
        public static string WorldDate3 = "TW_Save_Date_6.tw";
        public static string WorldDate4 = "TW_Save_Date_7.tw";
        public static string ActorLife = "TW_Save_Date_8.tw";
        public static string SystemSetting = "Game_Setting.tw";
        public static string NewGameSetting = "New_Setting.tw";

        public List<SaveFile> SaveFiles { get; set; }

        private string GetDataPath(string dir,string dataTypeName) => Path.Combine(dir, dataTypeName);

        /// <summary>
        /// 存档管理构造函数
        /// </summary>
        /// <param name="savePath">存档根目录</param>
        public SaveFileManager(string savePath)
        {
            _saveDir = savePath;
            SaveFiles = new List<SaveFile>();
        }

        public void LoadSaveFile()
        {
            if (string.IsNullOrEmpty(_saveDir)) return;
            foreach (var dir in Directory.GetFiles(_saveDir).Where(t=>t.StartsWith("Data_")))
            {
                if (!EnsureFiles(dir))
                {
                    System.Windows.Forms.MessageBox.Show("存档损坏,数据获取失败!");
                }
                SaveFiles.Add(GetDate<SaveFile>(GetDataPath(dir, SaveDate)));
            }
        }

        public T GetDate<T>(string path)
        {
            using (StreamReader streamReader = File.OpenText(path))
            {
                try
                {
                    string pString = streamReader.ReadToEnd();
                    pString = this.RijndaelDecrypt(pString, "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
                    return JsonConvert.DeserializeObject<T>(pString);
                }
                catch (Exception ex)
                {
                    throw new Exception("读取存档数据时存档损坏");
                }
            }
        }

        /// <summary>
        /// 验证存档有效性
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public bool EnsureFiles(string path)
        {
            string[] array = new string[]
            {
                SaveDate,
                GameSetting,
                HomeBuilding,
                PlaceResource,
                WorldDate1,
                WorldDate2,
                WorldDate3,
                WorldDate4,
                ActorLife,
                SystemSetting,
                NewGameSetting
            };
            DirectoryInfo di = new DirectoryInfo(path);
            var allfile = di.GetFiles();
            if (allfile.Count() != array.Count()) return false;
            return allfile.Count(t=>array.Contains(t.Name)) == array.Count();
        }

        /// <summary>
        /// 存档文本加密
        /// </summary>
        /// <param name="pString"></param>
        /// <param name="pKey"></param>
        /// <returns></returns>
        private string RijndaelEncrypt(string pString, string pKey)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(pKey);
            byte[] bytes2 = Encoding.UTF8.GetBytes(pString);
            RijndaelManaged rijndaelManaged = new RijndaelManaged
            {
                Key = bytes,
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };
            ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor();
            byte[] array = cryptoTransform.TransformFinalBlock(bytes2, 0, bytes2.Length);
            return Convert.ToBase64String(array, 0, array.Length);
        }

        /// <summary>
        /// 存档文本解密
        /// </summary>
        /// <param name="pString"></param>
        /// <param name="pKey"></param>
        /// <returns></returns>
        private string RijndaelDecrypt(string pString, string pKey)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(pKey);
            byte[] array = Convert.FromBase64String(pString);
            RijndaelManaged rijndaelManaged = new RijndaelManaged
            {
                Key = bytes,
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };
            ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
            byte[] bytes2 = cryptoTransform.TransformFinalBlock(array, 0, array.Length);
            return Encoding.UTF8.GetString(bytes2);
        }
    }
}
