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
using System.Reflection;
using ReadPixelImage.Forms;
using System.Xml;

namespace ReadPixelImage
{
    public partial class SettingsCaptureForm : Form
    {

        #region Variables
        CaptureDisplay captureForm;
        CreateReadedPixelsSettingForm createSettFom;

        ScreenReader screenReader = new ScreenReader();
        Bitmap currentImage;
        CaptureSetting currentCaptureSetting;
        CaptureSetting tempCaptureSetting;
        ReadedPixelsSetting currentReadedPixelsSettings;
        SettingsManager settingsManager;

        Dictionary<string, Bitmap> imageDict;
        Dictionary<int, CaptureSetting> captureSettingsDict;
        Dictionary<int, ReadedPixelsSetting> readedPixSettingsDict;

        bool isRectsSettingModified;
        #endregion

        #region Constructor

        public SettingsCaptureForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        public MainMenuForm OwnerForm { get; set; }

        private void InitializeForm()
        {
            imageDict = new Dictionary<string, Bitmap>();
            captureSettingsDict = new Dictionary<int, CaptureSetting>();
            readedPixSettingsDict = new Dictionary<int, ReadedPixelsSetting>();
            currentReadedPixelsSettings = new ReadedPixelsSetting();
            currentCaptureSetting = new CaptureSetting();
            tempCaptureSetting = new CaptureSetting(-1, "Temporary Setting", 0, 0, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            createSettFom = new CreateReadedPixelsSettingForm();
            captureForm = new CaptureDisplay();
            captureForm.OwnerForm = this.OwnerForm;
            settingsManager = new SettingsManager();

            yCaptureNb.Maximum = Screen.PrimaryScreen.Bounds.Height;
            xCaptureNb.Maximum = Screen.PrimaryScreen.Bounds.Width;
            heightCaptureNb.Maximum = Screen.PrimaryScreen.Bounds.Height;
            widthCaptureNb.Maximum = Screen.PrimaryScreen.Bounds.Width;

            yPixelsNb.Maximum = Screen.PrimaryScreen.Bounds.Height;
            xPixelsNb.Maximum = Screen.PrimaryScreen.Bounds.Width;
            heightPixelsNb.Maximum = Screen.PrimaryScreen.Bounds.Height;
            widthPixelsNb.Maximum = Screen.PrimaryScreen.Bounds.Width;

            isRectsSettingModified = false;

            drawButton.Click += readedPixelBtn_Click;
            modifyRectBtn.Click += readedPixelBtn_Click;
            deleteRectButton.Click += readedPixelBtn_Click;

            ManageSettingsAndDirectories();
            ManageLoadedImages();
            InitSettings();
            captureForm.Show();
            DisplayCapture();

        }
        #endregion

        #region Properties
        //Properties create to have easier access to NumUpDown cotnrol
        public int XCoordCapture { get { return (int)xCaptureNb.Value; } set { xCaptureNb.Value = value; } }
        public int YCoordCapture { get { return (int)yCaptureNb.Value; } set { yCaptureNb.Value = value; } }
        public int WidthCoordCapture { get { return (int)widthCaptureNb.Value; } set { widthCaptureNb.Value = value; } }
        public int HeightCoordCapture { get { return (int)heightCaptureNb.Value; } set { heightCaptureNb.Value = value; } }

        public int XCoordPixelsReaded { get { return (int)xPixelsNb.Value; } set { xPixelsNb.Value = value; } }
        public int YCoordPixelsReaded { get { return (int)yPixelsNb.Value; } set { yPixelsNb.Value = value; } }
        public int WidthCoordPixelsReaded { get { return (int)widthPixelsNb.Value; } set { widthPixelsNb.Value = value; } }
        public int HeightCoordPixelsReaded { get { return (int)heightPixelsNb.Value; } set { heightPixelsNb.Value = value; } }

        #endregion

        #region Methods
        /// <summary>
        /// Create the needed directories in Public folder
        /// </summary>
        private void ManageSettingsAndDirectories()
        {
            string[] files = { "" };
            files = Directory.GetDirectories(settingsManager.PublicDocPath, "ReadPixelImage");

            if (files == null || files.Count() == 0
                || !files.Contains(settingsManager.PublicDocPath + "\\ReadPixelImage"))
            {
                Directory.CreateDirectory(settingsManager.PublicDocPath + "\\ReadPixelImage");
                Directory.CreateDirectory(settingsManager.SettingsDocPath);
                Directory.CreateDirectory(settingsManager.CaptureSettingsDocPath);
                Directory.CreateDirectory(settingsManager.ReadedPixelsSettingsDocPath);
                Directory.CreateDirectory(settingsManager.ImagesDocPath);
                Directory.CreateDirectory(settingsManager.ImagesDocPath + "\\Loaded");
                Directory.CreateDirectory(settingsManager.ImagesDocPath + "\\Saved");
                Directory.CreateDirectory(settingsManager.ImagesDocPath + "\\Capture");

                loadedImgCb.Items.Clear();
                ImageConverter imgConvert = new ImageConverter();

                string path = TryGetSolutionDirectoryInfo(Directory.GetCurrentDirectory()).FullName + "\\TestImages";
                foreach (var item in Directory.GetFiles(path))
                {
                    if (item.ToString().Contains(".png") || item.ToString().Contains(".jpeg"))
                    {
                        Bitmap imgToAdd = new Bitmap(item.ToString());
                        string imgName = item.Substring(path.Length + 1);
                        File.WriteAllBytes(settingsManager.ImagesDocPath + "\\Loaded\\" + imgName, (byte[])imgConvert.ConvertTo(imgToAdd, typeof(byte[])));
                    }
                }

            }

            files = Directory.GetFiles(settingsManager.ReadedPixelsSettingsDocPath);
            if (!files.Contains(settingsManager.ReadedPixelsSettingsDocPath + SettingsManager.READED_PIXELS_SETTINGS_FILENAME))
                settingsManager.CreateExcellReadedPixelsSettingsFiles(out readedPixSettingsDict);

            files = Directory.GetFiles(settingsManager.CaptureSettingsDocPath);
            if (!files.Contains(settingsManager.CaptureSettingsDocPath + SettingsManager.CAPTURE_SETTINGS_FILENAME))
            {
                settingsManager.CreateExcellCaptureSettingsFiles(out captureSettingsDict);
            }


        }
        /// <summary>
        /// Get directory info of given path
        /// </summary>
        /// <param name="currentPath"></param>
        /// <returns></returns>
        public static DirectoryInfo TryGetSolutionDirectoryInfo(string currentPath = null)
        {
            var directory = new DirectoryInfo(
                currentPath ?? Directory.GetCurrentDirectory());
            while (directory != null && !directory.GetFiles("*.sln").Any())
            {
                directory = directory.Parent;
            }
            return directory;
        }
        /// <summary>
        /// Initialize the settings provided in the .xls files ( Public folder )
        /// </summary>
        private void InitSettings()
        {
            ManageReadedPixelSettings(true);
            ManageCaptureSettings(true);

            currentCaptureSetting = captureSettingsDict[0];
            SetNumericalField(currentCaptureSetting);

            yCaptureNb.Maximum = Screen.PrimaryScreen.Bounds.Height;
            xCaptureNb.Maximum = Screen.PrimaryScreen.Bounds.Width;
            heightCaptureNb.Maximum = Screen.PrimaryScreen.Bounds.Width;
            widthCaptureNb.Maximum = Screen.PrimaryScreen.Bounds.Width;
            savedCaptureSettingsCb.SelectedIndex = 0;//Set on default 
            savedReadedPixelSettingsCb.SelectedIndex = 0;//Set on default 
        }

        private void LoadAndDisplayReadedPixelsRectangle()
        {
            readedPixelsRectsListBox.Items.Clear();

            if (currentReadedPixelsSettings.Rectangles.Count > 0)
            {
                for (int i = 0; i < currentReadedPixelsSettings.Rectangles.Count(); i++)
                {
                    readedPixelsRectsListBox.Items.Add(currentReadedPixelsSettings.Rectangles[i]);
                }

                if (readedPixelsRectsListBox.Items.Count > 0)
                    readedPixelsRectsListBox.SelectedIndex = 0;

                captureForm.SetAndDrawRectangles(currentReadedPixelsSettings.Rectangles, readedPixelsRectsListBox.SelectedIndex);
                SetNumericalField(currentReadedPixelsSettings.Rectangles[0]);
            }
            else
            {
                captureForm.SetAndDrawRectangles(currentReadedPixelsSettings.Rectangles);
                SetNumericalField();
            }
        }

        private void ManageCaptureSettings(bool isInit = false)
        {
            int selIndex = isInit ? 0 : savedCaptureSettingsCb.SelectedIndex;
            settingsManager.LoadCaptureSettings(out captureSettingsDict);
            savedCaptureSettingsCb.Items.Clear();
            foreach (CaptureSetting captSett in captureSettingsDict.Values)
                savedCaptureSettingsCb.Items.Add(captSett);
            savedCaptureSettingsCb.SelectedIndex = selIndex;
            if (selIndex > -1)
                currentCaptureSetting = captureSettingsDict[selIndex];
            else
                ManageTemporarySetting(true);

        }

        private void ManageReadedPixelSettings(bool isInit = false)
        {
            int selIndex = isInit ? 0 : savedReadedPixelSettingsCb.SelectedIndex;
            settingsManager.LoadReadedPixelsSettings(out readedPixSettingsDict);
            savedReadedPixelSettingsCb.Items.Clear();
            foreach (ReadedPixelsSetting rdPixelSett in readedPixSettingsDict.Values)
                savedReadedPixelSettingsCb.Items.Add(rdPixelSett);
            savedReadedPixelSettingsCb.SelectedIndex = selIndex;

            if (selIndex > -1)
                currentReadedPixelsSettings = readedPixSettingsDict[selIndex];
            else
                currentReadedPixelsSettings = new ReadedPixelsSetting();

        }
        private void ManageTemporarySetting(bool setToCurrentSett)
        {
            if (setToCurrentSett)
            {
                tempCaptureSetting.X = XCoordCapture;
                tempCaptureSetting.Y = YCoordCapture;
                tempCaptureSetting.Width = WidthCoordCapture;
                tempCaptureSetting.Height = HeightCoordCapture;

                currentCaptureSetting = tempCaptureSetting;

                if (!savedCaptureSettingsCb.Items.Contains(tempCaptureSetting))
                    savedCaptureSettingsCb.Items.Add(tempCaptureSetting);
                savedCaptureSettingsCb.SelectedItem = tempCaptureSetting;
            }
            else if (savedCaptureSettingsCb.Items.Contains(tempCaptureSetting))
                savedCaptureSettingsCb.Items.Remove(tempCaptureSetting);

        }


        private void ManageLoadedImages()
        {
            settingsManager.LoadImages(out imageDict);
            loadedImgCb.Items.Clear();
            foreach (string name in imageDict.Keys)
                loadedImgCb.Items.Add(name);
            loadedImgCb.SelectedIndex = -1;
        }



        /// <summary>
        /// Display the current image or screenshot with the settings provided
        /// </summary>
        private void DisplayCapture()
        {
            Bitmap cropImgToShow = screenReader.GetParametredCapture(currentCaptureSetting, currentImage);

            if (savedCaptureSettingsCb.SelectedIndex == 0)
            {
                captureForm.MaximumSize = new Size(0, 0);
                captureForm.WindowState = FormWindowState.Maximized;// Preset saved where (Width && Height == Screen.Primary.Bounds)
            }
            else
            {
                captureForm.WindowState = FormWindowState.Normal;
                captureForm.MaximumSize = cropImgToShow.Size + new Size(16, 39);
                captureForm.CaptureImg.Size = cropImgToShow.Size;
            }

            captureForm.CaptureImg.Image = cropImgToShow;
            captureForm.SetAndDrawRectangles(currentReadedPixelsSettings.Rectangles, currentReadedPixelsSettings.Rectangles.Count() > 0 ? 0 : -1);
            captureForm.Show();

            this.WindowState = FormWindowState.Normal;
        }

        private void SetNumericalField(CaptureSetting captureSett)
        {
            XCoordCapture = captureSett.X;
            YCoordCapture = captureSett.Y;
            WidthCoordCapture = captureSett.Width;
            HeightCoordCapture = captureSett.Height;
        }

        private void SetNumericalField(Rectangle rect = new Rectangle())
        {
            XCoordPixelsReaded = rect.X;
            YCoordPixelsReaded = rect.Y;
            WidthCoordPixelsReaded = rect.Width;
            HeightCoordPixelsReaded = rect.Height;
        }

        #endregion

        #region Event Handler


        private void imageChooseCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (imageDict.TryGetValue(loadedImgCb.SelectedItem.ToString(), out currentImage))
                DisplayCapture();
        }

