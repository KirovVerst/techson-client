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
using RandomForestComponent;
using Newtonsoft.Json.Linq;

namespace TechsonClient
{
    public partial class mainForm : Form
    {
        private bool is_scaled = false;
        private Label[] labels1;
        public mainForm()
        {
            InitializeComponent();
            labels1 = new Label[10] {label_1_0, label_1_1,label_1_2, label_1_3, label_1_4,label_1_5,
            label_1_6, label_1_7, label_1_8, label_1_9};
        }

        private void chooseImage(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Filter = "Image Files (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
            fdlg.FilterIndex = 1;

            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                Bitmap newImage = new Bitmap(fdlg.FileName);
                pictureBox.ImageLocation = fdlg.FileName;
                pictureBox.Image = newImage;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            minimizeForm();
            clearFields();

            int[] data = transfomImage();

            RandomForestClassifier clsr = new RandomForestClassifier(data);

            double[] predicts = clsr.predict();

            for (int i = 0; i < labels1.Length; i++)
            {
                labels1[i].Text += " " + string.Format("{0:0.00}", predicts[i]);
            }

            maximizeForm();
        }

        private void clearFields(){
            for (var i = 0; i < labels1.Length; i++)
            {
                if (labels1[i].Text[labels1[i].Text.Length - 1] != ':'){
                    int lastSpace = labels1[i].Text.LastIndexOf(' ');
                    labels1[i].Text = labels1[i].Text.Substring(0, lastSpace);
                }
                
            }
        }

        private void maximizeForm(){
            Size oldSize = mainForm.ActiveForm.Size;
            if (!is_scaled)
            {
                mainForm.ActiveForm.Size = new Size(oldSize.Width, oldSize.Height + methodBox1.Height + 20);
                is_scaled = true;
            }
        }

        private void minimizeForm()
        {
            Size oldSize = mainForm.ActiveForm.Size;
            if (is_scaled)
            {
                mainForm.ActiveForm.Size = new Size(oldSize.Width, oldSize.Height - methodBox1.Height - 20);
                is_scaled = false;
            }
        }

        private int[] transfomImage(){
            string imagePath;

            Console.WriteLine(pictureBox.ImageLocation);
            ImageFormat imgConverter = new ImageFormat(pictureBox.ImageLocation);
            imagePath = imgConverter.SetPngFormat();
            ImageGrayScale imgGrayScale = new ImageGrayScale(imagePath);
            imagePath = imgGrayScale.transform();
            ImageResize imgResize = new ImageResize(imagePath);
            imagePath = imgResize.Resize(28,28);
            ImageToByte imgToByte = new ImageToByte(imagePath);
            return imgToByte.convert();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
