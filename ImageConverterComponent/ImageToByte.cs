using System;
using System.IO;
using System.Drawing;
using System.ComponentModel;
using System.Drawing;

namespace ImageConverterComponent
{
    public class ImageToByte: Component
    {
        private Bitmap m_image;
        public ImageToByte(Image image)
        {
            m_image = new Bitmap(image);
        }

        public int[] Transform()
        {
            int[] result = new int[m_image.Width*m_image.Height];
            for (int y = 0; y < m_image.Height; y++)
            {
                for (int x = 0; x < m_image.Width; x++)
                {
                    Color pixel = m_image.GetPixel(x, y);
                    result[y*10 + x] = Convert.ToInt32(255 - pixel.G);
                }
            }
            return result;
        }
    }
}
