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
            Image imgToShow = rbBottom.Checked ? screenReader.GetBottomScreen() : screenReader.GetTopScreen();
            captureForm.CaptureImg.BackgroundImage= imgToShow;
            this.Show();

        }

        private void DrawRectangle(PaintEventArgs e, float x = 10, float y = 10, float width = 4, float height = 4)
        {
            Pen pen = new Pen(Color.LimeGreen, 2);
            e.Graphics.DrawRectangle(pen, x, y, width, height);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            DrawRectangle(e);//Test to see what pixel to read
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
                    imageChooseCb.Items.Add(imgName);
                }
            }
        }

        public Bitmap GetTopLoadedImage(Bitmap bitmapToCrop)
        {
            Bitmap cropBitmap = new Bitmap(bitmapToCrop);
            Rectangle cropRectangle = new Rectangle(0, 0, cropBitmap.Width, 216);//TODO Crop top and bottom of loaded image

            return cropBitmap.Clone(cropRectangle, cropBitmap.PixelFormat);
        }

        public Bitmap GetBottomLoadedImage(Bitmap bitmapToCrop)
        {
            Bitmap cropBitmap = new Bitmap(bitmapToCrop);
            Rectangle cropRectangle = new Rectangle(0, 864, cropBitmap.Width, 216);//TODO Crop top and bottom of loaded image

            return cropBitmap.Clone(cropRectangle, cropBitmap.PixelFormat);
        }

        private void imageChooseCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Bitmap imgToShow = null;
            if (imageDict.TryGetValue(imageChooseCb.SelectedItem.ToString(), out imgToShow))
            {
                Bitmap cropImgToShow = rbBottom.Checked ? GetBottomLoadedImage(imgToShow) : GetTopLoadedImage(imgToShow);
                captureForm.CaptureImg.Size = cropImgToShow.Size;
                captureForm.CaptureImg.BackgroundImage = cropImgToShow;
            }

        }
    }
}
