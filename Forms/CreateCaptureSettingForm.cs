using ReadPixelImage.CaptureSettings;
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
    public partial class CreateOrEditCaptureSettingForm : Form
    {
        CaptureSetting captureSett;
        DialogResult result = DialogResult.Cancel;
        public CreateOrEditCaptureSettingForm(CaptureSetting captSettToEdit)
        {
            captureSett = captSettToEdit;
            InitializeComponent();
            yCaptureNb.Maximum = Screen.PrimaryScreen.Bounds.Height;
            xCaptureNb.Maximum = Screen.PrimaryScreen.Bounds.Width;
            heightCaptureNb.Maximum = Screen.PrimaryScreen.Bounds.Height;
            widthCaptureNb.Maximum = Screen.PrimaryScreen.Bounds.Width;

            yCaptureNb.Value = captureSett.Y;
            xCaptureNb.Value = captureSett.X;
            heightCaptureNb.Value = captureSett.Height;
            widthCaptureNb.Value = captureSett.Width;

            createOrEditBtn.Text = "Edit";
            this.Text = "Edit Capture Setting";
            nameTb.Text = captureSett.Name;
        }
        public CreateOrEditCaptureSettingForm()//Constructor for new setting
        {
            InitializeComponent();
            yCaptureNb.Maximum = Screen.PrimaryScreen.Bounds.Height;
            xCaptureNb.Maximum = Screen.PrimaryScreen.Bounds.Width;
            heightCaptureNb.Maximum = Screen.PrimaryScreen.Bounds.Height;
            widthCaptureNb.Maximum = Screen.PrimaryScreen.Bounds.Width;

            createOrEditBtn.Text = "Create";
            this.Text = "Create Capture Setting";

        }

        public CaptureSetting CaptureSetting { get { return captureSett; } }
        public DialogResult Result { get { return result; } set { result = value; } }

        private void createOrEditBtn_Click(object sender, EventArgs e)
        {
            if (CheckNumFieldValues())
            {
                if (captureSett == null)//New capture to create
                {
                    captureSett = new CaptureSetting()
                    {
                        Id = -1,//Set when addind to excell file
                        Name = nameTb.Text,
                        X = int.Parse(xCaptureNb.Value.ToString()),
                        Y = int.Parse(yCaptureNb.Value.ToString()),
                        Height = int.Parse(heightCaptureNb.Value.ToString()),
                        Width = int.Parse(widthCaptureNb.Value.ToString()),
                    };
                    result = DialogResult.OK;
                }
                else//Capture setting to edit
                {
                    captureSett.Name = nameTb.Text;
                    captureSett.X = int.Parse(xCaptureNb.Value.ToString());
                    captureSett.Y = int.Parse(yCaptureNb.Value.ToString());
                    captureSett.Height = int.Parse(heightCaptureNb.Value.ToString());
                    captureSett.Width = int.Parse(widthCaptureNb.Value.ToString());
                    result = DialogResult.OK;
                }

                this.Hide();
            }
            else
                MessageBox.Show("Numerical Field Error", "Error");
        }

        private bool CheckNumFieldValues()
        {
            if (widthCaptureNb.Value == 0 || heightCaptureNb.Value == 0)
                return false;
            if (xCaptureNb.Value >= Screen.PrimaryScreen.Bounds.Width || yCaptureNb.Value >= Screen.PrimaryScreen.Bounds.Height)
                return false;

            return true;
        }

        private void nameTb_TextChanged(object sender, EventArgs e)
        {
            createOrEditBtn.Enabled = nameTb.Text.Length > 0;
        }
    }
}
