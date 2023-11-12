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
            InitializeComponent();
        }

        public PictureBox CaptureImg { get { return pictureBox1; } set { pictureBox1 = value; } }

        public void SetAndDrawRectangles(List<Rectangle> rectangles)
        {
            rectanglesToDraw = rectangles;
            pictureBox1.Invalidate(); // force Redraw the form
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Rectangle rectangle in rectanglesToDraw)
            {
                e.Graphics.DrawRectangle(Pens.Lime, rectangle);
            }
        }

    }
}
