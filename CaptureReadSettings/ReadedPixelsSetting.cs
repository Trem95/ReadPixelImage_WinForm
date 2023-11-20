using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ReadPixelImage.CaptureReadSettings
{
    public class ReadedPixelsSetting
    {
        private int id;
        private string name;
        private List<Rectangle> rectangles;//TODO make propfull in every class and manage the exception in SettingsCaptureForm

        public ReadedPixelsSetting() { }
        public ReadedPixelsSetting(int id, string name, List<Rectangle> rects = null)
        {
            this.id = id;
            this.name = name;
            if (rects == null)
                rectangles = new List<Rectangle>();
            else
                rectangles = rects;
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

        public List<Rectangle> Rectangles
        {
            get { return rectangles; }
            set { rectangles = value; }
        }
        
        public void EditRectangle(Rectangle rectToEdit, int idToEdit)
        {
            rectangles[idToEdit] = rectToEdit;
        }

        public void RemoveRectangle(int idToRemove)
        {
            rectangles.RemoveAt(idToRemove);
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
