namespace ASM
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crrlNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mởFileCtrlOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biênDịchVàThựcThiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biênDịchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thựcThiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripButton();
            this.btnRun = new System.Windows.Forms.ToolStripButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.biênDịchVàThựcThiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(981, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crrlNToolStripMenuItem,
            this.mởFileCtrlOToolStripMenuItem,
            this.lưuFileToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // crrlNToolStripMenuItem
            // 
            this.crrlNToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1});
            this.crrlNToolStripMenuItem.Image = global::ASM.Properties.Resources.R;
            this.crrlNToolStripMenuItem.Name = "crrlNToolStripMenuItem";
            this.crrlNToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.crrlNToolStripMenuItem.Text = "Tạo mới       Ctrl + N";
            this.crrlNToolStripMenuItem.Click += new System.EventHandler(this.crrlNToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.Black;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(71, 6);
            // 
            // mởFileCtrlOToolStripMenuItem
            // 
            this.mởFileCtrlOToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mởFileCtrlOToolStripMenuItem.Image")));
            this.mởFileCtrlOToolStripMenuItem.Name = "mởFileCtrlOToolStripMenuItem";
            this.mởFileCtrlOToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.mởFileCtrlOToolStripMenuItem.Text = "Mở file         Ctrl + O";
            this.mởFileCtrlOToolStripMenuItem.Click += new System.EventHandler(this.mởFileCtrlOToolStripMenuItem_Click);
            // 
            // lưuFileToolStripMenuItem
            // 
            this.lưuFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lưuFileToolStripMenuItem.Image")));
            this.lưuFileToolStripMenuItem.Name = "lưuFileToolStripMenuItem";
            this.lưuFileToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.lưuFileToolStripMenuItem.Text = "Lưu file         Ctrl + S";
            this.lưuFileToolStripMenuItem.Click += new System.EventHandler(this.lưuFileToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.thoátToolStripMenuItem.Text = "Thoát            Alt + F4";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // biênDịchVàThựcThiToolStripMenuItem
            // 
            this.biênDịchVàThựcThiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.biênDịchToolStripMenuItem,
            this.thựcThiToolStripMenuItem});
            this.biênDịchVàThựcThiToolStripMenuItem.Name = "biênDịchVàThựcThiToolStripMenuItem";
            this.biênDịchVàThựcThiToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.biênDịchVàThựcThiToolStripMenuItem.Text = "Biên dịch và thực thi";
            // 
            // biênDịchToolStripMenuItem
            // 
            this.biênDịchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("biênDịchToolStripMenuItem.Image")));
            this.biênDịchToolStripMenuItem.Name = "biênDịchToolStripMenuItem";
            this.biênDịchToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.biênDịchToolStripMenuItem.Text = "Biên dịch      F6";
            // 
            // thựcThiToolStripMenuItem
            // 
            this.thựcThiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thựcThiToolStripMenuItem.Image")));
            this.thựcThiToolStripMenuItem.Name = "thựcThiToolStripMenuItem";
            this.thựcThiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thựcThiToolStripMenuItem.Text = "Thực thi        F5";
            this.thựcThiToolStripMenuItem.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripSplitButton2,
            this.btnRun});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(981, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "Thực thi";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(29, 24);
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(29, 24);
            this.toolStripSplitButton2.Text = "toolStripSplitButton2";
            // 
            // btnRun
            // 
            this.btnRun.Image = ((System.Drawing.Image)(resources.GetObject("btnRun.Image")));
            this.btnRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(86, 24);
            this.btnRun.Text = "Thực thi";
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(45, 83);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(936, 470);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 571);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(981, 26);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ActiveLinkColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Lime;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(50, 20);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(45, 470);
            this.panel1.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 597);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Bài tập LT Windows";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biênDịchVàThựcThiToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem crrlNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mởFileCtrlOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lưuFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripButton btnRun;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem biênDịchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thựcThiToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

