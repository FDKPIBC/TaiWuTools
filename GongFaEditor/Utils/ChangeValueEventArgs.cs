using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GongFaEditor.Utils
{
    public class ChangeValueEventArgs : EventArgs
    {
        public object SourceValue { get; set; }

        public object ChangedValue { get; set; }

        public GongFaAttribute Attribute { get; set; }
    }
}
