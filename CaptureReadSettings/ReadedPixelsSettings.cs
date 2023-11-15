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
        public ReadedPixelsSettings() {}
        public ReadedPixelsSettings(int id, string name, List<Rectangle> rects = null) 
        {
            Id = id;
            Name = name;
            if (rects == null)
                Rectangles = new List<Rectangle>();
            else
                Rectangles = rects;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Rectangle> Rectangles { get; set; }

        public override string ToString()
        {
            return $"{Id} - {Name}";
        }
    }
}
