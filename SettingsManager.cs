using ExcelLibrary.SpreadSheet;
using ExcelLibrary;
using ReadPixelImage.CaptureReadSettings;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReadPixelImage.CaptureSettings;
using System.IO;
using System.Data;
using System.Configuration;
using System.Windows.Forms;
using System.Threading;

namespace ReadPixelImage
{
    public class SettingsManager
    {
        Workbook captureSettingsWorkbooks;
        Workbook readedPixelsSettingsWorkbook;

        string publicDocPath;
        string settingsDocPath;
        string imagesDocPath;
        string captureSettingsDocPath;
        string readedPixelsSettingsDocPath;

        int newCaptureSettingsId;
        int newReadedPixelsSettingsId;

        public const string CAPTURE_SETTINGS_FILENAME = "\\CaptureSettings.xls";
        public const string READED_PIXELS_SETTINGS_FILENAME = "\\ReadedPixelsSettings.xls";
        public SettingsManager()
        {
            captureSettingsWorkbooks = new Workbook();
            readedPixelsSettingsWorkbook = new Workbook();

            publicDocPath = Environment.ExpandEnvironmentVariables(@"%PUBLIC%\Documents");
            settingsDocPath = publicDocPath + @"\ReadPixelImage\Settings";
            imagesDocPath = publicDocPath + @"\ReadPixelImage\Images";
            captureSettingsDocPath = settingsDocPath + @"\Capture";
            readedPixelsSettingsDocPath = settingsDocPath + @"\Pixels";
        }

        public string PublicDocPath { get { return publicDocPath; } }
        public string SettingsDocPath { get { return settingsDocPath; } }
        public string ImagesDocPath { get { return imagesDocPath; } }
        public string CaptureSettingsDocPath { get { return captureSettingsDocPath; } }
        public string ReadedPixelsSettingsDocPath { get { return readedPixelsSettingsDocPath; } }
        public int NewCaptureSettingsId { get { return newCaptureSettingsId; } set { newCaptureSettingsId = value; } }
        public int NewReadedPixelsSettingsId { get { return newReadedPixelsSettingsId; } set { newReadedPixelsSettingsId = value; } }
        public void CreateExcellReadedPixelsSettingsFiles(out Dictionary<int, ReadedPixelsSetting> settingsDict)
        {
            DataSet ds = new DataSet();
            ds.Tables.Add("Default Settings");

            DataSetHelper.CreateWorkbook(readedPixelsSettingsDocPath + READED_PIXELS_SETTINGS_FILENAME, ds);
            readedPixelsSettingsWorkbook = Workbook.Load(readedPixelsSettingsDocPath + READED_PIXELS_SETTINGS_FILENAME);
            readedPixelsSettingsWorkbook.Worksheets[0].Cells[0, 0] = new Cell("ID");
            readedPixelsSettingsWorkbook.Worksheets[0].Cells[0, 1] = new Cell("NAME");
            readedPixelsSettingsWorkbook.Worksheets[0].Cells[0, 2] = new Cell("RECT COORDS");

            settingsDict = new Dictionary<int, ReadedPixelsSetting>();
            settingsDict.Add(0, new ReadedPixelsSetting()
            {
                Id = 0,
                Name = "Default",
                Rectangles = new List<Rectangle>() { new Rectangle(40, 40, 40, 40) }
            });

            CreateNewSetting(settingsDict.FirstOrDefault().Value);
            readedPixelsSettingsWorkbook.Save(readedPixelsSettingsDocPath + READED_PIXELS_SETTINGS_FILENAME);
        }

