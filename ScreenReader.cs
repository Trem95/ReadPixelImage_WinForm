using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ReadPixelImage
{
    internal class ScreenReader
    {
        public Image GetTopScreen()
        {
            //Creating a new Bitmap object
            Bitmap captureBitmap = new Bitmap(1920, 1080);
            //Bitmap captureBitmap = new Bitmap(int width, int height, PixelFormat);

            //Creating a Rectangle object which will
            //capture our Current Screen
            Rectangle captureRectangle = new Rectangle(0,0, captureBitmap.Width, captureBitmap.Height);
            //Creating a New Graphics Object
            Graphics captureGraphics = Graphics.FromImage(captureBitmap);

            //Copying Image from The Screen
            captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);

            //Saving the Image File (I am here Saving it in My E drive).
            //captureBitmap.Save(@"E:\Capture.jpg", ImageFormat.Jpeg);

            return captureBitmap;
        }

    }
}
