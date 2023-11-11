using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadPixelImage.CaptureSettings
{
    public class DefaultCaptureSettings : CaptureSetting
    {

        public DefaultCaptureSettings()
        {
            Name = "Default Capture Settings";
            X = 0;
            Y = 0;
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height;
        }
    }
}
