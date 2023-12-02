using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadPixelImage.Forms
{
    public partial class HealthCheckerDisplay : Form
    {
        List<Rectangle> rectanglesToDraw;
        int selectedRectIndex;
        public HealthCheckerDisplay()
        {
            rectanglesToDraw = new List<Rectangle>();
            selectedRectIndex = -1;
            InitializeComponent();
        }

        public PictureBox CaptureImg { get { return capturePicBox; } }

      
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

        private void displayPictureBox_Paint(object sender, PaintEventArgs e)
        {
            Pen orPen = new Pen(Color.Orange, 0.5F);
            Pen grPen = new Pen(Color.Orange, 0.5F);
            for (int i = 0; i < rectanglesToDraw.Count(); i++)
                e.Graphics.DrawRectangle(selectedRectIndex == i ? Pens.Orange : Pens.LimeGreen, rectanglesToDraw[i]);
        }

        private void healthCheckerDisplay_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
