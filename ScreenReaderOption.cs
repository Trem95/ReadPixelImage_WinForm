using System;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

public static class ScreenReaderOption
{
    public static int DefaultHeightScreen =  Screen.PrimaryScreen.Bounds.Height;
    public static int DefaultWidthScreen =  Screen.PrimaryScreen.Bounds.Width;
    public const float DEFAULT_SCREEN_CAPTURE_HEIGHT = 1080;
    public const float DEFAULT_SCREEN_CAPTURE_WIDTH = 1920;//TODO
    public const float MAFIA_II_LIFE_CAPTURE_X = 0;//TODO
    public const float MAFIA_II_LIFE_CAPTURE_Y = 0;//TODO
    public const float MAFIA_II_SCREEN_CAPTURE_HEIGHT = 264;//TODO
    public const float MAFIA_II_SCREEN_CAPTURE_WIDTH = 1080;//TODO
    public static System.Drawing.Image ResizeImage(System.Drawing.Bitmap imgToResize, Size size)
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
}
