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
using ImageResizeComponent;
using ImageFormatComponent;
using ImageGrayScaleComponent;

namespace TechsonClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string path = @"\\Mac\Home\Desktop\formated-kitten.png";
            try
            {
                ImageGrayScale imgFormat = new ImageGrayScale(path);
                string result = imgFormat.transform();
                System.Console.WriteLine(result);
            }
            catch (FileNotFoundException ex)
            {
                System.Console.WriteLine(ex);
            }
        }
    }
}
