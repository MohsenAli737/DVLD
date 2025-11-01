namespace ProjDVLD
{
    partial class FrmissueDriversLicense
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
            this.uscVisionTestAppoimint1 = new ProjDVLD.UscVisionTestAppoimint();
            this.textboxNotes = new System.Windows.Forms.TextBox();
            this.butIsusse = new System.Windows.Forms.Button();
            this.butCloss = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uscVisionTestAppoimint1
            // 
            this.uscVisionTestAppoimint1.BackColor = System.Drawing.Color.White;
            this.uscVisionTestAppoimint1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uscVisionTestAppoimint1.Location = new System.Drawing.Point(13, 3);
            this.uscVisionTestAppoimint1.Margin = new System.Windows.Forms.Padding(4);
            this.uscVisionTestAppoimint1.Name = "uscVisionTestAppoimint1";
            this.uscVisionTestAppoimint1.Size = new System.Drawing.Size(880, 556);
            this.uscVisionTestAppoimint1.TabIndex = 0;
            this.uscVisionTestAppoimint1.Load += new System.EventHandler(this.uscVisionTestAppoimint1_Load);
            // 
            // textboxNotes
            // 
            this.textboxNotes.Location = new System.Drawing.Point(316, 595);
            this.textboxNotes.Multiline = true;
            this.textboxNotes.Name = "textboxNotes";
            this.textboxNotes.Size = new System.Drawing.Size(207, 138);
            this.textboxNotes.TabIndex = 1;
            // 
            // butIsusse
            // 
            this.butIsusse.BackColor = System.Drawing.Color.White;
            this.butIsusse.BackgroundImage = global::ProjDVLD.Properties.Resources.IssueDrivingLicense_32;
            this.butIsusse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butIsusse.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butIsusse.Location = new System.Drawing.Point(529, 753);
            this.butIsusse.Name = "butIsusse";
            this.butIsusse.Size = new System.Drawing.Size(116, 41);
            this.butIsusse.TabIndex = 2;
            this.butIsusse.Text = "Isusse";
            this.butIsusse.UseVisualStyleBackColor = false;
            this.butIsusse.Click += new System.EventHandler(this.butIsusse_Click);
            // 
            // butCloss
            // 
            this.butCloss.BackColor = System.Drawing.Color.White;
            this.butCloss.BackgroundImage = global::ProjDVLD.Properties.Resources.closeBlack32;
            this.butCloss.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butCloss.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCloss.Location = new System.Drawing.Point(202, 753);
            this.butCloss.Name = "butCloss";
            this.butCloss.Size = new System.Drawing.Size(112, 41);
            this.butCloss.TabIndex = 3;
            this.butCloss.Text = "Close";
            this.butCloss.UseVisualStyleBackColor = false;
            this.butCloss.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 576);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Notes:";
            // 
            // FrmissueDriversLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(892, 806);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butCloss);
            this.Controls.Add(this.butIsusse);
            this.Controls.Add(this.textboxNotes);
            this.Controls.Add(this.uscVisionTestAppoimint1);
            this.Name = "FrmissueDriversLicense";
            this.Text = "FrmissueDriversLicense";
            this.Load += new System.EventHandler(this.FrmissueDriversLicense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UscVisionTestAppoimint uscVisionTestAppoimint1;
        private System.Windows.Forms.TextBox textboxNotes;
        private System.Windows.Forms.Button butIsusse;
        private System.Windows.Forms.Button butCloss;
        private System.Windows.Forms.Label label1;
    }
}