using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadPixelImage.CaptureSettings
{
    public class DownScreenCaptureSetting : CaptureSetting
    {
        public DownScreenCaptureSetting()
        {
            Name = "Down Screen Capture Settings";
            X = 0;
            Y = Screen.PrimaryScreen.Bounds.Height - (Screen.PrimaryScreen.Bounds.Height / 4);
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height / 4;
        }
    }
}
