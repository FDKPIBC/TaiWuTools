using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaiWuSaveEdit.Utils
{
    public static class ObjectExtend
    {
        public static bool IsNullOrEmpty(this string str) => string.IsNullOrEmpty(str);

        public static bool IsDirctoryExist(this string path) => Directory.Exists(path);
    }
}
