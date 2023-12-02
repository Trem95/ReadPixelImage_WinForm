namespace ReadPixelImage.Forms
{
    partial class HealthCheckerDisplay
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
            this.capturePicBox.Size = new System.Drawing.Size(800, 450);
            this.capturePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.capturePicBox.TabIndex = 5;
            this.capturePicBox.TabStop = false;
            this.capturePicBox.Paint += new System.Windows.Forms.PaintEventHandler(this.displayPictureBox_Paint);
            // 
            // HealthCheckerDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.capturePicBox);
            this.Name = "HealthCheckerDisplay";
            this.Text = "HealthCheckerDisplay";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.healthCheckerDisplay_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.capturePicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox capturePicBox;
    }
}