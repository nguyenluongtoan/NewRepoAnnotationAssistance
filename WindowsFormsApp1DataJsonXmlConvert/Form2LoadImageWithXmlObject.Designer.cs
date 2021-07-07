
namespace WindowsFormsApp1DataJsonXmlConvert
{
    partial class Form2LoadImageWithXmlObject
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
            this.button1Open = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1Prev = new System.Windows.Forms.Button();
            this.button2Next = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1Open
            // 
            this.button1Open.Location = new System.Drawing.Point(12, 12);
            this.button1Open.Name = "button1Open";
            this.button1Open.Size = new System.Drawing.Size(75, 23);
            this.button1Open.TabIndex = 0;
            this.button1Open.Text = "Open";
            this.button1Open.UseVisualStyleBackColor = true;
            this.button1Open.Click += new System.EventHandler(this.button1Open_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(93, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1427, 700);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1Prev
            // 
            this.button1Prev.Location = new System.Drawing.Point(93, 12);
            this.button1Prev.Name = "button1Prev";
            this.button1Prev.Size = new System.Drawing.Size(75, 23);
            this.button1Prev.TabIndex = 2;
            this.button1Prev.Text = "<<";
            this.button1Prev.UseVisualStyleBackColor = true;
            this.button1Prev.Click += new System.EventHandler(this.button1Prev_Click);
            // 
            // button2Next
            // 
            this.button2Next.Location = new System.Drawing.Point(174, 12);
            this.button2Next.Name = "button2Next";
            this.button2Next.Size = new System.Drawing.Size(75, 23);
            this.button2Next.TabIndex = 3;
            this.button2Next.Text = ">>";
            this.button2Next.UseVisualStyleBackColor = true;
            this.button2Next.Click += new System.EventHandler(this.button2Next_Click);
            // 
            // Form2LoadImageWithXmlObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1609, 753);
            this.Controls.Add(this.button2Next);
            this.Controls.Add(this.button1Prev);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1Open);
            this.Name = "Form2LoadImageWithXmlObject";
            this.Text = "Form2LoadImageWithXmlObject";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1Open;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1Prev;
        private System.Windows.Forms.Button button2Next;
    }
}