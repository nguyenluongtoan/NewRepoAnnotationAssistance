
namespace WindowsFormsApp1DataJsonXmlConvert
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2Test = new System.Windows.Forms.Button();
            this.button2CheckComplexPolygon = new System.Windows.Forms.Button();
            this.richTextBox1CheckComplexPolygon = new System.Windows.Forms.RichTextBox();
            this.progressBar1Files = new System.Windows.Forms.ProgressBar();
            this.progressBar1Object = new System.Windows.Forms.ProgressBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1Input = new System.Windows.Forms.PictureBox();
            this.button2OpenImage = new System.Windows.Forms.Button();
            this.richTextBox1BlackImg = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Input)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2Test
            // 
            this.button2Test.Location = new System.Drawing.Point(19, 55);
            this.button2Test.Name = "button2Test";
            this.button2Test.Size = new System.Drawing.Size(75, 23);
            this.button2Test.TabIndex = 1;
            this.button2Test.Text = "Test";
            this.button2Test.UseVisualStyleBackColor = true;
            this.button2Test.Click += new System.EventHandler(this.button2Test_Click);
            // 
            // button2CheckComplexPolygon
            // 
            this.button2CheckComplexPolygon.Location = new System.Drawing.Point(98, 26);
            this.button2CheckComplexPolygon.Name = "button2CheckComplexPolygon";
            this.button2CheckComplexPolygon.Size = new System.Drawing.Size(147, 23);
            this.button2CheckComplexPolygon.TabIndex = 2;
            this.button2CheckComplexPolygon.Text = "Check complex polygon";
            this.button2CheckComplexPolygon.UseVisualStyleBackColor = true;
            this.button2CheckComplexPolygon.Click += new System.EventHandler(this.button2CheckComplexPolygon_Click);
            // 
            // richTextBox1CheckComplexPolygon
            // 
            this.richTextBox1CheckComplexPolygon.Location = new System.Drawing.Point(98, 55);
            this.richTextBox1CheckComplexPolygon.Name = "richTextBox1CheckComplexPolygon";
            this.richTextBox1CheckComplexPolygon.Size = new System.Drawing.Size(414, 355);
            this.richTextBox1CheckComplexPolygon.TabIndex = 3;
            this.richTextBox1CheckComplexPolygon.Text = "";
            // 
            // progressBar1Files
            // 
            this.progressBar1Files.Location = new System.Drawing.Point(251, 26);
            this.progressBar1Files.Name = "progressBar1Files";
            this.progressBar1Files.Size = new System.Drawing.Size(117, 23);
            this.progressBar1Files.TabIndex = 4;
            // 
            // progressBar1Object
            // 
            this.progressBar1Object.Location = new System.Drawing.Point(374, 26);
            this.progressBar1Object.Name = "progressBar1Object";
            this.progressBar1Object.Size = new System.Drawing.Size(138, 23);
            this.progressBar1Object.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(540, 468);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox1CheckComplexPolygon);
            this.tabPage1.Controls.Add(this.progressBar1Object);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.progressBar1Files);
            this.tabPage1.Controls.Add(this.button2Test);
            this.tabPage1.Controls.Add(this.button2CheckComplexPolygon);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(532, 442);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBox1BlackImg);
            this.tabPage2.Controls.Add(this.button2OpenImage);
            this.tabPage2.Controls.Add(this.pictureBox1Input);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(532, 442);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1Input
            // 
            this.pictureBox1Input.Location = new System.Drawing.Point(16, 35);
            this.pictureBox1Input.Name = "pictureBox1Input";
            this.pictureBox1Input.Size = new System.Drawing.Size(75, 59);
            this.pictureBox1Input.TabIndex = 0;
            this.pictureBox1Input.TabStop = false;
            // 
            // button2OpenImage
            // 
            this.button2OpenImage.Location = new System.Drawing.Point(6, 6);
            this.button2OpenImage.Name = "button2OpenImage";
            this.button2OpenImage.Size = new System.Drawing.Size(85, 23);
            this.button2OpenImage.TabIndex = 1;
            this.button2OpenImage.Text = "Select Images";
            this.button2OpenImage.UseVisualStyleBackColor = true;
            this.button2OpenImage.Click += new System.EventHandler(this.button2OpenImage_Click);
            // 
            // richTextBox1BlackImg
            // 
            this.richTextBox1BlackImg.Location = new System.Drawing.Point(97, 6);
            this.richTextBox1BlackImg.Name = "richTextBox1BlackImg";
            this.richTextBox1BlackImg.Size = new System.Drawing.Size(429, 430);
            this.richTextBox1BlackImg.TabIndex = 2;
            this.richTextBox1BlackImg.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 492);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Input)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2Test;
        private System.Windows.Forms.Button button2CheckComplexPolygon;
        private System.Windows.Forms.RichTextBox richTextBox1CheckComplexPolygon;
        private System.Windows.Forms.ProgressBar progressBar1Files;
        private System.Windows.Forms.ProgressBar progressBar1Object;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2OpenImage;
        private System.Windows.Forms.PictureBox pictureBox1Input;
        private System.Windows.Forms.RichTextBox richTextBox1BlackImg;
    }
}

