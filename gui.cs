using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GUI_XML_editor
{
    public partial class gui : Form
    {
        public gui()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            input.Clear();
            output.Clear();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            input.Copy();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            output.Copy();
        }

        private void loadfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Title = "open a file";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                input.Clear();
                using (StreamReader sr = new StreamReader(openfile.FileName))
                {
                    input.Text = sr.ReadToEnd();
                    sr.Close();
                }
            }
        }

        private void download_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Title = "save file";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter outputtxt = new StreamWriter(savefile.FileName);
                outputtxt.Write(output.Text);
                outputtxt.Close();
            }
        }
    }
}