        private void applySettingsBtn_Click(object sender, EventArgs e)
        {
            if (XCoordCapture > 0 && YCoordCapture > 0
                && WidthCoordCapture > 0 && HeightCoordCapture > 0)
            {
                ManageTemporarySetting(true);
                DisplayCapture();
            }
        }

        private void CaptureBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Console.WriteLine("SCREEN SIZE : " + Screen.PrimaryScreen.Bounds.Width + " / " + Screen.PrimaryScreen.Bounds.Height);
            Thread.Sleep(400);
            //currentImage = screenReader.GetParametredCapture(currentCaptureSetting);

            DisplayCapture();
            this.Show();

        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            isRectsSettingModified = true;
            Rectangle rectangle = new Rectangle(XCoordPixelsReaded, YCoordPixelsReaded, WidthCoordPixelsReaded, HeightCoordPixelsReaded);
            currentReadedPixelsSettings.Rectangles.Add(rectangle);
            captureForm.SetAndDrawRectangles(currentReadedPixelsSettings.Rectangles, currentReadedPixelsSettings.Rectangles.Count() - 1);
            readedPixelsRectsListBox.Items.Add(rectangle);
            readedPixelsRectsListBox.SelectedItem = rectangle;
            //readedPixelsRectsListBox.//TODO test and finish
        }

