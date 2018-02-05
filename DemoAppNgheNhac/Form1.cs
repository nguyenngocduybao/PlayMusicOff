using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoAppNgheNhac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String[] fileNames; //Tên File
        String[] filePaths; //Đường dẫn File
        private void btn_open_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                fileNames = openFileDialog1.SafeFileNames;
                filePaths = openFileDialog1.FileNames;
                foreach(String fileName in fileNames)
                {
                    listmusic.Items.Add(fileName);
                }
            }
        }

        private void listmusic_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = filePaths[listmusic.SelectedIndex];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
