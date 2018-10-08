namespace GongFaEditor
{
    partial class GongFaEdit
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.lbGongfa = new System.Windows.Forms.ListBox();
            this.pGongfa = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.menu.SuspendLayout();
            this.pGongfa.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpen,
            this.tsmiSave});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 25);
            this.menu.TabIndex = 2;
            this.menu.Text = "menuStrip1";
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.Size = new System.Drawing.Size(44, 21);
            this.tsmiOpen.Text = "打开";
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(44, 21);
            this.tsmiSave.Text = "保存";
            // 
            // lbGongfa
            // 
            this.lbGongfa.FormattingEnabled = true;
            this.lbGongfa.ItemHeight = 12;
            this.lbGongfa.Location = new System.Drawing.Point(12, 28);
            this.lbGongfa.Name = "lbGongfa";
            this.lbGongfa.Size = new System.Drawing.Size(162, 412);
            this.lbGongfa.TabIndex = 3;
            this.lbGongfa.SelectedIndexChanged += new System.EventHandler(this.lbGongfa_SelectedIndexChanged);
            // 
            // pGongfa
            // 
            this.pGongfa.Controls.Add(this.tbDescription);
            this.pGongfa.Controls.Add(this.label2);
            this.pGongfa.Controls.Add(this.tbName);
            this.pGongfa.Controls.Add(this.label1);
            this.pGongfa.Location = new System.Drawing.Point(181, 28);
            this.pGongfa.Name = "pGongfa";
            this.pGongfa.Size = new System.Drawing.Size(607, 412);
            this.pGongfa.TabIndex = 4;
            this.pGongfa.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "名称";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(40, 1);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(161, 21);
            this.tbName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "描述";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(40, 29);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(161, 76);
            this.tbDescription.TabIndex = 3;
            // 
            // GongFaEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pGongfa);
            this.Controls.Add(this.lbGongfa);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menu;
            this.Name = "GongFaEdit";
            this.Text = "功法编辑器";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.pGongfa.ResumeLayout(false);
            this.pGongfa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ListBox lbGongfa;
        private System.Windows.Forms.Panel pGongfa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label label2;
    }
}

