using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadPixelImage.CaptureReadSettings
{
    public class ReadedPixelsSettings
    {
        public ReadedPixelsSettings() { }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Rectangle> Rectangles { get; set; }
    }
}
