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
        public Bitmap GetTopScreen()
        {
            //Creating a new Bitmap object
            //Bitmap captureBitmap = new Bitmap(1920, 1080);//Capture full screen
            Bitmap captureBitmap = new Bitmap(1920, 216);//Capture full screen
            //Bitmap captureBitmap = new Bitmap(int width, int height, PixelFormat);

            //Creating a Rectangle object which will
            //capture our Current Screen
            Rectangle captureRectangle = new Rectangle(0, 0, captureBitmap.Width, captureBitmap.Height);
            //Creating a New Graphics Object
            Graphics captureGraphics = Graphics.FromImage(captureBitmap);

            //Copying Image from The Screen
            captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);

            //Saving the Image File (I am here Saving it in My E drive).
            //captureBitmap.Save(@"E:\Capture.jpg", ImageFormat.Jpeg);

            return captureBitmap;
        }

        public Bitmap GetBottomScreen()
        {
            Bitmap captureBitmap = new Bitmap(1920, 216);//

            Rectangle captureRectangle = new Rectangle(0, 864, captureBitmap.Width, captureBitmap.Height);
            //Creating a New Graphics Object
            Graphics captureGraphics = Graphics.FromImage(captureBitmap);

            //Copying Image from The Screen
            captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);

            return captureBitmap;
        }

        public Bitmap GetParametredCapture(CaptureSetting captureSett, Bitmap img = null)
        {
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

        public void SaveImage(Image imgToSave, string fileLoc = null)
        {
            if (fileLoc == null)
                imgToSave.Save(@"C:\Users\antoi\Pictures\Screenshots\ReadPixelImage\ReadImg" + DateTime.Now.GetHashCode(), ImageFormat.Jpeg);
            else imgToSave.Save(fileLoc + "ReadImg" + DateTime.Now.GetHashCode(), ImageFormat.Jpeg);

        }
    }
}
