namespace ProjDVLD
{
    partial class FrmShowDrivers
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
            this.labTaltal = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewDreivers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDreivers)).BeginInit();
            this.SuspendLayout();
            // 
            // labTaltal
            // 
            this.labTaltal.AutoSize = true;
            this.labTaltal.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTaltal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labTaltal.Location = new System.Drawing.Point(284, 192);
            this.labTaltal.Name = "labTaltal";
            this.labTaltal.Size = new System.Drawing.Size(176, 25);
            this.labTaltal.TabIndex = 1;
            this.labTaltal.Text = "Manage Drivers";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjDVLD.Properties.Resources.MangeDriver;
            this.pictureBox1.Location = new System.Drawing.Point(289, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewDreivers
            // 
            this.dataGridViewDreivers.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDreivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDreivers.Location = new System.Drawing.Point(154, 265);
            this.dataGridViewDreivers.Name = "dataGridViewDreivers";
            this.dataGridViewDreivers.Size = new System.Drawing.Size(453, 150);
            this.dataGridViewDreivers.TabIndex = 2;
            // 
            // FrmShowDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewDreivers);
            this.Controls.Add(this.labTaltal);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmShowDrivers";
            this.Text = "FrmShowDrivers";
            this.Load += new System.EventHandler(this.FrmShowDrivers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDreivers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labTaltal;
        private System.Windows.Forms.DataGridView dataGridViewDreivers;
    }
}