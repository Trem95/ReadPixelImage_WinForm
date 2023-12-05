namespace ReadPixelImage.Forms
{
    partial class HealthCheckerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imagesCb = new System.Windows.Forms.ComboBox();
            this.captureSettCb = new System.Windows.Forms.ComboBox();
            this.readedPixSettCb = new System.Windows.Forms.ComboBox();
            this.applyBtn = new System.Windows.Forms.Button();
            this.imageLbl = new System.Windows.Forms.Label();
            this.readedPixLbl = new System.Windows.Forms.Label();
            this.captureSettLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pixelsRdGb = new System.Windows.Forms.GroupBox();
            this.displayCurrentStream = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.displayCurrCaptureBtn = new System.Windows.Forms.Button();
            this.displayLoadImagesBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColorCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.readedPixels = new System.Windows.Forms.PictureBox();
            this.rectanglesLb = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.pixelsRdGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.imagesCb.Size = new System.Drawing.Size(347, 22);
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
            this.captureSettCb.Size = new System.Drawing.Size(347, 22);
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
            this.readedPixSettCb.Size = new System.Drawing.Size(347, 22);
            this.readedPixSettCb.TabIndex = 2;
            this.readedPixSettCb.SelectionChangeCommitted += new System.EventHandler(this.readedPixSettCb_SelectionChangeCommitted);
            // 
            // applyBtn
            // 
            this.applyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.applyBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyBtn.Location = new System.Drawing.Point(169, 141);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(75, 35);
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
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
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
            this.groupBox1.Size = new System.Drawing.Size(534, 233);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display Settings";
            // 
            // pixelsRdGb
            // 
            this.pixelsRdGb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pixelsRdGb.Controls.Add(this.displayCurrentStream);
            this.pixelsRdGb.Controls.Add(this.stopBtn);
            this.pixelsRdGb.Controls.Add(this.displayCurrCaptureBtn);
            this.pixelsRdGb.Controls.Add(this.displayLoadImagesBtn);
            this.pixelsRdGb.Controls.Add(this.dataGridView1);
            this.pixelsRdGb.Controls.Add(this.readedPixels);
            this.pixelsRdGb.Controls.Add(this.rectanglesLb);
            this.pixelsRdGb.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pixelsRdGb.Location = new System.Drawing.Point(552, 12);
            this.pixelsRdGb.Name = "pixelsRdGb";
            this.pixelsRdGb.Size = new System.Drawing.Size(828, 233);
            this.pixelsRdGb.TabIndex = 8;
            this.pixelsRdGb.TabStop = false;
            this.pixelsRdGb.Text = "Pixels Readed";
            // 
            // displayCurrentStream
            // 
            this.displayCurrentStream.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayCurrentStream.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayCurrentStream.Location = new System.Drawing.Point(638, 153);
            this.displayCurrentStream.Name = "displayCurrentStream";
            this.displayCurrentStream.Size = new System.Drawing.Size(184, 25);
            this.displayCurrentStream.TabIndex = 10;
            this.displayCurrentStream.Text = "Display Current Stream";
            this.displayCurrentStream.UseVisualStyleBackColor = true;
            this.displayCurrentStream.Click += new System.EventHandler(this.displayCurrentStream_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stopBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopBtn.Location = new System.Drawing.Point(635, 196);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(184, 25);
            this.stopBtn.TabIndex = 9;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // displayCurrCaptureBtn
            // 
            this.displayCurrCaptureBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayCurrCaptureBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayCurrCaptureBtn.Location = new System.Drawing.Point(635, 122);
            this.displayCurrCaptureBtn.Name = "displayCurrCaptureBtn";
            this.displayCurrCaptureBtn.Size = new System.Drawing.Size(184, 25);
            this.displayCurrCaptureBtn.TabIndex = 8;
            this.displayCurrCaptureBtn.Text = "Display Current Capture";
            this.displayCurrCaptureBtn.UseVisualStyleBackColor = true;
            this.displayCurrCaptureBtn.Click += new System.EventHandler(this.displayCurrCaptureBtn_Click);
            // 
            // displayLoadImagesBtn
            // 
            this.displayLoadImagesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayLoadImagesBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLoadImagesBtn.Location = new System.Drawing.Point(635, 93);
            this.displayLoadImagesBtn.Name = "displayLoadImagesBtn";
            this.displayLoadImagesBtn.Size = new System.Drawing.Size(184, 25);
            this.displayLoadImagesBtn.TabIndex = 7;
            this.displayLoadImagesBtn.Text = "Display Loaded Images";
            this.displayLoadImagesBtn.UseVisualStyleBackColor = true;
            this.displayLoadImagesBtn.Click += new System.EventHandler(this.displayBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColorCode,
            this.ColorImage});
            this.dataGridView1.Location = new System.Drawing.Point(253, 18);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(376, 203);
            this.dataGridView1.TabIndex = 3;
            // 
            // ColorCode
            // 
            this.ColorCode.HeaderText = "Code";
            this.ColorCode.Name = "ColorCode";
            this.ColorCode.ReadOnly = true;
            // 
            // ColorImage
            // 
            this.ColorImage.HeaderText = "Color";
            this.ColorImage.Name = "ColorImage";
            this.ColorImage.ReadOnly = true;
            // 
            // readedPixels
            // 
            this.readedPixels.Location = new System.Drawing.Point(635, 18);
            this.readedPixels.Name = "readedPixels";
            this.readedPixels.Size = new System.Drawing.Size(187, 69);
            this.readedPixels.TabIndex = 2;
            this.readedPixels.TabStop = false;
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
            this.rectanglesLb.Size = new System.Drawing.Size(232, 200);
            this.rectanglesLb.TabIndex = 0;
            this.rectanglesLb.SelectedIndexChanged += new System.EventHandler(this.rectanglesLb_SelectedIndexChanged);
            // 
            // HealthCheckerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 251);
            this.Controls.Add(this.pixelsRdGb);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(1408, 290);
            this.MinimumSize = new System.Drawing.Size(1408, 251);
            this.Name = "HealthCheckerForm";
            this.Text = "HealthChecker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HealthCheckerForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pixelsRdGb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorCode;
        private System.Windows.Forms.DataGridViewImageColumn ColorImage;
        private System.Windows.Forms.Button displayLoadImagesBtn;
        private System.Windows.Forms.PictureBox readedPixels;
        private System.Windows.Forms.Button displayCurrCaptureBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button displayCurrentStream;
    }
}