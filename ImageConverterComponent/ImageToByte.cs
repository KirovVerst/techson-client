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
            for (int y = 0; y < m_image.Height; y++)
            {
                for (int x = 0; x < m_image.Width; x++)
                {
                    Color pixel = m_image.GetPixel(y,x);
                    result[x*10 + y] = Convert.ToInt32((255-pixel.A)/255.0 *( 255 - pixel.G));
                }
            }
            return result;
        }
    }
}
