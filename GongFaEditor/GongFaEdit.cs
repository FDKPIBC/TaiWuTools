using GongFaEditor.Component;
using GongFaEditor.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GongFaEditor.Core;
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

        /// <summary>
        /// 加载功法数据
        /// </summary>
        /// <param name="gongfaIndex"></param>
        public void ShowGongFaData(int gongfaIndex)
        {
            var gongfa = gongFaManager.GongFaList.FirstOrDefault(t => t.GongFaId == gongfaIndex);
            var list = new List<GTextBox>();
            Parallel.ForEach(gongfa.GetType().GetProperties(), (prop) =>
            {
                var attr = GongFaManager.GetGongFaAttribute(prop);
                if (attr != null)
                {
                    if (attr.Skip) return;
                    var gtb = new GTextBox(prop, prop.GetValue(gongfa));
                    gtb.Init();
                    gtb.ValueChanged += (sender, e) =>
                    {
                        prop.SetValue(gongfa, e.ChangedValue);
                        gongfa.Original[attr.Index] = e.ChangedValue.ToString();
                    };
                    list.Add(gtb);
                }
            });
            flowLayoutPanel1.Controls.AddRange(list.ToArray());
        }

        /// <summary>
        /// 功法列表绑定
        /// </summary>
        public void LoadGongFaList()
        {
            lbGongfa.ValueMember = "Key";
            lbGongfa.DisplayMember = "Value";
            foreach (var GongFa in gongFaManager.GongFaData)
            {
                lbGongfa.Items.Add(new KeyValuePair<int, string>(GongFa.Key, GongFa.Value[0]));
            }
        }

        private void lbGongfa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lbGongfa.SelectedIndex < 0) return;
            flowLayoutPanel1.Controls.Clear();
            var value = (KeyValuePair<int, string>)lbGongfa.SelectedItem;
            ShowGongFaData(value.Key);
        }

        private void GongFaEdit_Load(object sender, EventArgs e) => LoadGongFaList();

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            var outdir = Path.Combine(gongFaManager.BasePath, "output");
            if (!Directory.Exists(outdir)) Directory.CreateDirectory(outdir);
            gongFaManager.SaveAll(Path.Combine(outdir, "GongFa_Date.txt"));
            if (MessageBox.Show("已保存,是否打开输出文件夹","",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Process.Start(outdir);
            }
        }
    }
}
