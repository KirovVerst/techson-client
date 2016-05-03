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

namespace TechsonClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string path = @"\\Mac\Home\Desktop\kitten.jpg";
            try
            {
                ImageFormat imgFormat = new ImageFormat(path);
                string result = imgFormat.SetPngFormat();
                System.Console.WriteLine(result);
            }
            catch (FileNotFoundException ex)
            {
                System.Console.WriteLine(ex);
            }
        }
    }
}
