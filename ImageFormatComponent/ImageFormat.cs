using ImageProcessor;
using ImageProcessor.Imaging;
using ImageProcessor.Imaging.Formats;
using ImageProcessor.Imaging.Filters.Photo;
using System;
using System.IO;
using System.Drawing;
using System.ComponentModel;


namespace ImageFormatComponent
{
    public class ImageFormat : Component
    {
        private Image m_resultImage;
        private Image m_image;

        public ImageFormat(Image image)
        {
            m_image = image;
        }

        public Image SetPngFormat(Int32 quality = 100)
        {
            MemoryStream stream = new MemoryStream();
            m_image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
            m_resultImage = Image.FromStream(stream);
            return m_resultImage;
        }
    }
}
