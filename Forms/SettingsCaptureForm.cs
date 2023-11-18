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
        CaptureForm captureForm;
        CreateSettingForm createSettFom;

        ScreenReader screenReader = new ScreenReader();
        Bitmap currentImage;
        CaptureSetting currentCaptureSetting;
        CaptureSetting tempCaptureSetting;
        ReadedPixelsSetting currentReadedPixelsSettings;

        Dictionary<string, Bitmap> imageDict;
        Dictionary<int, CaptureSetting> captureSettingsDict;
        Dictionary<int, ReadedPixelsSetting> readedPixSettingsDict;

        int newCaptureSettingsId;
        int newPixReadedSettingsId;

        Workbook captureSettingsWorkbooks;
        Workbook readedPixelsSettingsWorkbook;

        string publicDocPath;
        string settingsDocPath;
        string imagesDocPath;
        string captureSettingsDocPath;
        string readedPixelsSettingsDocPath;
        const string CAPTURE_SETTINGS_FILENAME = "\\CaptureSettings.xls";
        const string READED_PIXELS_SETTINGS_FILENAME = "\\ReadedPixelsSettings.xls";

        #endregion

        #region Constructor

        public SettingsCaptureForm()
        {
            InitializeComponent();
            InitializeForm();
        }
        private void InitializeForm()
        {
            imageDict = new Dictionary<string, Bitmap>();
            captureSettingsDict = new Dictionary<int, CaptureSetting>();
            readedPixSettingsDict = new Dictionary<int, ReadedPixelsSetting>();
            currentCaptureSetting = new CaptureSetting();
            tempCaptureSetting = new CaptureSetting(-1, "Temporary Setting", 0, 0, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            captureSettingsWorkbooks = new Workbook();
            readedPixelsSettingsWorkbook = new Workbook();

            createSettFom = new CreateSettingForm();
            captureForm = new CaptureForm();

            yCaptureNb.Maximum = Screen.PrimaryScreen.Bounds.Height;
            xCaptureNb.Maximum = Screen.PrimaryScreen.Bounds.Width;
            heightCaptureNb.Maximum = Screen.PrimaryScreen.Bounds.Height;
            widthCaptureNb.Maximum = Screen.PrimaryScreen.Bounds.Width;

            yPixelsNb.Maximum = Screen.PrimaryScreen.Bounds.Height;
            xPixelsNb.Maximum = Screen.PrimaryScreen.Bounds.Width;
            heightPixelsNb.Maximum = Screen.PrimaryScreen.Bounds.Height;
            widthPixelsNb.Maximum = Screen.PrimaryScreen.Bounds.Width;

            publicDocPath = Environment.ExpandEnvironmentVariables(@"%PUBLIC%\Documents");
            settingsDocPath = publicDocPath + @"\ReadPixelImage\Settings";
            imagesDocPath = publicDocPath + @"\ReadPixelImage\Images";
            captureSettingsDocPath = settingsDocPath + @"\Capture";
            readedPixelsSettingsDocPath = settingsDocPath + @"\Pixels";

            ManageSettingsAndDirectories();
            LoadImages();
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

                loadedImgCb.Items.Clear();
                ImageConverter imgConvert = new ImageConverter();

                string path = TryGetSolutionDirectoryInfo(Directory.GetCurrentDirectory()).FullName + "\\TestImages";
                foreach (var item in Directory.GetFiles(path))
                {
                    if (item.ToString().Contains(".png") || item.ToString().Contains(".jpeg"))
                    {
                        Bitmap imgToAdd = new Bitmap(item.ToString());
                        string imgName = item.Substring(path.Length + 1);
                        File.WriteAllBytes(imagesDocPath + "\\Loaded\\" + imgName, (byte[])imgConvert.ConvertTo(imgToAdd, typeof(byte[])));
                    }
                }

            }



            DataSet ds = new DataSet();
            ds.Tables.Add("Default Settings");

            files = Directory.GetFiles(readedPixelsSettingsDocPath);
            if (!files.Contains(readedPixelsSettingsDocPath + READED_PIXELS_SETTINGS_FILENAME))
            {
                DataSetHelper.CreateWorkbook(readedPixelsSettingsDocPath + READED_PIXELS_SETTINGS_FILENAME, ds);
                readedPixelsSettingsWorkbook = Workbook.Load(readedPixelsSettingsDocPath + READED_PIXELS_SETTINGS_FILENAME);
                readedPixelsSettingsWorkbook.Worksheets[0].Cells[0, 0] = new Cell("ID");
                readedPixelsSettingsWorkbook.Worksheets[0].Cells[0, 1] = new Cell("NAME");
                readedPixelsSettingsWorkbook.Worksheets[0].Cells[0, 2] = new Cell("RECT COORDS");

                readedPixSettingsDict.Add(0, new ReadedPixelsSetting()
                {
                    Id = 0,
                    Name = "Default",
                    Rectangles = new List<Rectangle>() { new Rectangle((captureForm.CaptureImg.Height / 2) - 20, (captureForm.CaptureImg.Width / 2) - 20, 40, 40) }
                });

                CreateNewSettings(readedPixSettingsDict.FirstOrDefault().Value);

                readedPixelsSettingsWorkbook.Save(readedPixelsSettingsDocPath + READED_PIXELS_SETTINGS_FILENAME);
            }

            files = Directory.GetFiles(captureSettingsDocPath);
            if (!files.Contains(captureSettingsDocPath + CAPTURE_SETTINGS_FILENAME))
            {
                DataSetHelper.CreateWorkbook(captureSettingsDocPath + CAPTURE_SETTINGS_FILENAME, ds);
                captureSettingsWorkbooks = Workbook.Load(captureSettingsDocPath + CAPTURE_SETTINGS_FILENAME);
                captureSettingsWorkbooks.Worksheets[0].Cells[0, 0] = new Cell("ID");
                captureSettingsWorkbooks.Worksheets[0].Cells[0, 1] = new Cell("Name");
                captureSettingsWorkbooks.Worksheets[0].Cells[0, 2] = new Cell("X COORD");
                captureSettingsWorkbooks.Worksheets[0].Cells[0, 3] = new Cell("Y COORD");
                captureSettingsWorkbooks.Worksheets[0].Cells[0, 4] = new Cell("WIDTH");
                captureSettingsWorkbooks.Worksheets[0].Cells[0, 5] = new Cell("HEIGHT");

                captureSettingsDict.Add(
                    0,
                    new CaptureSetting(0, "Default",
                        0,
                        0,
                        Screen.PrimaryScreen.Bounds.Width,
                        Screen.PrimaryScreen.Bounds.Height));

                captureSettingsDict.Add(
                    1,
                    new CaptureSetting(1, "Top Screen",
                        0,
                        0,
                        Screen.PrimaryScreen.Bounds.Width,
                        Screen.PrimaryScreen.Bounds.Height / 4));

                captureSettingsDict.Add(
                    2,
                    new CaptureSetting(2, "Bottom Screen",
                        0,
                        Screen.PrimaryScreen.Bounds.Height - (Screen.PrimaryScreen.Bounds.Height / 4),
                        Screen.PrimaryScreen.Bounds.Width,
                        Screen.PrimaryScreen.Bounds.Height / 4));

                captureSettingsDict.Add(
                    3,
                    new CaptureSetting(3, "Mafia II Health",
                        Screen.PrimaryScreen.Bounds.Width - (Screen.PrimaryScreen.Bounds.Width / 4),
                        Screen.PrimaryScreen.Bounds.Height - (Screen.PrimaryScreen.Bounds.Height / 3),
                        Screen.PrimaryScreen.Bounds.Width / 4,
                        Screen.PrimaryScreen.Bounds.Height / 3));

                foreach (KeyValuePair<int, CaptureSetting> kvp in captureSettingsDict)
                    CreateNewSettings(kvp.Value);

                captureSettingsWorkbooks.Save(captureSettingsDocPath + CAPTURE_SETTINGS_FILENAME);
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
            LoadCaptureSettings();
            LoadReadedPixelsSettings();

            currentCaptureSetting = captureSettingsDict[0];
            SetNumericalField(currentCaptureSetting);

            yCaptureNb.Maximum = Screen.PrimaryScreen.Bounds.Height;
            xCaptureNb.Maximum = Screen.PrimaryScreen.Bounds.Width;
            heightCaptureNb.Maximum = Screen.PrimaryScreen.Bounds.Width;
            widthCaptureNb.Maximum = Screen.PrimaryScreen.Bounds.Width;
            savedCaptureSettingsCb.SelectedIndex = 0;//Set on default 
        }
        /// <summary>
        /// Load the data from the setting workbook in the severals controls
        /// </summary>
        private void LoadCaptureSettings()
        {
            captureSettingsDict = new Dictionary<int, CaptureSetting>();
            int prevSelIndex = savedCaptureSettingsCb.SelectedIndex;
            savedCaptureSettingsCb.Items.Clear();
            //Load Excell Workbooks from xls document in Public
            captureSettingsWorkbooks = Workbook.Load(captureSettingsDocPath + CAPTURE_SETTINGS_FILENAME);
            //For each row of first workSheet, extract the data and parse it in Capture / ReadingPixel Setting
            for (int i = 1; i < captureSettingsWorkbooks.Worksheets[0].Cells.Rows.Count(); i++)
            {
                Row rowToRead = captureSettingsWorkbooks.Worksheets[0].Cells.Rows[i];
                //xls files are construct like the models 
                CaptureSetting captSettToAdd = new CaptureSetting()
                {
                    Id = int.Parse(rowToRead.GetCell(0).ToString()),
                    Name = rowToRead.GetCell(1).ToString(),
                    X = int.Parse(rowToRead.GetCell(2).ToString()),
                    Y = int.Parse(rowToRead.GetCell(3).ToString()),
                    Width = int.Parse(rowToRead.GetCell(4).ToString()),
                    Height = int.Parse(rowToRead.GetCell(5).ToString())
                };

                //Add the settings to the dictionnary and the comboBox
                captureSettingsDict.Add(captSettToAdd.Id, captSettToAdd);
                savedCaptureSettingsCb.Items.Add(captSettToAdd);
                savedCaptureSettingsCb.SelectedIndex = prevSelIndex;

                //Saved last Id in order to save new settings later
                if (i == captureSettingsWorkbooks.Worksheets[0].Cells.Rows.Count())
                    newCaptureSettingsId = captSettToAdd.Id + 1;
            }
        }
        /// <summary>
        /// Load the data from the setting workbook in the severals controls
        /// </summary>
        private void LoadReadedPixelsSettings()
        {
            readedPixSettingsDict = new Dictionary<int, ReadedPixelsSetting>();

            int prevSelIndex = savedReadedPixelSettingsCb.SelectedIndex;
            savedReadedPixelSettingsCb.Items.Clear();

            readedPixelsSettingsWorkbook = Workbook.Load(readedPixelsSettingsDocPath + READED_PIXELS_SETTINGS_FILENAME);
            for (int i = 1; i < readedPixelsSettingsWorkbook.Worksheets[0].Cells.Rows.Count(); i++)
            {
                Row rowToRead = readedPixelsSettingsWorkbook.Worksheets[0].Cells.Rows[i];
                List<Rectangle> rectanglesToAdd = new List<Rectangle>();
                //Each colonne whos index is <2 is a rectangle
                for (int j = 2; j <= readedPixelsSettingsWorkbook.Worksheets[0].Cells.Rows[i].LastColIndex; j++)
                {
                    //Rectangle data are stocked in one string with "|" as separator ex : "42|47|234|23"
                    string[] dataString = readedPixelsSettingsWorkbook.Worksheets[0].Cells.Rows[i].GetCell(j).ToString().Split('|');
                    int[] dataInt = new int[dataString.Length];

                    //Parse the string into int //TODO add exception for that kind of case ( bad entry in excel files )
                    for (int k = 0; k < dataString.Length; k++)
                        dataInt[k] = int.Parse(dataString[k]);

                    rectanglesToAdd.Add(new Rectangle(dataInt[0], dataInt[1], dataInt[2], dataInt[3]));
                    Console.WriteLine();
                }

                ReadedPixelsSetting readedPixSettToAdd = new ReadedPixelsSetting()
                {
                    Id = int.Parse(rowToRead.GetCell(0).ToString()),
                    Name = rowToRead.GetCell(1).ToString(),
                    Rectangles = rectanglesToAdd,
                };

                readedPixSettingsDict.Add(readedPixSettToAdd.Id, readedPixSettToAdd);
                savedReadedPixelSettingsCb.Items.Add(readedPixSettToAdd);

                if (i == readedPixelsSettingsWorkbook.Worksheets[0].Cells.Rows.Count() - 1)
                    newPixReadedSettingsId = readedPixSettToAdd.Id + 1;
            }

            if (prevSelIndex > -1 && savedReadedPixelSettingsCb.Items.Count - 1 >= prevSelIndex)
                savedReadedPixelSettingsCb.SelectedIndex = prevSelIndex;
            else if (savedReadedPixelSettingsCb.Items.Count > 0)
                savedReadedPixelSettingsCb.SelectedIndex = 0;

            if (currentReadedPixelsSettings == null) currentReadedPixelsSettings = readedPixSettingsDict.Count() > 0 ? readedPixSettingsDict[0] : new ReadedPixelsSetting(-1, "New Settings", new List<Rectangle>());

            LoadAndDisplayReadedPixelsRectangle();
        }
        private void LoadAndDisplayReadedPixelsRectangle()
        {
            readedPixelsRectsListBox.Items.Clear();

            if (currentReadedPixelsSettings.Rectangles.Count > 0)
            {
                foreach (Rectangle rect in currentReadedPixelsSettings.Rectangles)
                {
                    readedPixelsRectsListBox.Items.Add(rect);
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
            }
            else if (savedCaptureSettingsCb.Items.Contains(tempCaptureSetting))
                savedCaptureSettingsCb.Items.Remove(tempCaptureSetting);

        }

        /// <summary>
        /// Create a new Capture Settings and save it in the CaptureSettings.xls files
        /// </summary>
        /// <param name="captureSett"></param>
        private void CreateNewSettings(CaptureSetting captureSett)
        {

            //Cells[0, 0] = "ID"
            //Cells[0, 1] = "Name"
            //Cells[0, 2] = "X COORD"
            //Cells[0, 3] = "Y COORD"
            //Cells[0, 4] = "WIDTH"
            //Cells[0, 5] = "HEIGHT"
            CellCollection cells = captureSettingsWorkbooks.Worksheets[0].Cells;
            int rowCpt = cells.Rows.Count();

            cells.CreateCell(rowCpt, 0, captureSett.Id, 0);
            cells.CreateCell(rowCpt, 1, captureSett.Name, 0);
            cells.CreateCell(rowCpt, 2, captureSett.X, 0);
            cells.CreateCell(rowCpt, 3, captureSett.Y, 0);
            cells.CreateCell(rowCpt, 4, captureSett.Width, 0);
            cells.CreateCell(rowCpt, 5, captureSett.Height, 0);

            captureSettingsWorkbooks.Save(captureSettingsDocPath + CAPTURE_SETTINGS_FILENAME);
            LoadCaptureSettings();
        }

        /// <summary>
        /// Load the images presents in Public folders
        /// </summary>
        private void LoadImages()
        {
            imageDict = new Dictionary<string, Bitmap>();
            loadedImgCb.Items.Clear();

            foreach (var item in Directory.EnumerateFiles(imagesDocPath + "\\Loaded"))
            {
                if (item.ToString().Contains(".png") || item.ToString().Contains(".jpeg"))
                {
                    Bitmap imgToAdd = new Bitmap(item.ToString());
                    string imgName = item.Substring((imagesDocPath.Length + "\\Loaded").Length + 1);
                    imageDict.Add(imgName, imgToAdd);
                    loadedImgCb.Items.Add(imgName);
                }
            }
        }


        /// <summary>
        /// Create a new Capture Settings and save it in the CaptureSettings.xls files
        /// </summary>
        /// <param name="readedPixelsSett"></param>
        private void CreateNewSettings(ReadedPixelsSetting readedPixelsSett)
        {
            //Cells[0, 0] = new Cell("ID");
            //Cells[0, 1] = new Cell("NAME");
            //Cells[0, 2] = new Cell("RECT COORDS");

            CellCollection cells = readedPixelsSettingsWorkbook.Worksheets[0].Cells;
            int rowCpt = cells.Rows.Count();

            cells.CreateCell(rowCpt, 0, readedPixelsSett.Id, 0);
            cells.CreateCell(rowCpt, 1, readedPixelsSett.Name, 0);

            for (int i = 0; i < readedPixelsSett.Rectangles.Count(); i++)
            {
                Rectangle rectToAdd = readedPixelsSett.Rectangles[i];
                cells.CreateCell(rowCpt, 2 + i, $"{rectToAdd.X}|{rectToAdd.Y}|{rectToAdd.Width}|{rectToAdd.Height}", 0);
            }
            //TODO manage exception where i cant save a existing Excell files
            if (Directory.GetFiles(readedPixelsSettingsDocPath).Contains(readedPixelsSettingsDocPath + READED_PIXELS_SETTINGS_FILENAME))
                File.Delete(readedPixelsSettingsDocPath + READED_PIXELS_SETTINGS_FILENAME);

            readedPixelsSettingsWorkbook.Save(readedPixelsSettingsDocPath + READED_PIXELS_SETTINGS_FILENAME);
            LoadReadedPixelsSettings();
        }

        private void DeleteSetting(ReadedPixelsSetting readedPixelsSett)
        {
            //Cells[0, 0] = new Cell("ID");
            //Cells[0, 1] = new Cell("NAME");
            //Cells[0, 2] = new Cell("RECT COORDS");

            CellCollection cells = readedPixelsSettingsWorkbook.Worksheets[0].Cells;
            int idToRemove;
            for (int i = 1; i < cells.Rows.Count; i++)
            {
                if (int.TryParse(cells.Rows[i].GetCell(0).ToString(), out idToRemove)
                    && idToRemove == readedPixelsSett.Id)
                {
                    cells.Rows.Remove(i);
                    break;
                }
            }

            if (Directory.GetFiles(readedPixelsSettingsDocPath).Contains(readedPixelsSettingsDocPath + READED_PIXELS_SETTINGS_FILENAME))
                File.Delete(readedPixelsSettingsDocPath + READED_PIXELS_SETTINGS_FILENAME);

            readedPixelsSettingsWorkbook.Save(readedPixelsSettingsDocPath + READED_PIXELS_SETTINGS_FILENAME);
            LoadReadedPixelsSettings();
        }

        private void DeleteSetting(CaptureSetting captureSett)
        {
            //TODO
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

        private void drawButton_Click(object sender, EventArgs e)
        {
            //TODO manage the behavior of ReadedPixSettings
            //draw rect widht coor in numField
            //manage behavir of add button visiblity
            // andd and manage currentDrawedRect whos gonna be save if in current rdPixelsSettigns if click on add button

            //Rectangle rectangle = new Rectangle(XCoordPixelsReaded, YCoordPixelsReaded, WidthCoordPixelsReaded, HeightCoordPixelsReaded);
            //if (savedPixelSettingsCb.SelectedIndex == 0)//Set on Create Settings
            //{

            //    ReadedPixelsSettings newReadedPixSett = new ReadedPixelsSettings(newPixReadedSettingsId, "New Settings " + persPixelsSettingsCdw, new List<Rectangle>() { rectangle });
            //    readedPixSettings.Add(newReadedPixSett.Id, newReadedPixSett);
            //    savedPixelSettingsCb.Items.Add(newReadedPixSett);
            //    currentReadedPixelsSettings = readedPixSettings.Values.Last();
            //    savedPixelSettingsCb.SelectedIndex = savedPixelSettingsCb.Items.Count - 1;

            //    newPixReadedSettingsId++;
            //    persPixelsSettingsCdw++;

            //    captureForm.SetAndDrawRectangles(newReadedPixSett.Rectangles);
            //}
            //else
            //{
            //    currentReadedPixelsSettings.Rectangles.Add(rectangle);
            //    captureForm.SetAndDrawRectangles(currentReadedPixelsSettings.Rectangles
            //}
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
                    Id = newPixReadedSettingsId,
                    Name = createSettFom.NameTbText,
                    Rectangles = new List<Rectangle>()
                };
                CreateNewSettings(newRDPixSett);

            }
            newPixReadedSettingsId++;
        }

        private void saveCaptureSettBtn_Click(object sender, EventArgs e)
        {
            //TODO

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

        private void addRectBtn_Click(object sender, EventArgs e)
        {
            //TODO add drawed rectangle in list first manage drawedRectangle in capture form
        }

        private void modifyRectBtn_Click(object sender, EventArgs e)
        {
            //TODO data from rectangle in list box
        }

        private void deleteRectButton_Click(object sender, EventArgs e)
        {
            //TODO delete rectangle from
        }

        #endregion

        private void deleteSavedReadedPixBtn_Click(object sender, EventArgs e)
        {
            ReadedPixelsSetting settingToRemove;
            if (readedPixSettingsDict.TryGetValue((savedReadedPixelSettingsCb.SelectedItem as ReadedPixelsSetting).Id, out settingToRemove))
            {
                DeleteSetting(settingToRemove);
            }
        }
    }
}
