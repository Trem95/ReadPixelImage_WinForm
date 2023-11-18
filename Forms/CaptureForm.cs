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
        int selectedRectIndex;
        public CaptureForm()
        {
            rectanglesToDraw = new List<Rectangle>();
            selectedRectIndex = -1;
            this.AutoScrollMinSize = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            InitializeComponent();
        }

        public PictureBox CaptureImg { get { return capturePicBox; }}

        public void SetAndDrawRectangles(List<Rectangle> rectangles, int selectRect = -1)
        {
            selectedRectIndex = selectRect;
            rectanglesToDraw = rectangles;
            capturePicBox.Invalidate(); // force Redraw the form
        }

        public void SetSelectedRectangle(int selectRect)
        {
            selectedRectIndex = selectRect;
            capturePicBox.Invalidate();
        }

        private void capturePictureBox_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < rectanglesToDraw.Count(); i++)
                e.Graphics.DrawRectangle(selectedRectIndex == i ? Pens.Orange : Pens.LimeGreen, rectanglesToDraw[i]);
        }

        private void CaptureForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
