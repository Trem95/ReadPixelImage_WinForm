using ReadPixelImage.CaptureReadSettings;
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
using ExcelLibrary;
using ExcelLibrary.SpreadSheet;

namespace ReadPixelImage
{
    public partial class SettingsCaptureForm : Form
    {

        #region Variables
        CaptureForm captureForm;

        ScreenReader screenReader = new ScreenReader();
        Bitmap currentImage;
        CaptureSetting currentCaptureSetting;
        ReadedPixelsSettings currentReadedPixelsSettings;

        Dictionary<string, Bitmap> imageDict;
        Dictionary<int, CaptureSetting> captureSettings;
        Dictionary<int, ReadedPixelsSettings> readedPixSettings;

        int persCaptSettingsCdw = 1;
        int persPixelsSettingsCdw = 1;
        int newCaptureSettingsId;
        int newPixReadedSettingsId;

        Workbook captureSettingsWorkbooks;
        Workbook pixelsSettingsWorkbook;

        string publicDocPath;
        string settingsDocPath;
        string imagesDocPath;
        string captureSettingsDocPath;
        string readedPixelsSettingsDocPath;
        const string CAPTURE_SETTINGS_FILENAME = "CaptureSettings.xlsx";
        const string RPIXELS_SETTINGS_FILENAME = "ReadedPixelsSettings.xlsx" ;

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
            readedPixSettings = new Dictionary<int, ReadedPixelsSettings>();
            currentCaptureSetting = new CaptureSetting();

            publicDocPath = Environment.ExpandEnvironmentVariables(@"%PUBLIC%\Documents");
            settingsDocPath = publicDocPath + @"\ReadPixelImage\Settings";
            imagesDocPath = publicDocPath + @"\ReadPixelImage\Images";
            captureSettingsDocPath = settingsDocPath + @"\Capture";
            readedPixelsSettingsDocPath = settingsDocPath + @"\Pixels";

            CreateAndLoadSettingsDirectory();
            LoadImages();
            LoadCaptureSettings();
            LoadReadedPixelsSetings();
            captureForm = new CaptureForm();
            captureForm.Show();

        }
        #endregion

        #region Properties

        public int XCoordCapture { get { return (int)xCaptureNb.Value; } }
        public int YCoordCapture { get { return (int)yCaptureNb.Value; } }
        public int HeightCoordCapture { get { return (int)heightCaptureNb.Value; } }
        public int WidthCoordCapture { get { return (int)widthCaptureNb.Value; } }

        public int XCoordPixelsReaded { get { return (int)xPixelsNb.Value; } }
        public int YCoordPixelsReaded { get { return (int)yPixelsNb.Value; } }
        public int HeightCoordPixelsReaded { get { return (int)heightPixelsNb.Value; } }
        public int WidthCoordPixelsReaded { get { return (int)widthPixelsNb.Value; } }

        #endregion

        #region Methods
        private void CreateAndLoadSettingsDirectory()
        {
            string[] files = { "" };
            files = Directory.GetDirectories(publicDocPath, "ReadPixelImage");

            if (files == null || files.Count() == 0
                || !files.Contains(publicDocPath + "\\ReadPixelImage"))
            {
                Directory.CreateDirectory(publicDocPath + "\\ReadPixelImage");
                Directory.CreateDirectory(settingsDocPath);
                Directory.CreateDirectory(captureSettingsDocPath);
                Directory.CreateDirectory(readedPixelsSettingsDocPath);
                Directory.CreateDirectory(imagesDocPath);
                Directory.CreateDirectory(imagesDocPath + "\\Loaded");
                Directory.CreateDirectory(imagesDocPath + "\\Saved");
                Directory.CreateDirectory(imagesDocPath + "\\Capture");

            }

            files = Directory.GetFiles(readedPixelsSettingsDocPath, "Settings", SearchOption.AllDirectories);

            Workbook readedPixselSettWBook = new Workbook();
            Workbook captureSettWBook = new Workbook();
            DataSet ds = new DataSet();
            ds.Tables.Add("Default Settings");

            if(files.Count() == 0 || !files.Contains("ReadedPixelsSettings") || !files.Contains("CaptureSettings"))
            {
                DataSetHelper.CreateWorkbook(captureSettingsDocPath + "\\CaptureSettings.xls", ds );
                DataSetHelper.CreateWorkbook(readedPixelsSettingsDocPath + "\\ReadedPixelsSettings.xls", ds);
                    
            }

        }
        private void CreateOrLoadExcelFiles()
        {

        }

