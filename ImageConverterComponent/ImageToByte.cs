using System;
using System.IO;
using System.Drawing;
using System.ComponentModel;
using System.Drawing;

namespace ImageConverterComponent
{
    public class ImageToByte
    {
        private string m_imagePath;
        private string m_resultImagePath = null;
        private Bitmap m_image;
        public ImageToByte(string imagePath)
        {
            if (File.Exists(imagePath)){
                m_imagePath = String.Copy(imagePath);
                m_image = new Bitmap(m_imagePath);

                string fileName = Path.GetFileNameWithoutExtension(m_imagePath);
                string dirName = Path.GetDirectoryName(m_imagePath);
                m_resultImagePath = dirName + "\\" + "bmp-" + fileName + ".bmp";
            }
            else
            {
                throw new FileNotFoundException(imagePath);
            }
        }

        public int[] convert()
        {
            m_image.Save(m_resultImagePath, System.Drawing.Imaging.ImageFormat.Bmp);
            int[] result = new int[m_image.Width*m_image.Height];
            for (int i = 0; i < m_image.Width; i++)
            {
                for (int j = 0; j < m_image.Height; j++)
                {
                    Color pixel = m_image.GetPixel(i,j);
                    result[i*10 + j] = 255 - pixel.R;
                }
            }
            return result;
        }
    }
}
