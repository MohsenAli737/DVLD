namespace ProjDVLD.DetainedLicense.Mang_Datained
{
    partial class FrmMangDatein
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
            this.dataGridViewDateins = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttAddNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDateins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDateins
            // 
            this.dataGridViewDateins.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDateins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDateins.Location = new System.Drawing.Point(3, 246);
            this.dataGridViewDateins.Name = "dataGridViewDateins";
            this.dataGridViewDateins.RowHeadersWidth = 51;
            this.dataGridViewDateins.RowTemplate.Height = 26;
            this.dataGridViewDateins.Size = new System.Drawing.Size(983, 197);
            this.dataGridViewDateins.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(397, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mange Datein";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ProjDVLD.Properties.Resources.Detain_64;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(388, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 114);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // buttAddNew
            // 
            this.buttAddNew.BackgroundImage = global::ProjDVLD.Properties.Resources.Detain_64;
            this.buttAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttAddNew.Location = new System.Drawing.Point(801, 155);
            this.buttAddNew.Name = "buttAddNew";
            this.buttAddNew.Size = new System.Drawing.Size(175, 85);
            this.buttAddNew.TabIndex = 3;
            this.buttAddNew.Text = "Add New";
            this.buttAddNew.UseVisualStyleBackColor = true;
            this.buttAddNew.Click += new System.EventHandler(this.buttAddNew_Click);
            // 
            // FrmMangDatein
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(988, 482);
            this.Controls.Add(this.buttAddNew);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewDateins);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMangDatein";
            this.Text = "FrmMangDatein";
            this.Load += new System.EventHandler(this.FrmMangDatein_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDateins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDateins;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttAddNew;
    }
}