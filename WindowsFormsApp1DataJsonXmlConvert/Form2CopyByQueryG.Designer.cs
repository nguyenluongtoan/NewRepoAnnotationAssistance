
namespace WindowsFormsApp1DataJsonXmlConvert
{
    partial class Form2CopyByQueryG
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
            this.progressBar1Copying = new System.Windows.Forms.ProgressBar();
            this.button1Excecute = new System.Windows.Forms.Button();
            this.button1OpenFolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar1Copying
            // 
            this.progressBar1Copying.Location = new System.Drawing.Point(12, 59);
            this.progressBar1Copying.Name = "progressBar1Copying";
            this.progressBar1Copying.Size = new System.Drawing.Size(776, 26);
            this.progressBar1Copying.TabIndex = 0;
            // 
            // button1Excecute
            // 
            this.button1Excecute.Location = new System.Drawing.Point(174, 12);
            this.button1Excecute.Name = "button1Excecute";
            this.button1Excecute.Size = new System.Drawing.Size(75, 23);
            this.button1Excecute.TabIndex = 1;
            this.button1Excecute.Text = "execute";
            this.button1Excecute.UseVisualStyleBackColor = true;
            this.button1Excecute.Click += new System.EventHandler(this.button1Excecute_Click);
            // 
            // button1OpenFolder
            // 
            this.button1OpenFolder.Location = new System.Drawing.Point(93, 12);
            this.button1OpenFolder.Name = "button1OpenFolder";
            this.button1OpenFolder.Size = new System.Drawing.Size(75, 23);
            this.button1OpenFolder.TabIndex = 2;
            this.button1OpenFolder.Text = "Open Csv";
            this.button1OpenFolder.UseVisualStyleBackColor = true;
            this.button1OpenFolder.Click += new System.EventHandler(this.button1OpenFolder_Click);
            // 
            // Form2CopyByQueryG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1OpenFolder);
            this.Controls.Add(this.button1Excecute);
            this.Controls.Add(this.progressBar1Copying);
            this.Name = "Form2CopyByQueryG";
            this.Text = "Form2CopyByQueryG";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1Copying;
        private System.Windows.Forms.Button button1Excecute;
        private System.Windows.Forms.Button button1OpenFolder;
    }
}