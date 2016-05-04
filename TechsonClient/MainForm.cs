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
        private Label[] labels1;
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

        private void button2_Click(object sender, EventArgs e)
        {
            labels1 = new Label[10] {label_1_0, label_1_1,label_1_2, label_1_3, label_1_4,label_1_5,
            label_1_6, label_1_7, label_1_8, label_1_9};

            Size oldSize = mainForm.ActiveForm.Size;
            if (!is_scaled)
            {
                mainForm.ActiveForm.Size = new Size(oldSize.Width, oldSize.Height + methodBox1.Height + 20);
                is_scaled = true;
            }
            for (int i = 0; i < labels1.Length; i++)
            {
                labels1[i].Text += "<value>";
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
