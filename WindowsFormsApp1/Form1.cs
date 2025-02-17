using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ResizeListBox();
        }

        private void ResizeListBox()
        {
            int width = (int)(tabPage1.Width * 0.35);
            listBoxSelectedFiles.Width = width;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                listBoxSelectedFiles.Items.Clear();
                foreach (string file in openFileDialog1.FileNames)
                {
                    listBoxSelectedFiles.Items.Add(file);
                }
            }
        }

        private void buttonGetSubtitleFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                listBoxSelectedFiles.Items.Clear();
                foreach (string file in openFileDialog1.FileNames)
                {
                    listBoxSelectedFiles.Items.Add(file);
                }
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnConvert_Click_1(object sender, EventArgs e)
        {
            new SrtConverter().ConvertListBoxItems(listBoxSelectedFiles);
        }
    }
}
