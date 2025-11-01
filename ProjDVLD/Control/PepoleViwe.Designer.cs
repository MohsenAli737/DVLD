namespace ProjDVLD
{
    partial class PepoleViwe
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
            this.components = new System.ComponentModel.Container();
            this.LaTatal = new System.Windows.Forms.Label();
            this.dataGridViewScren = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textFilter = new System.Windows.Forms.TextBox();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripShowDetil = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAddNew = new System.Windows.Forms.ToolStripMenuItem();
            this.uptadePersonToolStripUptate = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buClose = new System.Windows.Forms.Button();
            this.buAddNew = new System.Windows.Forms.Button();
            this.pictureMengementPepole = new System.Windows.Forms.PictureBox();
            this.buRefrsh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScren)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMengementPepole)).BeginInit();
            this.SuspendLayout();
            // 
            // LaTatal
            // 
            this.LaTatal.AutoSize = true;
            this.LaTatal.Font = new System.Drawing.Font("Sitka Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaTatal.ForeColor = System.Drawing.Color.Red;
            this.LaTatal.Location = new System.Drawing.Point(346, 112);
            this.LaTatal.Name = "LaTatal";
            this.LaTatal.Size = new System.Drawing.Size(239, 35);
            this.LaTatal.TabIndex = 0;
            this.LaTatal.Text = "Pepole  Mangement";
            // 
            // dataGridViewScren
            // 
            this.dataGridViewScren.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewScren.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewScren.Location = new System.Drawing.Point(6, 226);
            this.dataGridViewScren.Name = "dataGridViewScren";
            this.dataGridViewScren.Size = new System.Drawing.Size(961, 168);
            this.dataGridViewScren.TabIndex = 1;
            this.dataGridViewScren.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewScren_CellContentClick);
            // 
            // textFilter
            // 
            this.textFilter.Location = new System.Drawing.Point(167, 203);
            this.textFilter.Name = "textFilter";
            this.textFilter.Size = new System.Drawing.Size(170, 20);
            this.textFilter.TabIndex = 3;
            this.textFilter.TextChanged += new System.EventHandler(this.textFilter_TextChanged);
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Location = new System.Drawing.Point(83, 202);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(78, 21);
            this.comboBoxFilter.TabIndex = 4;
            this.comboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Filter By";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripShowDetil,
            this.toolStripMenuItemAddNew,
            this.uptadePersonToolStripUptate,
            this.deletePersonToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(152, 92);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // toolStripShowDetil
            // 
            this.toolStripShowDetil.Image = global::ProjDVLD.Properties.Resources.PersonDetails_32;
            this.toolStripShowDetil.Name = "toolStripShowDetil";
            this.toolStripShowDetil.Size = new System.Drawing.Size(151, 22);
            this.toolStripShowDetil.Text = "Show";
            this.toolStripShowDetil.Click += new System.EventHandler(this.toolStripShowDetil_Click);
            // 
            // toolStripMenuItemAddNew
            // 
            this.toolStripMenuItemAddNew.Image = global::ProjDVLD.Properties.Resources.Add_Person_401;
            this.toolStripMenuItemAddNew.Name = "toolStripMenuItemAddNew";
            this.toolStripMenuItemAddNew.Size = new System.Drawing.Size(151, 22);
            this.toolStripMenuItemAddNew.Text = "AddNew";
            this.toolStripMenuItemAddNew.Click += new System.EventHandler(this.toolStripMenuItemAddNew_Click);
            // 
            // uptadePersonToolStripUptate
            // 
            this.uptadePersonToolStripUptate.Image = global::ProjDVLD.Properties.Resources.edit_32;
            this.uptadePersonToolStripUptate.Name = "uptadePersonToolStripUptate";
            this.uptadePersonToolStripUptate.Size = new System.Drawing.Size(151, 22);
            this.uptadePersonToolStripUptate.Text = "Uptade person";
            this.uptadePersonToolStripUptate.Click += new System.EventHandler(this.uptadePersonToolStripUptate_Click);
            // 
            // deletePersonToolStripMenuItem
            // 
            this.deletePersonToolStripMenuItem.Image = global::ProjDVLD.Properties.Resources.Delete_32;
            this.deletePersonToolStripMenuItem.Name = "deletePersonToolStripMenuItem";
            this.deletePersonToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.deletePersonToolStripMenuItem.Text = "Delete person";
            this.deletePersonToolStripMenuItem.Click += new System.EventHandler(this.deletePersonToolStripMenuItem_Click);
            // 
            // buClose
            // 
            this.buClose.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buClose.BackgroundImage = global::ProjDVLD.Properties.Resources.Close_32;
            this.buClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buClose.Location = new System.Drawing.Point(858, 397);
            this.buClose.Name = "buClose";
            this.buClose.Size = new System.Drawing.Size(106, 44);
            this.buClose.TabIndex = 8;
            this.buClose.Text = "Close";
            this.buClose.UseVisualStyleBackColor = false;
            this.buClose.Click += new System.EventHandler(this.buClose_Click);
            // 
            // buAddNew
            // 
            this.buAddNew.Image = global::ProjDVLD.Properties.Resources.AddPerson_32;
            this.buAddNew.Location = new System.Drawing.Point(889, 26);
            this.buAddNew.Name = "buAddNew";
            this.buAddNew.Size = new System.Drawing.Size(75, 74);
            this.buAddNew.TabIndex = 6;
            this.buAddNew.Text = " ";
            this.buAddNew.UseVisualStyleBackColor = true;
            this.buAddNew.Click += new System.EventHandler(this.buAddNew_Click);
            // 
            // pictureMengementPepole
            // 
            this.pictureMengementPepole.Image = global::ProjDVLD.Properties.Resources.People_400;
            this.pictureMengementPepole.Location = new System.Drawing.Point(371, 12);
            this.pictureMengementPepole.Name = "pictureMengementPepole";
            this.pictureMengementPepole.Size = new System.Drawing.Size(193, 97);
            this.pictureMengementPepole.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureMengementPepole.TabIndex = 5;
            this.pictureMengementPepole.TabStop = false;
            // 
            // buRefrsh
            // 
            this.buRefrsh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buRefrsh.BackgroundImage = global::ProjDVLD.Properties.Resources.List_32;
            this.buRefrsh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buRefrsh.Location = new System.Drawing.Point(3, 397);
            this.buRefrsh.Name = "buRefrsh";
            this.buRefrsh.Size = new System.Drawing.Size(158, 38);
            this.buRefrsh.TabIndex = 2;
            this.buRefrsh.Text = "List";
            this.buRefrsh.UseVisualStyleBackColor = false;
            this.buRefrsh.Click += new System.EventHandler(this.buRefrsh_Click);
            // 
            // PepoleViwe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.buClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buAddNew);
            this.Controls.Add(this.pictureMengementPepole);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.textFilter);
            this.Controls.Add(this.buRefrsh);
            this.Controls.Add(this.dataGridViewScren);
            this.Controls.Add(this.LaTatal);
            this.Name = "PepoleViwe";
            this.Size = new System.Drawing.Size(967, 447);
            this.Load += new System.EventHandler(this.PepoleViwe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScren)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMengementPepole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LaTatal;
        private System.Windows.Forms.DataGridView dataGridViewScren;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buRefrsh;
        private System.Windows.Forms.TextBox textFilter;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.PictureBox pictureMengementPepole;
        private System.Windows.Forms.Button buAddNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buClose;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripShowDetil;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddNew;
        private System.Windows.Forms.ToolStripMenuItem uptadePersonToolStripUptate;
        private System.Windows.Forms.ToolStripMenuItem deletePersonToolStripMenuItem;
    }
}
