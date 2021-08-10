using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1DataJsonXmlConvert.WE
{
    class OpenDialog
    {
        OpenFileDialog openFileDialog;

        public OpenDialog()
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = true;
        }

        public bool OpenFileDialogShowDialogIsDialogResultOK()
        {
            return openFileDialog.ShowDialog() == DialogResult.OK;
        }

        public string[] FileNames()
        {
            return openFileDialog.FileNames;
        }
        public List<string> FileXml()
        {
            List<string> files = new List<string>();
            foreach (string g in openFileDialog.FileNames)
            {
                if (g.EndsWith(".xml"))
                {
                    files.Add(g);
                }
            }
            return files;
        }
        public List<string> FileJpg()
        {
            List<string> files = new List<string>();
            foreach (string g in openFileDialog.FileNames)
            {
                if (g.EndsWith(".jpg"))
                {
                    files.Add(g);
                }
            }
            return files;
        }
        public List<string> FileExtension(string ext)
        {
            List<string> files = new List<string>();
            foreach (string g in openFileDialog.FileNames)
            {
                if (g.EndsWith(ext))
                {
                    files.Add(g);
                }
            }
            return files;
        }
    }
}
