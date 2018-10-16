using GongFaEditor.Component;
using GongFaEditor.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GongFaEditor
{
    public partial class GongFaEdit : Form
    {
        private GongFaManager gongFaManager;

        public GongFaEdit()
        {
            InitializeComponent();
            gongFaManager = new GongFaManager();
            gongFaManager.LoadGongFaData();
            gongFaManager.LoadMessageData();
        }

        public void ShowGongFaData(int gongfaIndex)
        {
            var gongfa = gongFaManager.GongFaList.FirstOrDefault(t => t.GongFaId == gongfaIndex);
            var list = new List<GTextBox>();
            Parallel.ForEach(gongfa.GetType().GetProperties(), (prop) =>
            {
                var attr = gongFaManager.GetGongFaAttribute(prop);
                if (attr != null)
                {
                    var gtb = new GTextBox(prop.GetValue(gongfa));
                    gtb.Attribute = attr;
                    gtb.Init();
                    list.Add(gtb);
                }
            });
            flowLayoutPanel1.Controls.AddRange(list.ToArray());
        }

        public void LoadGongFaList()
        {
            lbGongfa.ValueMember = "Key";
            lbGongfa.DisplayMember = "Value";
            Stopwatch stopWatch = new Stopwatch();
            Parallel.ForEach(gongFaManager.GongFaData, (GongFa) => {
                lbGongfa.Invoke(new Action(()=> {
                    lbGongfa.Items.Add(new KeyValuePair<int, string>(GongFa.Key, GongFa.Value[0]));
                }));
            });
        }

        private void lbGongfa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lbGongfa.SelectedIndex < 0) return;
            flowLayoutPanel1.Controls.Clear();
            var value = (KeyValuePair<int, string>)lbGongfa.SelectedItem;
            ShowGongFaData(value.Key);
        }

        private void GongFaEdit_Load(object sender, EventArgs e) => LoadGongFaList();
    }
}
