using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GongFaEditor.Utils
{
    [AttributeUsage(AttributeTargets.Property, Inherited = true)]
    public class GongFaAttribute : Attribute
    {
        /// <summary>
        /// 数据序号
        /// </summary>
        public int Index = -1;

        /// <summary>
        /// 说明
        /// </summary>
        public string Description = string.Empty;

        /// <summary>
        /// tips
        /// </summary>
        public string Tips = string.Empty;

        /// <summary>
        /// 是否可编辑
        /// </summary>
        public bool Editable = true;
    }
}
