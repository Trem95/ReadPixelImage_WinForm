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

        #region Variables
        CaptureForm captureForm;
        Dictionary<string, Bitmap> imageDict;
        Dictionary<int, CaptureSetting> captureSettings;
        List<Rectangle> pixelsReadedRectangles;
        Bitmap currentImage;
        CaptureSetting currentSetting;
        
        int persSettingsCdw = 1;
        int newId;

        ScreenReader screenReader = new ScreenReader();

        #endregion

        #region Constructor

        public SettingsCaptureForm()
        {
            InitializeComponent();
            InitializeSettings();
        }
        private void InitializeSettings()
        {
            imageDict = new Dictionary<string, Bitmap>();
            captureSettings = new Dictionary<int, CaptureSetting>();
            pixelsReadedRectangles = new List<Rectangle>();
            currentSetting = new CaptureSetting();

            LoadImages();
            LoadCaptureSettings();
            captureForm = new CaptureForm();
            captureForm.Show();

        }
        #endregion

        #region Properties

        public int XCoordCapture { get { return (int)xCaptureNb.Value; } }
        public int YCoordCapture { get { return (int)yCaptureNb.Value; } }
        public int HeightCoordCapture { get { return (int)heightCaptureNb.Value; } }
        public int WidthCoordCapture { get { return (int)widthCaptureNb.Value; } }

        #endregion

        #region Methods
        private void LoadImages()
        {
            string path = @"C:\Users\antoi\Pictures\Screenshots\ReadPixelImage\ImageToRead";
            foreach (var item in Directory.EnumerateFiles(path))
            {
                if (item.ToString().Contains(".png"))
                {
                    Bitmap imgToAdd = new Bitmap(item.ToString());
                    string imgName = item.Substring(path.Length + 1);
                    imageDict.Add(imgName, imgToAdd);
                    loadedImgCb.Items.Add(imgName);
                }
            }
        }

        private void DisplayCapture()
        {
            Bitmap cropImgToShow = screenReader.GetParametredCapture(currentSetting, currentImage);
            captureForm.CaptureImg.Size = cropImgToShow.Size;
            captureForm.CaptureImg.BackgroundImage = cropImgToShow;
        }

        private void LoadCaptureSettings()//TODO Create CSV (or other) file to load parameterized settings
        {
            captureSettings.Add(
                1,
                new CaptureSetting(0, "Default",
                    0,
                    0,
                    Screen.PrimaryScreen.Bounds.Width,
                    Screen.PrimaryScreen.Bounds.Height));

            captureSettings.Add(
                2,
                new CaptureSetting(1, "Top Screen",
                    0,
                    0,
                    Screen.PrimaryScreen.Bounds.Width,
                    Screen.PrimaryScreen.Bounds.Height / 4));

            captureSettings.Add(
                3,
                new CaptureSetting(2, "Bottom Screen",
                    0,
                    Screen.PrimaryScreen.Bounds.Height - (Screen.PrimaryScreen.Bounds.Height / 4),
                    Screen.PrimaryScreen.Bounds.Width,
                    Screen.PrimaryScreen.Bounds.Height / 4));

            captureSettings.Add(
                4,
                new CaptureSetting(3,"Mafia II Health",
                    Screen.PrimaryScreen.Bounds.Width - (Screen.PrimaryScreen.Bounds.Width / 4),
                    Screen.PrimaryScreen.Bounds.Height - (Screen.PrimaryScreen.Bounds.Height / 3),
                    Screen.PrimaryScreen.Bounds.Width / 4,
                    Screen.PrimaryScreen.Bounds.Height / 3));

            newId = captureSettings.Last().Value.Id ++;

            foreach (KeyValuePair<int, CaptureSetting> kvp in captureSettings)
            {
                savedSettingsCb.Items.Add(kvp.Value);
            }

            savedSettingsCb.SelectedIndex = 0;
        }

        #endregion
        #region Event Handler


        private void imageChooseCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (imageDict.TryGetValue(loadedImgCb.SelectedItem.ToString(), out currentImage))
            {
                DisplayCapture();
            }

        }

        private void savedSettingsCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (captureSettings.TryGetValue( (savedSettingsCb.SelectedItem as CaptureSetting).Id, out currentSetting))
            {
                xCaptureNb.Value = currentSetting.X;
                yCaptureNb.Value = currentSetting.Y;
                widthCaptureNb.Value = currentSetting.Width;
                heightCaptureNb.Value = currentSetting.Height;

                DisplayCapture();
            }
        }

        private void applySettingsBtn_Click(object sender, EventArgs e)
        {
            if (XCoordCapture > 0 && YCoordCapture > 0
                && WidthCoordCapture > 0 && HeightCoordCapture > 0)
            {
                captureSettings.Add(newId, new CaptureSetting( newId, "Personnalized" + persSettingsCdw, XCoordCapture, YCoordCapture, WidthCoordCapture, HeightCoordCapture));
                savedSettingsCb.Items.Add("Personnalized " + persSettingsCdw);
                savedSettingsCb.SelectedItem = "Personnalized " + persSettingsCdw;
                persSettingsCdw++;
                newId++;

                DisplayCapture();
            }
        }

        private void CaptureBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Console.WriteLine("SCREEN SIZE : " + Screen.PrimaryScreen.Bounds.Width + " / " + Screen.PrimaryScreen.Bounds.Height);
            Thread.Sleep(400);
            currentImage = screenReader.GetParametredCapture(currentSetting);
            captureForm.CaptureImg.Size = currentImage.Size;
            captureForm.CaptureImg.BackgroundImage = currentImage;
            this.Show();

        }
        #endregion
       
        List<Rectangle> _rectangles = new List<Rectangle>();//ATR TEST
        private void drawButton_Click(object sender, EventArgs e)
        {
            //ATR TEST TODO maange rectangle settings
            Rectangle rectangle = new Rectangle((int)xPixelsNb.Value, (int)yPixelsNb.Value,(int)widthPixelsNb.Value, (int)heightCaptureNb.Value);
            _rectangles.Add(rectangle);
            captureForm.SetAndDrawRectangles(_rectangles);
        }
    }
}
