namespace ProjDVLD.Users
{
    partial class FrmShowApplicatons
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
            this.uscVisionTestAppoimint = new ProjDVLD.UscVisionTestAppoimint();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uscVisionTestAppoimint
            // 
            this.uscVisionTestAppoimint.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uscVisionTestAppoimint.Location = new System.Drawing.Point(46, 151);
            this.uscVisionTestAppoimint.Margin = new System.Windows.Forms.Padding(4);
            this.uscVisionTestAppoimint.Name = "uscVisionTestAppoimint";
            this.uscVisionTestAppoimint.Size = new System.Drawing.Size(904, 575);
            this.uscVisionTestAppoimint.TabIndex = 0;
            this.uscVisionTestAppoimint.Load += new System.EventHandler(this.uscVisionTestAppoimint_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(324, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = " Loacil Driving Info";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjDVLD.Properties.Resources.Local_Driving_License_512;
            this.pictureBox1.Location = new System.Drawing.Point(364, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FrmShowApplicatons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 695);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uscVisionTestAppoimint);
            this.Name = "FrmShowApplicatons";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmShowApplicatons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UscVisionTestAppoimint uscVisionTestAppoimint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}