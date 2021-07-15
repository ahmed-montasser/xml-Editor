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

namespace XmlEditor
{
    public partial class Form1 : Form
    {
        private string xmlString = "";
        private string output_string = "";
        private string fileName = "";
        private string output_fileName = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            input.Clear();
            output.Clear();
            input_radioButton.Checked = false;
            output_radioButton.Checked = false;
            compressed_rdbtn.Checked = false;
            xmlFile_rdbtn.Checked = false;
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
            if (!xmlFile_rdbtn.Checked && !compressed_rdbtn.Checked)
            {
                MessageBox.Show("You should choose compressed or XML", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Title = "Open a XML file";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                input.Clear();
                if (xmlFile_rdbtn.Checked && !compressed_rdbtn.Checked)
                {
                    using (StreamReader sr = new StreamReader(openfile.FileName))
                    {
                        fileName = openfile.FileName;
                        output_fileName = fileName;
                        xmlString = sr.ReadToEnd();
                        input.Text = xmlString;
                        sr.Close();


                    }
                }
                else if (!xmlFile_rdbtn.Checked && compressed_rdbtn.Checked)
                {
                    fileName = openfile.FileName;
                    output_fileName = fileName;

                    HAlgo d = new HAlgo();
                    xmlString = d.Decompress(fileName);
                    input.Text = xmlString;
                }
            }
        }

        private void download_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Title = "Save file";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter outputtxt = new StreamWriter(savefile.FileName + ".xml");
                outputtxt.Write(output.Text);
                outputtxt.Close();
            }
        }

        private void minify_Click(object sender, EventArgs e)
        {
            output_string = Minifying.minify(input.Text);
            output.Clear();
            if (output_string != null)
            {
                output.Text = output_string;
                output_fileName = $"{fileName}_Minified";
            }
            else
            {
                output.Text = "Check Consistency first";
            }
        }

        private void compress_Click(object sender, EventArgs e)
        {
            if (!input_radioButton.Checked && !output_radioButton.Checked)
            {
                MessageBox.Show("You should choose input or output", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (input_radioButton.Checked && !output_radioButton.Checked) //input
            {
                if (input.Text == "" || input.Text == null)
                {
                    MessageBox.Show("Input Text is empty", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.Title = "Save file";
                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    new HAlgo().Compress(fileName, savefile.FileName);
                }

            }

            else if (!input_radioButton.Checked && output_radioButton.Checked) //output
            {
                if (output.Text == "" || output.Text == null)
                {
                    MessageBox.Show("Output Text is empty", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.Title = "Save file";
                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    new HAlgo().Compress(fileName, savefile.FileName);
                }
            }

        }

        private void xmlToJson_Click(object sender, EventArgs e)
        {

            List<string> xml = new List<string>();
            String x = input.Text;
            int i = 0;
            while (x.IndexOf("\n", i) >= 0 && x.IndexOf("\n", i) < 100000)
            {
                xml.Add(x.Substring(i, x.IndexOf("\n", i) - i));
                i = x.IndexOf("\n", i) + 1;
            }
            xml.Add(x.Substring(i, x.Length -i));
            xml2json function = new xml2json();
            List<string> json = function.finalizing(xml);
            string f_output="";
            for (int m = 0; m < json.Count()-1; m++)
            {
                f_output += json[m] + "\n";
            }
            f_output += json[json.Count() - 1];
            output.Text = f_output;
        }

        private void format_Click(object sender, EventArgs e)
        {

            List<string> xml = new List<string>();
            String x = input.Text;
            int i = 0;
            while (x.IndexOf("\n", i) >= 0 && x.IndexOf("\n", i) < 100000)
            {
                xml.Add(x.Substring(i, x.IndexOf("\n", i) - i));
                i = x.IndexOf("\n", i) + 1;
            }
            xml.Add(x.Substring(i, x.Length - i));
            prettify function2 = new prettify();
            List<string> p_xml = function2.operation2(xml);
            string f_output = "";
            for (int m = 0; m < p_xml.Count() - 1; m++)
            {
                f_output += p_xml[m] + "\n";
            }
            f_output += p_xml[p_xml.Count() - 1];
            output.Text = f_output;
        }
    }
}
