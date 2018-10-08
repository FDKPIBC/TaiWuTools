using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using TaiWuSaveEdit.Core;

namespace TaiWuSaveEdit
{
    public partial class MainForm : Form
    {
        private SaveFileManager _saveFileManager;

        private SaveFile _currentSaveFile;

        public MainForm()
        {
            InitializeComponent();
            msChoose.Hide();
        }

        private void SetFormTitle(string title) => this.Text = title;
        
        /// <summary>
        /// 设置进度
        /// </summary>
        /// <param name="offset">进度条偏移量</param>
        /// <param name="text">进度状态文字描述</param>
        private void ChangeLoadStatus(int offset,string text)
        {
            tspbLoad.Value += offset;
            tsslLoadText.Text = text;
        }

        public void LoadSaveFile()
        {

        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            fbd.Description = "请选择游戏存档所在的文件夹,例如:\"D:\\Steam\\steamapps\\common\\The Scroll Of Taiwu\\The Scroll Of Taiwu Alpha V1.0_Data\\SaveFiles\"";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                _saveFileManager = new SaveFileManager(fbd.SelectedPath);
                LoadSaveFile();
                msChoose.Show();
            }
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {

        }
    }
}
