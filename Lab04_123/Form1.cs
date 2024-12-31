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
    public partial class Form : System.Windows.Forms.Form
    {
        private StudentContextDB context;
        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            using (var context = new StudentContextDB())
            {
                // Hiển thị danh sách sinh viên bằng ViewModel
                var studentViewModels = context.Students
                    .Include(s => s.Faculty)
                    .Select(s => new ViewModel
                    {
                        StudentID = s.StudentID,
                        FullName = s.FullName,
                        AverageScore = s.AverageScore,
                        FacultyName = s.Faculty.FacultyName
                    }).ToList();

                dgvStudent.DataSource = studentViewModels;

                // Hiển thị tên khoa trong ComboBox
                var faculties = context.Faculties.ToList();
                cmbFaculty.DataSource = faculties;
                cmbFaculty.DisplayMember = "FacultyName";
                cmbFaculty.ValueMember = "FacultyID";
            }
        }
    
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var context = new StudentContextDB())
            {
                var student = new Student
                {
                    StudentID = txtStudentID.Text,
                    FullName = txtFullName.Text,
                    AverageScore = float.Parse(txtAverageScore.Text),  // Ép kiểu từ string sang float
                    FacultyID = (int)cmbFaculty.SelectedValue
                };
                context.Students.Add(student);
                context.SaveChanges();
                MessageBox.Show("Thêm mới dữ liệu thành công!");

                // Cập nhật DataGridView sau khi thêm sinh viên mới
                var studentViewModels = context.Students
                    .Include(s => s.Faculty)
                    .Select(s => new ViewModel
                    {
                        StudentID = s.StudentID,
                        FullName = s.FullName,
                        AverageScore = (float)(s.AverageScore.HasValue ? s.AverageScore.Value : 0.0),
                        FacultyName = s.Faculty.FacultyName
                    }).ToList();

                dgvStudent.DataSource = studentViewModels;
                ResetForm();
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (var context = new StudentContextDB())
            {
                var student = context.Students.SingleOrDefault(s => s.StudentID == txtStudentID.Text);
                if (student != null)
                {
                    student.FullName = txtFullName.Text;
                    student.AverageScore = float.Parse(txtAverageScore.Text);  // Ép kiểu từ string sang float
                    student.FacultyID = (int)cmbFaculty.SelectedValue;
                    context.SaveChanges();
                    MessageBox.Show("Cập nhật dữ liệu thành công!");

                    // Cập nhật DataGridView sau khi sửa sinh viên
                    var studentViewModels = context.Students
                        .Include(s => s.Faculty)
                        .Select(s => new ViewModel
                        {
                            StudentID = s.StudentID,
                            FullName = s.FullName,
                            AverageScore = (float)(s.AverageScore.HasValue ? s.AverageScore.Value : 0.0),
                            FacultyName = s.Faculty.FacultyName
                        }).ToList();

                    dgvStudent.DataSource = studentViewModels;
                    ResetForm();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy MSSV cần sửa!");
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var context = new StudentContextDB())
            {
                var student = context.Students.SingleOrDefault(s => s.StudentID == txtStudentID.Text);
                if (student != null)
                {
                    var result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        context.Students.Remove(student);
                        context.SaveChanges();
                        MessageBox.Show("Xóa sinh viên thành công!");
                        ResetForm();
                        dgvStudent.DataSource = context.Students.Include(s => s.Faculty).ToList();
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy MSSV cần xóa!");
                }
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStudent.CurrentRow != null)
            {
                txtStudentID.Text = dgvStudent.CurrentRow.Cells["StudentID"].Value.ToString();
                txtFullName.Text = dgvStudent.CurrentRow.Cells["FullName"].Value.ToString();
                txtAverageScore.Text = dgvStudent.CurrentRow.Cells["AverageScore"].Value.ToString();
                cmbFaculty.SelectedValue = dgvStudent.CurrentRow.Cells["FacultyID"].Value;
            }
        }
        private void ResetForm()
        {
            txtStudentID.Clear();
            txtFullName.Clear();
            txtAverageScore.Clear();
            cmbFaculty.SelectedIndex = -1;
        }
        private void btnManageFaculties_Click_1(object sender, EventArgs e)
        {
            var facultyForm = new frmFaculty();
            facultyForm.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchForm = new frmSearch(); 
            searchForm.Show();
        }

        private void Out_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        { // Dispose context khi form đóng
          if (context != null) 
            { 
                context.Dispose(); 
            } 
            base.OnFormClosing(e); }
        }
}


