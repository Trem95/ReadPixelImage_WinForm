﻿using System;
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
    public partial class CreateReadedPixelsSettingForm : Form
    {
        DialogResult result;
        public CreateReadedPixelsSettingForm()
        {
            InitializeComponent();
            result = DialogResult.Cancel;
        }
        public String NameTbText { get { return nameTb.Text; } set { nameTb.Text = value;} }
        public DialogResult Result { get { return result; } set { result = value; } }
        private void createBtn_Click(object sender, EventArgs e)
        {
            result = DialogResult.OK;
            this.Hide();
        }

        private void nameTb_TextChanged(object sender, EventArgs e)
        {
            createBtn.Enabled = nameTb.Text.Length > 0;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            result = DialogResult.Cancel;
            this.Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            this.Hide();
           
        }
    }
}
