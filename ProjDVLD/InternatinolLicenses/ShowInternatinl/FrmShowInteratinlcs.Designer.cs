namespace ProjDVLD
{
    partial class FrmShowInteratinlcs
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
            this.uscShowInternetLicenses1 = new ProjDVLD.UscShowInternetLicenses();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uscShowInternetLicenses1
            // 
            this.uscShowInternetLicenses1.Location = new System.Drawing.Point(22, 217);
            this.uscShowInternetLicenses1.Name = "uscShowInternetLicenses1";
            this.uscShowInternetLicenses1.Size = new System.Drawing.Size(747, 389);
            this.uscShowInternetLicenses1.TabIndex = 0;
            this.uscShowInternetLicenses1.Load += new System.EventHandler(this.uscShowInternetLicenses1_Load);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ProjDVLD.Properties.Resources.CardLicenses;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(230, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 175);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmShowInteratinlcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(781, 690);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.uscShowInternetLicenses1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmShowInteratinlcs";
            this.Text = "FrmShowInteratinlcs";
            this.Load += new System.EventHandler(this.FrmShowInteratinlcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UscShowInternetLicenses uscShowInternetLicenses1;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}