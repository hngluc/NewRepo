using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab04_123.Model;
namespace Lab04_123
{
    public partial class frmFaculty : System.Windows.Forms.Form
    {
        public frmFaculty()
        {
            InitializeComponent();
        }

        private void frmFaculty_Load(object sender, EventArgs e)
        {
            LoadFacultyData();
        }
        private void LoadFacultyData()
        {
            using (var context = new StudentContextDB())
            {
                dgvFaculty.DataSource = context.Faculties.ToList();
            }
        }

        private void btnAddorEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFacultyName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khoa!");
                return;
            }

            using (var context = new StudentContextDB())
            {
                Faculty faculty;

                // Kiểm tra nếu FacultyID rỗng hoặc không tồn tại => Thêm mới
                if (string.IsNullOrWhiteSpace(txtFacultyID.Text))
                {
                    faculty = new Faculty
                    {
                        FacultyName = txtFacultyName.Text,
                        TotalProfessor = string.IsNullOrWhiteSpace(txtTotalProfessor.Text) ? (int?)null : int.Parse(txtTotalProfessor.Text)
                    };

                    context.Faculties.Add(faculty);
                    MessageBox.Show("Thêm mới khoa thành công!");
                }
                // Ngược lại => Sửa
                else
                {
                    var facultyId = int.Parse(txtFacultyID.Text);
                    faculty = context.Faculties.SingleOrDefault(f => f.FacultyID == facultyId);

                    if (faculty != null)
                    {
                        faculty.FacultyName = txtFacultyName.Text;
                        faculty.TotalProfessor = string.IsNullOrWhiteSpace(txtTotalProfessor.Text) ? (int?)null : int.Parse(txtTotalProfessor.Text);

                        MessageBox.Show("Cập nhật khoa thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy khoa cần sửa!");
                        return;
                    }
                }

                context.SaveChanges();
                ResetForm();
                LoadFacultyData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFacultyID.Text))
            {
                MessageBox.Show("Vui lòng nhập mã khoa cần xóa!");
                return;
            }

            using (var context = new StudentContextDB())
            {
                var facultyId = int.Parse(txtFacultyID.Text);
                var faculty = context.Faculties.SingleOrDefault(f => f.FacultyID == facultyId);

                if (faculty != null)
                {
                    var result = MessageBox.Show("Bạn có chắc chắn muốn xóa khoa này?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        context.Faculties.Remove(faculty);
                        context.SaveChanges();
                        MessageBox.Show("Xóa khoa thành công!");
                        ResetForm();
                        LoadFacultyData();
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã khoa cần xóa!");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ResetForm()
        {
            txtFacultyID.Clear();
            txtFacultyName.Clear();
            txtTotalProfessor.Clear();
        }
        private void dgvFaculty_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFaculty.CurrentRow != null)
            {
                txtFacultyID.Text = dgvFaculty.CurrentRow.Cells["FacultyID"].Value.ToString();
                txtFacultyName.Text = dgvFaculty.CurrentRow.Cells["FacultyName"].Value.ToString();
                txtTotalProfessor.Text = dgvFaculty.CurrentRow.Cells["TotalProfessor"].Value.ToString();
            }
        }
    }
}
