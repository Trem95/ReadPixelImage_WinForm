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
            this.imageChooseCb = new System.Windows.Forms.ComboBox();
            this.rbTop = new System.Windows.Forms.RadioButton();
            this.rbBottom = new System.Windows.Forms.RadioButton();
            this.pixelsReadedGb = new System.Windows.Forms.GroupBox();
            this.drawButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.widthLbl = new System.Windows.Forms.Label();
            this.yCoordLbl = new System.Windows.Forms.Label();
            this.xCoordLbl = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.pixelsRdTb = new System.Windows.Forms.TextBox();
            this.pixelRdPb = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pixelsReadedGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pixelRdPb)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.captureBtn);
            this.panel1.Controls.Add(this.imageChooseCb);
            this.panel1.Controls.Add(this.rbTop);
            this.panel1.Controls.Add(this.rbBottom);
            this.panel1.Controls.Add(this.pixelsReadedGb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1167, 308);
            this.panel1.TabIndex = 0;
            // 
            // captureBtn
            // 
            this.captureBtn.AutoSize = true;
            this.captureBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.captureBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.captureBtn.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captureBtn.Location = new System.Drawing.Point(0, 0);
            this.captureBtn.Margin = new System.Windows.Forms.Padding(20);
            this.captureBtn.Name = "captureBtn";
            this.captureBtn.Size = new System.Drawing.Size(241, 286);
            this.captureBtn.TabIndex = 5;
            this.captureBtn.Text = "Capture";
            this.captureBtn.UseVisualStyleBackColor = true;
            this.captureBtn.Click += new System.EventHandler(this.CaptureBtn_Click);
            // 
            // imageChooseCb
            // 
            this.imageChooseCb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.imageChooseCb.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageChooseCb.FormattingEnabled = true;
            this.imageChooseCb.Location = new System.Drawing.Point(0, 286);
            this.imageChooseCb.Name = "imageChooseCb";
            this.imageChooseCb.Size = new System.Drawing.Size(241, 22);
            this.imageChooseCb.TabIndex = 8;
            this.imageChooseCb.SelectionChangeCommitted += new System.EventHandler(this.imageChooseCb_SelectionChangeCommitted);
            // 
            // rbTop
            // 
            this.rbTop.AutoSize = true;
            this.rbTop.Checked = true;
            this.rbTop.Dock = System.Windows.Forms.DockStyle.Right;
            this.rbTop.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTop.Location = new System.Drawing.Point(241, 0);
            this.rbTop.Name = "rbTop";
            this.rbTop.Padding = new System.Windows.Forms.Padding(5);
            this.rbTop.Size = new System.Drawing.Size(61, 308);
            this.rbTop.TabIndex = 7;
            this.rbTop.TabStop = true;
            this.rbTop.Text = "Top";
            this.rbTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbTop.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.rbTop.UseVisualStyleBackColor = true;
            // 
            // rbBottom
            // 
            this.rbBottom.AutoSize = true;
            this.rbBottom.Dock = System.Windows.Forms.DockStyle.Right;
            this.rbBottom.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBottom.Location = new System.Drawing.Point(302, 0);
            this.rbBottom.Name = "rbBottom";
            this.rbBottom.Size = new System.Drawing.Size(79, 308);
            this.rbBottom.TabIndex = 6;
            this.rbBottom.Text = "Bottom";
            this.rbBottom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbBottom.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.rbBottom.UseVisualStyleBackColor = true;
            // 
            // pixelsReadedGb
            // 
            this.pixelsReadedGb.Controls.Add(this.drawButton);
            this.pixelsReadedGb.Controls.Add(this.label4);
            this.pixelsReadedGb.Controls.Add(this.widthLbl);
            this.pixelsReadedGb.Controls.Add(this.yCoordLbl);
            this.pixelsReadedGb.Controls.Add(this.xCoordLbl);
            this.pixelsReadedGb.Controls.Add(this.numericUpDown4);
            this.pixelsReadedGb.Controls.Add(this.numericUpDown3);
            this.pixelsReadedGb.Controls.Add(this.numericUpDown2);
            this.pixelsReadedGb.Controls.Add(this.numericUpDown1);
            this.pixelsReadedGb.Controls.Add(this.pixelsRdTb);
            this.pixelsReadedGb.Controls.Add(this.pixelRdPb);
            this.pixelsReadedGb.Dock = System.Windows.Forms.DockStyle.Right;
            this.pixelsReadedGb.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pixelsReadedGb.Location = new System.Drawing.Point(381, 0);
            this.pixelsReadedGb.Name = "pixelsReadedGb";
            this.pixelsReadedGb.Size = new System.Drawing.Size(786, 308);
            this.pixelsReadedGb.TabIndex = 9;
            this.pixelsReadedGb.TabStop = false;
            this.pixelsReadedGb.Text = "Pixels Readed";
            // 
            // drawButton
            // 
            this.drawButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.drawButton.Location = new System.Drawing.Point(3, 277);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(288, 28);
            this.drawButton.TabIndex = 13;
            this.drawButton.Text = "Draw";
            this.drawButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(152, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "Height :";
            // 
            // widthLbl
            // 
            this.widthLbl.AutoSize = true;
            this.widthLbl.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLbl.Location = new System.Drawing.Point(152, 49);
            this.widthLbl.Name = "widthLbl";
            this.widthLbl.Size = new System.Drawing.Size(51, 14);
            this.widthLbl.TabIndex = 12;
            this.widthLbl.Text = "Width :";
            // 
            // yCoordLbl
            // 
            this.yCoordLbl.AutoSize = true;
            this.yCoordLbl.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yCoordLbl.Location = new System.Drawing.Point(21, 49);
            this.yCoordLbl.Name = "yCoordLbl";
            this.yCoordLbl.Size = new System.Drawing.Size(27, 14);
            this.yCoordLbl.TabIndex = 11;
            this.yCoordLbl.Text = "Y : ";
            // 
            // xCoordLbl
            // 
            this.xCoordLbl.AutoSize = true;
            this.xCoordLbl.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xCoordLbl.Location = new System.Drawing.Point(21, 22);
            this.xCoordLbl.Name = "xCoordLbl";
            this.xCoordLbl.Size = new System.Drawing.Size(24, 14);
            this.xCoordLbl.TabIndex = 10;
            this.xCoordLbl.Text = "X :";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown4.Location = new System.Drawing.Point(212, 19);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(65, 22);
            this.numericUpDown4.TabIndex = 9;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown3.Location = new System.Drawing.Point(81, 48);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(65, 22);
            this.numericUpDown3.TabIndex = 8;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.Location = new System.Drawing.Point(212, 48);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(65, 22);
            this.numericUpDown2.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(81, 19);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(65, 22);
            this.numericUpDown1.TabIndex = 6;
            // 
            // pixelsRdTb
            // 
            this.pixelsRdTb.Dock = System.Windows.Forms.DockStyle.Right;
            this.pixelsRdTb.Location = new System.Drawing.Point(291, 19);
            this.pixelsRdTb.Multiline = true;
            this.pixelsRdTb.Name = "pixelsRdTb";
            this.pixelsRdTb.ReadOnly = true;
            this.pixelsRdTb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.pixelsRdTb.Size = new System.Drawing.Size(255, 286);
            this.pixelsRdTb.TabIndex = 0;
            // 
            // pixelRdPb
            // 
            this.pixelRdPb.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pixelRdPb.Dock = System.Windows.Forms.DockStyle.Right;
            this.pixelRdPb.Location = new System.Drawing.Point(546, 19);
            this.pixelRdPb.Name = "pixelRdPb";
            this.pixelRdPb.Size = new System.Drawing.Size(237, 286);
            this.pixelRdPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pixelRdPb.TabIndex = 1;
            this.pixelRdPb.TabStop = false;
            // 
            // SettingsCaptureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 310);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1920, 420);
            this.Name = "SettingsCaptureForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pixelsReadedGb.ResumeLayout(false);
            this.pixelsReadedGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pixelRdPb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button captureBtn;
        private System.Windows.Forms.ComboBox imageChooseCb;
        private System.Windows.Forms.RadioButton rbTop;
        private System.Windows.Forms.RadioButton rbBottom;
        private System.Windows.Forms.GroupBox pixelsReadedGb;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label widthLbl;
        private System.Windows.Forms.Label yCoordLbl;
        private System.Windows.Forms.Label xCoordLbl;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox pixelsRdTb;
        private System.Windows.Forms.PictureBox pixelRdPb;
    }
}

