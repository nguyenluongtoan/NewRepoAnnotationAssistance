using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1DataJsonXmlConvert.Geometry;
using WindowsFormsApp1DataJsonXmlConvert.WE;
using Point = WindowsFormsApp1DataJsonXmlConvert.Geometry.Point;

namespace WindowsFormsApp1DataJsonXmlConvert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Visible = button2Test.Visible = false;            // code for Hg
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenDialog choofdlog = new OpenDialog();
            if (choofdlog.OpenFileDialogShowDialogIsDialogResultOK())
            {
                string[] arrAllFiles = choofdlog.FileNames(); //used when Multiselect = true           
                foreach(string g in arrAllFiles)
                {
                    string json = File.ReadAllText(g);
                    dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
                    var len = jsonObj["objects"].Count;
                    for(int i = 0; i < len; i++)
                    {
                        var x = jsonObj["objects"][i]["label"];
                        var y = jsonObj["objects"][i]["polygon"];
                        jsonObj["objects"][i].Property("polygon").Remove();
                        jsonObj["objects"][i].Add("polygon", y);
                        string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                        File.WriteAllText(g, output);
                    }
                }
            }
        }
        private void button2Test_Click(object sender, EventArgs e)
        {
            Test.Run(); 
        }
        private void button2CheckComplexPolygon_Click(object sender, EventArgs e)
        {
            OpenDialog openDialog = new OpenDialog();
            if (openDialog.OpenFileDialogShowDialogIsDialogResultOK())
            {
                string[] openDialogFileNames = openDialog.FileNames(); //used when Multiselect = true
                progressBar1Files.Minimum = 0;
                progressBar1Files.Maximum = openDialogFileNames.Length;
                richTextBox1CheckComplexPolygon.Text = "";
                StringBuilder stringBuilder = new StringBuilder();
                var watch = System.Diagnostics.Stopwatch.StartNew();
                foreach (string fileName in openDialogFileNames)
                {
                    progressBar1Files.Value++;
                    string json = File.ReadAllText(fileName);
                    dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
                    var objCount = jsonObj["objects"].Count;
                    progressBar1Object.Minimum = 0;
                    progressBar1Object.Maximum = objCount;
                    progressBar1Object.Value = 0;
                    var polygonPoints =  Bussiness._.GetPointsFromJsonFile(fileName);
                    int i = 0;
                    while(polygonPoints.Count > 0)
                    {
                        i++;
                        Polygon polygon = new Polygon(polygonPoints.Pop());
                        if (polygon.IsComplex())
                        {
                            stringBuilder.AppendLine(fileName + "\tobjCouunt = " + objCount+ "\n"+"label: " + " CUT");
                            stringBuilder.AppendLine("Toa do: " + polygon.ToString());
                            stringBuilder.AppendLine("Thu tu: " + i);
                        }
                    }
                }
                richTextBox1CheckComplexPolygon.Text = stringBuilder.ToString();
                watch.Stop();
                richTextBox1CheckComplexPolygon.Text += watch.ElapsedMilliseconds;
            }
        }

        private void button2OpenImage_Click(object sender, EventArgs e)
        {
            OpenDialog openDialog = new OpenDialog();
            if (openDialog.OpenFileDialogShowDialogIsDialogResultOK())
            {
                string[] openDialogFileNames = openDialog.FileNames();
                StringBuilder stringBuilder = new StringBuilder();
                foreach(string fileName in openDialogFileNames)
                {
                    using (var tempBmp = new Bitmap(fileName))
                    {
                        BitmapData bmpData = tempBmp.LockBits(new System.Drawing.Rectangle(0, 0, tempBmp.Width, tempBmp.Height), ImageLockMode.ReadWrite, tempBmp.PixelFormat);
                        IntPtr ptr = bmpData.Scan0;
                        int height = tempBmp.Height;
                        int bytes = System.Math.Abs(bmpData.Stride) * height;
                        byte[] rgbValues = new byte[bytes];
                        System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);
                        bool hasBlack = false;
                        for (int counter = 0; counter < rgbValues.Length - 3; counter += 3)
                        {
                            if (rgbValues[counter] == rgbValues[counter + 1] &&
                                rgbValues[counter + 1] == rgbValues[counter + 2] &&
                               rgbValues[counter] == 0)
                            {
                                hasBlack = true;
                                break;
                            }
                        }
                        tempBmp.UnlockBits(bmpData);
                        if (hasBlack)
                        {
                            stringBuilder.AppendLine(fileName);
                        }
                    }
                    
                }
                richTextBox1BlackImg.Text = stringBuilder.ToString();
             
            }

        }
    }
}
