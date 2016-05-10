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
        private string m_imagePath;
        private string m_resultImagePath = null;
        private Image m_image;

        public ImageFormat(string imagePath, string resultImagePath = null)
        {
            if (File.Exists(imagePath)){
                m_imagePath = String.Copy(imagePath);
                m_image = Image.FromFile(m_imagePath);
            }
            else
            {
                throw new FileNotFoundException(imagePath);
            }

            if (resultImagePath != null)
            {
                m_resultImagePath = String.Copy(resultImagePath);
            }
            else
            {
                string fileName = Path.GetFileNameWithoutExtension(m_imagePath);
                string dirName = Path.GetDirectoryName(m_imagePath);
                m_resultImagePath = dirName + "\\" + "formated-" + fileName;
            }
        }

        public string SetPngFormat(Int32 quality = 100)
        {
            m_resultImagePath += ".png";
            m_image.Save(m_resultImagePath, System.Drawing.Imaging.ImageFormat.Png);
            
            return m_resultImagePath;
        }


			
        public string ImagePath
        {
            get
            {
                return m_imagePath;
            }
        }
        public string ResultImagePath
        {
            get
            {
                return m_resultImagePath;
            }
        }
    }
}
