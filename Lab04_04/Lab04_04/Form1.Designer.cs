namespace Lab04_04
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDelivery = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkViewAll = new System.Windows.Forms.CheckBox();
            this.dgvProductOrder = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaydathang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaygiaohang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbTo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbDelivery);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkViewAll);
            this.groupBox1.Location = new System.Drawing.Point(18, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn hàng";
            // 
            // cmbTo
            // 
            this.cmbTo.FormattingEnabled = true;
            this.cmbTo.Location = new System.Drawing.Point(364, 71);
            this.cmbTo.Name = "cmbTo";
            this.cmbTo.Size = new System.Drawing.Size(121, 24);
            this.cmbTo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "~";
            // 
            // cmbDelivery
            // 
            this.cmbDelivery.FormattingEnabled = true;
            this.cmbDelivery.Location = new System.Drawing.Point(183, 71);
            this.cmbDelivery.Name = "cmbDelivery";
            this.cmbDelivery.Size = new System.Drawing.Size(121, 24);
            this.cmbDelivery.TabIndex = 2;
            this.cmbDelivery.SelectedIndexChanged += new System.EventHandler(this.cmbDelivery_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thời gian giao hàng ";
            // 
            // chkViewAll
            // 
            this.chkViewAll.AutoSize = true;
            this.chkViewAll.Location = new System.Drawing.Point(51, 35);
            this.chkViewAll.Name = "chkViewAll";
            this.chkViewAll.Size = new System.Drawing.Size(160, 20);
            this.chkViewAll.TabIndex = 0;
            this.chkViewAll.Text = "Xem tất cả trong tháng";
            this.chkViewAll.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkViewAll.UseVisualStyleBackColor = true;
            this.chkViewAll.CheckedChanged += new System.EventHandler(this.chkViewAll_CheckedChanged);
            // 
            // dgvProductOrder
            // 
            this.dgvProductOrder.AllowUserToAddRows = false;
            this.dgvProductOrder.AllowUserToDeleteRows = false;
            this.dgvProductOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.SOHD,
            this.ngaydathang,
            this.ngaygiaohang,
            this.thanhtien});
            this.dgvProductOrder.Location = new System.Drawing.Point(18, 147);
            this.dgvProductOrder.Name = "dgvProductOrder";
            this.dgvProductOrder.ReadOnly = true;
            this.dgvProductOrder.RowHeadersWidth = 51;
            this.dgvProductOrder.RowTemplate.Height = 24;
            this.dgvProductOrder.Size = new System.Drawing.Size(701, 279);
            this.dgvProductOrder.TabIndex = 1;
            this.dgvProductOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductOrder_CellContentClick);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 125;
            // 
            // SOHD
            // 
            this.SOHD.HeaderText = "Số HĐ";
            this.SOHD.MinimumWidth = 6;
            this.SOHD.Name = "SOHD";
            this.SOHD.ReadOnly = true;
            this.SOHD.Width = 125;
            // 
            // ngaydathang
            // 
            this.ngaydathang.HeaderText = "Ngày Đặt Hàng";
            this.ngaydathang.MinimumWidth = 6;
            this.ngaydathang.Name = "ngaydathang";
            this.ngaydathang.ReadOnly = true;
            this.ngaydathang.Width = 125;
            // 
            // ngaygiaohang
            // 
            this.ngaygiaohang.HeaderText = "Ngày Giao Hàng";
            this.ngaygiaohang.MinimumWidth = 6;
            this.ngaygiaohang.Name = "ngaygiaohang";
            this.ngaygiaohang.ReadOnly = true;
            this.ngaygiaohang.Width = 125;
            // 
            // thanhtien
            // 
            this.thanhtien.HeaderText = "Thành Tiền";
            this.thanhtien.MinimumWidth = 6;
            this.thanhtien.Name = "thanhtien";
            this.thanhtien.ReadOnly = true;
            this.thanhtien.Width = 125;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(431, 445);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(72, 16);
            this.lblTotalAmount.TabIndex = 5;
            this.lblTotalAmount.Text = "Tổng cộng";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(509, 439);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 22);
            this.textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 473);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.dgvProductOrder);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbDelivery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkViewAll;
        private System.Windows.Forms.DataGridView dgvProductOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaydathang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaygiaohang;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private System.Windows.Forms.ComboBox cmbTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TextBox textBox1;
    }
}

