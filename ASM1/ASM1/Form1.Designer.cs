namespace ASM1
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sắpXếpTheoSốCaNhiễmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cácĐịaPhươngNhómNguyCơToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtBáoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDP = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCaNhiem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTT = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCovid19 = new System.Windows.Forms.DataGridView();
            this.MDP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENDP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANHIEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANGTHAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCovid19)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(283, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tình hình dịch Covid-19";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sắpXếpTheoSốCaNhiễmToolStripMenuItem,
            this.cácĐịaPhươngNhómNguyCơToolStripMenuItem,
            this.xuấtBáoCáoToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // sắpXếpTheoSốCaNhiễmToolStripMenuItem
            // 
            this.sắpXếpTheoSốCaNhiễmToolStripMenuItem.Name = "sắpXếpTheoSốCaNhiễmToolStripMenuItem";
            this.sắpXếpTheoSốCaNhiễmToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.sắpXếpTheoSốCaNhiễmToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.sắpXếpTheoSốCaNhiễmToolStripMenuItem.Text = "Sắp xếp theo số ca nhiễm";
            this.sắpXếpTheoSốCaNhiễmToolStripMenuItem.Click += new System.EventHandler(this.sắpXếpTheoSốCaNhiễmToolStripMenuItem_Click);
            // 
            // cácĐịaPhươngNhómNguyCơToolStripMenuItem
            // 
            this.cácĐịaPhươngNhómNguyCơToolStripMenuItem.Name = "cácĐịaPhươngNhómNguyCơToolStripMenuItem";
            this.cácĐịaPhươngNhómNguyCơToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.cácĐịaPhươngNhómNguyCơToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.cácĐịaPhươngNhómNguyCơToolStripMenuItem.Text = "Các địa phương nhóm nguy cơ";
            // 
            // xuấtBáoCáoToolStripMenuItem
            // 
            this.xuấtBáoCáoToolStripMenuItem.Name = "xuấtBáoCáoToolStripMenuItem";
            this.xuấtBáoCáoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.xuấtBáoCáoToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.xuấtBáoCáoToolStripMenuItem.Text = "Xuất báo cáo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã địa phương";
            // 
            // txtDP
            // 
            this.txtDP.Location = new System.Drawing.Point(123, 62);
            this.txtDP.Name = "txtDP";
            this.txtDP.Size = new System.Drawing.Size(106, 22);
            this.txtDP.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(123, 114);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(177, 22);
            this.txtName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên địa phương";
            // 
            // txtCaNhiem
            // 
            this.txtCaNhiem.Location = new System.Drawing.Point(123, 163);
            this.txtCaNhiem.Name = "txtCaNhiem";
            this.txtCaNhiem.Size = new System.Drawing.Size(106, 22);
            this.txtCaNhiem.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số ca nhiễm mới ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Trạng thái";
            // 
            // cmbTT
            // 
            this.cmbTT.FormattingEnabled = true;
            this.cmbTT.Location = new System.Drawing.Point(123, 221);
            this.cmbTT.Name = "cmbTT";
            this.cmbTT.Size = new System.Drawing.Size(185, 24);
            this.cmbTT.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(139, 281);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(248, 281);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.cmbTT);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCaNhiem);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 334);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin địa phương";
            // 
            // dgvCovid19
            // 
            this.dgvCovid19.AllowUserToAddRows = false;
            this.dgvCovid19.AllowUserToDeleteRows = false;
            this.dgvCovid19.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCovid19.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MDP,
            this.TENDP,
            this.CANHIEM,
            this.TRANGTHAI});
            this.dgvCovid19.Location = new System.Drawing.Point(390, 122);
            this.dgvCovid19.Name = "dgvCovid19";
            this.dgvCovid19.ReadOnly = true;
            this.dgvCovid19.RowHeadersWidth = 51;
            this.dgvCovid19.Size = new System.Drawing.Size(647, 398);
            this.dgvCovid19.TabIndex = 13;
            // 
            // MDP
            // 
            this.MDP.HeaderText = "MDP";
            this.MDP.MinimumWidth = 6;
            this.MDP.Name = "MDP";
            this.MDP.ReadOnly = true;
            this.MDP.Width = 125;
            // 
            // TENDP
            // 
            this.TENDP.HeaderText = "Tên ĐP";
            this.TENDP.MinimumWidth = 6;
            this.TENDP.Name = "TENDP";
            this.TENDP.ReadOnly = true;
            this.TENDP.Width = 125;
            // 
            // CANHIEM
            // 
            this.CANHIEM.HeaderText = "Ca Nhiễm";
            this.CANHIEM.MinimumWidth = 6;
            this.CANHIEM.Name = "CANHIEM";
            this.CANHIEM.ReadOnly = true;
            this.CANHIEM.Width = 125;
            // 
            // TRANGTHAI
            // 
            this.TRANGTHAI.HeaderText = "Trạng thái";
            this.TRANGTHAI.MinimumWidth = 6;
            this.TRANGTHAI.Name = "TRANGTHAI";
            this.TRANGTHAI.ReadOnly = true;
            this.TRANGTHAI.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 556);
            this.Controls.Add(this.dgvCovid19);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Thông tin địa phương";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCovid19)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDP;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCaNhiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTT;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCovid19;
        private System.Windows.Forms.ToolStripMenuItem sắpXếpTheoSốCaNhiễmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cácĐịaPhươngNhómNguyCơToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuấtBáoCáoToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MDP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENDP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANHIEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANGTHAI;
    }
}

