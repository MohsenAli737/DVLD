namespace ProjDVLD
{
    partial class frmShowLicences
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
            this.uscShowLicens1 = new ProjDVLD.UscShowLicens();
            this.SuspendLayout();
            // 
            // uscShowLicens1
            // 
            this.uscShowLicens1.AutoSize = true;
            this.uscShowLicens1.Location = new System.Drawing.Point(12, 12);
            this.uscShowLicens1.Name = "uscShowLicens1";
            this.uscShowLicens1.Size = new System.Drawing.Size(595, 341);
            this.uscShowLicens1.TabIndex = 0;
            this.uscShowLicens1.Load += new System.EventHandler(this.uscShowLicens1_Load);
            // 
            // frmShowLicences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 402);
            this.Controls.Add(this.uscShowLicens1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShowLicences";
            this.Text = "frmShowLicences";
            this.Load += new System.EventHandler(this.frmShowLicences_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UscShowLicens uscShowLicens1;
    }
}