        public void CreateExcellCaptureSettingsFiles(out Dictionary<int, CaptureSetting> settingsDict)
        {
            DataSet ds = new DataSet();
            ds.Tables.Add("Default Settings");

            DataSetHelper.CreateWorkbook(captureSettingsDocPath + CAPTURE_SETTINGS_FILENAME, ds);
            captureSettingsWorkbooks = Workbook.Load(captureSettingsDocPath + CAPTURE_SETTINGS_FILENAME);
            captureSettingsWorkbooks.Worksheets[0].Cells[0, 0] = new Cell("ID");
            captureSettingsWorkbooks.Worksheets[0].Cells[0, 1] = new Cell("Name");
            captureSettingsWorkbooks.Worksheets[0].Cells[0, 2] = new Cell("X COORD");
            captureSettingsWorkbooks.Worksheets[0].Cells[0, 3] = new Cell("Y COORD");
            captureSettingsWorkbooks.Worksheets[0].Cells[0, 4] = new Cell("WIDTH");
            captureSettingsWorkbooks.Worksheets[0].Cells[0, 5] = new Cell("HEIGHT");

            settingsDict = new Dictionary<int, CaptureSetting>
            {
                {
                    0,
                    new CaptureSetting(0, "Default",
                    0,
                    0,
                    Screen.PrimaryScreen.Bounds.Width,
                    Screen.PrimaryScreen.Bounds.Height)
                },

                {
                    1,
                    new CaptureSetting(1, "Top Screen",
                    0,
                    0,
                    Screen.PrimaryScreen.Bounds.Width,
                    Screen.PrimaryScreen.Bounds.Height / 4)
                },

                {
                    2,
                    new CaptureSetting(2, "Bottom Screen",
                    0,
                    Screen.PrimaryScreen.Bounds.Height - (Screen.PrimaryScreen.Bounds.Height / 4),
                    Screen.PrimaryScreen.Bounds.Width,
                    Screen.PrimaryScreen.Bounds.Height / 4)
                },

                {
                    3,
                    new CaptureSetting(3, "Mafia II Health",
                    Screen.PrimaryScreen.Bounds.Width - (Screen.PrimaryScreen.Bounds.Width / 4),
                    Screen.PrimaryScreen.Bounds.Height - (Screen.PrimaryScreen.Bounds.Height / 3),
                    Screen.PrimaryScreen.Bounds.Width / 4,
                    Screen.PrimaryScreen.Bounds.Height / 3)
                }
            };

            foreach (KeyValuePair<int, CaptureSetting> kvp in settingsDict)
                CreateNewSetting(kvp.Value);

            captureSettingsWorkbooks.Save(captureSettingsDocPath + CAPTURE_SETTINGS_FILENAME);
        }

        /// <summary>
        /// Create a new Capture Settings and save it in the CaptureSettings.xls files
        /// </summary>
        /// <param name="captureSett"></param>
        public void CreateNewSetting(CaptureSetting captureSett)
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

            if (Directory.GetFiles(captureSettingsDocPath).Contains(captureSettingsDocPath + CAPTURE_SETTINGS_FILENAME))
                File.Delete(captureSettingsDocPath + CAPTURE_SETTINGS_FILENAME);

            captureSettingsWorkbooks.Save(captureSettingsDocPath + CAPTURE_SETTINGS_FILENAME);
        }

        /// <summary>
        /// Create a new Capture Settings and save it in the CaptureSettings.xls files
        /// </summary>
        /// <param name="readedPixelsSett"></param>
        public void CreateNewSetting(ReadedPixelsSetting readedPixelsSett)
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

            if (Directory.GetFiles(readedPixelsSettingsDocPath).Contains(readedPixelsSettingsDocPath + READED_PIXELS_SETTINGS_FILENAME))
                File.Delete(readedPixelsSettingsDocPath + READED_PIXELS_SETTINGS_FILENAME);

