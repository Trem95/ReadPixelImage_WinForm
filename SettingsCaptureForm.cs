using stdole;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadPixelImage
{
    public partial class SettingsCaptureForm : Form
    {
        CaptureForm captureForm;
        Dictionary<string, Bitmap> imageDict = new Dictionary<string, Bitmap>();
        Bitmap currentImage;


        ScreenReader screenReader = new ScreenReader();
        public SettingsCaptureForm()
        {
            captureForm = new CaptureForm();
            captureForm.Show();
            InitializeComponent();
            LoadImages();
        }

        private void CaptureBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Console.WriteLine("SCREEN SIZE : " + Screen.PrimaryScreen.Bounds.Width + " / " + Screen.PrimaryScreen.Bounds.Height);
            Thread.Sleep(400);
            currentImage = rbBottom.Checked ? screenReader.GetBottomScreen() : screenReader.GetTopScreen();
            captureForm.CaptureImg.Size = currentImage.Size;
            captureForm.CaptureImg.BackgroundImage= currentImage;
            this.Show();

        }


        private void LoadImages()
        {
            string path = @"C:\Users\antoi\Pictures\Screenshots\ReadPixelImage\ImageToRead";
            foreach (var item in Directory.EnumerateFiles(path))
            {
                if (item.ToString().Contains(".png"))//TODO find better solution even if only for test
                {
                    Bitmap imgToAdd = new Bitmap(item.ToString());
                    string imgName = item.Substring(path.Length + 1);
                    imageDict.Add(imgName, imgToAdd);
                    loadedImgCb.Items.Add(imgName);
                }
            }
        }

        public Bitmap GetTopLoadedImage(Bitmap bitmapToCrop)
        {
            Bitmap cropBitmap = new Bitmap(bitmapToCrop);
            Rectangle cropRectangle = new Rectangle(0, 0, cropBitmap.Width, 216);

            return cropBitmap.Clone(cropRectangle, cropBitmap.PixelFormat);
        }

        public Bitmap GetBottomLoadedImage(Bitmap bitmapToCrop)
        {
            Bitmap cropBitmap = new Bitmap(bitmapToCrop);
            Rectangle cropRectangle = new Rectangle(0, 864, cropBitmap.Width, 216);

            return cropBitmap.Clone(cropRectangle, cropBitmap.PixelFormat);
        }

        private void imageChooseCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (imageDict.TryGetValue(loadedImgCb.SelectedItem.ToString(), out currentImage))
            {
                Bitmap cropImgToShow = rbBottom.Checked ? GetBottomLoadedImage(currentImage) : GetTopLoadedImage(currentImage);
                captureForm.CaptureImg.Size = cropImgToShow.Size;
                captureForm.CaptureImg.BackgroundImage = cropImgToShow;
            }

        }
    }
}
