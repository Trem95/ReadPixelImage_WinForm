using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadPixelImage
{
    public partial class CaptureForm : Form
    {
        List<Rectangle> rectanglesToDraw;
        public CaptureForm()
        {
            rectanglesToDraw = new List<Rectangle>();
            this.AutoScrollMinSize = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            InitializeComponent();
        }

        public PictureBox CaptureImg { get { return capturePicBox; }}

        public void SetAndDrawRectangles(List<Rectangle> rectangles)
        {
            rectanglesToDraw = rectangles;
            capturePicBox.Invalidate(); // force Redraw the form
        }

        private void capturePictureBox_Paint(object sender, PaintEventArgs e)
        {
            foreach (Rectangle rectangle in rectanglesToDraw)
            {
                e.Graphics.DrawRectangle(Pens.Lime, rectangle);
            }
        }

        private void CaptureForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
