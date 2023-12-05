using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadPixelImage.Forms.HealthChecker
{
    public partial class StreamDisplay : Form
    {
        public StreamDisplay()
        {
            InitializeComponent();
        }

        public WebView2 WebView { get { return streamView; } set {streamView = value ;} }
    }
}
