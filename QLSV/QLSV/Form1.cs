using QLSV.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
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

            var listStudents = db.Students.ToList();
            var listFaculty = db.Faculties.ToList();

            cmbFaculty.DataSource = listFaculty;
            cmbFaculty.DisplayMember = "FacultyName";

            HHH(listStudents);
        }

        private void HHH(List<Student> students)
        {
            foreach (var item in students)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = item.StudentID;
                dataGridView1.Rows[index].Cells[1].Value = item.FullName;
                dataGridView1.Rows[index].Cells[2].Value = item.Faculty.FacultyName;
                dataGridView1.Rows[index].Cells[3].Value = item.AverageScore;
            }
        }
    }
}
