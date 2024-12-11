using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

         private void panel1_Paint(object sender, PaintEventArgs e)
         {
             AddLineNumber();
         }

        private void AddLineNumber()
        {
            
        }

        private void crrlNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.Show();
        }

        private void mởFileCtrlOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Filter = "C++ Files (*.cpp)|*.cpp |All Files (*.cpp)|*.cpp";
            if (dlg.ShowDialog() == DialogResult.OK)
                MessageBox.Show(dlg.FileName);
        }

        private void lưuFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sdlg = new SaveFileDialog();

            sdlg.Filter = "C++ Files (*.cpp)|*.cpp|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            sdlg.Title = "Save File";
            sdlg.DefaultExt = sdlg.FileName;
            sdlg.AddExtension = true;

            if (sdlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(sdlg.FileName, richTextBox1.Text);
                    MessageBox.Show("Luu thanh cong!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {

        }
    }
}
