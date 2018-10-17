using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RecordGenerator.Utils
{
    public static class ObjectExtend
    {
        public static bool IsNullOrEmpty(this string str) => string.IsNullOrEmpty(str);

        public static bool DirectoryExist(this string path) => Directory.Exists(path);
    }
}
