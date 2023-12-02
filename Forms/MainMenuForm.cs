using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadPixelImage.Forms
{
    public partial class MainMenuForm : Form
    {
        SettingsCaptureForm settingsCaptureForm;
        HealthCheckerForm healthChecker;
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            settingsCaptureForm = new SettingsCaptureForm();
            settingsCaptureForm.OwnerForm = this;
            settingsCaptureForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            healthChecker = new HealthCheckerForm();
            healthChecker.OwnerForm = this;
            healthChecker.Show();
            this.Hide();
        }
    }
}
