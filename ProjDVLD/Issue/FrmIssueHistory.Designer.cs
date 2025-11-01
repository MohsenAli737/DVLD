namespace ProjDVLD
{
    partial class FrmIssueHistory
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
            this.datalisunssDrevers = new System.Windows.Forms.DataGridView();
            this.uscShowPerson1 = new ProjDVLD.uscShowPerson();
            this.labeTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewIntrenanol = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datalisunssDrevers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIntrenanol)).BeginInit();
            this.SuspendLayout();
            // 
            // datalisunssDrevers
            // 
            this.datalisunssDrevers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.datalisunssDrevers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalisunssDrevers.Location = new System.Drawing.Point(7, 34);
            this.datalisunssDrevers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datalisunssDrevers.Name = "datalisunssDrevers";
            this.datalisunssDrevers.RowHeadersWidth = 51;
            this.datalisunssDrevers.Size = new System.Drawing.Size(1110, 185);
            this.datalisunssDrevers.TabIndex = 0;
            this.datalisunssDrevers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // uscShowPerson1
            // 
            this.uscShowPerson1.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uscShowPerson1.Location = new System.Drawing.Point(178, 87);
            this.uscShowPerson1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.uscShowPerson1.Name = "uscShowPerson1";
            this.uscShowPerson1.Size = new System.Drawing.Size(1049, 367);
            this.uscShowPerson1.TabIndex = 1;
            this.uscShowPerson1.Load += new System.EventHandler(this.uscShowPerson1_Load);
            // 
            // labeTitle
            // 
            this.labeTitle.AutoSize = true;
            this.labeTitle.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labeTitle.Location = new System.Drawing.Point(462, 9);
            this.labeTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeTitle.Name = "labeTitle";
            this.labeTitle.Size = new System.Drawing.Size(297, 41);
            this.labeTitle.TabIndex = 2;
            this.labeTitle.Text = "Licences History";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ProjDVLD.Properties.Resources.LicenseView_400;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(41, 257);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 518);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1219, 270);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.datalisunssDrevers);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1211, 241);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "LocalLicnses";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewIntrenanol);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1211, 241);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "internanolLicnses";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewIntrenanol
            // 
            this.dataGridViewIntrenanol.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dataGridViewIntrenanol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIntrenanol.Location = new System.Drawing.Point(6, 36);
            this.dataGridViewIntrenanol.Name = "dataGridViewIntrenanol";
            this.dataGridViewIntrenanol.RowHeadersWidth = 51;
            this.dataGridViewIntrenanol.RowTemplate.Height = 26;
            this.dataGridViewIntrenanol.Size = new System.Drawing.Size(1158, 182);
            this.dataGridViewIntrenanol.TabIndex = 5;
            // 
            // FrmIssueHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 910);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labeTitle);
            this.Controls.Add(this.uscShowPerson1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmIssueHistory";
            this.Text = "FrmIssueHistory";
            this.Load += new System.EventHandler(this.FrmIssueHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datalisunssDrevers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIntrenanol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datalisunssDrevers;
        private uscShowPerson uscShowPerson1;
        private System.Windows.Forms.Label labeTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewIntrenanol;
    }
}