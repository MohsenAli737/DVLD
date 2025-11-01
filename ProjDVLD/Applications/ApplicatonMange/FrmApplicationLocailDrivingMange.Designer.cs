namespace ProjDVLD.Applications.ApplicatonMange
{
    partial class FrmApplicationLocailDrivingMange
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewLocailApplicatonMange = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delteteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelAppliciatonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TestlStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visionTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writingTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.streetTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueDriversLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAddnewLoacil = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocailApplicatonMange)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLocailApplicatonMange
            // 
            this.dataGridViewLocailApplicatonMange.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewLocailApplicatonMange.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLocailApplicatonMange.Location = new System.Drawing.Point(83, 231);
            this.dataGridViewLocailApplicatonMange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewLocailApplicatonMange.Name = "dataGridViewLocailApplicatonMange";
            this.dataGridViewLocailApplicatonMange.RowHeadersWidth = 51;
            this.dataGridViewLocailApplicatonMange.Size = new System.Drawing.Size(750, 191);
            this.dataGridViewLocailApplicatonMange.TabIndex = 0;
            this.dataGridViewLocailApplicatonMange.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(230, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Applicaton LocaiL Mange";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showInfoToolStripMenuItem,
            this.delteteToolStripMenuItem,
            this.cancelAppliciatonsToolStripMenuItem,
            this.TestlStripMenuItem,
            this.issueDriversLicensesToolStripMenuItem,
            this.LicenseHistoryToolStripMenuItem,
            this.showLicenseToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(223, 216);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showInfoToolStripMenuItem
            // 
            this.showInfoToolStripMenuItem.Image = global::ProjDVLD.Properties.Resources.Local_Driving_License_512;
            this.showInfoToolStripMenuItem.Name = "showInfoToolStripMenuItem";
            this.showInfoToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.showInfoToolStripMenuItem.Text = "show info";
            this.showInfoToolStripMenuItem.Click += new System.EventHandler(this.showInfoToolStripMenuItem_Click);
            // 
            // delteteToolStripMenuItem
            // 
            this.delteteToolStripMenuItem.Image = global::ProjDVLD.Properties.Resources.Delete_32_2;
            this.delteteToolStripMenuItem.Name = "delteteToolStripMenuItem";
            this.delteteToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.delteteToolStripMenuItem.Text = "Delete";
            // 
            // cancelAppliciatonsToolStripMenuItem
            // 
            this.cancelAppliciatonsToolStripMenuItem.Image = global::ProjDVLD.Properties.Resources.Delete_32;
            this.cancelAppliciatonsToolStripMenuItem.Name = "cancelAppliciatonsToolStripMenuItem";
            this.cancelAppliciatonsToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.cancelAppliciatonsToolStripMenuItem.Text = "Cancel Appliciatons";
            this.cancelAppliciatonsToolStripMenuItem.Click += new System.EventHandler(this.cancelAppliciatonsToolStripMenuItem_Click);
            // 
            // TestlStripMenuItem
            // 
            this.TestlStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visionTestToolStripMenuItem,
            this.writingTestToolStripMenuItem,
            this.streetTestToolStripMenuItem});
            this.TestlStripMenuItem.Image = global::ProjDVLD.Properties.Resources.Schedule_Test_32;
            this.TestlStripMenuItem.Name = "TestlStripMenuItem";
            this.TestlStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.TestlStripMenuItem.Text = "Test";
            this.TestlStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // visionTestToolStripMenuItem
            // 
            this.visionTestToolStripMenuItem.AutoSize = false;
            this.visionTestToolStripMenuItem.Enabled = false;
            this.visionTestToolStripMenuItem.Image = global::ProjDVLD.Properties.Resources.Vision_Test_32;
            this.visionTestToolStripMenuItem.Name = "visionTestToolStripMenuItem";
            this.visionTestToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.visionTestToolStripMenuItem.Text = "Vision Test";
            this.visionTestToolStripMenuItem.Click += new System.EventHandler(this.visionTestToolStripMenuItem_Click);
            // 
            // writingTestToolStripMenuItem
            // 
            this.writingTestToolStripMenuItem.Enabled = false;
            this.writingTestToolStripMenuItem.Image = global::ProjDVLD.Properties.Resources.Written_Test_32;
            this.writingTestToolStripMenuItem.Name = "writingTestToolStripMenuItem";
            this.writingTestToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.writingTestToolStripMenuItem.Text = "writing Test";
            this.writingTestToolStripMenuItem.Click += new System.EventHandler(this.writingTestToolStripMenuItem_Click);
            // 
            // streetTestToolStripMenuItem
            // 
            this.streetTestToolStripMenuItem.Enabled = false;
            this.streetTestToolStripMenuItem.Image = global::ProjDVLD.Properties.Resources.Street_Test_32;
            this.streetTestToolStripMenuItem.Name = "streetTestToolStripMenuItem";
            this.streetTestToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.streetTestToolStripMenuItem.Text = "(Street) Test";
            this.streetTestToolStripMenuItem.Click += new System.EventHandler(this.streetTestToolStripMenuItem_Click);
            // 
            // issueDriversLicensesToolStripMenuItem
            // 
            this.issueDriversLicensesToolStripMenuItem.Image = global::ProjDVLD.Properties.Resources.IssueDrivingLicense_32;
            this.issueDriversLicensesToolStripMenuItem.Name = "issueDriversLicensesToolStripMenuItem";
            this.issueDriversLicensesToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.issueDriversLicensesToolStripMenuItem.Text = "Issue Drivers Licenses";
            this.issueDriversLicensesToolStripMenuItem.Click += new System.EventHandler(this.issueDriversLicensesToolStripMenuItem_Click);
            // 
            // LicenseHistoryToolStripMenuItem
            // 
            this.LicenseHistoryToolStripMenuItem.Image = global::ProjDVLD.Properties.Resources.PersonLicenseHistory_32;
            this.LicenseHistoryToolStripMenuItem.Name = "LicenseHistoryToolStripMenuItem";
            this.LicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.LicenseHistoryToolStripMenuItem.Text = "License Histrory";
            this.LicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.LicenseHistoryToolStripMenuItem_Click);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Image = global::ProjDVLD.Properties.Resources.IssueDrivingLicense_32;
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.showLicenseToolStripMenuItem.Text = "Show License";
            this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ProjDVLD.Properties.Resources.Close_32;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(807, 459);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 36);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAddnewLoacil
            // 
            this.buttonAddnewLoacil.BackgroundImage = global::ProjDVLD.Properties.Resources.New_Application_64;
            this.buttonAddnewLoacil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAddnewLoacil.Location = new System.Drawing.Point(763, 167);
            this.buttonAddnewLoacil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddnewLoacil.Name = "buttonAddnewLoacil";
            this.buttonAddnewLoacil.Size = new System.Drawing.Size(70, 57);
            this.buttonAddnewLoacil.TabIndex = 3;
            this.buttonAddnewLoacil.UseVisualStyleBackColor = true;
            this.buttonAddnewLoacil.Click += new System.EventHandler(this.buttonAddnewLoacil_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ProjDVLD.Properties.Resources.Manage_Applications_64;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(318, 90);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FrmApplicationLocailDrivingMange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(933, 523);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAddnewLoacil);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewLocailApplicatonMange);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmApplicationLocailDrivingMange";
            this.Text = "FrmApplicationMange";
            this.Load += new System.EventHandler(this.FrmApplicationMange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocailApplicatonMange)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLocailApplicatonMange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonAddnewLoacil;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delteteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelAppliciatonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TestlStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visionTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writingTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem streetTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueDriversLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
    }
}