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
    public partial class CreateSettingForm : Form
    {
        public CreateSettingForm()
        {
            InitializeComponent();
        }
        public String NameTbText { get { return nameTb.Text; } set { nameTb.Text = value;} }

        private void createBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void nameTb_TextChanged(object sender, EventArgs e)
        {
            createBtn.Enabled = nameTb.Text.Length > 0;
        }
    }
}
