namespace ProjDVLD
{
    partial class frmShowUser
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
            this.uscshowUser1 = new ProjDVLD.uscshowUser();
            this.SuspendLayout();
            // 
            // uscshowUser1
            // 
            this.uscshowUser1.Location = new System.Drawing.Point(12, -2);
            this.uscshowUser1.Name = "uscshowUser1";
            this.uscshowUser1.Size = new System.Drawing.Size(906, 594);
            this.uscshowUser1.TabIndex = 0;
            this.uscshowUser1.Load += new System.EventHandler(this.uscshowUser1_Load);
            // 
            // frmShowUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 584);
            this.Controls.Add(this.uscshowUser1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShowUser";
            this.Text = "frmShowUser";
            this.Load += new System.EventHandler(this.frmShowUser_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private uscshowUser uscshowUser1;
    }
}