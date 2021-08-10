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
using WindowsFormsApp1DataJsonXmlConvert.WE;

namespace WindowsFormsApp1DataJsonXmlConvert
{
    public partial class Form2CopyByQueryG : Form
    {
        List<string> openDialogCsvFileNames;
        public Form2CopyByQueryG()
        {
            InitializeComponent(); 
           

        }

        private void button1Excecute_Click(object sender, EventArgs e)
        {
            string sourceDir = @"D:\lqa\hangano\a\b";
            sourceDir = @"\\172.16.8.10\qcom_t17\DATA\PJT_QUALCOMM\QUALCOMM_PJT_NORMAL TASKS\Raw Data\191223-road-delimiter\Images\2MP\2MP_180625\Images_1920x1020\mkz2.2018_05_16.SR125_To_BC\generated\CAM_TFM50_2MP\test0810";
            string backupDir = @"D:\lqa\hangano\a\c";

            try
            {
                string[] picList = Directory.GetFiles(sourceDir, "*.png");
                string[] txtList = Directory.GetFiles(sourceDir, "*.txt");
                progressBar1Copying.Maximum = picList.Length;
                progressBar1Copying.Step = 1;
                // Copy picture files.
                foreach (string f in picList)
                {
                    // Remove path from the file name.
                    string fName = f.Substring(sourceDir.Length + 1);
                    progressBar1Copying.PerformStep();

                    // Use the Path.Combine method to safely append the file name to the path.
                    // Will overwrite if the destination file already exists.
                    File.Copy(Path.Combine(sourceDir, fName), Path.Combine(backupDir, fName), true);
                }

                // Copy text files.
                foreach (string f in txtList)
                {

                    // Remove path from the file name.
                    string fName = f.Substring(sourceDir.Length + 1);

                    try
                    {
                        // Will not overwrite if the destination file already exists.
                        File.Copy(Path.Combine(sourceDir, fName), Path.Combine(backupDir, fName));
                    }

                    // Catch exception if the file was already copied.
                    catch (IOException copyError)
                    {
                        Console.WriteLine(copyError.Message);
                    }
                }

                // Delete source files that were copied.
                //foreach (string f in txtList)
                //{
                //    File.Delete(f);
                //}
                //foreach (string f in picList)
                //{
                //    File.Delete(f);
                //}
            }

            catch (DirectoryNotFoundException dirNotFound)
            {
                Console.WriteLine(dirNotFound.Message);
            }

        }

        private void button1OpenFolder_Click(object sender, EventArgs e)
        {
            OpenDialog openDialog = new OpenDialog();
            
            if (openDialog.OpenFileDialogShowDialogIsDialogResultOK())
            {
                openDialogCsvFileNames = openDialog.FileExtension("csv");
                var column2 = new List<string>();
                string g = @"D:\lqa\hangano\Path_csv\smt_junction_pseudo_gt_5_fix.csv";
                g = openDialogCsvFileNames[0];
                using (var rd = new StreamReader(g))
                {
                    while (!rd.EndOfStream)
                    {
                        var splits = rd.ReadLine().Split(',');
                        string imagePath =
@"\\172.16.8.10\qcom_t17\DATA\PJT_QUALCOMM\QUALCOMM_PJT_NORMAL TASKS\Raw Data\191223-road-delimiter\Images\"
                        + splits[0];
                        column2.Add(imagePath);
                    }
                }

                foreach(var r in column2)
                {
                    
                }
                
                int t = 0;
            }
        }
    }
}