        private void applyChosenSettingsBtn_Click(object sender, EventArgs e)
        {
            SetNumericalField(currentCaptureSetting);
            DisplayCapture();
        }

        private void createNewPixSettBtn_Click(object sender, EventArgs e)
        {
            createSettFom.ShowDialog();
            if (createSettFom.Result == DialogResult.OK)
            {

                ReadedPixelsSetting newRDPixSett = new ReadedPixelsSetting()
                {
                    Id = settingsManager.NewReadedPixelsSettingsId,
                    Name = createSettFom.NameTbText,
                    Rectangles = new List<Rectangle>()
                };

                int prevSelIndex = savedReadedPixelSettingsCb.SelectedIndex;

                settingsManager.CreateNewSetting(newRDPixSett);
                ManageReadedPixelSettings();

                foreach (KeyValuePair<int, ReadedPixelsSetting> kvp in readedPixSettingsDict)
                    savedReadedPixelSettingsCb.Items.Add(kvp.Value);

                if (prevSelIndex > -1 && savedReadedPixelSettingsCb.Items.Count - 1 >= prevSelIndex)
                    savedReadedPixelSettingsCb.SelectedIndex = prevSelIndex;
                else if (savedReadedPixelSettingsCb.Items.Count > 0)
                    savedReadedPixelSettingsCb.SelectedIndex = 0;

                settingsManager.NewReadedPixelsSettingsId++;

                if (currentReadedPixelsSettings == null) currentReadedPixelsSettings = readedPixSettingsDict[0];

                LoadAndDisplayReadedPixelsRectangle();

            }
        }

