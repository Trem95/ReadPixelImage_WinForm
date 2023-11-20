using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadPixelImage.CaptureSettings
{
    public class CaptureSetting
    {
        private int id;
        private string name;
        private int x;
        private int y;
        private int width;
        private int height;

        public CaptureSetting() {}
        public CaptureSetting(int id, string name, int x, int y, int width, int height)
        {
            Id = id;
            Name = name;
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
