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

namespace ReadPixelImage
{
    public partial class MainForm : Form
    {
        ScreenReader screenReader = new ScreenReader();
        public MainForm()
        {
            InitializeComponent();
        }

        private void CaptureScreen_button(object sender, EventArgs e)
        {
            this.Hide();
            Console.WriteLine("SCREEN SIZE : " + Screen.PrimaryScreen.Bounds.Width + " / " + Screen.PrimaryScreen.Bounds.Height);
            Thread.Sleep(400);
            Image imgToShow = screenReader.GetTopScreen();
            pictureBox1.BackgroundImage = imgToShow;
            this.Show();

        }
    }
}
