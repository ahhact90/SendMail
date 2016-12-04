using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SendMail
{
    public partial class FrmListFile : Form
    {
        public FrmListFile()
        {
            InitializeComponent();
        }

        private void btOpenFile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                lstBoxFile.Items.Clear();
                string [] files = Directory.GetFiles(FBD.SelectedPath);
                string[] dirs = Directory.GetDirectories(FBD.SelectedPath);
                foreach (string file in files)
                {
                    lstBoxFile.Items.Add(Path.GetFileName(file)); 
                }
                foreach (string dir in dirs)
                {
                    lstBoxFile.Items.Add(Path.GetFileName(dir));
                }

            }
        }

        private void lstBoxFile_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
