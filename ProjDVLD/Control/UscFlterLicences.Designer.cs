namespace ProjDVLD
{
    partial class UscFlterLicences
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxFliter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttIsusse = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabelShowLicensesHistory = new System.Windows.Forms.LinkLabel();
            this.labShowLicnses = new System.Windows.Forms.LinkLabel();
            this.uscShowLicens1 = new ProjDVLD.UscShowLicens();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFliter
            // 
            this.textBoxFliter.Location = new System.Drawing.Point(110, 39);
            this.textBoxFliter.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFliter.Name = "textBoxFliter";
            this.textBoxFliter.Size = new System.Drawing.Size(319, 24);
            this.textBoxFliter.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "LicencesID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttIsusse);
            this.groupBox1.Controls.Add(this.textBoxFliter);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(679, 123);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fliter.";
            // 
            // buttIsusse
            // 
            this.buttIsusse.BackgroundImage = global::ProjDVLD.Properties.Resources.IssueDrivingLicense_32;
            this.buttIsusse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttIsusse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttIsusse.ForeColor = System.Drawing.Color.Yellow;
            this.buttIsusse.Location = new System.Drawing.Point(469, 39);
            this.buttIsusse.Margin = new System.Windows.Forms.Padding(4);
            this.buttIsusse.Name = "buttIsusse";
            this.buttIsusse.Size = new System.Drawing.Size(110, 39);
            this.buttIsusse.TabIndex = 2;
            this.buttIsusse.UseVisualStyleBackColor = true;
            this.buttIsusse.Click += new System.EventHandler(this.buttIsusse_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjDVLD.Properties.Resources.LicenseView_400;
            this.pictureBox1.Location = new System.Drawing.Point(160, 158);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabelShowLicensesHistory
            // 
            this.linkLabelShowLicensesHistory.AutoSize = true;
            this.linkLabelShowLicensesHistory.Enabled = false;
            this.linkLabelShowLicensesHistory.Location = new System.Drawing.Point(46, 682);
            this.linkLabelShowLicensesHistory.Name = "linkLabelShowLicensesHistory";
            this.linkLabelShowLicensesHistory.Size = new System.Drawing.Size(135, 17);
            this.linkLabelShowLicensesHistory.TabIndex = 5;
            this.linkLabelShowLicensesHistory.TabStop = true;
            this.linkLabelShowLicensesHistory.Text = "ShowLicensesHistory";
            this.linkLabelShowLicensesHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelShowLicensesHistory_LinkClicked);
            // 
            // labShowLicnses
            // 
            this.labShowLicnses.AutoSize = true;
            this.labShowLicnses.Enabled = false;
            this.labShowLicnses.Location = new System.Drawing.Point(448, 682);
            this.labShowLicnses.Name = "labShowLicnses";
            this.labShowLicnses.Size = new System.Drawing.Size(92, 17);
            this.labShowLicnses.TabIndex = 6;
            this.labShowLicnses.TabStop = true;
            this.labShowLicnses.Text = "ShowLicenses";
            // 
            // uscShowLicens1
            // 
            this.uscShowLicens1.Location = new System.Drawing.Point(4, 315);
            this.uscShowLicens1.Margin = new System.Windows.Forms.Padding(5);
            this.uscShowLicens1.Name = "uscShowLicens1";
            this.uscShowLicens1.Size = new System.Drawing.Size(679, 505);
            this.uscShowLicens1.TabIndex = 3;
            this.uscShowLicens1.Load += new System.EventHandler(this.uscShowLicens1_Load);
            // 
            // UscFlterLicences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labShowLicnses);
            this.Controls.Add(this.linkLabelShowLicensesHistory);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.uscShowLicens1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UscFlterLicences";
            this.Size = new System.Drawing.Size(699, 823);
            this.Load += new System.EventHandler(this.UscFlterLicences_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFliter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private UscShowLicens uscShowLicens1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttIsusse;
        private System.Windows.Forms.LinkLabel linkLabelShowLicensesHistory;
        private System.Windows.Forms.LinkLabel labShowLicnses;
    }
}
