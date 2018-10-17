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
        private static string logPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log");

        public static void WriteLog(string content)
        {
            if (content.IsNullOrEmpty()) return;
            if (!Directory.Exists(logPath)) Directory.CreateDirectory(logPath);
            var filename = Path.Combine(logPath, DateTime.Now.ToString("yyyyMMdd") + ".log");
            File.AppendAllText(filename, content);
        }

        public static void WriteExceptionLog(Exception ex)
        {
            if (ex == null) return;
            if (!Directory.Exists(logPath)) Directory.CreateDirectory(logPath); 
            var sb = new StringBuilder();
            sb.AppendLine($"-----------{DateTime.Now:yyyy/MM/dd hh:mm:ss}----------");
            sb.AppendLine($"StackTrace:{ex.InnerException?.StackTrace ?? ex.StackTrace}");
            sb.AppendLine();
            sb.AppendLine($"Message:{ex.InnerException?.Message ?? ex.Message}");
            sb.AppendLine($"------------------------------------------");
            var filename = Path.Combine(logPath, DateTime.Now.ToString("yyyyMMdd") + ".exception");
            File.AppendAllText(filename, sb.ToString());
        }
    }
}
