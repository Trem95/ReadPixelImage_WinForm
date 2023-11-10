using stdole;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadPixelImage
{
    public partial class MainForm : Form
    {
        List<Image> imageList = new List<Image>();
        List<string> imagePathList = new List<string>();

        ScreenReader screenReader = new ScreenReader();
        public MainForm()
        {
            InitializeComponent();
            LoadImages();
        }

        private void CaptureBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Console.WriteLine("SCREEN SIZE : " + Screen.PrimaryScreen.Bounds.Width + " / " + Screen.PrimaryScreen.Bounds.Height);
            Thread.Sleep(400);
            Image imgToShow =  rbBottom.Checked ? screenReader.GetBottomScreen() : screenReader.GetTopScreen();
            pictureBox1.BackgroundImage = imgToShow;
            this.Show();

        }

        private void DrawRectangle(PaintEventArgs e, float x = 10, float y = 10, float width = 200, float height = 200)
        {
            Pen pen = new Pen(Color.LimeGreen, 2);
            e.Graphics.DrawRectangle(pen, x, y, width, height);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //DrawRectangle(e);//Test to see what pixel to read
        }

        private void LoadImages()
        {

            foreach (var item in Directory.EnumerateFiles(@"C:\Users\antoi\Pictures\Screenshots\ReadPixelImage\ImageToRead"))
            {
                if (item.ToString().Contains(".png"))//TODO find better solution even if only for test
                { 
                    Console.WriteLine(item);//TODO transform item into image to show
                    imagePathList.Add(item);
                }
            }
        }
    }
}
