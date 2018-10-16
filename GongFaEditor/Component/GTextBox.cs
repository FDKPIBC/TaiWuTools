using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GongFaEditor.Utils;
using System.Reflection;

namespace GongFaEditor.Component
{
    public partial class GTextBox : UserControl,ITaiWuService
    {
        public GongFaAttribute Attribute;

        private ToolTip tip;

        public GTextBox(object value)
        {
            InitializeComponent();
            textBox1.Text = value.ToString();
        }

        public object GetData() => textBox1.Text;

        public void Init()
        {
            label1.Text = Attribute.Description;
            textBox1.ReadOnly = !Attribute.Editable;
        }
    }
}
