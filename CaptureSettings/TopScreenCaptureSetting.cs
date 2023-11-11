using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadPixelImage.CaptureSettings
{
    public class TopScreenCaptureSettings : CaptureSetting
    {
        public TopScreenCaptureSettings()
        {
            Name = "Top Screen Capture Settings";
            X = 0;
            Y = 0;
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height / 4;
        }
    }
}
