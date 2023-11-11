using ReadPixelImage.CaptureSettings;
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
        Dictionary<string, CaptureSetting> captureSettings = new Dictionary<string, CaptureSetting>();
        Bitmap currentImage;
        CaptureSetting currentSetting = new DefaultCaptureSettings();

        ScreenReader screenReader = new ScreenReader();
        public SettingsCaptureForm()
        {
            InitializeComponent();
            InitializeSettings();
        }
        private void InitializeSettings()
        {
            LoadImages();
            LoadCaptureSettings();
            captureForm = new CaptureForm();
            captureForm.Show();

        }
        private void CaptureBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Console.WriteLine("SCREEN SIZE : " + Screen.PrimaryScreen.Bounds.Width + " / " + Screen.PrimaryScreen.Bounds.Height);
            Thread.Sleep(400);
            currentImage = rbBottom.Checked ? screenReader.GetBottomScreen() : screenReader.GetTopScreen();
            captureForm.CaptureImg.Size = currentImage.Size;
            captureForm.CaptureImg.BackgroundImage = currentImage;
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

        private void LoadCaptureSettings()
        {
            captureSettings.Add("Default", new DefaultCaptureSettings());
            captureSettings.Add("Top Screen", new TopScreenCaptureSettings());
            captureSettings.Add("Down Screen", new DownScreenCaptureSetting());
            captureSettings.Add("Mafia II Setting", new Mafia2HealthCaptureSetting());

            foreach (KeyValuePair<string, CaptureSetting> kvp in captureSettings)
            {
                savedSettingsCb.Items.Add(kvp.Key);
            }

            savedSettingsCb.SelectedIndex = 0;
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

        private void savedSettingsCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (captureSettings.TryGetValue(savedSettingsCb.SelectedItem.ToString(), out currentSetting))
            {
                xCaptureNb.Value = currentSetting.X;
                yCaptureNb.Value = currentSetting.Y;
                widthCaptureNb.Value = currentSetting.Width;
                heightCaptureNb.Value = currentSetting.Height;
            }
        }
    }
}
