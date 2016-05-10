using ImageProcessor;
using ImageProcessor.Imaging;
using ImageProcessor.Imaging.Formats;
using ImageProcessor.Imaging.Filters.Photo;
using System;
using System.ComponentModel;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace ImageGrayScaleComponent
{
    public class ImageGrayScale : Component
    {
        private Image m_resultImage;
        private byte[] m_imageBytes;

        public ImageGrayScale(Image image){
            ImageConverter converter = new ImageConverter();
            m_imageBytes = (byte[])converter.ConvertTo(image, typeof(byte[]));
        }
        public Image Transform()
        {
            using (MemoryStream inStream = new MemoryStream(this.m_imageBytes))
            {
                using (MemoryStream outStream = new MemoryStream())
                {
                    using (ImageFactory imageFactory = new ImageFactory(preserveExifData: true))
                    {
                        imageFactory.Load(inStream)
                            .Filter(MatrixFilters.GreyScale)
                            .Save(outStream);
                        m_resultImage = Image.FromStream(outStream);
                        outStream.Close();
                    }
                    inStream.Close();
                }
            }
            return m_resultImage;
        }
    }
}
