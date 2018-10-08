using GongFaEditor.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            var first = gongFaManager.GongFaData[150002];
            LoadGongFaList();
        }

        public void ShowGongFaData(int gongfaIndex)
        {
            var gongfa = gongFaManager.GongFaData[gongfaIndex];
            tbName.Text = gongfa[0];
            tbDescription.Text = gongfa[99];
            pGongfa.Visible = true;
        }

        public void LoadGongFaList()
        {
            foreach (var GongFa in gongFaManager.GongFaData)
            {
                lbGongfa.Items.Add(new KeyValuePair<int,string>(GongFa.Key, GongFa.Value[0]));
            }
            lbGongfa.ValueMember = "Key";
            lbGongfa.DisplayMember = "Value";
        }

        private void lbGongfa_SelectedIndexChanged(object sender, EventArgs e)
        {
            pGongfa.Visible = false;
            if (this.lbGongfa.SelectedIndex < 0) return;
            var value = (KeyValuePair<int, string>)lbGongfa.SelectedItem;
            ShowGongFaData(value.Key);
        }
    }
}
