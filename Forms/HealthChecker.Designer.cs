namespace ReadPixelImage.Forms
{
    partial class HealthChecker
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
            this.imagesCb = new System.Windows.Forms.ComboBox();
            this.captureSettCb = new System.Windows.Forms.ComboBox();
            this.readedPixSettCb = new System.Windows.Forms.ComboBox();
            this.applyBtn = new System.Windows.Forms.Button();
            this.imageLbl = new System.Windows.Forms.Label();
            this.readedPixLbl = new System.Windows.Forms.Label();
            this.captureSettLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pixelsRdGb = new System.Windows.Forms.GroupBox();
            this.readedPixels = new System.Windows.Forms.PictureBox();
            this.readedPixLb = new System.Windows.Forms.ListBox();
            this.rectanglesLb = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.pixelsRdGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.readedPixels)).BeginInit();
            this.SuspendLayout();
            // 
            // imagesCb
            // 
            this.imagesCb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imagesCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.imagesCb.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imagesCb.FormattingEnabled = true;
            this.imagesCb.Location = new System.Drawing.Point(169, 28);
            this.imagesCb.Name = "imagesCb";
            this.imagesCb.Size = new System.Drawing.Size(330, 22);
            this.imagesCb.TabIndex = 0;
            this.imagesCb.SelectionChangeCommitted += new System.EventHandler(this.imagesCb_SelectionChangeCommitted);
            // 
            // captureSettCb
            // 
            this.captureSettCb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.captureSettCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.captureSettCb.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captureSettCb.FormattingEnabled = true;
            this.captureSettCb.Location = new System.Drawing.Point(169, 70);
            this.captureSettCb.Name = "captureSettCb";
            this.captureSettCb.Size = new System.Drawing.Size(330, 22);
            this.captureSettCb.TabIndex = 1;
            this.captureSettCb.SelectionChangeCommitted += new System.EventHandler(this.captureSettCb_SelectionChangeCommitted);
            // 
            // readedPixSettCb
            // 
            this.readedPixSettCb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.readedPixSettCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.readedPixSettCb.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readedPixSettCb.FormattingEnabled = true;
            this.readedPixSettCb.Location = new System.Drawing.Point(169, 112);
            this.readedPixSettCb.Name = "readedPixSettCb";
            this.readedPixSettCb.Size = new System.Drawing.Size(330, 22);
            this.readedPixSettCb.TabIndex = 2;
            this.readedPixSettCb.SelectionChangeCommitted += new System.EventHandler(this.readedPixSettCb_SelectionChangeCommitted);
            // 
            // applyBtn
            // 
            this.applyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.applyBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyBtn.Location = new System.Drawing.Point(169, 153);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(75, 23);
            this.applyBtn.TabIndex = 3;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // imageLbl
            // 
            this.imageLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageLbl.AutoSize = true;
            this.imageLbl.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageLbl.Location = new System.Drawing.Point(6, 31);
            this.imageLbl.Name = "imageLbl";
            this.imageLbl.Size = new System.Drawing.Size(60, 14);
            this.imageLbl.TabIndex = 4;
            this.imageLbl.Text = "Image : ";
            // 
            // readedPixLbl
            // 
            this.readedPixLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.readedPixLbl.AutoSize = true;
            this.readedPixLbl.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readedPixLbl.Location = new System.Drawing.Point(6, 115);
            this.readedPixLbl.Name = "readedPixLbl";
            this.readedPixLbl.Size = new System.Drawing.Size(147, 14);
            this.readedPixLbl.TabIndex = 5;
            this.readedPixLbl.Text = "Readed  Pix. Setting : ";
            // 
            // captureSettLbl
            // 
            this.captureSettLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.captureSettLbl.AutoSize = true;
            this.captureSettLbl.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captureSettLbl.Location = new System.Drawing.Point(6, 73);
            this.captureSettLbl.Name = "captureSettLbl";
            this.captureSettLbl.Size = new System.Drawing.Size(116, 14);
            this.captureSettLbl.TabIndex = 6;
            this.captureSettLbl.Text = "Capture Setting :";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.captureSettLbl);
            this.groupBox1.Controls.Add(this.imagesCb);
            this.groupBox1.Controls.Add(this.readedPixLbl);
            this.groupBox1.Controls.Add(this.captureSettCb);
            this.groupBox1.Controls.Add(this.imageLbl);
            this.groupBox1.Controls.Add(this.readedPixSettCb);
            this.groupBox1.Controls.Add(this.applyBtn);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 194);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display Settings";
            // 
            // pixelsRdGb
            // 
            this.pixelsRdGb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pixelsRdGb.Controls.Add(this.readedPixels);
            this.pixelsRdGb.Controls.Add(this.readedPixLb);
            this.pixelsRdGb.Controls.Add(this.rectanglesLb);
            this.pixelsRdGb.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pixelsRdGb.Location = new System.Drawing.Point(552, 12);
            this.pixelsRdGb.Name = "pixelsRdGb";
            this.pixelsRdGb.Size = new System.Drawing.Size(603, 194);
            this.pixelsRdGb.TabIndex = 8;
            this.pixelsRdGb.TabStop = false;
            this.pixelsRdGb.Text = "Pixels Readed";
            // 
            // readedPixels
            // 
            this.readedPixels.Location = new System.Drawing.Point(401, 34);
            this.readedPixels.Name = "readedPixels";
            this.readedPixels.Size = new System.Drawing.Size(177, 141);
            this.readedPixels.TabIndex = 2;
            this.readedPixels.TabStop = false;
            // 
            // readedPixLb
            // 
            this.readedPixLb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.readedPixLb.FormattingEnabled = true;
            this.readedPixLb.ItemHeight = 14;
            this.readedPixLb.Location = new System.Drawing.Point(199, 21);
            this.readedPixLb.Name = "readedPixLb";
            this.readedPixLb.Size = new System.Drawing.Size(166, 158);
            this.readedPixLb.TabIndex = 1;
            // 
            // rectanglesLb
            // 
            this.rectanglesLb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rectanglesLb.FormattingEnabled = true;
            this.rectanglesLb.ItemHeight = 14;
            this.rectanglesLb.Location = new System.Drawing.Point(15, 21);
            this.rectanglesLb.Name = "rectanglesLb";
            this.rectanglesLb.Size = new System.Drawing.Size(168, 158);
            this.rectanglesLb.TabIndex = 0;
            this.rectanglesLb.SelectedIndexChanged += new System.EventHandler(this.rectanglesLb_SelectedIndexChanged);
            // 
            // HealthChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 212);
            this.Controls.Add(this.pixelsRdGb);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(1183, 251);
            this.Name = "HealthChecker";
            this.Text = "HealthChecker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pixelsRdGb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.readedPixels)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox imagesCb;
        private System.Windows.Forms.ComboBox captureSettCb;
        private System.Windows.Forms.ComboBox readedPixSettCb;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.Label imageLbl;
        private System.Windows.Forms.Label readedPixLbl;
        private System.Windows.Forms.Label captureSettLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox pixelsRdGb;
        private System.Windows.Forms.ListBox rectanglesLb;
        private System.Windows.Forms.ListBox readedPixLb;
        private System.Windows.Forms.PictureBox readedPixels;
    }
}