namespace XmlEditor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.input = new System.Windows.Forms.RichTextBox();
            this.output = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.xmlFile_rdbtn = new System.Windows.Forms.RadioButton();
            this.compressed_rdbtn = new System.Windows.Forms.RadioButton();
            this.loadfile = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.output_radioButton = new System.Windows.Forms.RadioButton();
            this.input_radioButton = new System.Windows.Forms.RadioButton();
            this.compress = new System.Windows.Forms.Button();
            this.save_Button = new System.Windows.Forms.Button();
            this.minify = new System.Windows.Forms.Button();
            this.xmlToJson = new System.Windows.Forms.Button();
            this.format = new System.Windows.Forms.Button();
            this.checkError = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(10, 52);
            this.input.Margin = new System.Windows.Forms.Padding(2);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(368, 283);
            this.input.TabIndex = 0;
            this.input.Text = "";
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(380, 52);
            this.output.Margin = new System.Windows.Forms.Padding(2);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(368, 283);
            this.output.TabIndex = 1;
            this.output.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(10, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 37);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(239, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(278, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(145, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "XML Input";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Window;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(380, 11);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(368, 37);
            this.panel5.TabIndex = 6;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(277, 2);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(21, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(131, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Output";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.checkError);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.save_Button);
            this.panel2.Controls.Add(this.minify);
            this.panel2.Controls.Add(this.xmlToJson);
            this.panel2.Controls.Add(this.format);
            this.panel2.Location = new System.Drawing.Point(10, 349);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(738, 125);
            this.panel2.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.loadfile);
            this.groupBox1.Location = new System.Drawing.Point(10, -2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(150, 115);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.xmlFile_rdbtn);
            this.groupBox2.Controls.Add(this.compressed_rdbtn);
            this.groupBox2.Location = new System.Drawing.Point(6, 46);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(132, 64);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose Type of File:";
            // 
            // xmlFile_rdbtn
            // 
            this.xmlFile_rdbtn.AutoSize = true;
            this.xmlFile_rdbtn.Location = new System.Drawing.Point(5, 41);
            this.xmlFile_rdbtn.Margin = new System.Windows.Forms.Padding(2);
            this.xmlFile_rdbtn.Name = "xmlFile_rdbtn";
            this.xmlFile_rdbtn.Size = new System.Drawing.Size(66, 17);
            this.xmlFile_rdbtn.TabIndex = 1;
            this.xmlFile_rdbtn.TabStop = true;
            this.xmlFile_rdbtn.Text = "XML File";
            this.xmlFile_rdbtn.UseVisualStyleBackColor = true;
            // 
            // compressed_rdbtn
            // 
            this.compressed_rdbtn.AutoSize = true;
            this.compressed_rdbtn.Location = new System.Drawing.Point(5, 18);
            this.compressed_rdbtn.Margin = new System.Windows.Forms.Padding(2);
            this.compressed_rdbtn.Name = "compressed_rdbtn";
            this.compressed_rdbtn.Size = new System.Drawing.Size(83, 17);
            this.compressed_rdbtn.TabIndex = 0;
            this.compressed_rdbtn.TabStop = true;
            this.compressed_rdbtn.Text = "Compressed";
            this.compressed_rdbtn.UseVisualStyleBackColor = true;
            // 
            // loadfile
            // 
            this.loadfile.BackColor = System.Drawing.Color.AliceBlue;
            this.loadfile.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.loadfile.Location = new System.Drawing.Point(8, 10);
            this.loadfile.Margin = new System.Windows.Forms.Padding(2);
            this.loadfile.Name = "loadfile";
            this.loadfile.Size = new System.Drawing.Size(130, 32);
            this.loadfile.TabIndex = 0;
            this.loadfile.Text = "Load file";
            this.loadfile.UseVisualStyleBackColor = false;
            this.loadfile.Click += new System.EventHandler(this.loadfile_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.compress);
            this.groupBox3.Location = new System.Drawing.Point(177, 5);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(154, 109);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.output_radioButton);
            this.groupBox4.Controls.Add(this.input_radioButton);
            this.groupBox4.Location = new System.Drawing.Point(13, 40);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(125, 64);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Choose:";
            // 
            // output_radioButton
            // 
            this.output_radioButton.AutoSize = true;
            this.output_radioButton.Location = new System.Drawing.Point(5, 39);
            this.output_radioButton.Margin = new System.Windows.Forms.Padding(2);
            this.output_radioButton.Name = "output_radioButton";
            this.output_radioButton.Size = new System.Drawing.Size(57, 17);
            this.output_radioButton.TabIndex = 1;
            this.output_radioButton.TabStop = true;
            this.output_radioButton.Text = "Output";
            this.output_radioButton.UseVisualStyleBackColor = true;
            // 
            // input_radioButton
            // 
            this.input_radioButton.AutoSize = true;
            this.input_radioButton.Location = new System.Drawing.Point(5, 17);
            this.input_radioButton.Margin = new System.Windows.Forms.Padding(2);
            this.input_radioButton.Name = "input_radioButton";
            this.input_radioButton.Size = new System.Drawing.Size(49, 17);
            this.input_radioButton.TabIndex = 0;
            this.input_radioButton.TabStop = true;
            this.input_radioButton.Text = "Input";
            this.input_radioButton.UseVisualStyleBackColor = true;
            // 
            // compress
            // 
            this.compress.BackColor = System.Drawing.Color.AliceBlue;
            this.compress.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.compress.Location = new System.Drawing.Point(9, 5);
            this.compress.Margin = new System.Windows.Forms.Padding(2);
            this.compress.Name = "compress";
            this.compress.Size = new System.Drawing.Size(130, 30);
            this.compress.TabIndex = 4;
            this.compress.Text = "Compress";
            this.compress.UseVisualStyleBackColor = false;
            this.compress.Click += new System.EventHandler(this.compress_Click);
            // 
            // save_Button
            // 
            this.save_Button.BackColor = System.Drawing.Color.AliceBlue;
            this.save_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.save_Button.Location = new System.Drawing.Point(580, 76);
            this.save_Button.Margin = new System.Windows.Forms.Padding(2);
            this.save_Button.Name = "save_Button";
            this.save_Button.Size = new System.Drawing.Size(130, 30);
            this.save_Button.TabIndex = 6;
            this.save_Button.Text = "Save";
            this.save_Button.UseVisualStyleBackColor = false;
            this.save_Button.Click += new System.EventHandler(this.download_Click);
            // 
            // minify
            // 
            this.minify.BackColor = System.Drawing.Color.AliceBlue;
            this.minify.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.minify.Location = new System.Drawing.Point(580, 11);
            this.minify.Margin = new System.Windows.Forms.Padding(2);
            this.minify.Name = "minify";
            this.minify.Size = new System.Drawing.Size(130, 30);
            this.minify.TabIndex = 3;
            this.minify.Text = "Minify";
            this.minify.UseVisualStyleBackColor = false;
            this.minify.Click += new System.EventHandler(this.minify_Click);
            // 
            // xmlToJson
            // 
            this.xmlToJson.BackColor = System.Drawing.Color.AliceBlue;
            this.xmlToJson.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.xmlToJson.Location = new System.Drawing.Point(368, 76);
            this.xmlToJson.Margin = new System.Windows.Forms.Padding(2);
            this.xmlToJson.Name = "xmlToJson";
            this.xmlToJson.Size = new System.Drawing.Size(130, 30);
            this.xmlToJson.TabIndex = 2;
            this.xmlToJson.Text = "XML to JSON";
            this.xmlToJson.UseVisualStyleBackColor = false;
            this.xmlToJson.Click += new System.EventHandler(this.xmlToJson_Click);
            // 
            // format
            // 
            this.format.BackColor = System.Drawing.Color.AliceBlue;
            this.format.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.format.Location = new System.Drawing.Point(368, 11);
            this.format.Margin = new System.Windows.Forms.Padding(2);
            this.format.Name = "format";
            this.format.Size = new System.Drawing.Size(130, 30);
            this.format.TabIndex = 1;
            this.format.Text = "Format";
            this.format.UseVisualStyleBackColor = false;
            this.format.Click += new System.EventHandler(this.format_Click);
            // 
            // checkError
            // 
            this.checkError.BackColor = System.Drawing.Color.AliceBlue;
            this.checkError.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.checkError.Location = new System.Drawing.Point(473, 42);
            this.checkError.Margin = new System.Windows.Forms.Padding(2);
            this.checkError.Name = "checkError";
            this.checkError.Size = new System.Drawing.Size(130, 30);
            this.checkError.TabIndex = 13;
            this.checkError.Text = "Check consistency";
            this.checkError.UseVisualStyleBackColor = false;
            this.checkError.Click += new System.EventHandler(this.checkError_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(758, 481);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "XML editor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox input;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button format;
        private System.Windows.Forms.Button save_Button;
        private System.Windows.Forms.Button compress;
        private System.Windows.Forms.Button minify;
        private System.Windows.Forms.Button xmlToJson;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton output_radioButton;
        private System.Windows.Forms.RadioButton input_radioButton;
        private System.Windows.Forms.Button loadfile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton xmlFile_rdbtn;
        private System.Windows.Forms.RadioButton compressed_rdbtn;
        private System.Windows.Forms.Button checkError;
    }
}

