using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadPixelImage.CaptureSettings
{
    public class Mafia2HealthCaptureSetting : CaptureSetting
    {
        public Mafia2HealthCaptureSetting()
        {
            Name = "Mafia II Health Capture Setting";
            X = Screen.PrimaryScreen.Bounds.Width - (Screen.PrimaryScreen.Bounds.Width / 4);
            Y = Screen.PrimaryScreen.Bounds.Height - (Screen.PrimaryScreen.Bounds.Height / 3);
            Width = Screen.PrimaryScreen.Bounds.Width / 4;
            Height = Screen.PrimaryScreen.Bounds.Height / 3;
        }
        //public string Name { get { return "Mafia II Health Capture Settings"; } }
        //public int X { get { return Screen.PrimaryScreen.Bounds.Width - (Screen.PrimaryScreen.Bounds.Width / 4); } set { X = value; } }
        //public int Y { get { return Screen.PrimaryScreen.Bounds.Height - (Screen.PrimaryScreen.Bounds.Height / 3); } set { X = value; } }
        //public int Width { get { return Screen.PrimaryScreen.Bounds.Width / 4; } set { Width = value; } }
        //public int Height { get { return Screen.PrimaryScreen.Bounds.Height / 3; } set { Height = value; } }
    }
}
