using ReadPixelImage.CaptureReadSettings;
using ReadPixelImage.CaptureSettings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadPixelImage.Forms
{
    public partial class HealthChecker : Form
    {

        HealthCheckerDisplay healthCheckDisplay;

        Dictionary<int, CaptureSetting> captureSettingsDict;
        Dictionary<int, ReadedPixelsSetting> readedPixelsSettingsDict;
        Dictionary<string, Bitmap> imagesDict;

        SettingsManager settingsManager;
        CaptureSetting currentCaptureSetting;
        ReadedPixelsSetting currentReadedPixelsSetting;
        ScreenReader screenReader;
        Bitmap loadedImage;
        Bitmap croppedImage;
        public HealthChecker()
        {
            //TODO start create method and behaviour for read pixel
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm() 
        {
            healthCheckDisplay = new HealthCheckerDisplay();
            settingsManager = new SettingsManager();
            screenReader = new ScreenReader();
            ManageLoadedImages();
            ManageCaptureSettings(true);
            ManageReadedPixelSettings(true);
            CheckAndSetCanApplyBtn();

        }

        private void ManageCaptureSettings(bool isInit = false)
        {
            int selIndex = isInit ? 0 : captureSettCb.SelectedIndex;
            settingsManager.LoadCaptureSettings(out captureSettingsDict);
            captureSettCb.Items.Clear();
            foreach (CaptureSetting captSett in captureSettingsDict.Values)
                captureSettCb.Items.Add(captSett);
            captureSettCb.SelectedIndex = selIndex;
            if (selIndex > -1)
                currentCaptureSetting = captureSettingsDict[selIndex];
            else
                captureSettCb.Enabled = false;//TODO manage case

        }

        private void ManageReadedPixelSettings(bool isInit = false)
        {
            int selIndex = isInit ? 0 : readedPixSettCb.SelectedIndex;
            settingsManager.LoadReadedPixelsSettings(out readedPixelsSettingsDict);
            readedPixSettCb.Items.Clear();
            foreach (ReadedPixelsSetting rdPixelSett in readedPixelsSettingsDict.Values)
                readedPixSettCb.Items.Add(rdPixelSett);
            readedPixSettCb.SelectedIndex = selIndex;

            if (selIndex > -1)
                currentReadedPixelsSetting = readedPixelsSettingsDict[selIndex];
            else
                currentReadedPixelsSetting = new ReadedPixelsSetting();
        }
        
        private void ManageSelectedReadedPixelSetting()
        {
            rectanglesLb.Items.Clear();
            foreach (Rectangle rect in currentReadedPixelsSetting.Rectangles)
                rectanglesLb.Items.Add(rect);

            if (rectanglesLb.Items.Count > 0)
            {
                rectanglesLb.SelectedIndex = 0;
                ManageSelectedRectangle();
            }
            
        }

        private void ManageSelectedRectangle()
        {
            Rectangle rect = currentReadedPixelsSetting.Rectangles[rectanglesLb.SelectedIndex];

            Bitmap cropBitmap = new Bitmap(croppedImage);
            readedPixels.Image = cropBitmap.Clone(rect, cropBitmap.PixelFormat);
            readedPixLb.Items.Clear();
            for (int i = 0; i < rect.Width; i++)
            {
                for (int j = 0; j < rect.Height; j++)
                {
                    readedPixLb.Items.Add(((Bitmap)readedPixels.Image).GetPixel(i, j));
                }
            }
            
            healthCheckDisplay.SetAndDrawRectangles(currentReadedPixelsSetting.Rectangles, rectanglesLb.SelectedIndex);
            
        }

        private void ManageLoadedImages()
        {
            settingsManager.LoadImages(out imagesDict);
            imagesCb.Items.Clear();
            foreach (string name in imagesDict.Keys)
                imagesCb.Items.Add(name);
            imagesCb.SelectedIndex = -1;
        }

        private void DisplayImage()
        {
            croppedImage = screenReader.GetParametredCapture(currentCaptureSetting, loadedImage);
            if (captureSettCb.SelectedIndex == 0)//Default
            {
                healthCheckDisplay.MaximumSize = new Size(0, 0);
                healthCheckDisplay.WindowState = FormWindowState.Maximized;// Preset saved where (Width && Height == Screen.Primary.Bounds)
            }
            else
            {
                healthCheckDisplay.WindowState = FormWindowState.Normal;
                healthCheckDisplay.MaximumSize = croppedImage.Size + new Size(16, 39);
                healthCheckDisplay.CaptureImg.Size = croppedImage.Size;
            }

            healthCheckDisplay.CaptureImg.Image = croppedImage;
            healthCheckDisplay.SetAndDrawRectangles(currentReadedPixelsSetting.Rectangles, currentReadedPixelsSetting.Rectangles.Count() > 0 ? 0 : -1);
            healthCheckDisplay.Show();

        }

        private void CheckAndSetCanApplyBtn()
        {
            applyBtn.Enabled = imagesCb.SelectedIndex >= 0 && captureSettCb.SelectedIndex >= 0 && readedPixSettCb.SelectedIndex >= 0;
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            DisplayImage();
            ManageSelectedReadedPixelSetting();
        }

        private void imagesCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loadedImage = imagesDict[imagesCb.SelectedItem.ToString()];
            CheckAndSetCanApplyBtn();
        }

        private void captureSettCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            currentCaptureSetting = captureSettingsDict[(captureSettCb.SelectedItem as CaptureSetting).Id];
            CheckAndSetCanApplyBtn();
        }

        private void readedPixSettCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            currentReadedPixelsSetting = readedPixelsSettingsDict[(readedPixSettCb.SelectedItem as ReadedPixelsSetting).Id];
            CheckAndSetCanApplyBtn();
        }

        private void rectanglesLb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManageSelectedRectangle();
        }
    }
}
