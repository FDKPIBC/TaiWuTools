using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GongFaEditor.Utils
{
    public static class ObjectExtend
    {
        public static void Log(this Exception ex) => LogManager.WriteLog(ex);

        public static bool IsNullOrEmpty(this string str) => string.IsNullOrEmpty(str);
    }
}
