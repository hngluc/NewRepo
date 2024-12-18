using Lab04_01.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04_01
{
    public partial class Form_Load : Form
    {
        public Form_Load()
        {
            InitializeComponent();
        }

        private void frmStudentManagement_Load(object sender, EventArgs e)
        {
            try
            {
                var context = new Model1();
                List<Faculty> listFaculty = context.Faculties.ToList();
                List<Student> listStudent = context.Students.ToList();
                FillFacultyCombobox(listFaculty);
                BindGrid(listStudent);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BindGrid(List<Student> listStudent)
        {
            dgvStudent.Rows.Clear();
            foreach (var item in listStudent)
            {
                int index = dgvStudent.Rows.Add();
                dgvStudent.Rows[index].Cells[0].Value = item.StudentID;
                dgvStudent.Rows[index].Cells[1].Value = item.FullName;
                dgvStudent.Rows[index].Cells[2].Value = item.Faculty.FacultyName;
                dgvStudent.Rows[index].Cells[3].Value = item.AverageScore;
            }

        }

        private void FillFacultyCombobox(List<Faculty> listFaculty)
        {
            this.cmbFaculty.DataSource = listFaculty;
            this.cmbFaculty.DisplayMember = "FacultyName";
            this.cmbFaculty.ValueMember = "FacultyID";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new Model1();
                List<Student> studentList = db.Students.ToList();
                if (studentList.Any(s => s.StudentID == int.Parse(txtID.Text)))
                {
                    MessageBox.Show("Mã số sv đã tồn tại. Vui lòng nhập một mã khác. ",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var newStudent = new Student
                {
                    StudentID = int.Parse(txtID.Text),
                    FullName = txtName.Text,
                    FacultyID = int.Parse(cmbFaculty.SelectedValue.ToString()),
                    AverageScore = (decimal?)double.Parse(txtAvg.Text)
                };
                db.Students.Add(newStudent);
                db.SaveChanges();

                BindGrid(db.Students.ToList());

                MessageBox.Show("Thêm sinh viên thành công!", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm dữ liệu {ex.Message}", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new Model1();
                List<Student> studentList = db.Students.ToList();
                var student = studentList.FirstOrDefault(s => s.StudentID == int.Parse(txtID.Text));
                if (student != null)
                {
                    if (studentList.Any(s => s.StudentID == int.Parse(txtID.Text) && s.StudentID != student.StudentID))
                    {
                        MessageBox.Show("Mã SV đã tồn tại. Vui lòng nhập một mã khac. ", "Thong bao",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    student.FullName = txtName.Text;
                    student.FacultyID = int.Parse(cmbFaculty.SelectedValue.ToString());
                    student.AverageScore = (decimal?)double.Parse(txtAvg.Text);

                    db.SaveChanges();

                    BindGrid(db.Students.ToList());

                    MessageBox.Show("Chỉnh sửa thông tinh sinh viên thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sinh viên không tìm thấy!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm dữ liệu {ex.Message}", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                
               using(var context = new Model1())
                {
                    List<Student> studentList = context.Students.ToList();

                    var student = studentList.FirstOrDefault(s => s.StudentID == int.Parse(txtID.Text));

                    if (student != null)
                    {
                        context.Students.Remove(student);
                        context.SaveChanges();

                        BindGrid(context.Students.ToList());

                        MessageBox.Show("Sinh viên đa được xoa thanh công!", "Thông bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sinh viên không tìm thấy!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } catch (Exception ex) {

                MessageBox.Show($"Lỗi khi cập nhật dữ liệu: {ex.Message}", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvStudent.Rows[e.RowIndex];
                txtID.Text = Convert.ToString(row.Cells["ID"].Value);
                txtName.Text = Convert.ToString(row.Cells["Name"].Value);
                txtAvg.Text = Convert.ToString(row.Cells["Avg"].Value);
                cmbFaculty.Text = Convert.ToString(row.Cells["Faculty"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
