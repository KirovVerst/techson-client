using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageFormatComponent;
using ImageGrayScaleComponent;
using ImageConverterComponent;
using ImageResizeComponent;

namespace TechsonClient
{
    public partial class mainForm : Form
    {
        private bool is_scaled = false;
        public mainForm()
        {
            InitializeComponent();
        }

        private void chooseImage(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Filter = "Image Files (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
            fdlg.FilterIndex = 1;

            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                Bitmap newImage = new Bitmap(fdlg.FileName);
                pictureBox.Image = newImage;
                System.Console.WriteLine(fdlg.FileName);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Size oldSize = mainForm.ActiveForm.Size;
            if (!is_scaled)
            {
                mainForm.ActiveForm.Size = new Size(oldSize.Width, oldSize.Height + 100);
                is_scaled = true;
            }
            
        }
    }
}
