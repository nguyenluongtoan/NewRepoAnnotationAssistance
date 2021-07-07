using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1DataJsonXmlConvert.WE;

namespace WindowsFormsApp1DataJsonXmlConvert
{
    public partial class Form2LoadImageWithXmlObject : Form
    {
        public Form2LoadImageWithXmlObject()
        {
            InitializeComponent();
            currentPosition = 0;
            selectedImage = false;
        }
        int currentPosition;
        List<Rectangle> rectangles;
        List<string> openDialogXmlFileNames;
        List<string> openDialogJpgFileNames;
        bool selectedImage;
        private void button1Open_Click(object sender, EventArgs e)
        {
            OpenDialog openDialog = new OpenDialog();
            if (openDialog.OpenFileDialogShowDialogIsDialogResultOK())
            {
                openDialogXmlFileNames = openDialog.FileXml();
                openDialogJpgFileNames = openDialog.FileJpg();
                //foreach (var filename in openDialogFileNames)
                //{  }
                pictureBox1_RePaint();
            }
            //Bussiness._.GetXml();
            //string fileName = @"F:\lqa\hangano\OD_samples (1)\images\cm_ger.1872_19701202_204506_n.mp4_01140.jpg";
        }

        private void pictureBox1_Paintzxvzv(object sender, PaintEventArgs e)
        {
            //rectangles = Bussiness._.GetXml(@"F:\lqa\hangano\OD_samples (1)\xml\cm_ger.1872_19701202_204506_n.mp4_01140.xml");
            //string fileName = @"F:\lqa\hangano\OD_samples (1)\images\cm_ger.1872_19701202_204506_n.mp4_01140.jpg";
            if (selectedImage)
            {
                rectangles = Bussiness._.GetXml(openDialogXmlFileNames[currentPosition]);
                string fileName = openDialogJpgFileNames[currentPosition];
                e.Graphics.Clear(Color.White);
                e.Graphics.DrawImage(new Bitmap(fileName), 0, 0);
                foreach (Rectangle rectangle in rectangles)
                {
                    e.Graphics.DrawRectangle( new Pen(Color.Red, 2f), rectangle );
                }
            }
           
            //pictureBox1.Image = new Bitmap(fileName);
        }

        void pictureBox1_RePaint()
        {
            Graphics g = this.pictureBox1.CreateGraphics();
            rectangles = Bussiness._.GetXml(openDialogXmlFileNames[currentPosition]);
            string fileName = openDialogJpgFileNames[currentPosition];
            g.Clear(Color.White);
            g.DrawImage(new Bitmap(fileName), 0, 0);
            foreach (Rectangle rectangle in rectangles)
            {
                g.DrawRectangle(new Pen(Color.Red, 2f), rectangle);
            }
        }

        private void button1Prev_Click(object sender, EventArgs e)
        {
            if(currentPosition > 0)
            {
                currentPosition--;
                pictureBox1_RePaint();
            }
        }

        private void button2Next_Click(object sender, EventArgs e)
        {
            currentPosition++;
            pictureBox1_RePaint();
        }
    }
}
