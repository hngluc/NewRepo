using ASM1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var context = new Model1();
                List<TrangThai> trangThais = context.TrangThais.ToList();
                List<DiaPhuong> diaPhuongs = context.DiaPhuongs.ToList();
                FillTrangThaiCombobox(trangThais);
                BindGrid(diaPhuongs);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindGrid(List<DiaPhuong> diaPhuongs)
        {
            dgvCovid19.Rows.Clear();
            foreach (var item in diaPhuongs)
            {
                int index = dgvCovid19.Rows.Add();
                dgvCovid19.Rows[index].Cells[0].Value = item.MaDP;
                dgvCovid19.Rows[index].Cells[1].Value = item.TenDP;
                dgvCovid19.Rows[index].Cells[2].Value = item.SoCaNhiemMoi;
                dgvCovid19.Rows[index].Cells[3].Value = item.TrangThai.TenTT;

            }
        }

        private void FillTrangThaiCombobox(List<TrangThai> trangThais)
        {
            this.cmbTT.DataSource = trangThais;
            this.cmbTT.DisplayMember = "TenTT";
            this.cmbTT.ValueMember = "MaTT";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new Model1();
                List<DiaPhuong> dpList = db.DiaPhuongs.ToList();
                if (dpList.Any(dp => dp.MaDP == txtDP.Text))
                {
                    MessageBox.Show("Mã địa phương đã tồn tai. Vui lòng nhập mã khác", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                

                var newDiaPhuong = new DiaPhuong
                {
                    MaDP = txtDP.Text,
                    TenDP = txtName.Text,
                    SoCaNhiemMoi = int.Parse(txtCaNhiem.Text),
                    MaTT = cmbTT.SelectedIndex
                };

                db.DiaPhuongs.Add(newDiaPhuong);
                db.SaveChanges();

                BindGrid(db.DiaPhuongs.ToList());
                 
                MessageBox.Show("Thêm địa phương thành công!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                 MessageBox.Show($"Vui lòng nhập đầy đủ thông tin! {ex.Message}", "Thông báo",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void sắpXếpTheoSốCaNhiễmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.FormClosed += (s, args) => this.Show();

            form2.Show();
            this.Hide();
        }
    }
}
