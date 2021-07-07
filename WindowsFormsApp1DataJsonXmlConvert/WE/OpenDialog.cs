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
    }
}