        private void saveCaptureSettBtn_Click(object sender, EventArgs e)
        {
            CreateOrEditCaptureSettingForm editForm = new CreateOrEditCaptureSettingForm();
            editForm.ShowDialog();
            if (editForm.Result == DialogResult.OK)
            {
                CaptureSetting newCaptSett = editForm.CaptureSetting;
                newCaptSett.Id = settingsManager.NewCaptureSettingsId;
                int prevSelIndex = savedReadedPixelSettingsCb.SelectedIndex;

                settingsManager.CreateNewSetting(newCaptSett);
                settingsManager.LoadCaptureSettings(out captureSettingsDict);
                savedCaptureSettingsCb.Items.Clear();

                foreach (KeyValuePair<int, CaptureSetting> kvp in captureSettingsDict)
                    savedCaptureSettingsCb.Items.Add(kvp.Value);

                if (prevSelIndex > -1 && savedCaptureSettingsCb.Items.Count - 1 >= prevSelIndex)
                    savedCaptureSettingsCb.SelectedIndex = prevSelIndex;
                else if (savedCaptureSettingsCb.Items.Count > 0)
                    savedCaptureSettingsCb.SelectedIndex = 0;

                settingsManager.NewCaptureSettingsId++;

                if (captureSettingsDict == null) currentCaptureSetting = captureSettingsDict[0];

            }

        }

        private void applyPixSettBtn_Click(object sender, EventArgs e)
        {
            if (readedPixSettingsDict.TryGetValue((savedReadedPixelSettingsCb.SelectedItem as ReadedPixelsSetting).Id, out currentReadedPixelsSettings))
            {
                LoadAndDisplayReadedPixelsRectangle();
                captureForm.SetAndDrawRectangles(currentReadedPixelsSettings.Rectangles, savedReadedPixelSettingsCb.SelectedIndex);
            }
        }

