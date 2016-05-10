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
using Newtonsoft.Json.Linq;
// image preprocessing
using ImageFormatComponent; 
using ImageGrayScaleComponent;
using ImageConverterComponent;
using ImageResizeComponent;
// machine learning components
using RandomForestComponent;
using NeuralNetworkComponent;
using GradientBoostingComponent;


namespace TechsonClient
{
    public partial class mainForm : Form
    {
        private bool isWindowScaled = false;
        private bool isImageChosen = false;
        private bool isImageUpdated = false;

        private int maxHeight = 560;
        private int midHeight = 340;
        private int minHeight = 230;
        private Label[,] labels;
        private GroupBox[] methodBoxes;

        private int[] m_data;

        public mainForm()
        {
            InitializeComponent();
            labels = new Label[3,10] {
                {label_1_0, label_1_1,label_1_2, label_1_3, label_1_4,label_1_5, label_1_6, label_1_7, label_1_8, label_1_9},
                {label_2_0, label_2_1,label_2_2, label_2_3, label_2_4,label_2_5, label_2_6, label_2_7, label_2_8, label_2_9},
                {label_3_0, label_3_1,label_3_2, label_3_3, label_3_4,label_3_5, label_3_6, label_3_7, label_3_8, label_3_9}
            };
            methodBoxes = new GroupBox[3] { methodBox1, methodBox2, methodBox3 };
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
                pictureBox.ImageLocation = fdlg.FileName;
                isImageChosen = true;
                isImageUpdated = true;
            }
        }

        private void startPredict(object sender, EventArgs e)
        {
            if (!isImageChosen)
            {
                MessageBox.Show("Please, choose a image ...", "Error");
                return;
            }

            if (!isMethodChosen())
            {
                MessageBox.Show("Please, choose a method ...", "Error");
                return;
            }

            ResetHeight(minHeight);
            ResetLabels();
            if (isImageUpdated)
            {
                m_data = TransfomImage();
            }
            
            double[,] predicts;
            string[] methodNames;
            try
            {
                if (gradientBoostingRadioButton.Checked)
                {
                    predicts = GradientBoostingPredict();
                    methodNames = new string[1] { "Gradient Boosting" };
                }
                else if (neuralNetworkRadioButton.Checked)
                {
                    predicts = NeuralNetworkPredict();
                    methodNames = new string[1] { "Neural Network" };
                }else if (randomForestRadioButton.Checked)
                {
                    predicts = RandomForestPredict();
                    methodNames = new string[1] { "Random Forest" };
                }
                else
                {
                    predicts = new double[3, 10];
                    methodNames = new string[3] { "Random Forest", "Neural Network", "Gradient Boosting"};
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return;
            }

            isImageUpdated = false;
            
            ShowResults(predicts, methodNames);
        }

        private void ShowResults(double[,] predicts, string[] methodNames)
        {
            int nrows = predicts.GetLength(0);
            int ncols = predicts.GetLength(1);
            for (int i = 0; i < nrows; i++)
            {
                for (int j = 0; j < ncols; j++)
                {
                    labels[i, j].Text += " " + string.Format("{0:0.00}", predicts[i, j]);
                }
                methodBoxes[i].Text = methodNames[i];
            }

            if (methodNames.Length > 1)
            {
                ResetHeight(maxHeight);
            }
            else
            {
                ResetHeight(midHeight);
            }
        }

        private double[,] RandomForestPredict()
        {
            RandomForestClassifier cls = new RandomForestClassifier(m_data);
            double[] predicts = cls.predict();
            double [,] result = new double[1,predicts.Length];
            for(int i = 0; i < predicts.Length; i++){
                result[0, i] = predicts[i];
            }
            return result;
        }

        private double[,] NeuralNetworkPredict()
        {
            NeuralNetworkClassifier cls = new NeuralNetworkClassifier(m_data);
            double[] predicts = cls.predict();
            double[,] result = new double[1, predicts.Length];
            for (int i = 0; i < predicts.Length; i++)
            {
                result[0, i] = predicts[i];
            }
            return result;
        }

        private double[,] GradientBoostingPredict()
        {
            GradientBoostingClassifier cls = new GradientBoostingClassifier(m_data);
            double[] predicts = cls.predict();
            double[,] result = new double[1, predicts.Length];
            for (int i = 0; i < predicts.Length; i++)
            {
                result[0, i] = predicts[i];
            }
            return result;
        }

        private double[,] AllMethodsPredict()
        {

        }

        private bool isMethodChosen()
        {
            return randomForestRadioButton.Checked || neuralNetworkRadioButton.Checked || gradientBoostingRadioButton.Checked || allMethodsRadioMethod.Checked;
        }

        private void ResetLabels(){
            int nrows = labels.GetLength(0);
            int ncols = labels.GetLength(1);
            for (int i = 0; i < nrows; i++)
            {
                for (int j = 0; j < ncols; j++)
                {
                    if (labels[i, j].Text[labels[i, j].Text.Length - 1] != ':')
                    {
                        int lastSpace = labels[i, j].Text.LastIndexOf(' ');
                        labels[i, j].Text = labels[i, j].Text.Substring(0, lastSpace);
                    }
                }
            }
        }

        private void ResetHeight(int newHeight)
        {
            Size oldSize = mainForm.ActiveForm.Size;
            mainForm.ActiveForm.Size = new Size(oldSize.Width, newHeight);
        }

        private int[] TransfomImage(){
            Image image = pictureBox.Image;

            using (ImageFormat imgConverter = new ImageFormat(image))
            {
                image = imgConverter.SetPngFormat();
                using (ImageGrayScale imgGrayScale = new ImageGrayScale(image))
                {
                    image = imgGrayScale.Transform();
                    using (ImageResize imgResize = new ImageResize(image))
                    {
                        image = imgResize.Resize(28, 28);
                        using (ImageToByte imgToByte = new ImageToByte(image))
                        {
                            return imgToByte.Transform();
                        }
                    }
                }
            }            
        }


        private void resetButton_Click(object sender, EventArgs e)
        {
            ResetHeight(minHeight);
            ResetLabels();
            neuralNetworkRadioButton.Checked = false;
            gradientBoostingRadioButton.Checked = false;
            randomForestRadioButton.Checked = false;
            allMethodsRadioMethod.Checked = false;
            isImageChosen = false;
            pictureBox.Image = null;
            ResetLabels();
        }
    }
}
