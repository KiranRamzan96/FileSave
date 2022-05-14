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

namespace FileSave
{
    public partial class Form1 : Form
    {
       
        public Form1()

        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            string fileToCopy = ofd.FileName;
            byte[] filedata =File.ReadAllBytes(ofd.FileName);
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            //  File.GetAccessControl(fbd.SelectedPath);
             File.WriteAllBytes(fbd.SelectedPath, filedata);
            
            MessageBox.Show("Saved!");


        }
    }
}
