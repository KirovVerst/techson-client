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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string path = @"\\Mac\Home\Desktop\grayscaled-formated-kitten.png";
            try
            {
                ImageResize imgResize = new ImageResize(path);
                path = imgResize.Resize(30, 30);
                ImageToByte imgToByte = new ImageToByte(path);
                int[] result = imgToByte.convert();
            }
            catch (FileNotFoundException ex)
            {
                System.Console.WriteLine(ex);
            }
        }
    }
}
