using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GongFaEditor.Utils
{
    public class LogManager
    {
        private static string logDirPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"log");

        public static void WriteLog(Exception ex)
        {
            var sb = new StringBuilder();
            WriteLog(sb.ToString());
        }

        public static void WriteLog(string log)
        {
            if (Directory.Exists(logDirPath))
                Directory.CreateDirectory(logDirPath);
            var filename = Path.Combine(logDirPath, DateTime.Now.ToString("yyMMdd") + ".log");
            File.AppendAllText(filename, log);
        }
    }
}
