namespace ProjDVLD
{
    partial class FrmLostOrDamagedLicnsesDrivers
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
            this.uscFlterLicences1 = new ProjDVLD.UscFlterLicences();
            this.laTitle = new System.Windows.Forms.Label();
            this.radioDamaget = new System.Windows.Forms.RadioButton();
            this.radioLostDriver = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttIsusse = new System.Windows.Forms.Button();
            this.laLicensesId = new System.Windows.Forms.Label();
            this.laFees = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uscFlterLicences1
            // 
            this.uscFlterLicences1.BackColor = System.Drawing.Color.White;
            this.uscFlterLicences1.Location = new System.Drawing.Point(13, 13);
            this.uscFlterLicences1.Margin = new System.Windows.Forms.Padding(4);
            this.uscFlterLicences1.Name = "uscFlterLicences1";
            this.uscFlterLicences1.Size = new System.Drawing.Size(879, 883);
            this.uscFlterLicences1.TabIndex = 0;
            // 
            // laTitle
            // 
            this.laTitle.AutoSize = true;
            this.laTitle.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTitle.ForeColor = System.Drawing.Color.Red;
            this.laTitle.Location = new System.Drawing.Point(749, 9);
            this.laTitle.Name = "laTitle";
            this.laTitle.Size = new System.Drawing.Size(271, 32);
            this.laTitle.TabIndex = 1;
            this.laTitle.Text = "Lost Drivers Licenses";
            // 
            // radioDamaget
            // 
            this.radioDamaget.AutoSize = true;
            this.radioDamaget.Location = new System.Drawing.Point(47, 63);
            this.radioDamaget.Name = "radioDamaget";
            this.radioDamaget.Size = new System.Drawing.Size(184, 21);
            this.radioDamaget.TabIndex = 2;
            this.radioDamaget.Text = "Damaget  Driver Licenses";
            this.radioDamaget.UseVisualStyleBackColor = true;
            this.radioDamaget.CheckedChanged += new System.EventHandler(this.radioDamaget_CheckedChanged);
            // 
            // radioLostDriver
            // 
            this.radioLostDriver.AutoSize = true;
            this.radioLostDriver.Checked = true;
            this.radioLostDriver.Location = new System.Drawing.Point(47, 23);
            this.radioLostDriver.Name = "radioLostDriver";
            this.radioLostDriver.Size = new System.Drawing.Size(150, 21);
            this.radioLostDriver.TabIndex = 3;
            this.radioLostDriver.TabStop = true;
            this.radioLostDriver.Text = "Lost Driver Licenses";
            this.radioLostDriver.UseVisualStyleBackColor = true;
            this.radioLostDriver.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioDamaget);
            this.groupBox1.Controls.Add(this.radioLostDriver);
            this.groupBox1.Location = new System.Drawing.Point(832, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ApplicatonType";
            // 
            // buttIsusse
            // 
            this.buttIsusse.BackgroundImage = global::ProjDVLD.Properties.Resources.IssueDrivingLicense_32;
            this.buttIsusse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttIsusse.Location = new System.Drawing.Point(914, 646);
            this.buttIsusse.Name = "buttIsusse";
            this.buttIsusse.Size = new System.Drawing.Size(115, 43);
            this.buttIsusse.TabIndex = 5;
            this.buttIsusse.Text = "Isusse";
            this.buttIsusse.UseVisualStyleBackColor = true;
            this.buttIsusse.Click += new System.EventHandler(this.button1_Click);
            // 
            // laLicensesId
            // 
            this.laLicensesId.AutoSize = true;
            this.laLicensesId.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laLicensesId.Location = new System.Drawing.Point(169, 43);
            this.laLicensesId.Name = "laLicensesId";
            this.laLicensesId.Size = new System.Drawing.Size(56, 17);
            this.laLicensesId.TabIndex = 6;
            this.laLicensesId.Text = "............";
            // 
            // laFees
            // 
            this.laFees.AutoSize = true;
            this.laFees.Location = new System.Drawing.Point(169, 84);
            this.laFees.Name = "laFees";
            this.laFees.Size = new System.Drawing.Size(60, 17);
            this.laFees.TabIndex = 7;
            this.laFees.Text = ".............";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fees :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "LicensesIDnew:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.laFees);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.laLicensesId);
            this.groupBox2.Location = new System.Drawing.Point(832, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 160);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ApplicatonType";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ProjDVLD.Properties.Resources.Number_32;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(127, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 23);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ProjDVLD.Properties.Resources.money_32;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(61, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 23);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLostOrDamagedLicnsesDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1167, 893);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttIsusse);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.laTitle);
            this.Controls.Add(this.uscFlterLicences1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLostOrDamagedLicnsesDrivers";
            this.Text = "FrmLostOrDamagedLicnsesDrivers";
            this.Load += new System.EventHandler(this.FrmLostOrDamagedLicnsesDrivers_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UscFlterLicences uscFlterLicences1;
        private System.Windows.Forms.Label laTitle;
        private System.Windows.Forms.RadioButton radioDamaget;
        private System.Windows.Forms.RadioButton radioLostDriver;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttIsusse;
        private System.Windows.Forms.Label laLicensesId;
        private System.Windows.Forms.Label laFees;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}