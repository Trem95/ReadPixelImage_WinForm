namespace ReadPixelImage.Forms
{
    partial class CreateSettingForm
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
            this.nameTb = new System.Windows.Forms.TextBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.nameLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameTb
            // 
            this.nameTb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTb.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTb.Location = new System.Drawing.Point(72, 18);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(182, 23);
            this.nameTb.TabIndex = 0;
            // 
            // createBtn
            // 
            this.createBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createBtn.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.createBtn.Location = new System.Drawing.Point(266, 18);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(75, 23);
            this.createBtn.TabIndex = 1;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            // 
            // nameLbl
            // 
            this.nameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.nameLbl.Location = new System.Drawing.Point(12, 21);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(54, 16);
            this.nameLbl.TabIndex = 2;
            this.nameLbl.Text = "Name :";
            // 
            // CreateSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 53);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.nameTb);
            this.MaximumSize = new System.Drawing.Size(369, 92);
            this.MinimumSize = new System.Drawing.Size(369, 92);
            this.Name = "CreateSettingForm";
            this.Text = "Create New Setting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Label nameLbl;
    }
}