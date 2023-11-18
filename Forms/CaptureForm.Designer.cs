namespace ReadPixelImage
{
    partial class CaptureForm
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
            this.capturePicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.capturePicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // capturePicBox
            // 
            this.capturePicBox.BackColor = System.Drawing.Color.Indigo;
            this.capturePicBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.capturePicBox.Location = new System.Drawing.Point(0, 0);
            this.capturePicBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.capturePicBox.Name = "capturePicBox";
            this.capturePicBox.Size = new System.Drawing.Size(1067, 510);
            this.capturePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.capturePicBox.TabIndex = 4;
            this.capturePicBox.TabStop = false;
            this.capturePicBox.Paint += new System.Windows.Forms.PaintEventHandler(this.capturePictureBox_Paint);
            // 
            // CaptureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1067, 510);
            this.Controls.Add(this.capturePicBox);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CaptureForm";
            this.Text = "CaptureForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CaptureForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.capturePicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox capturePicBox;
    }
}