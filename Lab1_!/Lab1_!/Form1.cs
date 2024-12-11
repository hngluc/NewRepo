using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = (float.Parse(txtNumber1.Text) + float.Parse(txtNumber2.Text)).ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = (float.Parse(txtNumber1.Text) - float.Parse(txtNumber2.Text)).ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {

        }

        private void btnChia_Click(object sender, EventArgs e)
        {

        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            txtAnswer.Enabled = (!txtAnswer.Enabled);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
