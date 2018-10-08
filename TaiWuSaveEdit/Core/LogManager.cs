using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TaiWuSaveEdit.Utils;
using System.Windows.Forms;

namespace TaiWuSaveEdit.Core
{
    public class LogManager
    {
        public static string LogPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"Log");

        private string TodayLogPath => Path.Combine(LogPath, DateTime.Now.ToString("yyyyMMdd") + ".ex");

        public void WriteLog(Exception ex)
        {
            if (!LogPath.IsDirctoryExist()) Directory.CreateDirectory(LogPath);
            if (ex == null) return;
            MessageBox.Show("程序运行异常,即将关闭,详情请查看错误日志!");
            var sb = new StringBuilder();
            sb.AppendLine($"-----------{DateTime.Now:yyyy/MM/dd hh:mm:ss}----------");
            sb.AppendLine($"StackTrace:{ex.InnerException?.StackTrace ?? ex.StackTrace}");
            sb.AppendLine();
            sb.AppendLine($"Message:{ex.InnerException?.Message ?? ex.Message}");
            sb.AppendLine($"----------------------------------------------");
            sb.AppendLine();
            System.IO.File.AppendAllText(TodayLogPath, sb.ToString());
            Application.Exit();
        }
    }
}
