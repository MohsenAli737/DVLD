namespace ProjDVLD.Control
{
    partial class FormTestAppoint
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
            this.labTitel = new System.Windows.Forms.Label();
            this.pictourTitle = new System.Windows.Forms.PictureBox();
            this.dataGridTestApp = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.takTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uscVisionTestAppoimint1 = new ProjDVLD.UscVisionTestAppoimint();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictourTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTestApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labTitel
            // 
            this.labTitel.AutoSize = true;
            this.labTitel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labTitel.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labTitel.Location = new System.Drawing.Point(449, 31);
            this.labTitel.Name = "labTitel";
            this.labTitel.Size = new System.Drawing.Size(57, 29);
            this.labTitel.TabIndex = 0;
            this.labTitel.Text = "Test ";
            this.labTitel.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictourTitle
            // 
            this.pictourTitle.Location = new System.Drawing.Point(832, 12);
            this.pictourTitle.Name = "pictourTitle";
            this.pictourTitle.Size = new System.Drawing.Size(137, 69);
            this.pictourTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictourTitle.TabIndex = 1;
            this.pictourTitle.TabStop = false;
            // 
            // dataGridTestApp
            // 
            this.dataGridTestApp.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridTestApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTestApp.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridTestApp.Location = new System.Drawing.Point(12, 694);
            this.dataGridTestApp.Name = "dataGridTestApp";
            this.dataGridTestApp.Size = new System.Drawing.Size(516, 150);
            this.dataGridTestApp.TabIndex = 3;
            this.dataGridTestApp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjDVLD.Properties.Resources.AddAppointment_32;
            this.pictureBox1.Location = new System.Drawing.Point(726, 730);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(728, 789);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "NewTestAppo";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.takTestToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(112, 26);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // takTestToolStripMenuItem
            // 
            this.takTestToolStripMenuItem.Image = global::ProjDVLD.Properties.Resources.Test_32;
            this.takTestToolStripMenuItem.Name = "takTestToolStripMenuItem";
            this.takTestToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.takTestToolStripMenuItem.Text = "TakTest";
            this.takTestToolStripMenuItem.Click += new System.EventHandler(this.takTestToolStripMenuItem_Click);
            // 
            // uscVisionTestAppoimint1
            // 
            this.uscVisionTestAppoimint1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uscVisionTestAppoimint1.Location = new System.Drawing.Point(14, 88);
            this.uscVisionTestAppoimint1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.uscVisionTestAppoimint1.Name = "uscVisionTestAppoimint1";
            this.uscVisionTestAppoimint1.Size = new System.Drawing.Size(996, 575);
            this.uscVisionTestAppoimint1.TabIndex = 2;
            this.uscVisionTestAppoimint1.Load += new System.EventHandler(this.uscVisionTestAppoimint1_Load);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(555, 670);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Uptate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormTestAppoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1037, 856);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridTestApp);
            this.Controls.Add(this.uscVisionTestAppoimint1);
            this.Controls.Add(this.pictourTitle);
            this.Controls.Add(this.labTitel);
            this.Name = "FormTestAppoint";
            this.Text = "FormTestAppoint";
            this.Load += new System.EventHandler(this.FormTestAppoint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictourTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTestApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTitel;
        private System.Windows.Forms.PictureBox pictourTitle;
        private UscVisionTestAppoimint uscVisionTestAppoimint1;
        private System.Windows.Forms.DataGridView dataGridTestApp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem takTestToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}