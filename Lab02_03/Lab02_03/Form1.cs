using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lab02_03
{
    public partial class Form1 : Form
    {
        private int totalAmount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var seatbtn = sender as Button;
            if (seatbtn.BackColor == Color.White)
            {
                seatbtn.BackColor = Color.Blue;
                totalAmount += GetSeatPrice(seatbtn);
            }
            else if (seatbtn.BackColor == Color.Blue)
            {
                seatbtn.BackColor = Color.White;
                totalAmount -= GetSeatPrice(seatbtn);
            }
            else if (seatbtn.BackColor == Color.Yellow)
            {
                MessageBox.Show("Ghe da dc ban!!");
            }
            txtTT.Text = $"{totalAmount} VND";

        }

        private int GetSeatPrice(Button seatbtn)
        {
            var seatnumber = int.Parse(seatbtn.Text);
            if (seatnumber >= 1 && seatnumber <= 5) return 30000;
            if (seatnumber >= 6 && seatnumber <= 10) return 40000;
            if (seatnumber >= 11 && seatnumber <= 15) return 50000;
            return 80000;

        }

        private void So6_Click(object sender, EventArgs e)
        {

        }

        private void So11_Click(object sender, EventArgs e)
        {

        }

        private void So16_Click(object sender, EventArgs e)
        {

        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < panel1.Controls.Count; i++)
                if (panel1.Controls[i] is Button && panel1.Controls[i].BackColor == Color.Blue)
                {
                    panel1.Controls[i].BackColor = Color.Yellow;
                }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < panel1.Controls.Count; i++)
                if (panel1.Controls[i] is Button && panel1.Controls[i].BackColor == Color.Yellow)
                {
                    panel1.Controls[i].BackColor = Color.White;
                }
        }
    }
}