        private void ReadSettingsExcelFiles()
        {
            Workbook settingsWorkbook = new Workbook();
            Workbook.Load("");
            //settingsWorkbook.
        }

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
            Bitmap cropImgToShow = screenReader.GetParametredCapture(currentCaptureSetting, currentImage);
            captureForm.CaptureImg.Size = cropImgToShow.Size;
            captureForm.CaptureImg.BackgroundImage = cropImgToShow;

            yPixelsNb.Maximum = captureForm.CaptureImg.Size.Height;
            xPixelsNb.Maximum = captureForm.CaptureImg.Size.Width;
            heightPixelsNb.Maximum = captureForm.CaptureImg.Size.Height;
            widthPixelsNb.Maximum = captureForm.CaptureImg.Size.Width;

            if (savedCaptureSettingsCb.SelectedIndex == 1) captureForm.WindowState = FormWindowState.Maximized;// Preset saved where (Width && Height == Screen.Primary.Bounds)
            else captureForm.WindowState = FormWindowState.Normal;

            this.WindowState = FormWindowState.Normal;
        }

        private void LoadCaptureSettings()//TODO Create CSV (or other) file to load parameterized settings
        {
            yCaptureNb.Maximum = Screen.PrimaryScreen.Bounds.Height;
            xCaptureNb.Maximum = Screen.PrimaryScreen.Bounds.Width;
            heightCaptureNb.Maximum = Screen.PrimaryScreen.Bounds.Height;
            widthCaptureNb.Maximum = Screen.PrimaryScreen.Bounds.Width;

            captureSettings.Add(
                0,
                new CaptureSetting(0, "Create Settings",
                    0,
                    0,
                    0,
                    0));

            captureSettings.Add(
                1,
                new CaptureSetting(1, "Default",
                    0,
                    0,
                    Screen.PrimaryScreen.Bounds.Width,
                    Screen.PrimaryScreen.Bounds.Height));

            captureSettings.Add(
                2,
                new CaptureSetting(2, "Top Screen",
                    0,
                    0,
                    Screen.PrimaryScreen.Bounds.Width,
                    Screen.PrimaryScreen.Bounds.Height / 4));

            captureSettings.Add(
                3,
                new CaptureSetting(3, "Bottom Screen",
                    0,
                    Screen.PrimaryScreen.Bounds.Height - (Screen.PrimaryScreen.Bounds.Height / 4),
                    Screen.PrimaryScreen.Bounds.Width,
                    Screen.PrimaryScreen.Bounds.Height / 4));

            captureSettings.Add(
                4,
                new CaptureSetting(4, "Mafia II Health",
                    Screen.PrimaryScreen.Bounds.Width - (Screen.PrimaryScreen.Bounds.Width / 4),
                    Screen.PrimaryScreen.Bounds.Height - (Screen.PrimaryScreen.Bounds.Height / 3),
                    Screen.PrimaryScreen.Bounds.Width / 4,
                    Screen.PrimaryScreen.Bounds.Height / 3));

            newCaptureSettingsId = captureSettings.Last().Value.Id++;

            foreach (KeyValuePair<int, CaptureSetting> kvp in captureSettings)
            {
                savedCaptureSettingsCb.Items.Add(kvp.Value);
            }

            currentCaptureSetting = captureSettings[1];
            savedCaptureSettingsCb.SelectedIndex = 1;//Set on default 
        }

        private void LoadReadedPixelsSetings()
        {
            readedPixSettings.Add(
                0,
                new ReadedPixelsSettings(
                    0,
                    "Create Settings "
                    ));

            readedPixSettings.Add(
                1,
                new ReadedPixelsSettings(
                    1,
                    "Default "
                    ));

            readedPixSettings.Add(
                2,
                new ReadedPixelsSettings(
                    2,
                    "Mafia II Life Settings"
                    ));

            newPixReadedSettingsId = readedPixSettings.Last().Value.Id++;

            foreach (KeyValuePair<int, ReadedPixelsSettings> kvp in readedPixSettings)
            {
                savedPixelSettingsCb.Items.Add(kvp.Value);
            }

            currentReadedPixelsSettings = readedPixSettings[1];
            savedPixelSettingsCb.SelectedIndex = 1;
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

        private void applySettingsBtn_Click(object sender, EventArgs e)
        {
            if (XCoordCapture > 0 && YCoordCapture > 0
                && WidthCoordCapture > 0 && HeightCoordCapture > 0)
            {
                currentCaptureSetting = new CaptureSetting(0, "TEMPORARY_SETTINGS", XCoordCapture, YCoordCapture, WidthCoordCapture, HeightCoordCapture);
                DisplayCapture();
            }
        }

        private void CaptureBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Console.WriteLine("SCREEN SIZE : " + Screen.PrimaryScreen.Bounds.Width + " / " + Screen.PrimaryScreen.Bounds.Height);
            Thread.Sleep(400);
            currentImage = screenReader.GetParametredCapture(currentCaptureSetting);
            DisplayCapture();
            this.Show();

        }
        #endregion

        private void drawButton_Click(object sender, EventArgs e)
        {
            Rectangle rectangle = new Rectangle(XCoordPixelsReaded, YCoordPixelsReaded, WidthCoordPixelsReaded, HeightCoordPixelsReaded);
            if (savedPixelSettingsCb.SelectedIndex == 0)//Set on Create Settings
            {

                ReadedPixelsSettings newReadedPixSett = new ReadedPixelsSettings(newPixReadedSettingsId, "New Settings " + persPixelsSettingsCdw, new List<Rectangle>() { rectangle });
                readedPixSettings.Add(newReadedPixSett.Id, newReadedPixSett);
                savedPixelSettingsCb.Items.Add(newReadedPixSett);
                currentReadedPixelsSettings = readedPixSettings.Values.Last();
                savedPixelSettingsCb.SelectedIndex = savedPixelSettingsCb.Items.Count - 1;

                newPixReadedSettingsId++;
                persPixelsSettingsCdw++;

                captureForm.SetAndDrawRectangles(newReadedPixSett.Rectangles);
            }
            else
            {
                currentReadedPixelsSettings.Rectangles.Add(rectangle);
                captureForm.SetAndDrawRectangles(currentReadedPixelsSettings.Rectangles);
            }
        }

        private void savedPixelSettingsCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            currentReadedPixelsSettings = readedPixSettings.Values.ToList()[(savedPixelSettingsCb.SelectedItem as ReadedPixelsSettings).Id];
            if (MessageBox.Show("Confirm", "Confirm Action", MessageBoxButtons.OKCancel) == DialogResult.OK)
                captureForm.SetAndDrawRectangles(currentReadedPixelsSettings.Rectangles);
        }

        private void savedCaptureSettingsBtn_Click(object sender, EventArgs e)
        {
            CaptureSetting newCaptSett = new CaptureSetting(newCaptureSettingsId, "New Settings" + persCaptSettingsCdw, XCoordCapture, YCoordCapture, WidthCoordCapture, HeightCoordCapture);
            captureSettings.Add(newCaptSett.Id, newCaptSett);
            savedCaptureSettingsCb.Items.Add(newCaptSett);
            savedCaptureSettingsCb.SelectedItem = "New Settings " + persCaptSettingsCdw;
            persCaptSettingsCdw++;
            newCaptureSettingsId++;
        }
    }
}
