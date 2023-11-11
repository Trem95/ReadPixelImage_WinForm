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
        public CaptureForm()
        {
            InitializeComponent();
        }

        public PictureBox CaptureImg { get { return pictureBox1; } set { pictureBox1 = value; } }

        private void DrawRectangle(PaintEventArgs e, float x = 10, float y = 10, float width = 4, float height = 4)
        {
            Pen pen = new Pen(Color.LimeGreen, 2);
            e.Graphics.DrawRectangle(pen, x, y, width, height);
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            DrawRectangle(e);//Test to see what pixel to read
        }

        
    }
}
