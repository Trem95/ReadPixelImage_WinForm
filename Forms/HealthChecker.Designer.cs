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
            this.SuspendLayout();
            // 
            // imagesCb
            // 
            this.imagesCb.FormattingEnabled = true;
            this.imagesCb.Location = new System.Drawing.Point(197, 31);
            this.imagesCb.Name = "imagesCb";
            this.imagesCb.Size = new System.Drawing.Size(330, 22);
            this.imagesCb.TabIndex = 0;
            // 
            // captureSettCb
            // 
            this.captureSettCb.FormattingEnabled = true;
            this.captureSettCb.Location = new System.Drawing.Point(197, 73);
            this.captureSettCb.Name = "captureSettCb";
            this.captureSettCb.Size = new System.Drawing.Size(330, 22);
            this.captureSettCb.TabIndex = 1;
            // 
            // readedPixSettCb
            // 
            this.readedPixSettCb.FormattingEnabled = true;
            this.readedPixSettCb.Location = new System.Drawing.Point(197, 115);
            this.readedPixSettCb.Name = "readedPixSettCb";
            this.readedPixSettCb.Size = new System.Drawing.Size(330, 22);
            this.readedPixSettCb.TabIndex = 2;
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(197, 156);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(75, 23);
            this.applyBtn.TabIndex = 3;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // imageLbl
            // 
            this.imageLbl.AutoSize = true;
            this.imageLbl.Location = new System.Drawing.Point(34, 34);
            this.imageLbl.Name = "imageLbl";
            this.imageLbl.Size = new System.Drawing.Size(60, 14);
            this.imageLbl.TabIndex = 4;
            this.imageLbl.Text = "Image : ";
            // 
            // readedPixLbl
            // 
            this.readedPixLbl.AutoSize = true;
            this.readedPixLbl.Location = new System.Drawing.Point(34, 118);
            this.readedPixLbl.Name = "readedPixLbl";
            this.readedPixLbl.Size = new System.Drawing.Size(147, 14);
            this.readedPixLbl.TabIndex = 5;
            this.readedPixLbl.Text = "Readed  Pix. Setting : ";
            // 
            // captureSettLbl
            // 
            this.captureSettLbl.AutoSize = true;
            this.captureSettLbl.Location = new System.Drawing.Point(34, 76);
            this.captureSettLbl.Name = "captureSettLbl";
            this.captureSettLbl.Size = new System.Drawing.Size(116, 14);
            this.captureSettLbl.TabIndex = 6;
            this.captureSettLbl.Text = "Capture Setting :";
            // 
            // HealthChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 207);
            this.Controls.Add(this.captureSettLbl);
            this.Controls.Add(this.readedPixLbl);
            this.Controls.Add(this.imageLbl);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.readedPixSettCb);
            this.Controls.Add(this.captureSettCb);
            this.Controls.Add(this.imagesCb);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "HealthChecker";
            this.Text = "HealthChecker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox imagesCb;
        private System.Windows.Forms.ComboBox captureSettCb;
        private System.Windows.Forms.ComboBox readedPixSettCb;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.Label imageLbl;
        private System.Windows.Forms.Label readedPixLbl;
        private System.Windows.Forms.Label captureSettLbl;
    }
}