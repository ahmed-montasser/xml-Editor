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

namespace XML_editor_GUI
{
    public partial class XMLgui : Form
    {
        public XMLgui()
        {
            InitializeComponent();
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            input.Clear();
        }

        private void loadfile_MouseEnter(object sender, EventArgs e)
        {

            loadfile.BackColor = Color.White;
        }

        private void loadfile_MouseLeave(object sender, EventArgs e)
        {
            loadfile.BackColor = Color.AliceBlue;
        }

        private void format_MouseEnter(object sender, EventArgs e)
        {
            format.BackColor = Color.White;
        }

        private void format_MouseLeave(object sender, EventArgs e)
        {
            format.BackColor = Color.AliceBlue;
        }

        private void xmlToJson_MouseEnter(object sender, EventArgs e)
        {
            xmlToJson.BackColor = Color.White;
        }

        private void xmlToJson_MouseLeave(object sender, EventArgs e)
        {
            xmlToJson.BackColor = Color.AliceBlue;
        }

        private void minify_MouseEnter(object sender, EventArgs e)
        {
            minify.BackColor = Color.White;
        }

        private void minify_MouseLeave(object sender, EventArgs e)
        {
            minify.BackColor = Color.AliceBlue;
        }

        private void compress_MouseEnter(object sender, EventArgs e)
        {
            compress.BackColor = Color.White;
        }

        private void compress_MouseLeave(object sender, EventArgs e)
        {
            compress.BackColor = Color.AliceBlue;
        }

        private void treeView_MouseEnter(object sender, EventArgs e)
        {
            treeView.BackColor = Color.White;
        }

        private void treeView_MouseLeave(object sender, EventArgs e)
        {
            treeView.BackColor = Color.AliceBlue;
        }

        private void csv_MouseEnter(object sender, EventArgs e)
        {
            csv.BackColor = Color.White;
        }

        private void csv_MouseLeave(object sender, EventArgs e)
        {
            csv.BackColor = Color.AliceBlue;
        }

        private void download_MouseEnter(object sender, EventArgs e)
        {
            download.BackColor = Color.White;
        }

        private void download_MouseLeave(object sender, EventArgs e)
        {
            download.BackColor = Color.AliceBlue;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            input.Copy();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            output.Copy();
        }
    }
}
