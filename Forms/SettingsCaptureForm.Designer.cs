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
            this.loadedImgLbl = new System.Windows.Forms.Label();
            this.settingsGb = new System.Windows.Forms.GroupBox();
            this.pixelsReadedGb = new System.Windows.Forms.GroupBox();
            this.deleteSavedReadedPixBtn = new System.Windows.Forms.Button();
            this.modifyRectBtn = new System.Windows.Forms.Button();
            this.applyPixSettBtn = new System.Windows.Forms.Button();
            this.createNewPixSettBtn = new System.Windows.Forms.Button();
            this.savedPixelSettingsLb = new System.Windows.Forms.Label();
            this.savedReadedPixelSettingsCb = new System.Windows.Forms.ComboBox();
            this.deleteRectButton = new System.Windows.Forms.Button();
            this.addRectBtn = new System.Windows.Forms.Button();
            this.readedPixelsRectsListBox = new System.Windows.Forms.ListBox();
            this.yPixelsLbl = new System.Windows.Forms.Label();
            this.xPixelsNb = new System.Windows.Forms.NumericUpDown();
            this.drawButton = new System.Windows.Forms.Button();
            this.widthPixelsNb = new System.Windows.Forms.NumericUpDown();
            this.heightPixelsLbl = new System.Windows.Forms.Label();
            this.yPixelsNb = new System.Windows.Forms.NumericUpDown();
            this.widthPixelsLbl = new System.Windows.Forms.Label();
            this.heightPixelsNb = new System.Windows.Forms.NumericUpDown();
            this.xPixelsLbl = new System.Windows.Forms.Label();
            this.captureSettingsGb = new System.Windows.Forms.GroupBox();
            this.deleteCaptSet = new System.Windows.Forms.Button();
            this.editCaptureSettBtn = new System.Windows.Forms.Button();
            this.createNewCaptureSettBtn = new System.Windows.Forms.Button();
            this.applyChosenSettingsBtn = new System.Windows.Forms.Button();
            this.applyTempCappSettBtn = new System.Windows.Forms.Button();
            this.savedCaptureSettingsLb = new System.Windows.Forms.Label();
            this.savedCaptureSettingsCb = new System.Windows.Forms.ComboBox();
            this.yCaptureLbl = new System.Windows.Forms.Label();
            this.xCaptureNb = new System.Windows.Forms.NumericUpDown();
            this.widthCaptureNb = new System.Windows.Forms.NumericUpDown();
            this.heightCaptureLbl = new System.Windows.Forms.Label();
            this.yCaptureNb = new System.Windows.Forms.NumericUpDown();
            this.widthCaptureLbl = new System.Windows.Forms.Label();
            this.heightCaptureNb = new System.Windows.Forms.NumericUpDown();
            this.xCaptureLbl = new System.Windows.Forms.Label();
            this.loadedImgCb = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.settingsGb.SuspendLayout();
            this.pixelsReadedGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xPixelsNb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthPixelsNb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yPixelsNb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightPixelsNb)).BeginInit();
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
            this.panel1.Controls.Add(this.loadedImgLbl);
            this.panel1.Controls.Add(this.settingsGb);
            this.panel1.Controls.Add(this.loadedImgCb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1167, 393);
            this.panel1.TabIndex = 0;
            // 
            // captureBtn
            // 
            this.captureBtn.AutoSize = true;
            this.captureBtn.BackColor = System.Drawing.Color.Indigo;
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
            // loadedImgLbl
            // 
            this.loadedImgLbl.AutoSize = true;
            this.loadedImgLbl.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadedImgLbl.Location = new System.Drawing.Point(10, 189);
            this.loadedImgLbl.Name = "loadedImgLbl";
            this.loadedImgLbl.Size = new System.Drawing.Size(107, 14);
            this.loadedImgLbl.TabIndex = 21;
            this.loadedImgLbl.Text = "Loaded Images :";
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
            this.settingsGb.Size = new System.Drawing.Size(786, 393);
            this.settingsGb.TabIndex = 9;
            this.settingsGb.TabStop = false;
            this.settingsGb.Text = "Settings";
            // 
            // pixelsReadedGb
            // 
            this.pixelsReadedGb.Controls.Add(this.deleteSavedReadedPixBtn);
            this.pixelsReadedGb.Controls.Add(this.modifyRectBtn);
            this.pixelsReadedGb.Controls.Add(this.applyPixSettBtn);
            this.pixelsReadedGb.Controls.Add(this.createNewPixSettBtn);
            this.pixelsReadedGb.Controls.Add(this.savedPixelSettingsLb);
            this.pixelsReadedGb.Controls.Add(this.savedReadedPixelSettingsCb);
            this.pixelsReadedGb.Controls.Add(this.deleteRectButton);
            this.pixelsReadedGb.Controls.Add(this.addRectBtn);
            this.pixelsReadedGb.Controls.Add(this.readedPixelsRectsListBox);
            this.pixelsReadedGb.Controls.Add(this.yPixelsLbl);
            this.pixelsReadedGb.Controls.Add(this.xPixelsNb);
            this.pixelsReadedGb.Controls.Add(this.drawButton);
            this.pixelsReadedGb.Controls.Add(this.widthPixelsNb);
            this.pixelsReadedGb.Controls.Add(this.heightPixelsLbl);
            this.pixelsReadedGb.Controls.Add(this.yPixelsNb);
            this.pixelsReadedGb.Controls.Add(this.widthPixelsLbl);
            this.pixelsReadedGb.Controls.Add(this.heightPixelsNb);
            this.pixelsReadedGb.Controls.Add(this.xPixelsLbl);
            this.pixelsReadedGb.Dock = System.Windows.Forms.DockStyle.Right;
            this.pixelsReadedGb.Location = new System.Drawing.Point(401, 19);
            this.pixelsReadedGb.Name = "pixelsReadedGb";
            this.pixelsReadedGb.Size = new System.Drawing.Size(382, 371);
            this.pixelsReadedGb.TabIndex = 15;
            this.pixelsReadedGb.TabStop = false;
            this.pixelsReadedGb.Text = "Pixels Readed";
            // 
            // deleteSavedReadedPixBtn
            // 
            this.deleteSavedReadedPixBtn.Location = new System.Drawing.Point(279, 330);
            this.deleteSavedReadedPixBtn.Name = "deleteSavedReadedPixBtn";
            this.deleteSavedReadedPixBtn.Size = new System.Drawing.Size(100, 28);
            this.deleteSavedReadedPixBtn.TabIndex = 28;
            this.deleteSavedReadedPixBtn.Text = "Delete";
            this.deleteSavedReadedPixBtn.UseVisualStyleBackColor = true;
            this.deleteSavedReadedPixBtn.Click += new System.EventHandler(this.deleteSavedReadedPixBtn_Click);
            // 
            // modifyRectBtn
            // 
            this.modifyRectBtn.Location = new System.Drawing.Point(194, 79);
            this.modifyRectBtn.Name = "modifyRectBtn";
            this.modifyRectBtn.Size = new System.Drawing.Size(80, 28);
            this.modifyRectBtn.TabIndex = 27;
            this.modifyRectBtn.Text = "Modify";
            this.modifyRectBtn.UseVisualStyleBackColor = true;
            this.modifyRectBtn.Visible = false;
            this.modifyRectBtn.Click += new System.EventHandler(this.modifyRectBtn_Click);
            // 
            // applyPixSettBtn
            // 
            this.applyPixSettBtn.Location = new System.Drawing.Point(11, 330);
            this.applyPixSettBtn.Name = "applyPixSettBtn";
            this.applyPixSettBtn.Size = new System.Drawing.Size(104, 28);
            this.applyPixSettBtn.TabIndex = 26;
            this.applyPixSettBtn.Text = "Apply";
            this.applyPixSettBtn.UseVisualStyleBackColor = true;
            this.applyPixSettBtn.Click += new System.EventHandler(this.applyPixSettBtn_Click);
            // 
            // createNewPixSettBtn
            // 
            this.createNewPixSettBtn.Location = new System.Drawing.Point(122, 330);
            this.createNewPixSettBtn.Name = "createNewPixSettBtn";
            this.createNewPixSettBtn.Size = new System.Drawing.Size(152, 28);
            this.createNewPixSettBtn.TabIndex = 25;
            this.createNewPixSettBtn.Text = "Create New";
            this.createNewPixSettBtn.UseVisualStyleBackColor = true;
            this.createNewPixSettBtn.Click += new System.EventHandler(this.createNewPixSettBtn_Click);
            // 
            // savedPixelSettingsLb
            // 
            this.savedPixelSettingsLb.AutoSize = true;
            this.savedPixelSettingsLb.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savedPixelSettingsLb.Location = new System.Drawing.Point(12, 285);
            this.savedPixelSettingsLb.Name = "savedPixelSettingsLb";
            this.savedPixelSettingsLb.Size = new System.Drawing.Size(106, 14);
            this.savedPixelSettingsLb.TabIndex = 24;
            this.savedPixelSettingsLb.Text = "Saved Settings :";
            // 
            // savedReadedPixelSettingsCb
            // 
            this.savedReadedPixelSettingsCb.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savedReadedPixelSettingsCb.FormattingEnabled = true;
            this.savedReadedPixelSettingsCb.Location = new System.Drawing.Point(11, 302);
            this.savedReadedPixelSettingsCb.Name = "savedReadedPixelSettingsCb";
            this.savedReadedPixelSettingsCb.Size = new System.Drawing.Size(354, 22);
            this.savedReadedPixelSettingsCb.TabIndex = 23;
            // 
            // deleteRectButton
            // 
            this.deleteRectButton.Location = new System.Drawing.Point(285, 79);
            this.deleteRectButton.Name = "deleteRectButton";
            this.deleteRectButton.Size = new System.Drawing.Size(80, 28);
            this.deleteRectButton.TabIndex = 16;
            this.deleteRectButton.Text = "Delete";
            this.deleteRectButton.UseVisualStyleBackColor = true;
            this.deleteRectButton.Visible = false;
            this.deleteRectButton.Click += new System.EventHandler(this.deleteRectButton_Click);
            // 
            // addRectBtn
            // 
            this.addRectBtn.Location = new System.Drawing.Point(102, 79);
            this.addRectBtn.Name = "addRectBtn";
            this.addRectBtn.Size = new System.Drawing.Size(80, 28);
            this.addRectBtn.TabIndex = 15;
            this.addRectBtn.Text = "Add";
            this.addRectBtn.UseVisualStyleBackColor = true;
            this.addRectBtn.Visible = false;
            this.addRectBtn.Click += new System.EventHandler(this.addRectBtn_Click);
            // 
            // readedPixelsRectsListBox
            // 
            this.readedPixelsRectsListBox.FormattingEnabled = true;
            this.readedPixelsRectsListBox.HorizontalScrollbar = true;
            this.readedPixelsRectsListBox.ItemHeight = 16;
            this.readedPixelsRectsListBox.Location = new System.Drawing.Point(11, 113);
            this.readedPixelsRectsListBox.Name = "readedPixelsRectsListBox";
            this.readedPixelsRectsListBox.Size = new System.Drawing.Size(354, 164);
            this.readedPixelsRectsListBox.TabIndex = 14;
            this.readedPixelsRectsListBox.SelectedIndexChanged += new System.EventHandler(this.pixelReadedRectsListBox_SelectedIndexChanged);
            // 
            // yPixelsLbl
            // 
            this.yPixelsLbl.AutoSize = true;
            this.yPixelsLbl.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yPixelsLbl.Location = new System.Drawing.Point(21, 52);
            this.yPixelsLbl.Name = "yPixelsLbl";
            this.yPixelsLbl.Size = new System.Drawing.Size(27, 14);
            this.yPixelsLbl.TabIndex = 11;
            this.yPixelsLbl.Text = "Y : ";
            // 
            // xPixelsNb
            // 
            this.xPixelsNb.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xPixelsNb.Location = new System.Drawing.Point(81, 22);
            this.xPixelsNb.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.xPixelsNb.Name = "xPixelsNb";
            this.xPixelsNb.Size = new System.Drawing.Size(65, 22);
            this.xPixelsNb.TabIndex = 6;
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(11, 79);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(80, 28);
            this.drawButton.TabIndex = 13;
            this.drawButton.Text = "Draw";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // widthPixelsNb
            // 
            this.widthPixelsNb.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthPixelsNb.Location = new System.Drawing.Point(240, 51);
            this.widthPixelsNb.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.widthPixelsNb.Name = "widthPixelsNb";
            this.widthPixelsNb.Size = new System.Drawing.Size(65, 22);
            this.widthPixelsNb.TabIndex = 7;
            // 
            // heightPixelsLbl
            // 
            this.heightPixelsLbl.AutoSize = true;
            this.heightPixelsLbl.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightPixelsLbl.Location = new System.Drawing.Point(180, 25);
            this.heightPixelsLbl.Name = "heightPixelsLbl";
            this.heightPixelsLbl.Size = new System.Drawing.Size(55, 14);
            this.heightPixelsLbl.TabIndex = 5;
            this.heightPixelsLbl.Text = "Height :";
            // 
            // yPixelsNb
            // 
            this.yPixelsNb.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yPixelsNb.Location = new System.Drawing.Point(81, 51);
            this.yPixelsNb.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.yPixelsNb.Name = "yPixelsNb";
            this.yPixelsNb.Size = new System.Drawing.Size(65, 22);
            this.yPixelsNb.TabIndex = 8;
            // 
            // widthPixelsLbl
            // 
            this.widthPixelsLbl.AutoSize = true;
            this.widthPixelsLbl.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthPixelsLbl.Location = new System.Drawing.Point(180, 52);
            this.widthPixelsLbl.Name = "widthPixelsLbl";
            this.widthPixelsLbl.Size = new System.Drawing.Size(51, 14);
            this.widthPixelsLbl.TabIndex = 12;
            this.widthPixelsLbl.Text = "Width :";
            // 
            // heightPixelsNb
            // 
            this.heightPixelsNb.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightPixelsNb.Location = new System.Drawing.Point(240, 22);
            this.heightPixelsNb.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.heightPixelsNb.Name = "heightPixelsNb";
            this.heightPixelsNb.Size = new System.Drawing.Size(65, 22);
            this.heightPixelsNb.TabIndex = 9;
            // 
            // xPixelsLbl
            // 
            this.xPixelsLbl.AutoSize = true;
            this.xPixelsLbl.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xPixelsLbl.Location = new System.Drawing.Point(21, 25);
            this.xPixelsLbl.Name = "xPixelsLbl";
            this.xPixelsLbl.Size = new System.Drawing.Size(24, 14);
            this.xPixelsLbl.TabIndex = 10;
            this.xPixelsLbl.Text = "X :";
            // 
            // captureSettingsGb
            // 
            this.captureSettingsGb.Controls.Add(this.deleteCaptSet);
            this.captureSettingsGb.Controls.Add(this.editCaptureSettBtn);
            this.captureSettingsGb.Controls.Add(this.createNewCaptureSettBtn);
            this.captureSettingsGb.Controls.Add(this.applyChosenSettingsBtn);
            this.captureSettingsGb.Controls.Add(this.applyTempCappSettBtn);
            this.captureSettingsGb.Controls.Add(this.savedCaptureSettingsLb);
            this.captureSettingsGb.Controls.Add(this.savedCaptureSettingsCb);
            this.captureSettingsGb.Controls.Add(this.yCaptureLbl);
            this.captureSettingsGb.Controls.Add(this.xCaptureNb);
            this.captureSettingsGb.Controls.Add(this.widthCaptureNb);
            this.captureSettingsGb.Controls.Add(this.heightCaptureLbl);
            this.captureSettingsGb.Controls.Add(this.yCaptureNb);
            this.captureSettingsGb.Controls.Add(this.widthCaptureLbl);
            this.captureSettingsGb.Controls.Add(this.heightCaptureNb);
            this.captureSettingsGb.Controls.Add(this.xCaptureLbl);
            this.captureSettingsGb.Dock = System.Windows.Forms.DockStyle.Left;
            this.captureSettingsGb.Location = new System.Drawing.Point(3, 19);
            this.captureSettingsGb.Name = "captureSettingsGb";
            this.captureSettingsGb.Size = new System.Drawing.Size(392, 371);
            this.captureSettingsGb.TabIndex = 14;
            this.captureSettingsGb.TabStop = false;
            this.captureSettingsGb.Text = "Capture";
            // 
            // deleteCaptSet
            // 
            this.deleteCaptSet.Location = new System.Drawing.Point(264, 185);
            this.deleteCaptSet.Name = "deleteCaptSet";
            this.deleteCaptSet.Size = new System.Drawing.Size(110, 28);
            this.deleteCaptSet.TabIndex = 26;
            this.deleteCaptSet.Text = "Delete";
            this.deleteCaptSet.UseVisualStyleBackColor = true;
            this.deleteCaptSet.Click += new System.EventHandler(this.deleteCaptSet_Click);
            // 
            // editCaptureSettBtn
            // 
            this.editCaptureSettBtn.Location = new System.Drawing.Point(139, 185);
            this.editCaptureSettBtn.Name = "editCaptureSettBtn";
            this.editCaptureSettBtn.Size = new System.Drawing.Size(119, 28);
            this.editCaptureSettBtn.TabIndex = 25;
            this.editCaptureSettBtn.Text = "Edit";
            this.editCaptureSettBtn.UseVisualStyleBackColor = true;
            this.editCaptureSettBtn.Click += new System.EventHandler(this.editCaptureSettBtn_Click);
            // 
            // createNewCaptureSettBtn
            // 
            this.createNewCaptureSettBtn.Location = new System.Drawing.Point(12, 219);
            this.createNewCaptureSettBtn.Name = "createNewCaptureSettBtn";
            this.createNewCaptureSettBtn.Size = new System.Drawing.Size(121, 28);
            this.createNewCaptureSettBtn.TabIndex = 24;
            this.createNewCaptureSettBtn.Text = "Create New";
            this.createNewCaptureSettBtn.UseVisualStyleBackColor = true;
            this.createNewCaptureSettBtn.Click += new System.EventHandler(this.saveCaptureSettBtn_Click);
            // 
            // applyChosenSettingsBtn
            // 
            this.applyChosenSettingsBtn.Location = new System.Drawing.Point(12, 185);
            this.applyChosenSettingsBtn.Name = "applyChosenSettingsBtn";
            this.applyChosenSettingsBtn.Size = new System.Drawing.Size(121, 28);
            this.applyChosenSettingsBtn.TabIndex = 23;
            this.applyChosenSettingsBtn.Text = "Apply";
            this.applyChosenSettingsBtn.UseVisualStyleBackColor = true;
            this.applyChosenSettingsBtn.Click += new System.EventHandler(this.applyChosenSettingsBtn_Click);
            // 
            // applyTempCappSettBtn
            // 
            this.applyTempCappSettBtn.Location = new System.Drawing.Point(16, 79);
            this.applyTempCappSettBtn.Name = "applyTempCappSettBtn";
            this.applyTempCappSettBtn.Size = new System.Drawing.Size(122, 28);
            this.applyTempCappSettBtn.TabIndex = 14;
            this.applyTempCappSettBtn.Text = "Apply";
            this.applyTempCappSettBtn.UseVisualStyleBackColor = true;
            this.applyTempCappSettBtn.Click += new System.EventHandler(this.applySettingsBtn_Click);
            // 
            // savedCaptureSettingsLb
            // 
            this.savedCaptureSettingsLb.AutoSize = true;
            this.savedCaptureSettingsLb.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savedCaptureSettingsLb.Location = new System.Drawing.Point(13, 140);
            this.savedCaptureSettingsLb.Name = "savedCaptureSettingsLb";
            this.savedCaptureSettingsLb.Size = new System.Drawing.Size(106, 14);
            this.savedCaptureSettingsLb.TabIndex = 22;
            this.savedCaptureSettingsLb.Text = "Saved Settings :";
            // 
            // savedCaptureSettingsCb
            // 
            this.savedCaptureSettingsCb.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savedCaptureSettingsCb.FormattingEnabled = true;
            this.savedCaptureSettingsCb.Location = new System.Drawing.Point(12, 157);
            this.savedCaptureSettingsCb.Name = "savedCaptureSettingsCb";
            this.savedCaptureSettingsCb.Size = new System.Drawing.Size(362, 22);
            this.savedCaptureSettingsCb.TabIndex = 21;
            this.savedCaptureSettingsCb.SelectionChangeCommitted += new System.EventHandler(this.savedCaptureSettingsCb_SelectionChangeCommitted);
            // 
            // yCaptureLbl
            // 
            this.yCaptureLbl.AutoSize = true;
            this.yCaptureLbl.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yCaptureLbl.Location = new System.Drawing.Point(13, 52);
            this.yCaptureLbl.Name = "yCaptureLbl";
            this.yCaptureLbl.Size = new System.Drawing.Size(27, 14);
            this.yCaptureLbl.TabIndex = 19;
            this.yCaptureLbl.Text = "Y : ";
            // 
            // xCaptureNb
            // 
            this.xCaptureNb.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xCaptureNb.Location = new System.Drawing.Point(73, 22);
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
            this.widthCaptureNb.Location = new System.Drawing.Point(236, 51);
            this.widthCaptureNb.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.widthCaptureNb.Name = "widthCaptureNb";
            this.widthCaptureNb.Size = new System.Drawing.Size(65, 22);
            this.widthCaptureNb.TabIndex = 15;
            // 
            // heightCaptureLbl
            // 
            this.heightCaptureLbl.AutoSize = true;
            this.heightCaptureLbl.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightCaptureLbl.Location = new System.Drawing.Point(176, 25);
            this.heightCaptureLbl.Name = "heightCaptureLbl";
            this.heightCaptureLbl.Size = new System.Drawing.Size(55, 14);
            this.heightCaptureLbl.TabIndex = 13;
            this.heightCaptureLbl.Text = "Height :";
            // 
            // yCaptureNb
            // 
            this.yCaptureNb.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yCaptureNb.Location = new System.Drawing.Point(73, 51);
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
            this.widthCaptureLbl.Location = new System.Drawing.Point(176, 52);
            this.widthCaptureLbl.Name = "widthCaptureLbl";
            this.widthCaptureLbl.Size = new System.Drawing.Size(51, 14);
            this.widthCaptureLbl.TabIndex = 20;
            this.widthCaptureLbl.Text = "Width :";
            // 
            // heightCaptureNb
            // 
            this.heightCaptureNb.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightCaptureNb.Location = new System.Drawing.Point(236, 22);
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
            this.xCaptureLbl.Location = new System.Drawing.Point(13, 25);
            this.xCaptureLbl.Name = "xCaptureLbl";
            this.xCaptureLbl.Size = new System.Drawing.Size(24, 14);
            this.xCaptureLbl.TabIndex = 18;
            this.xCaptureLbl.Text = "X :";
            // 
            // loadedImgCb
            // 
            this.loadedImgCb.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadedImgCb.FormattingEnabled = true;
            this.loadedImgCb.Location = new System.Drawing.Point(10, 206);
            this.loadedImgCb.Name = "loadedImgCb";
            this.loadedImgCb.Size = new System.Drawing.Size(362, 22);
            this.loadedImgCb.TabIndex = 8;
            this.loadedImgCb.SelectionChangeCommitted += new System.EventHandler(this.imageChooseCb_SelectionChangeCommitted);
            // 
            // SettingsCaptureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 395);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1185, 434);
            this.MinimumSize = new System.Drawing.Size(1185, 284);
            this.Name = "SettingsCaptureForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.settingsGb.ResumeLayout(false);
            this.pixelsReadedGb.ResumeLayout(false);
            this.pixelsReadedGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xPixelsNb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthPixelsNb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yPixelsNb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightPixelsNb)).EndInit();
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
        private System.Windows.Forms.Label yPixelsLbl;
        private System.Windows.Forms.NumericUpDown xPixelsNb;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.NumericUpDown widthPixelsNb;
        private System.Windows.Forms.Label heightPixelsLbl;
        private System.Windows.Forms.NumericUpDown yPixelsNb;
        private System.Windows.Forms.Label widthPixelsLbl;
        private System.Windows.Forms.NumericUpDown heightPixelsNb;
        private System.Windows.Forms.Label xPixelsLbl;
        private System.Windows.Forms.GroupBox captureSettingsGb;
        private System.Windows.Forms.Label yCaptureLbl;
        private System.Windows.Forms.NumericUpDown xCaptureNb;
        private System.Windows.Forms.NumericUpDown widthCaptureNb;
        private System.Windows.Forms.Label heightCaptureLbl;
        private System.Windows.Forms.NumericUpDown yCaptureNb;
        private System.Windows.Forms.Label widthCaptureLbl;
        private System.Windows.Forms.NumericUpDown heightCaptureNb;
        private System.Windows.Forms.Label xCaptureLbl;
        private System.Windows.Forms.ComboBox savedCaptureSettingsCb;
        private System.Windows.Forms.Label savedCaptureSettingsLb;
        private System.Windows.Forms.Button applyTempCappSettBtn;
        private System.Windows.Forms.ListBox readedPixelsRectsListBox;
        private System.Windows.Forms.Button addRectBtn;
        private System.Windows.Forms.Button deleteRectButton;
        private System.Windows.Forms.Label savedPixelSettingsLb;
        private System.Windows.Forms.ComboBox savedReadedPixelSettingsCb;
        private System.Windows.Forms.Button applyChosenSettingsBtn;
        private System.Windows.Forms.Button createNewPixSettBtn;
        private System.Windows.Forms.Button applyPixSettBtn;
        private System.Windows.Forms.Button createNewCaptureSettBtn;
        private System.Windows.Forms.Button modifyRectBtn;
        private System.Windows.Forms.Button deleteSavedReadedPixBtn;
        private System.Windows.Forms.Button deleteCaptSet;
        private System.Windows.Forms.Button editCaptureSettBtn;
    }
}

