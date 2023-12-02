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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadPixelImage.Forms
{
    public partial class HealthCheckerForm : Form
    {

        HealthCheckerDisplay healthCheckDisplay;
        Display display;
        Thread healthCheckerThread;

        Dictionary<int, CaptureSetting> captureSettingsDict;
        Dictionary<int, ReadedPixelsSetting> readedPixelsSettingsDict;
        Dictionary<string, Bitmap> imagesDict;
        Dictionary<int, string> statusDict;//TEST will be replace by a Dict.<int,bitmap>
        Dictionary<int, Color[]> pixelColorsRectangle;

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
            pixelColorsRectangle = new Dictionary<int, Color[]>();
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
            //TODO find solution to make thread inclusive writing easy ( like SDT)
            if (rectanglesLb.InvokeRequired)
            {
                rectanglesLb.Invoke((MethodInvoker)delegate
                {
                    rectanglesLb.Items.Clear();
                    foreach (Rectangle rect in currentReadedPixelsSetting.Rectangles)
                        rectanglesLb.Items.Add(rect);

                    CheckCurrentSettingsRectangles();
                    if (rectanglesLb.Items.Count > 0)
                    {
                        rectanglesLb.SelectedIndex = 0;
                        DisplayRectangleColors(0);
                    }
                });
            }
            else
            {

                rectanglesLb.Items.Clear();
                foreach (Rectangle rect in currentReadedPixelsSetting.Rectangles)
                    rectanglesLb.Items.Add(rect);

                CheckCurrentSettingsRectangles();
                if (rectanglesLb.Items.Count > 0)
                {
                    rectanglesLb.SelectedIndex = 0;
                    DisplayRectangleColors(0);
                }
            }

        }

        private void CheckCurrentSettingsRectangles()
        {
            pixelColorsRectangle.Clear();
            foreach (Rectangle rect in currentReadedPixelsSetting.Rectangles)
                CheckRectangle(currentReadedPixelsSetting.Rectangles.IndexOf(rect));
        }

        private void CheckRectangle(int index)
        {
            Bitmap cropBitmap = new Bitmap(croppedImage);
            Rectangle rect = currentReadedPixelsSetting.Rectangles[index];
            readedPixels.Image = cropBitmap.Clone(rect, cropBitmap.PixelFormat);
            Color[] colors = new Color[rect.Width * rect.Height];
            int cpt = 0;
            for (int i = 0; i < rect.Width; i++)
            {
                for (int j = 0; j < rect.Height; j++)
                {
                    Bitmap pixel = new Bitmap(1, 1);
                    Color pixelColor = ((Bitmap)readedPixels.Image).GetPixel(i, j);
                    pixel.SetPixel(0, 0, pixelColor);
                    pixel = (Bitmap)screenReader.ResizeImage(pixel, new Size(200, 20));
                    colors[cpt] = pixelColor;
                    cpt++;
                }
            }

            if (pixelColorsRectangle.ContainsKey(index))
                pixelColorsRectangle[index] = colors;
            else
                pixelColorsRectangle.Add(index, colors);

            healthCheckDisplay.SetAndDrawRectangles(currentReadedPixelsSetting.Rectangles, rectanglesLb.SelectedIndex);

        }

        private void DisplayRectangleColors(int rectIndex)
        {
            dataGridView1.Rows.Clear();
            foreach (Color color in pixelColorsRectangle[rectIndex])
            {
                Bitmap pixel = new Bitmap(1, 1);
                pixel.SetPixel(0, 0, color);
                pixel = (Bitmap)screenReader.ResizeImage(pixel, new Size(200, 20));
                dataGridView1.Rows.Add(screenReader.GetStringColor(color), pixel);
            }
        }

        private void ManageLoadedImages()
        {
            settingsManager.LoadImages(out imagesDict);
            imagesCb.Items.Clear();
            imagesCb.Items.Add("Screen Capture");
            foreach (string name in imagesDict.Keys)
                imagesCb.Items.Add(name);
            imagesCb.SelectedIndex = -1;
        }

        private void ManageMafia2HealthDisplay()
        {
            //TODO check if, even if make morte time, if it more effiscient to do from 90% to 100% 
            //Check if it can fix issues when shop or quest icon appear in health bar
            if (display.InvokeRequired)
                display.BeginInvoke((MethodInvoker)delegate { display.Show(); });
            else
                display.Show();

            List<Rectangle> rectangles = currentReadedPixelsSetting.Rectangles;
            int rectCount = rectangles.Count - 1;
            //STEP 1 Check First, middle and last rectangle value (empty / full)


            List<bool> truthTable = new List<bool>();//TEST 
            for (int i = 0; i < rectangles.Count; i++)
            {
                truthTable.Add(CheckIsRectangleEmpty(i));
            }

            string textToShow = "NOT SET";
            //"RECT INDEX : " + i
            if (!CheckIsRectangleEmpty(0))
                textToShow = "FULL HEALTH";
            else
            {
                for (int i = 1;i < rectangles.Count ;i++)
                {
                    if (!CheckIsRectangleEmpty(i))
                    {
                        textToShow = $"{(100/rectCount) * ( rectCount - (i-1))}%";
                        break;

                    };
                }
            }

                if (display.ResultLbl.InvokeRequired)
                    display.ResultLbl.BeginInvoke((MethodInvoker)delegate { display.ResultLbl.Text = textToShow; });
                else
                    display.ResultLbl.Text = textToShow;
            #region ManageMafia2HealthDisplay V1 


            ////Check first rectangle 
            //if (!CheckIsRectangleEmpty(0))
            //{
            //    Console.WriteLine("FULL HEALTH");
            //    display.ResultLbl.BeginInvoke((MethodInvoker)delegate { display.ResultLbl.Text = "FULL HEALTH"; });//Full rectangle not empty, full live

            //}
            //else
            //{

            //    if (CheckIsRectangleEmpty(rectCount / 2))//Health is below half
            //    {
            //        if (CheckIsRectangleEmpty((rectCount / 2) + (rectCount / 4)))//Health is between 25 and 0%
            //        {
            //            for (int i = (rectCount / 2) + (rectCount / 4); i <= rectCount; i++)
            //            {
            //                if (!CheckIsRectangleEmpty(i))
            //                {
            //                    Console.WriteLine("RECT INDEX : " + i);
            //                    if (display.ResultLbl.InvokeRequired)
            //                        display.ResultLbl.BeginInvoke((MethodInvoker)delegate { display.ResultLbl.Text = "RECT INDEX : " + i; });
            //                    else
            //                        display.ResultLbl.Text = "RECT INDEX : " + i;
            //                    break;
            //                }
            //            }
            //        }
            //        else//Health is between 25 and 50%
            //        {
            //            for (int i = rectCount / 2; i < (rectCount / 2) + (rectCount / 4); i++)
            //            {
            //                if (!CheckIsRectangleEmpty(i))
            //                {
            //                    Console.WriteLine("RECT INDEX : " + i);
            //                    if (display.ResultLbl.InvokeRequired)
            //                        display.ResultLbl.BeginInvoke((MethodInvoker)delegate { display.ResultLbl.Text = "RECT INDEX : " + i; });
            //                    else
            //                        display.ResultLbl.Text = "RECT INDEX : " + i;
            //                    break;
            //                }
            //            }
            //        }
            //    }
            //    else//Health is above half
            //    {
            //        if (CheckIsRectangleEmpty((rectCount / 2) / 2))//Health is between 75 and 50%
            //        {
            //            for (int i = (rectCount / 2) / 2; i <= rectCount / 2; i++)
            //                if (!CheckIsRectangleEmpty(i))
            //                {
            //                    Console.WriteLine("RECT INDEX : " + i);
            //                    if (display.ResultLbl.InvokeRequired)
            //                        display.ResultLbl.BeginInvoke((MethodInvoker)delegate { display.ResultLbl.Text = "RECT INDEX : " + i; });
            //                    else
            //                        display.ResultLbl.Text = "RECT INDEX : " + i;
            //                    break;
            //                }
            //        }
            //        else//Health is between 75 and 100%
            //        {
            //            for (int i = 0; i < (rectCount / 2) / 2; i++)
            //                if (!CheckIsRectangleEmpty(i))
            //                {
            //                    Console.WriteLine("RECT INDEX : " + i);
            //                    if (display.ResultLbl.InvokeRequired)
            //                        display.ResultLbl.BeginInvoke((MethodInvoker)delegate { display.ResultLbl.Text = "RECT INDEX : " + i; });
            //                    else
            //                        display.ResultLbl.Text = "RECT INDEX : " + i;
            //                    break;
            //                }
            //        }
            //    }
            //}

            #endregion

            if (display.ResultLbl.InvokeRequired)
                display.ResultLbl.BeginInvoke((MethodInvoker)delegate { display.Refresh(); });
            else
                display.Refresh();
        }

        private bool CheckIsRectangleEmpty(int rectIndex)
        {
            int r = 0, g = 0, b = 0, cpt = 0;
            foreach (Color color in pixelColorsRectangle[rectIndex])
            {
                cpt++;
                r += color.R;
                g += color.G;
                b += color.B;
            }

            r = r / cpt;
            g = g / cpt;
            b = b / cpt;

            return (r <= 100 && g <= 100 && b <= 100);
        }

        private void DisplayResultFromImageThread()
        {
            try
            {
                while (threadIsStarted)
                {
                    ManageMafia2HealthDisplay();
                    Thread.Sleep(500);
                }
            }
            catch (ThreadAbortException)
            {
            }
        }

        private void DisplayResultFromCaptureThread()
        {
            try
            {
                while (threadIsStarted)
                {
                    DisplayImage();
                    ManageSelectedReadedPixelSetting();
                    ManageMafia2HealthDisplay();
                    Thread.Sleep(500);
                }
            }
            catch (ThreadAbortException)
            {
            }
        }

        private void DisplayImage()
        {
            if (loadedImage != null)
                croppedImage = screenReader.GetParametredCapture(currentCaptureSetting, loadedImage);
            else
                croppedImage = screenReader.GetParametredCapture(currentCaptureSetting);

            //if (captureSettCb.SelectedIndex == 0)//Default
            //{
            //    healthCheckDisplay.MaximumSize = new Size(0, 0);
            //    healthCheckDisplay.WindowState = FormWindowState.Maximized;// Preset saved where (Width && Height == Screen.Primary.Bounds)
            //}
            //else
            //{

            //}

            if (healthCheckDisplay.InvokeRequired)
            {
                healthCheckDisplay.Invoke((MethodInvoker)delegate
                {
                    healthCheckDisplay.WindowState = FormWindowState.Normal;
                    healthCheckDisplay.MaximumSize = croppedImage.Size + new Size(16, 39);
                    healthCheckDisplay.CaptureImg.Size = croppedImage.Size;
                    healthCheckDisplay.CaptureImg.Image = croppedImage;
                    healthCheckDisplay.SetAndDrawRectangles(currentReadedPixelsSetting.Rectangles, currentReadedPixelsSetting.Rectangles.Count() > 0 ? 0 : -1);
                    healthCheckDisplay.Show();
                });
            }
            else
            {
                healthCheckDisplay.WindowState = FormWindowState.Normal;
                healthCheckDisplay.MaximumSize = croppedImage.Size + new Size(16, 39);
                healthCheckDisplay.CaptureImg.Size = croppedImage.Size;
                healthCheckDisplay.CaptureImg.Image = croppedImage;
                healthCheckDisplay.SetAndDrawRectangles(currentReadedPixelsSetting.Rectangles, currentReadedPixelsSetting.Rectangles.Count() > 0 ? 0 : -1);
                healthCheckDisplay.Show();
            }


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
            if (imagesCb.SelectedIndex > 0)
                loadedImage = imagesDict[imagesCb.SelectedItem.ToString()];
            else
                loadedImage = null;
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
            DisplayRectangleColors(rectanglesLb.SelectedIndex);
            healthCheckDisplay.SetAndDrawRectangles(currentReadedPixelsSetting.Rectangles, rectanglesLb.SelectedIndex);
        }

        private void HealthCheckerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            display.Hide();
            healthCheckDisplay.Hide();
            OwnerForm.Show();
            this.Hide();
        }

        bool threadIsStarted = false;
        private void displayBtn_Click(object sender, EventArgs e)
        {
            if (!threadIsStarted)
            {
                display.Show();
                threadIsStarted = true;
                healthCheckerThread = new Thread(new ThreadStart(DisplayResultFromImageThread));
                healthCheckerThread.Start();
            }
            else
            {
                healthCheckerThread.Abort();
                this.Enabled = false;
                while (healthCheckerThread.IsAlive)
                {
                    Thread.Sleep(500);
                }
                this.Enabled = true;
                display.Show();
                threadIsStarted = true;
                healthCheckerThread = new Thread(new ThreadStart(DisplayResultFromImageThread));
                healthCheckerThread.Start();
            }
        }

        private void displayCurrCaptureBtn_Click(object sender, EventArgs e)
        {
            if (!threadIsStarted)
            {
                display.Show();
                threadIsStarted = true;
                healthCheckerThread = new Thread(new ThreadStart(DisplayResultFromCaptureThread));
                healthCheckerThread.Start();
            }
            else
            {
                healthCheckerThread.Abort();
                this.Enabled = false;
                while (healthCheckerThread.IsAlive)
                {
                    Thread.Sleep(500);
                }
                this.Enabled = true;
                display.Show();
                threadIsStarted = true;
                healthCheckerThread = new Thread(new ThreadStart(DisplayResultFromCaptureThread));
                healthCheckerThread.Start();
            }
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            if (threadIsStarted)
            {
                display.Hide();
                healthCheckerThread.Abort();
                this.Enabled = false;
                while (healthCheckerThread.IsAlive)
                {
                    Thread.Sleep(500);
                }
                this.Enabled = true;
                threadIsStarted = false;
            }
        }
    }
}
