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
            this.download = new System.Windows.Forms.Button();
            this.treeView = new System.Windows.Forms.Button();
            this.compress = new System.Windows.Forms.Button();
            this.minify = new System.Windows.Forms.Button();
            this.xmlToJson = new System.Windows.Forms.Button();
            this.format = new System.Windows.Forms.Button();
            this.loadfile = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(10, 52);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(426, 330);
            this.input.TabIndex = 0;
            this.input.Text = "";
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(442, 53);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(427, 329);
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
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 37);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(319, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(367, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 28);
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
            this.panel5.Location = new System.Drawing.Point(442, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(427, 37);
            this.panel5.TabIndex = 6;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(364, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(143, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Output";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.download);
            this.panel2.Controls.Add(this.treeView);
            this.panel2.Controls.Add(this.compress);
            this.panel2.Controls.Add(this.minify);
            this.panel2.Controls.Add(this.xmlToJson);
            this.panel2.Controls.Add(this.format);
            this.panel2.Controls.Add(this.loadfile);
            this.panel2.Location = new System.Drawing.Point(71, 400);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(738, 92);
            this.panel2.TabIndex = 7;
            // 
            // download
            // 
            this.download.BackColor = System.Drawing.Color.AliceBlue;
            this.download.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.download.Location = new System.Drawing.Point(489, 46);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(129, 30);
            this.download.TabIndex = 6;
            this.download.Text = "Download";
            this.download.UseVisualStyleBackColor = false;
            this.download.Click += new System.EventHandler(this.download_Click);
            // 
            // treeView
            // 
            this.treeView.BackColor = System.Drawing.Color.AliceBlue;
            this.treeView.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.treeView.Location = new System.Drawing.Point(306, 46);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(129, 30);
            this.treeView.TabIndex = 5;
            this.treeView.Text = "Tree view";
            this.treeView.UseVisualStyleBackColor = false;
            // 
            // compress
            // 
            this.compress.BackColor = System.Drawing.Color.AliceBlue;
            this.compress.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.compress.Location = new System.Drawing.Point(126, 46);
            this.compress.Name = "compress";
            this.compress.Size = new System.Drawing.Size(129, 30);
            this.compress.TabIndex = 4;
            this.compress.Text = "Compress";
            this.compress.UseVisualStyleBackColor = false;
            // 
            // minify
            // 
            this.minify.BackColor = System.Drawing.Color.AliceBlue;
            this.minify.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.minify.Location = new System.Drawing.Point(580, 10);
            this.minify.Name = "minify";
            this.minify.Size = new System.Drawing.Size(129, 30);
            this.minify.TabIndex = 3;
            this.minify.Text = "Minify";
            this.minify.UseVisualStyleBackColor = false;
            // 
            // xmlToJson
            // 
            this.xmlToJson.BackColor = System.Drawing.Color.AliceBlue;
            this.xmlToJson.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.xmlToJson.Location = new System.Drawing.Point(404, 10);
            this.xmlToJson.Name = "xmlToJson";
            this.xmlToJson.Size = new System.Drawing.Size(129, 30);
            this.xmlToJson.TabIndex = 2;
            this.xmlToJson.Text = "XML to JSON";
            this.xmlToJson.UseVisualStyleBackColor = false;
            // 
            // format
            // 
            this.format.BackColor = System.Drawing.Color.AliceBlue;
            this.format.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.format.Location = new System.Drawing.Point(212, 10);
            this.format.Name = "format";
            this.format.Size = new System.Drawing.Size(129, 30);
            this.format.TabIndex = 1;
            this.format.Text = "Format";
            this.format.UseVisualStyleBackColor = false;
            // 
            // loadfile
            // 
            this.loadfile.BackColor = System.Drawing.Color.AliceBlue;
            this.loadfile.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.loadfile.Location = new System.Drawing.Point(33, 10);
            this.loadfile.Name = "loadfile";
            this.loadfile.Size = new System.Drawing.Size(129, 30);
            this.loadfile.TabIndex = 0;
            this.loadfile.Text = "Load file";
            this.loadfile.UseVisualStyleBackColor = false;
            this.loadfile.Click += new System.EventHandler(this.loadfile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(884, 521);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input);
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
            this.ResumeLayout(false);

        }



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
        private System.Windows.Forms.Button loadfile;
        private System.Windows.Forms.Button download;
        private System.Windows.Forms.Button treeView;
        private System.Windows.Forms.Button compress;
        private System.Windows.Forms.Button minify;
        private System.Windows.Forms.Button xmlToJson;

        #endregion
    }
}

