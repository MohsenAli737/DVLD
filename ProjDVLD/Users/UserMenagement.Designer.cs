namespace ProjDVLD
{
    partial class UserMenagement
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labTitel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttClose = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chingPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 218);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Location = new System.Drawing.Point(169, 171);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(154, 20);
            this.textBoxFilter.TabIndex = 1;
            this.textBoxFilter.TextChanged += new System.EventHandler(this.textBoxFilter_TextChanged);
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Location = new System.Drawing.Point(78, 171);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(85, 21);
            this.comboBoxFilter.TabIndex = 2;
            this.comboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filter By:";
            // 
            // labTitel
            // 
            this.labTitel.AutoSize = true;
            this.labTitel.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitel.ForeColor = System.Drawing.Color.IndianRed;
            this.labTitel.Location = new System.Drawing.Point(196, 111);
            this.labTitel.Name = "labTitel";
            this.labTitel.Size = new System.Drawing.Size(138, 27);
            this.labTitel.TabIndex = 4;
            this.labTitel.Text = "Mange Users";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjDVLD.Properties.Resources.Users_2_400;
            this.pictureBox1.Location = new System.Drawing.Point(201, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // buttClose
            // 
            this.buttClose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttClose.BackgroundImage = global::ProjDVLD.Properties.Resources.Close_32;
            this.buttClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttClose.Location = new System.Drawing.Point(420, 444);
            this.buttClose.Name = "buttClose";
            this.buttClose.Size = new System.Drawing.Size(116, 43);
            this.buttClose.TabIndex = 6;
            this.buttClose.Text = " Close";
            this.buttClose.UseVisualStyleBackColor = false;
            this.buttClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjDVLD.Properties.Resources.Add_New_User_72;
            this.pictureBox2.Location = new System.Drawing.Point(473, 162);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showUserToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.chingPasswordToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(160, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showUserToolStripMenuItem
            // 
            this.showUserToolStripMenuItem.Image = global::ProjDVLD.Properties.Resources.User_32__2;
            this.showUserToolStripMenuItem.Name = "showUserToolStripMenuItem";
            this.showUserToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.showUserToolStripMenuItem.Text = "Show User";
            this.showUserToolStripMenuItem.Click += new System.EventHandler(this.showUserToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::ProjDVLD.Properties.Resources.Delete_User_32;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // chingPasswordToolStripMenuItem
            // 
            this.chingPasswordToolStripMenuItem.Image = global::ProjDVLD.Properties.Resources.Passed;
            this.chingPasswordToolStripMenuItem.Name = "chingPasswordToolStripMenuItem";
            this.chingPasswordToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.chingPasswordToolStripMenuItem.Text = "Ching Password";
            this.chingPasswordToolStripMenuItem.Click += new System.EventHandler(this.chingPasswordToolStripMenuItem_Click);
            // 
            // UserMenagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(548, 499);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labTitel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.textBoxFilter);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserMenagement";
            this.Text = "UserMenagement";
            this.Load += new System.EventHandler(this.UserMenagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labTitel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttClose;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chingPasswordToolStripMenuItem;
    }
}