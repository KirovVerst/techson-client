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

namespace TechsonClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string path = @"\\Mac\Home\Desktop\kittn.jpg";
            try
            {
                ImageResize imgResize = new ImageResize(path);
                string result = imgResize.Resize(300, 300);
                System.Console.WriteLine(result);
            }
            catch (FileNotFoundException ex)
            {
                System.Console.WriteLine(ex);
            }
        }
    }
}
