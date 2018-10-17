using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GongFaEditor.Utils
{
    public static class ObjectExtend
    {
        public static void WriteLog(this Exception ex) => LogManager.WriteExceptionLog(ex);

        public static void WriteLog(this string str) => LogManager.WriteLog(str);

        public static bool IsNullOrEmpty(this string str) => string.IsNullOrEmpty(str);
    }
}
