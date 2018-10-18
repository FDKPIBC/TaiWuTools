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
using GongFaEditor.Core;
using System.Reflection;

namespace GongFaEditor.Component
{
    public partial class GTextBox : UserControl
    {
        public GongFaAttribute Attribute { get; set; }

        private PropertyInfo info;

        public event EventHandler<ChangeValueEventArgs> ValueChanged;

        protected virtual void OnValueChanged(ChangeValueEventArgs e)
        {
            ValueChanged?.Invoke(this, e);
        }

        private object orginalValue;

        public GTextBox(PropertyInfo pinfo,object value)
        {
            InitializeComponent();
            Attribute = GongFaManager.GetGongFaAttribute(pinfo);
            info = pinfo;
            orginalValue = value;
        }

        public void Init()
        {
            FixLayout();
            textBox1.Text = orginalValue.ToString();
            label1.Text = Attribute.Description;
            textBox1.ReadOnly = !Attribute.Editable;
        }

        private void FixLayout()
        {
            Graphics g = Graphics.FromImage(new Bitmap(1, 1));
            Font font = new Font("宋体", 9);
            SizeF sizeD = g.MeasureString(Attribute.Description, font);
            SizeF sizeV = g.MeasureString(orginalValue.ToString(), font);
            textBox1.Location = new Point((int)sizeD.Width + 5,3);
            textBox1.Width = (int)sizeV.Width + 20;
            this.Width = (int)sizeD.Width + (int)sizeV.Width + 30;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == orginalValue.ToString()) return;
            try
            {
                OnValueChanged(new ChangeValueEventArgs()
                {
                    SourceValue = orginalValue,
                    ChangedValue = GongFaManager.DataConvert(textBox1.Text,info.PropertyType),
                    Attribute = this.Attribute
                });
            }
            catch (Exception ex)
            {
                textBox1.Text = orginalValue.ToString();
            }
        }
    }
}
