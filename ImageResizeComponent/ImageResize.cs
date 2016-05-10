using ImageProcessor;
using ImageProcessor.Imaging;
using ImageProcessor.Imaging.Formats;
using ImageProcessor.Imaging.Filters.Photo;
using System;
using System.IO;
using System.Drawing;
using System.ComponentModel;

namespace ImageResizeComponent
{
    public class ImageResize : Component
    {
        private byte[] m_imageBytes;
        private Image m_resultImage;

        public ImageResize(Image image)
        {
            ImageConverter converter = new ImageConverter();
            m_imageBytes = (byte[])converter.ConvertTo(image, typeof(byte[]));
        }

        public Image Resize(Int32 width, Int32 height)
        {
            Size size = new Size(width, height);
            
            using (MemoryStream inStream = new MemoryStream(this.m_imageBytes))
            {
                using (MemoryStream outStream = new MemoryStream())
                {
                    using (ImageFactory imageFactory = new ImageFactory(preserveExifData: true))
                    {
                        imageFactory.Load(inStream).Resize(size).Save(outStream);
                        m_resultImage = Image.FromStream(outStream);
                    }
                    inStream.Close();
                }
            }
            return m_resultImage;
        }
    }
}