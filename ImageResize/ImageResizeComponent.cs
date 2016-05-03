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
    public class ImageResize 
    {
        private string m_imagePath;
        private string m_resultImagePath;
        private FileStream m_resultFile;
        private byte[] m_imageBytes;

        public ImageResize(string imagePath, string resultImagePath = null)
        {
            if (File.Exists(imagePath)){
                m_imagePath = String.Copy(imagePath);
                m_imageBytes = File.ReadAllBytes(m_imagePath);
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
                string fileName = Path.GetFileName(m_imagePath);
                string dirName = Path.GetDirectoryName(m_imagePath);
                m_resultImagePath = dirName + "/" + "resized-" + fileName;
            }
            m_resultFile = File.OpenWrite(m_resultImagePath);
        }

        public string Resize(Int32 width, Int32 height)
        {
            Size size = new Size(width, height);
            using (MemoryStream inStream = new MemoryStream(this.m_imageBytes))
            {
                using (MemoryStream outStream = new MemoryStream())
                {

                    using (ImageFactory imageFactory = new ImageFactory(preserveExifData: true))
                    {
                        imageFactory.Load(inStream).Resize(size).Save(outStream); 
                        outStream.WriteTo(m_resultFile);
                        outStream.Close();
                    }
                    inStream.Close();
                    m_resultFile.Close();
                }
            }
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
