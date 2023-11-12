namespace ReadPixelImage
{
    partial class SettingsCaptureForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.captureBtn = new System.Windows.Forms.Button();
            this.settingsGb = new System.Windows.Forms.GroupBox();
            this.pixelsReadedGb = new System.Windows.Forms.GroupBox();
            this.yCoordLbl = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.drawButton = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.widthLbl = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.xCoordLbl = new System.Windows.Forms.Label();
            this.captureSettingsGb = new System.Windows.Forms.GroupBox();
            this.loadedImgLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loadedImgCb = new System.Windows.Forms.ComboBox();
            this.savedSettingsCb = new System.Windows.Forms.ComboBox();
            this.yCaptureLbl = new System.Windows.Forms.Label();
            this.xCaptureNb = new System.Windows.Forms.NumericUpDown();
            this.widthCaptureNb = new System.Windows.Forms.NumericUpDown();
            this.heightCpatureLbl = new System.Windows.Forms.Label();
            this.yCaptureNb = new System.Windows.Forms.NumericUpDown();
            this.widthCaptureLbl = new System.Windows.Forms.Label();
            this.heightCaptureNb = new System.Windows.Forms.NumericUpDown();
            this.xCaptureLbl = new System.Windows.Forms.Label();
            this.applySettingsBtn = new System.Windows.Forms.Button();
            this.pixelReadedRectsListBox = new System.Windows.Forms.ListBox();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.settingsGb.SuspendLayout();
            this.pixelsReadedGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.captureSettingsGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xCaptureNb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthCaptureNb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yCaptureNb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightCaptureNb)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.captureBtn);
            this.panel1.Controls.Add(this.settingsGb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1167, 243);
            this.panel1.TabIndex = 0;
            // 
            // captureBtn
            // 
            this.captureBtn.AutoSize = true;
            this.captureBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.captureBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.captureBtn.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captureBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.captureBtn.Location = new System.Drawing.Point(44, 65);
            this.captureBtn.Margin = new System.Windows.Forms.Padding(20);
            this.captureBtn.Name = "captureBtn";
            this.captureBtn.Size = new System.Drawing.Size(285, 108);
            this.captureBtn.TabIndex = 5;
            this.captureBtn.Text = "Capture";
            this.captureBtn.UseVisualStyleBackColor = false;
            this.captureBtn.Click += new System.EventHandler(this.CaptureBtn_Click);
            // 
            // settingsGb
            // 
            this.settingsGb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.settingsGb.Controls.Add(this.pixelsReadedGb);
            this.settingsGb.Controls.Add(this.captureSettingsGb);
            this.settingsGb.Dock = System.Windows.Forms.DockStyle.Right;
            this.settingsGb.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsGb.Location = new System.Drawing.Point(381, 0);
            this.settingsGb.Margin = new System.Windows.Forms.Padding(10);
            this.settingsGb.Name = "settingsGb";
            this.settingsGb.Size = new System.Drawing.Size(786, 243);
            this.settingsGb.TabIndex = 9;
            this.settingsGb.TabStop = false;
            this.settingsGb.Text = "Settings";
            // 
            // pixelsReadedGb
            // 
            this.pixelsReadedGb.Controls.Add(this.button1);
            this.pixelsReadedGb.Controls.Add(this.modifyBtn);
            this.pixelsReadedGb.Controls.Add(this.pixelReadedRectsListBox);
            this.pixelsReadedGb.Controls.Add(this.yCoordLbl);
            this.pixelsReadedGb.Controls.Add(this.numericUpDown1);
            this.pixelsReadedGb.Controls.Add(this.drawButton);
            this.pixelsReadedGb.Controls.Add(this.numericUpDown2);
            this.pixelsReadedGb.Controls.Add(this.label4);
            this.pixelsReadedGb.Controls.Add(this.numericUpDown3);
            this.pixelsReadedGb.Controls.Add(this.widthLbl);
            this.pixelsReadedGb.Controls.Add(this.numericUpDown4);
            this.pixelsReadedGb.Controls.Add(this.xCoordLbl);
            this.pixelsReadedGb.Dock = System.Windows.Forms.DockStyle.Right;
            this.pixelsReadedGb.Location = new System.Drawing.Point(401, 19);
            this.pixelsReadedGb.Name = "pixelsReadedGb";
            this.pixelsReadedGb.Size = new System.Drawing.Size(382, 221);
            this.pixelsReadedGb.TabIndex = 15;
            this.pixelsReadedGb.TabStop = false;
            this.pixelsReadedGb.Text = "Pixels Readed";
            // 
            // yCoordLbl
            // 
            this.yCoordLbl.AutoSize = true;
            this.yCoordLbl.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yCoordLbl.Location = new System.Drawing.Point(26, 65);
            this.yCoordLbl.Name = "yCoordLbl";
            this.yCoordLbl.Size = new System.Drawing.Size(27, 14);
            this.yCoordLbl.TabIndex = 11;
            this.yCoordLbl.Text = "Y : ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(86, 35);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(65, 22);
            this.numericUpDown1.TabIndex = 6;
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(16, 92);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(104, 28);
            this.drawButton.TabIndex = 13;
            this.drawButton.Text = "Draw";
            this.drawButton.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.Location = new System.Drawing.Point(217, 64);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(65, 22);
            this.numericUpDown2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(157, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "Height :";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown3.Location = new System.Drawing.Point(86, 64);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(65, 22);
            this.numericUpDown3.TabIndex = 8;
            // 
            // widthLbl
            // 
            this.widthLbl.AutoSize = true;
            this.widthLbl.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLbl.Location = new System.Drawing.Point(157, 65);
            this.widthLbl.Name = "widthLbl";
            this.widthLbl.Size = new System.Drawing.Size(51, 14);
            this.widthLbl.TabIndex = 12;
            this.widthLbl.Text = "Width :";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown4.Location = new System.Drawing.Point(217, 35);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(65, 22);
            this.numericUpDown4.TabIndex = 9;
            // 
            // xCoordLbl
            // 
            this.xCoordLbl.AutoSize = true;
            this.xCoordLbl.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xCoordLbl.Location = new System.Drawing.Point(26, 38);
            this.xCoordLbl.Name = "xCoordLbl";
            this.xCoordLbl.Size = new System.Drawing.Size(24, 14);
            this.xCoordLbl.TabIndex = 10;
            this.xCoordLbl.Text = "X :";
            // 
            // captureSettingsGb
            // 
            this.captureSettingsGb.Controls.Add(this.applySettingsBtn);
            this.captureSettingsGb.Controls.Add(this.loadedImgLbl);
            this.captureSettingsGb.Controls.Add(this.label1);
            this.captureSettingsGb.Controls.Add(this.loadedImgCb);
            this.captureSettingsGb.Controls.Add(this.savedSettingsCb);
            this.captureSettingsGb.Controls.Add(this.yCaptureLbl);
            this.captureSettingsGb.Controls.Add(this.xCaptureNb);
            this.captureSettingsGb.Controls.Add(this.widthCaptureNb);
            this.captureSettingsGb.Controls.Add(this.heightCpatureLbl);
            this.captureSettingsGb.Controls.Add(this.yCaptureNb);
            this.captureSettingsGb.Controls.Add(this.widthCaptureLbl);
            this.captureSettingsGb.Controls.Add(this.heightCaptureNb);
            this.captureSettingsGb.Controls.Add(this.xCaptureLbl);
            this.captureSettingsGb.Dock = System.Windows.Forms.DockStyle.Left;
            this.captureSettingsGb.Location = new System.Drawing.Point(3, 19);
            this.captureSettingsGb.Name = "captureSettingsGb";
            this.captureSettingsGb.Size = new System.Drawing.Size(392, 221);
            this.captureSettingsGb.TabIndex = 14;
            this.captureSettingsGb.TabStop = false;
            this.captureSettingsGb.Text = "Capture";
            // 
            // loadedImgLbl
            // 
            this.loadedImgLbl.AutoSize = true;
            this.loadedImgLbl.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadedImgLbl.Location = new System.Drawing.Point(18, 166);
            this.loadedImgLbl.Name = "loadedImgLbl";
            this.loadedImgLbl.Size = new System.Drawing.Size(107, 14);
            this.loadedImgLbl.TabIndex = 21;
            this.loadedImgLbl.Text = "Loaded Images :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 14);
            this.label1.TabIndex = 22;
            this.label1.Text = "Saved Settings :";
            // 
            // loadedImgCb
            // 
            this.loadedImgCb.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadedImgCb.FormattingEnabled = true;
            this.loadedImgCb.Location = new System.Drawing.Point(18, 183);
            this.loadedImgCb.Name = "loadedImgCb";
            this.loadedImgCb.Size = new System.Drawing.Size(362, 22);
            this.loadedImgCb.TabIndex = 8;
            this.loadedImgCb.SelectionChangeCommitted += new System.EventHandler(this.imageChooseCb_SelectionChangeCommitted);
            // 
            // savedSettingsCb
            // 
            this.savedSettingsCb.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savedSettingsCb.FormattingEnabled = true;
            this.savedSettingsCb.Location = new System.Drawing.Point(18, 132);
            this.savedSettingsCb.Name = "savedSettingsCb";
            this.savedSettingsCb.Size = new System.Drawing.Size(362, 22);
            this.savedSettingsCb.TabIndex = 21;
            this.savedSettingsCb.SelectionChangeCommitted += new System.EventHandler(this.savedSettingsCb_SelectionChangeCommitted);
            // 
            // yCaptureLbl
            // 
            this.yCaptureLbl.AutoSize = true;
            this.yCaptureLbl.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yCaptureLbl.Location = new System.Drawing.Point(18, 60);
            this.yCaptureLbl.Name = "yCaptureLbl";
            this.yCaptureLbl.Size = new System.Drawing.Size(27, 14);
            this.yCaptureLbl.TabIndex = 19;
            this.yCaptureLbl.Text = "Y : ";
            // 
            // xCaptureNb
            // 
            this.xCaptureNb.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xCaptureNb.Location = new System.Drawing.Point(78, 30);
            this.xCaptureNb.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.xCaptureNb.Name = "xCaptureNb";
            this.xCaptureNb.Size = new System.Drawing.Size(65, 22);
            this.xCaptureNb.TabIndex = 14;
            // 
            // widthCaptureNb
            // 
            this.widthCaptureNb.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthCaptureNb.Location = new System.Drawing.Point(209, 59);
            this.widthCaptureNb.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.widthCaptureNb.Name = "widthCaptureNb";
            this.widthCaptureNb.Size = new System.Drawing.Size(65, 22);
            this.widthCaptureNb.TabIndex = 15;
            // 
            // heightCpatureLbl
            // 
            this.heightCpatureLbl.AutoSize = true;
            this.heightCpatureLbl.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightCpatureLbl.Location = new System.Drawing.Point(149, 33);
            this.heightCpatureLbl.Name = "heightCpatureLbl";
            this.heightCpatureLbl.Size = new System.Drawing.Size(55, 14);
            this.heightCpatureLbl.TabIndex = 13;
            this.heightCpatureLbl.Text = "Height :";
            // 
            // yCaptureNb
            // 
            this.yCaptureNb.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yCaptureNb.Location = new System.Drawing.Point(78, 59);
            this.yCaptureNb.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.yCaptureNb.Name = "yCaptureNb";
            this.yCaptureNb.Size = new System.Drawing.Size(65, 22);
            this.yCaptureNb.TabIndex = 16;
            // 
            // widthCaptureLbl
            // 
            this.widthCaptureLbl.AutoSize = true;
            this.widthCaptureLbl.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthCaptureLbl.Location = new System.Drawing.Point(149, 60);
            this.widthCaptureLbl.Name = "widthCaptureLbl";
            this.widthCaptureLbl.Size = new System.Drawing.Size(51, 14);
            this.widthCaptureLbl.TabIndex = 20;
            this.widthCaptureLbl.Text = "Width :";
            // 
            // heightCaptureNb
            // 
            this.heightCaptureNb.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightCaptureNb.Location = new System.Drawing.Point(209, 30);
            this.heightCaptureNb.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.heightCaptureNb.Name = "heightCaptureNb";
            this.heightCaptureNb.Size = new System.Drawing.Size(65, 22);
            this.heightCaptureNb.TabIndex = 17;
            // 
            // xCaptureLbl
            // 
            this.xCaptureLbl.AutoSize = true;
            this.xCaptureLbl.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xCaptureLbl.Location = new System.Drawing.Point(18, 33);
            this.xCaptureLbl.Name = "xCaptureLbl";
            this.xCaptureLbl.Size = new System.Drawing.Size(24, 14);
            this.xCaptureLbl.TabIndex = 18;
            this.xCaptureLbl.Text = "X :";
            // 
            // applySettingsBtn
            // 
            this.applySettingsBtn.Location = new System.Drawing.Point(114, 87);
            this.applySettingsBtn.Name = "applySettingsBtn";
            this.applySettingsBtn.Size = new System.Drawing.Size(122, 28);
            this.applySettingsBtn.TabIndex = 14;
            this.applySettingsBtn.Text = "Apply";
            this.applySettingsBtn.UseVisualStyleBackColor = true;
            this.applySettingsBtn.Click += new System.EventHandler(this.applySettingsBtn_Click);
            // 
            // pixelReadedRectsListBox
            // 
            this.pixelReadedRectsListBox.FormattingEnabled = true;
            this.pixelReadedRectsListBox.HorizontalScrollbar = true;
            this.pixelReadedRectsListBox.ItemHeight = 16;
            this.pixelReadedRectsListBox.Location = new System.Drawing.Point(16, 126);
            this.pixelReadedRectsListBox.Name = "pixelReadedRectsListBox";
            this.pixelReadedRectsListBox.Size = new System.Drawing.Size(354, 84);
            this.pixelReadedRectsListBox.TabIndex = 14;
            // 
            // modifyBtn
            // 
            this.modifyBtn.Location = new System.Drawing.Point(144, 92);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(104, 28);
            this.modifyBtn.TabIndex = 15;
            this.modifyBtn.Text = "Modify";
            this.modifyBtn.UseVisualStyleBackColor = true;
            this.modifyBtn.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 28);
            this.button1.TabIndex = 16;
            this.button1.Text = "Modify";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // SettingsCaptureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 245);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1185, 284);
            this.MinimumSize = new System.Drawing.Size(1185, 284);
            this.Name = "SettingsCaptureForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.settingsGb.ResumeLayout(false);
            this.pixelsReadedGb.ResumeLayout(false);
            this.pixelsReadedGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.captureSettingsGb.ResumeLayout(false);
            this.captureSettingsGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xCaptureNb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthCaptureNb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yCaptureNb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightCaptureNb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button captureBtn;
        private System.Windows.Forms.ComboBox loadedImgCb;
        private System.Windows.Forms.Label loadedImgLbl;
        private System.Windows.Forms.GroupBox settingsGb;
        private System.Windows.Forms.GroupBox pixelsReadedGb;
        private System.Windows.Forms.Label yCoordLbl;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label widthLbl;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label xCoordLbl;
        private System.Windows.Forms.GroupBox captureSettingsGb;
        private System.Windows.Forms.Label yCaptureLbl;
        private System.Windows.Forms.NumericUpDown xCaptureNb;
        private System.Windows.Forms.NumericUpDown widthCaptureNb;
        private System.Windows.Forms.Label heightCpatureLbl;
        private System.Windows.Forms.NumericUpDown yCaptureNb;
        private System.Windows.Forms.Label widthCaptureLbl;
        private System.Windows.Forms.NumericUpDown heightCaptureNb;
        private System.Windows.Forms.Label xCaptureLbl;
        private System.Windows.Forms.ComboBox savedSettingsCb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button applySettingsBtn;
        private System.Windows.Forms.ListBox pixelReadedRectsListBox;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.Button button1;
    }
}

