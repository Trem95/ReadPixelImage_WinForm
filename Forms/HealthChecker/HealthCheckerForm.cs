using ReadPixelImage.CaptureReadSettings;
using ReadPixelImage.CaptureSettings;
using ReadPixelImage.Forms.HealthChecker;
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
    public partial class HealthCheckerForm : Form
    {

        HealthCheckerDisplay healthCheckDisplay;
        Display display;

        Dictionary<int, CaptureSetting> captureSettingsDict;
        Dictionary<int, ReadedPixelsSetting> readedPixelsSettingsDict;
        Dictionary<string, Bitmap> imagesDict;
        Dictionary<int, string> statusDict;//TEST will be replace by a Dict.<int,bitmap>
        List<Color> selectRectPixelsColor;

        SettingsManager settingsManager;
        CaptureSetting currentCaptureSetting;
        ReadedPixelsSetting currentReadedPixelsSetting;
        ScreenReader screenReader;
        Bitmap loadedImage;
        Bitmap croppedImage;
        public HealthCheckerForm()
        {
            //TODO Check every RGB of pixel from rectangle, if RGB < 100;100;100 => life gone, set rect empty
            InitializeComponent();
            InitializeForm();
        }

        public MainMenuForm OwnerForm { get; set; }

        private void InitializeForm()
        {
            healthCheckDisplay = new HealthCheckerDisplay();
            display = new Display();
            settingsManager = new SettingsManager();
            screenReader = new ScreenReader();
            selectRectPixelsColor = new List<Color>();
            statusDict = new Dictionary<int, string>()//8
            {
                { 1, "FULL HEALTH" },
                { 2, "80%" },
                { 3, "65%" },
                { 4, "50%" },
                { 5, "45%" },
                { 6, "30%" },
                { 7, "15%" },
                { 8, "DEAD%" },
            };

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
            selectRectPixelsColor.Clear();
            readedPixels.Image = cropBitmap.Clone(rect, cropBitmap.PixelFormat);
            dataGridView1.Rows.Clear();
            for (int i = 0; i < rect.Width; i++)
            {
                for (int j = 0; j < rect.Height; j++)
                {
                    Bitmap pixel = new Bitmap(1, 1);
                    Color pixelColor = ((Bitmap)readedPixels.Image).GetPixel(i, j);
                    selectRectPixelsColor.Add(pixelColor);
                    pixel.SetPixel(0, 0, pixelColor);
                    pixel = (Bitmap)screenReader.ResizeImage(pixel, new Size(200, 20));
                    dataGridView1.Rows.Add(screenReader.GetStringColor(pixelColor), pixel);
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

        private void ManageMafia2HealthDisplay()
        {
            if (currentReadedPixelsSetting.Rectangles.Count() > 0 && selectRectPixelsColor.Count() > 0)
            {
                int r = 0, g = 0, b = 0, cpt = 0;
                foreach (Color color in selectRectPixelsColor)
                {
                    cpt++;
                    r += color.R;
                    g += color.G;
                    b += color.B;
                }

                r = r / cpt;
                g = g / cpt;
                b = b / cpt;

                display.ResultLbl.Text = (r <= 100 && g <= 100 && b <= 100) ? "EMPTY" : "FULL"; 
            }

            display.Show();
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

        private void HealthCheckerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            OwnerForm.Show();
            this.Hide();
        }

        private void displayBtn_Click(object sender, EventArgs e)
        {
            ManageMafia2HealthDisplay();//TODO CONTINUE, automate process, add more rectangle in mafia 2 health settings for more precision
        }
    }
}
