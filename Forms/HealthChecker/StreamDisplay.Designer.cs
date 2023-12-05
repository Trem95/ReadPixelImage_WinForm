namespace ReadPixelImage.Forms.HealthChecker
{
    partial class StreamDisplay
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
            this.streamView = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.streamView)).BeginInit();
            this.SuspendLayout();
            // 
            // streamView
            // 
            this.streamView.AllowExternalDrop = true;
            this.streamView.CreationProperties = null;
            this.streamView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.streamView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.streamView.Location = new System.Drawing.Point(0, 0);
            this.streamView.Name = "streamView";
            this.streamView.Size = new System.Drawing.Size(533, 386);
            this.streamView.Source = new System.Uri("https://www.google.com", System.UriKind.Absolute);
            this.streamView.TabIndex = 0;
            this.streamView.ZoomFactor = 1D;
            // 
            // StreamDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 386);
            this.Controls.Add(this.streamView);
            this.Name = "StreamDisplay";
            this.Text = "StreamDisplay";
            ((System.ComponentModel.ISupportInitialize)(this.streamView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 streamView;
    }
}