using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void So0_Click(object sender, EventArgs e)
        {
            if (txtKQ.Text == "0")
            {
                txtKQ.Text = txtKQ.Text.Remove(0);

                
            }
            txtKQ.Text += (sender as Button).Text;
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            txtKQ.Text += (sender as Button).Text;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {   if (txtKQ.Text.Length == 1)
                
                    txtKQ.Text = "0";
                else
                txtKQ.Text = txtKQ.Text.Remove(txtKQ.Text.Length - 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Co gi dau ma xoa");
            }
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            try
            {
                txtKQ.Text = (string.IsNullOrEmpty(txtKQ.Text)).ToString();
                txtKQ.Text = (Program.calc(txtKQ.Text)).ToString();
            }
            catch (Exception ex) {
                MessageBox.Show("Khong co gi dau ma tinh");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {   
                txtKQ.Text = "0";
        }
    }
}
