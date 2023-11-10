namespace ReadPixelImage
{
    partial class MainForm
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
            this.captureBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.rbTop = new System.Windows.Forms.RadioButton();
            this.rbBottom = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // captureBtn
            // 
            this.captureBtn.AutoSize = true;
            this.captureBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.captureBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.captureBtn.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captureBtn.Location = new System.Drawing.Point(5, 5);
            this.captureBtn.Margin = new System.Windows.Forms.Padding(20);
            this.captureBtn.Name = "captureBtn";
            this.captureBtn.Size = new System.Drawing.Size(1259, 40);
            this.captureBtn.TabIndex = 0;
            this.captureBtn.Text = "Capture";
            this.captureBtn.UseVisualStyleBackColor = true;
            this.captureBtn.Click += new System.EventHandler(this.CaptureBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1930, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(1, 1);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.captureBtn);
            this.splitContainer1.Panel2.Controls.Add(this.comboBox1);
            this.splitContainer1.Panel2.Controls.Add(this.rbTop);
            this.splitContainer1.Panel2.Controls.Add(this.rbBottom);
            this.splitContainer1.Panel2.Margin = new System.Windows.Forms.Padding(5);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainer1.Size = new System.Drawing.Size(1409, 308);
            this.splitContainer1.SplitterDistance = 233;
            this.splitContainer1.TabIndex = 2;
            // 
            // rbTop
            // 
            this.rbTop.AutoSize = true;
            this.rbTop.Checked = true;
            this.rbTop.Dock = System.Windows.Forms.DockStyle.Right;
            this.rbTop.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTop.Location = new System.Drawing.Point(1264, 5);
            this.rbTop.Name = "rbTop";
            this.rbTop.Padding = new System.Windows.Forms.Padding(5);
            this.rbTop.Size = new System.Drawing.Size(61, 61);
            this.rbTop.TabIndex = 2;
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
            this.rbBottom.Location = new System.Drawing.Point(1325, 5);
            this.rbBottom.Name = "rbBottom";
            this.rbBottom.Size = new System.Drawing.Size(79, 61);
            this.rbBottom.TabIndex = 1;
            this.rbBottom.Text = "Bottom";
            this.rbBottom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbBottom.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.rbBottom.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(5, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(1259, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 310);
            this.Controls.Add(this.splitContainer1);
            this.MaximumSize = new System.Drawing.Size(1920, 349);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button captureBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RadioButton rbTop;
        private System.Windows.Forms.RadioButton rbBottom;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

