namespace ReadPixelImage.Forms
{
    partial class CreateOrEditCaptureSettingForm
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
            this.yCaptureLbl = new System.Windows.Forms.Label();
            this.xCaptureNb = new System.Windows.Forms.NumericUpDown();
            this.widthCaptureNb = new System.Windows.Forms.NumericUpDown();
            this.heightCaptureLbl = new System.Windows.Forms.Label();
            this.yCaptureNb = new System.Windows.Forms.NumericUpDown();
            this.widthCaptureLbl = new System.Windows.Forms.Label();
            this.heightCaptureNb = new System.Windows.Forms.NumericUpDown();
            this.xCaptureLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.createOrEditBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.xCaptureNb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthCaptureNb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yCaptureNb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightCaptureNb)).BeginInit();
            this.SuspendLayout();
            // 
            // yCaptureLbl
            // 
            this.yCaptureLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yCaptureLbl.AutoSize = true;
            this.yCaptureLbl.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yCaptureLbl.Location = new System.Drawing.Point(22, 85);
            this.yCaptureLbl.Name = "yCaptureLbl";
            this.yCaptureLbl.Size = new System.Drawing.Size(27, 14);
            this.yCaptureLbl.TabIndex = 27;
            this.yCaptureLbl.Text = "Y : ";
            // 
            // xCaptureNb
            // 
            this.xCaptureNb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xCaptureNb.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xCaptureNb.Location = new System.Drawing.Point(55, 56);
            this.xCaptureNb.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.xCaptureNb.Name = "xCaptureNb";
            this.xCaptureNb.Size = new System.Drawing.Size(65, 22);
            this.xCaptureNb.TabIndex = 22;
            // 
            // widthCaptureNb
            // 
            this.widthCaptureNb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.widthCaptureNb.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthCaptureNb.Location = new System.Drawing.Point(204, 85);
            this.widthCaptureNb.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.widthCaptureNb.Name = "widthCaptureNb";
            this.widthCaptureNb.Size = new System.Drawing.Size(65, 22);
            this.widthCaptureNb.TabIndex = 23;
            // 
            // heightCaptureLbl
            // 
            this.heightCaptureLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.heightCaptureLbl.AutoSize = true;
            this.heightCaptureLbl.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightCaptureLbl.Location = new System.Drawing.Point(144, 59);
            this.heightCaptureLbl.Name = "heightCaptureLbl";
            this.heightCaptureLbl.Size = new System.Drawing.Size(55, 14);
            this.heightCaptureLbl.TabIndex = 21;
            this.heightCaptureLbl.Text = "Height :";
            // 
            // yCaptureNb
            // 
            this.yCaptureNb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yCaptureNb.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yCaptureNb.Location = new System.Drawing.Point(55, 85);
            this.yCaptureNb.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.yCaptureNb.Name = "yCaptureNb";
            this.yCaptureNb.Size = new System.Drawing.Size(65, 22);
            this.yCaptureNb.TabIndex = 24;
            // 
            // widthCaptureLbl
            // 
            this.widthCaptureLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.widthCaptureLbl.AutoSize = true;
            this.widthCaptureLbl.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthCaptureLbl.Location = new System.Drawing.Point(144, 86);
            this.widthCaptureLbl.Name = "widthCaptureLbl";
            this.widthCaptureLbl.Size = new System.Drawing.Size(51, 14);
            this.widthCaptureLbl.TabIndex = 28;
            this.widthCaptureLbl.Text = "Width :";
            // 
            // heightCaptureNb
            // 
            this.heightCaptureNb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.heightCaptureNb.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightCaptureNb.Location = new System.Drawing.Point(204, 56);
            this.heightCaptureNb.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.heightCaptureNb.Name = "heightCaptureNb";
            this.heightCaptureNb.Size = new System.Drawing.Size(65, 22);
            this.heightCaptureNb.TabIndex = 25;
            // 
            // xCaptureLbl
            // 
            this.xCaptureLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xCaptureLbl.AutoSize = true;
            this.xCaptureLbl.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xCaptureLbl.Location = new System.Drawing.Point(22, 58);
            this.xCaptureLbl.Name = "xCaptureLbl";
            this.xCaptureLbl.Size = new System.Drawing.Size(24, 14);
            this.xCaptureLbl.TabIndex = 26;
            this.xCaptureLbl.Text = "X :";
            // 
            // nameLbl
            // 
            this.nameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.nameLbl.Location = new System.Drawing.Point(22, 21);
            this.nameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(54, 16);
            this.nameLbl.TabIndex = 30;
            this.nameLbl.Text = "Name :";
            // 
            // nameTb
            // 
            this.nameTb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTb.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTb.Location = new System.Drawing.Point(102, 17);
            this.nameTb.Margin = new System.Windows.Forms.Padding(4);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(241, 23);
            this.nameTb.TabIndex = 29;
            this.nameTb.TextChanged += new System.EventHandler(this.nameTb_TextChanged);
            // 
            // createOrEditBtn
            // 
            this.createOrEditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createOrEditBtn.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.createOrEditBtn.Location = new System.Drawing.Point(137, 119);
            this.createOrEditBtn.Name = "createOrEditBtn";
            this.createOrEditBtn.Size = new System.Drawing.Size(75, 23);
            this.createOrEditBtn.TabIndex = 31;
            this.createOrEditBtn.Text = "Create";
            this.createOrEditBtn.UseVisualStyleBackColor = true;
            this.createOrEditBtn.Click += new System.EventHandler(this.createOrEditBtn_Click);
            // 
            // CreateOrEditCaptureSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 154);
            this.Controls.Add(this.createOrEditBtn);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.yCaptureLbl);
            this.Controls.Add(this.xCaptureNb);
            this.Controls.Add(this.widthCaptureNb);
            this.Controls.Add(this.heightCaptureLbl);
            this.Controls.Add(this.yCaptureNb);
            this.Controls.Add(this.widthCaptureLbl);
            this.Controls.Add(this.heightCaptureNb);
            this.Controls.Add(this.xCaptureLbl);
            this.MaximumSize = new System.Drawing.Size(397, 193);
            this.MinimumSize = new System.Drawing.Size(397, 193);
            this.Name = "CreateOrEditCaptureSettingForm";
            this.Text = "CreateCaptureSettingForm";
            ((System.ComponentModel.ISupportInitialize)(this.xCaptureNb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthCaptureNb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yCaptureNb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightCaptureNb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label yCaptureLbl;
        private System.Windows.Forms.NumericUpDown xCaptureNb;
        private System.Windows.Forms.NumericUpDown widthCaptureNb;
        private System.Windows.Forms.Label heightCaptureLbl;
        private System.Windows.Forms.NumericUpDown yCaptureNb;
        private System.Windows.Forms.Label widthCaptureLbl;
        private System.Windows.Forms.NumericUpDown heightCaptureNb;
        private System.Windows.Forms.Label xCaptureLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.Button createOrEditBtn;
    }
}