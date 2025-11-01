namespace ProjDVLD
{
    partial class FrmLicenceShowInfo
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uscShowLicens = new ProjDVLD.UscShowLicens();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjDVLD.Properties.Resources.LicenseView_400;
            this.pictureBox1.Location = new System.Drawing.Point(104, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(441, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // uscShowLicens
            // 
            this.uscShowLicens.Location = new System.Drawing.Point(-4, 193);
            this.uscShowLicens.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uscShowLicens.Name = "uscShowLicens";
            this.uscShowLicens.Size = new System.Drawing.Size(688, 444);
            this.uscShowLicens.TabIndex = 0;
            this.uscShowLicens.Load += new System.EventHandler(this.uscShowLicens_Load);
            // 
            // FrmLicenceShowInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 652);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.uscShowLicens);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLicenceShowInfo";
            this.Text = "FrmLicenceShowInfo";
            this.Load += new System.EventHandler(this.FrmLicenceShowInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UscShowLicens uscShowLicens;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}