using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Lab04_123.Model;
namespace Lab04_123
{
    public partial class frmSearch : System.Windows.Forms.Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            using (var context = new StudentContextDB())
            {
                // Load dữ liệu khoa vào ComboBox
                var faculties = context.Faculties.ToList();
                faculties.Insert(0, new Faculty { FacultyID = 0, FacultyName = "Empty" });
                cmbFaculty.DataSource = faculties;
                cmbFaculty.DisplayMember = "FacultyName";
                cmbFaculty.ValueMember = "FacultyID";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (var context = new StudentContextDB())
            {
                var query = context.Students.Include(s => s.Faculty).AsQueryable();

                if (!string.IsNullOrWhiteSpace(txtStudentID.Text))
                {
                    query = query.Where(s => s.StudentID.Contains(txtStudentID.Text));
                }

                if (!string.IsNullOrWhiteSpace(txtFullName.Text))
                {
                    query = query.Where(s => s.FullName.Contains(txtFullName.Text));
                }

                if ((int)cmbFaculty.SelectedValue != 0)
                {
                    query = query.Where(s => s.FacultyID == (int)cmbFaculty.SelectedValue);
                }

                // Chuyển đổi dữ liệu sang ViewModel
                var results = query
                    .Select(s => new ViewModel
                    {
                        StudentID = s.StudentID,
                        FullName = s.FullName,
                        AverageScore = s.AverageScore,
                        FacultyName = s.Faculty.FacultyName
                    }).ToList();

                dgvResults.DataSource = results;
                lblTotalResults.Text = $"Kết quả tìm kiếm: {results.Count}";
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtStudentID.Clear();
            txtFullName.Clear();
            cmbFaculty.SelectedIndex = 0;
            dgvResults.DataSource = null;
            lblTotalResults.Text = "Kết quả tìm kiếm: 0";
        }
    }
}




