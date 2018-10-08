namespace TaiWuSaveEdit
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.ssStatusBar = new System.Windows.Forms.StatusStrip();
            this.tspbLoad = new System.Windows.Forms.ToolStripProgressBar();
            this.tsslLoadText = new System.Windows.Forms.ToolStripStatusLabel();
            this.msChoose = new System.Windows.Forms.MenuStrip();
            this.tsmiActor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.ssStatusBar.SuspendLayout();
            this.msChoose.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpen,
            this.tsmiSave});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.Size = new System.Drawing.Size(44, 21);
            this.tsmiOpen.Text = "打开";
            this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(44, 21);
            this.tsmiSave.Text = "保存";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // ssStatusBar
            // 
            this.ssStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspbLoad,
            this.tsslLoadText});
            this.ssStatusBar.Location = new System.Drawing.Point(0, 428);
            this.ssStatusBar.Name = "ssStatusBar";
            this.ssStatusBar.Size = new System.Drawing.Size(800, 22);
            this.ssStatusBar.TabIndex = 2;
            // 
            // tspbLoad
            // 
            this.tspbLoad.Name = "tspbLoad";
            this.tspbLoad.Size = new System.Drawing.Size(300, 16);
            // 
            // tsslLoadText
            // 
            this.tsslLoadText.Name = "tsslLoadText";
            this.tsslLoadText.Size = new System.Drawing.Size(55, 17);
            this.tsslLoadText.Text = "Loading";
            // 
            // msChoose
            // 
            this.msChoose.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiActor,
            this.tsmiItem});
            this.msChoose.Location = new System.Drawing.Point(0, 25);
            this.msChoose.Name = "msChoose";
            this.msChoose.Size = new System.Drawing.Size(800, 25);
            this.msChoose.TabIndex = 3;
            this.msChoose.Text = "menuStrip2";
            // 
            // tsmiActor
            // 
            this.tsmiActor.Name = "tsmiActor";
            this.tsmiActor.Size = new System.Drawing.Size(44, 21);
            this.tsmiActor.Text = "人物";
            // 
            // tsmiItem
            // 
            this.tsmiItem.Name = "tsmiItem";
            this.tsmiItem.Size = new System.Drawing.Size(44, 21);
            this.tsmiItem.Text = "物品";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 378);
            this.panel1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.msChoose);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ssStatusBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "TaiWuSaveEdit";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ssStatusBar.ResumeLayout(false);
            this.ssStatusBar.PerformLayout();
            this.msChoose.ResumeLayout(false);
            this.msChoose.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.StatusStrip ssStatusBar;
        private System.Windows.Forms.ToolStripProgressBar tspbLoad;
        private System.Windows.Forms.ToolStripStatusLabel tsslLoadText;
        private System.Windows.Forms.MenuStrip msChoose;
        private System.Windows.Forms.ToolStripMenuItem tsmiActor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem tsmiItem;
    }
}

