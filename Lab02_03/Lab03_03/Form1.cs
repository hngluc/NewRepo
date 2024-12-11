using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openn = new SaveFileDialog();
            openn.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
           var s = new OpenFileDialog();
            s.ShowDialog();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void ctrlNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1  = new RichTextBox();
            richTextBox1.Text = "";

        }

        private void goToF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
