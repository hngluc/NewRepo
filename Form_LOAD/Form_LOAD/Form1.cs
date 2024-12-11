using Form_LOAD.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_LOAD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var db = new Model1();
            var listCategory = db.HOADONs.ToList();

            cmbCategory.DataSource = listCategory;
            cmbCategory.DisplayMember = "MAHD";

            var listProduct = db.VATTUs.ToList();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var cellValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        }
    }
}