            readedPixelsSettingsWorkbook.Save(readedPixelsSettingsDocPath + READED_PIXELS_SETTINGS_FILENAME);
        }

        /// <summary>
        /// Load the data from the setting workbook in the severals controls
        /// </summary>
        public void LoadCaptureSettings(out Dictionary<int, CaptureSetting> settingsDict)
        {
            settingsDict = new Dictionary<int, CaptureSetting>();
            newCaptureSettingsId = 1;
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
                settingsDict.Add(captSettToAdd.Id, captSettToAdd);

                //Saved last Id in order to save new settings later
                if (i == captureSettingsWorkbooks.Worksheets[0].Cells.Rows.Count() - 1)
                    newCaptureSettingsId = captSettToAdd.Id + 1;
            }
        }
        /// <summary>
        /// Load the data from the setting workbook in the severals controls
        /// </summary>
        public void LoadReadedPixelsSettings(out Dictionary<int, ReadedPixelsSetting> settingsDict)
        {
            settingsDict = new Dictionary<int, ReadedPixelsSetting>();
            newReadedPixelsSettingsId = 1;

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

                settingsDict.Add(readedPixSettToAdd.Id, readedPixSettToAdd);

                if (i == readedPixelsSettingsWorkbook.Worksheets[0].Cells.Rows.Count() - 1)
                    newReadedPixelsSettingsId = readedPixSettToAdd.Id + 1;
            }

        }

        /// <summary>
        /// Load the images presents in Public folders
        /// </summary>
        public void LoadImages(out Dictionary<string,Bitmap> imageDict)
        {
            imageDict = new Dictionary<string, Bitmap>();
            foreach (var item in Directory.EnumerateFiles(imagesDocPath + "\\Loaded"))
            {
                if (item.ToString().Contains(".png") || item.ToString().Contains(".jpeg"))
                {
                    Bitmap imgToAdd = new Bitmap(item.ToString());
                    string imgName = item.Substring((imagesDocPath + "\\Loaded").Length + 1);
                    imageDict.Add(imgName, imgToAdd);
                }
            }
        }

        public void EditSetting(CaptureSetting captToEdit)
        {

            CellCollection cells = captureSettingsWorkbooks.Worksheets[0].Cells;
            Row rowToEdit = new Row();
            for (int i = 1; i < cells.Rows.Count(); i++)
            {
                int verifInt;
                if (int.TryParse(cells.Rows[i].GetCell(0).Value.ToString(), out verifInt) && verifInt == captToEdit.Id)
                {
                    rowToEdit = cells.Rows[i];
                    break;
                }
            }
            //Cells[0, 0] = "ID"
            //Cells[0, 1] = "Name"
            //Cells[0, 2] = "X COORD"
            //Cells[0, 3] = "Y COORD"
            //Cells[0, 4] = "WIDTH"
            //Cells[0, 5] = "HEIGHT"
            rowToEdit.GetCell(1).Value = captToEdit.Name;
            rowToEdit.GetCell(2).Value = captToEdit.X;
            rowToEdit.GetCell(3).Value = captToEdit.Y;
            rowToEdit.GetCell(4).Value = captToEdit.Width;
            rowToEdit.GetCell(5).Value = captToEdit.Height;

            if (Directory.GetFiles(readedPixelsSettingsDocPath).Contains(readedPixelsSettingsDocPath + READED_PIXELS_SETTINGS_FILENAME))
                File.Delete(readedPixelsSettingsDocPath + READED_PIXELS_SETTINGS_FILENAME);

            captureSettingsWorkbooks.Save(captureSettingsDocPath + CAPTURE_SETTINGS_FILENAME);
        }

        public void EditSetting(ReadedPixelsSetting readedPixelsSett)
        {

            CellCollection cells = readedPixelsSettingsWorkbook.Worksheets[0].Cells;
            Row rowToEdit = new Row();
            int rowIndex = -1;
            for (int i = 1; i < cells.Rows.Count(); i++)
            {
                int verifInt;
                if (int.TryParse(cells.Rows[i].GetCell(0).Value.ToString(), out verifInt) && verifInt == readedPixelsSett.Id)
                {
                    rowToEdit = cells.Rows[i];
                    rowIndex = i;
                    break;
                }
            }
            //Cells[0, 0] = "ID"
            //Cells[0, 1] = "Name"
            //Cells[0, 2] = "RECTANGLES"
            rowToEdit.GetCell(1).Value = readedPixelsSett.Name;

            for (int i = 2; i < rowToEdit.LastColIndex; i++)//Delete all old rectangle entry in the excell file
            {
                rowToEdit.SetCell(i, new Cell(""));
            }

            for (int i = 0; i < readedPixelsSett.Rectangles.Count(); i++)
            {
                Rectangle rectToAdd = readedPixelsSett.Rectangles[i];
                rowToEdit.SetCell(2 + i, new Cell($"{rectToAdd.X}|{rectToAdd.Y}|{rectToAdd.Width}|{rectToAdd.Height}"));
            }

            if (Directory.GetFiles(readedPixelsSettingsDocPath).Contains(readedPixelsSettingsDocPath + READED_PIXELS_SETTINGS_FILENAME))
                File.Delete(readedPixelsSettingsDocPath + READED_PIXELS_SETTINGS_FILENAME);

            Thread.Sleep(750);
            readedPixelsSettingsWorkbook.Save(readedPixelsSettingsDocPath + READED_PIXELS_SETTINGS_FILENAME);
        }

        public void DeleteSetting(CaptureSetting captureSett)
        {
            CellCollection cells = captureSettingsWorkbooks.Worksheets[0].Cells;
            int idToRemove;
            for (int i = 1; i < cells.Rows.Count; i++)
            {
                if (int.TryParse(cells.Rows[i].GetCell(0).ToString(), out idToRemove)
                    && idToRemove == captureSett.Id)
                {
                    cells.Rows.Remove(i);
                    if (i < cells.Rows.Count)
                    {

                        if (i + 1 < cells.Rows.Count)
                        {
                            for (int j = i + 1; j < cells.Rows.Count; j++)
                            {
                                cells.Rows[j - 1] = cells.Rows[j];
                                cells.Rows[j - 1].GetCell(0).Value = j - 1;//ID
                            }
                        }
                        else
                        {
                            cells.Rows[i] = cells.Rows[i + 1];
                            cells.Rows[i].GetCell(0).Value = i;
                        }

                        cells.Rows.Remove(cells.Rows.Last().Key);
                    }
                    break;
                }
            }

            if (Directory.GetFiles(captureSettingsDocPath).Contains(captureSettingsDocPath + CAPTURE_SETTINGS_FILENAME))
                File.Delete(captureSettingsDocPath + CAPTURE_SETTINGS_FILENAME);

            Thread.Sleep(750);
            captureSettingsWorkbooks.Save(captureSettingsDocPath + CAPTURE_SETTINGS_FILENAME);
        }

        public void DeleteSetting(ReadedPixelsSetting readedPixelsSett)
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
                    if (i < cells.Rows.Count)
                    {
                        if (i + 1 < cells.Rows.Count)
                        {
                            for (int j = i + 1; j < cells.Rows.Count; j++)
                            {
                                cells.Rows[j - 1] = cells.Rows[j];
                                cells.Rows[j - 1].GetCell(0).Value = j - 1;//ID
                            }
                        }
                        else
                        {
                            cells.Rows[i] = cells.Rows[i + 1];
                            cells.Rows[i].GetCell(0).Value = i;
                        }

                        cells.Rows.Remove(cells.Rows.Last().Key);
                    }

                    break;
                }
            }

            if (Directory.GetFiles(readedPixelsSettingsDocPath).Contains(readedPixelsSettingsDocPath + READED_PIXELS_SETTINGS_FILENAME))
                File.Delete(readedPixelsSettingsDocPath + READED_PIXELS_SETTINGS_FILENAME);

            Thread.Sleep(750);
            readedPixelsSettingsWorkbook.Save(readedPixelsSettingsDocPath + READED_PIXELS_SETTINGS_FILENAME);
        }
    }
}
