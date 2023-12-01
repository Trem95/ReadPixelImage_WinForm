using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using stdole;
using ReadPixelImage.CaptureSettings;

namespace ReadPixelImage
{
    internal class ScreenReader
    {

        public Bitmap GetParametredCapture(CaptureSetting captureSett, Bitmap img = null)
        {
            //Creating a Rectangle object which will capture the wanted screen or image 
            Rectangle captureRectangle = new Rectangle(captureSett.X, captureSett.Y, captureSett.Width, captureSett.Height);

            if (img == null)
            {
                Bitmap captureBitmap = new Bitmap(captureSett.Width, captureSett.Height);
                Graphics captureGraphics = Graphics.FromImage((Bitmap)captureBitmap);
                captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);

                return captureBitmap;
            }
            else
            {
                Bitmap cropBitmap = new Bitmap(img);
                return cropBitmap.Clone(captureRectangle, cropBitmap.PixelFormat);
            }
        }

        public System.Drawing.Image ResizeImage(System.Drawing.Bitmap imgToResize, Size size)
        {
            // Get the image current width
            int sourceWidth = imgToResize.Width;
            // Get the image current height
            int sourceHeight = imgToResize.Height;
            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;
            // Calculate width and height with new desired size
            nPercentW = ((float)size.Width / (float)sourceWidth);
            nPercentH = ((float)size.Height / (float)sourceHeight);
            nPercent = Math.Min(nPercentW, nPercentH);
            // New Width and Height
            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);
            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((System.Drawing.Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            // Draw image with new width and height
            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();
            return (System.Drawing.Image)b;
        }

        public string GetStringColor(Color color) 
        {
            string colorToString = $"R: {color.R}; G: {color.G}; B: {color.B}";
            return colorToString;
        }

        public void SaveImage(Image imgToSave, string fileLoc = null)
        {
            if (fileLoc == null)
                imgToSave.Save(@"C:\Users\antoi\Pictures\Screenshots\ReadPixelImage\ReadImg" + DateTime.Now.GetHashCode(), ImageFormat.Jpeg);
            else imgToSave.Save(fileLoc + "ReadImg" + DateTime.Now.GetHashCode(), ImageFormat.Jpeg);

        }
    }
}