        private void savedCaptureSettingsCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            currentCaptureSetting = savedCaptureSettingsCb.SelectedItem as CaptureSetting;
        }

        private void pixelReadedRectsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (readedPixelsRectsListBox.SelectedIndex >= 0)
            {
                SetNumericalField(currentReadedPixelsSettings.Rectangles[readedPixelsRectsListBox.SelectedIndex]);
                captureForm.SetSelectedRectangle(readedPixelsRectsListBox.SelectedIndex);
            }
            modifyRectBtn.Visible = readedPixelsRectsListBox.SelectedIndex >= 0;
            deleteRectButton.Visible = readedPixelsRectsListBox.SelectedIndex >= 0;
        }

        private void saveRectBtn_Click(object sender, EventArgs e)
        {
            ReadedPixelsSetting verif;
            if (readedPixSettingsDict.TryGetValue(currentReadedPixelsSettings.Id, out verif))
            {
                isRectsSettingModified = false;
                saveRectBtn.Visible = isRectsSettingModified;
                this.Enabled = false;
                settingsManager.EditSetting(currentReadedPixelsSettings);
                ManageReadedPixelSettings();
                this.Enabled = true;
            }
        }

        private void modifyRectBtn_Click(object sender, EventArgs e)
        {
            if (readedPixelsRectsListBox.SelectedIndex >= 0)
            {
                isRectsSettingModified = true;
                int index = readedPixelsRectsListBox.SelectedIndex;
                Rectangle rectToEdit = new Rectangle(XCoordPixelsReaded, YCoordPixelsReaded, WidthCoordPixelsReaded, HeightCoordPixelsReaded);

                currentReadedPixelsSettings.EditRectangle(rectToEdit, index);
                readedPixelsRectsListBox.Items.Clear();
                for (int i = 0; i < currentReadedPixelsSettings.Rectangles.Count(); i++)
                {
                    readedPixelsRectsListBox.Items.Add(currentReadedPixelsSettings.Rectangles[i]);
                }
                readedPixelsRectsListBox.SelectedItem = rectToEdit;

                captureForm.SetAndDrawRectangles(currentReadedPixelsSettings.Rectangles, index);
            }
        }

        private void deleteRectButton_Click(object sender, EventArgs e)
        {
            if (readedPixelsRectsListBox.SelectedIndex > 0)
            {
                isRectsSettingModified = true;
                currentReadedPixelsSettings.RemoveRectangle(readedPixelsRectsListBox.SelectedIndex);
                readedPixelsRectsListBox.Items.Clear();
                foreach (Rectangle rectangle in currentReadedPixelsSettings.Rectangles)
                {
                    readedPixelsRectsListBox.Items.Add(rectangle);
                }
                readedPixelsRectsListBox.SelectedIndex = readedPixelsRectsListBox.Items.Count > 0 ? 0 : -1;

                captureForm.SetAndDrawRectangles(currentReadedPixelsSettings.Rectangles, readedPixelsRectsListBox.SelectedIndex);
            }
        }

        #endregion

        private void deleteSavedReadedPixBtn_Click(object sender, EventArgs e)
        {
            ReadedPixelsSetting settingToRemove;
            if (readedPixSettingsDict.TryGetValue((savedReadedPixelSettingsCb.SelectedItem as ReadedPixelsSetting).Id, out settingToRemove))
            {
                settingsManager.DeleteSetting(settingToRemove);
                ManageReadedPixelSettings();
            }
        }

        private void editCaptureSettBtn_Click(object sender, EventArgs e)
        {
            CaptureSetting captToEdit;
            if (captureSettingsDict.TryGetValue(currentCaptureSetting.Id, out captToEdit))
            {
                CreateOrEditCaptureSettingForm editForm = new CreateOrEditCaptureSettingForm(currentCaptureSetting);
                editForm.ShowDialog();
                if (editForm.Result == DialogResult.OK)
                {
                    captToEdit = editForm.CaptureSetting;
                    settingsManager.EditSetting(captToEdit);
                    settingsManager.LoadCaptureSettings(out captureSettingsDict);
                }
            }
            else
                MessageBox.Show("Only saved setting can be edited", "Error");
        }

        private void deleteCaptSet_Click(object sender, EventArgs e)
        {
            CaptureSetting captSettToRemove;
            if (captureSettingsDict.TryGetValue((savedCaptureSettingsCb.SelectedItem as CaptureSetting).Id, out captSettToRemove))
            {
                settingsManager.DeleteSetting(captSettToRemove);
                settingsManager.LoadCaptureSettings(out captureSettingsDict);
            }
        }

        private void readedPixelBtn_Click(object sender, EventArgs e)
        {
            saveRectBtn.Visible = isRectsSettingModified;
        }

        private void SettingsCaptureForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            OwnerForm.Show();
            captureForm.Hide();
            this.Hide();
        }
    }
}
