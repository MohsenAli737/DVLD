namespace ProjDVLD
{
    partial class FrmInternenonlSet
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
            this.buttonIssuse = new System.Windows.Forms.Button();
            this.buttonClos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelFees = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labeInterId = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.uscFlterLicences1 = new ProjDVLD.UscFlterLicences();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonIssuse
            // 
            this.buttonIssuse.BackColor = System.Drawing.Color.White;
            this.buttonIssuse.BackgroundImage = global::ProjDVLD.Properties.Resources.International_32;
            this.buttonIssuse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonIssuse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIssuse.Location = new System.Drawing.Point(430, 784);
            this.buttonIssuse.Margin = new System.Windows.Forms.Padding(4);
            this.buttonIssuse.Name = "buttonIssuse";
            this.buttonIssuse.Size = new System.Drawing.Size(94, 49);
            this.buttonIssuse.TabIndex = 1;
            this.buttonIssuse.Text = "issuse";
            this.buttonIssuse.UseVisualStyleBackColor = false;
            this.buttonIssuse.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonClos
            // 
            this.buttonClos.BackColor = System.Drawing.Color.White;
            this.buttonClos.BackgroundImage = global::ProjDVLD.Properties.Resources.Close_32;
            this.buttonClos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClos.Location = new System.Drawing.Point(178, 784);
            this.buttonClos.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClos.Name = "buttonClos";
            this.buttonClos.Size = new System.Drawing.Size(79, 49);
            this.buttonClos.TabIndex = 2;
            this.buttonClos.UseVisualStyleBackColor = false;
            this.buttonClos.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(93, 740);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Do you want to issue an international driving license?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 225);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fees:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::ProjDVLD.Properties.Resources.money_32;
            this.pictureBox1.Location = new System.Drawing.Point(76, 225);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 31);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // labelFees
            // 
            this.labelFees.AutoSize = true;
            this.labelFees.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFees.Location = new System.Drawing.Point(121, 235);
            this.labelFees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFees.Name = "labelFees";
            this.labelFees.Size = new System.Drawing.Size(40, 21);
            this.labelFees.TabIndex = 7;
            this.labelFees.Text = "......";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Internatinolid:";
            // 
            // labeInterId
            // 
            this.labeInterId.AutoSize = true;
            this.labeInterId.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeInterId.Location = new System.Drawing.Point(174, 175);
            this.labeInterId.Name = "labeInterId";
            this.labeInterId.Size = new System.Drawing.Size(45, 20);
            this.labeInterId.TabIndex = 10;
            this.labeInterId.Text = "....";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = global::ProjDVLD.Properties.Resources.International_32;
            this.pictureBox2.Location = new System.Drawing.Point(125, 164);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 31);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // uscFlterLicences1
            // 
            this.uscFlterLicences1.BackColor = System.Drawing.Color.White;
            this.uscFlterLicences1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.uscFlterLicences1.Location = new System.Drawing.Point(5, 1);
            this.uscFlterLicences1.Margin = new System.Windows.Forms.Padding(5);
            this.uscFlterLicences1.Name = "uscFlterLicences1";
            this.uscFlterLicences1.Size = new System.Drawing.Size(699, 930);
            this.uscFlterLicences1.TabIndex = 0;
            this.uscFlterLicences1.Load += new System.EventHandler(this.uscFlterLicences1_Load);
            // 
            // FrmInternenonlSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(707, 945);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labeInterId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelFees);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonClos);
            this.Controls.Add(this.buttonIssuse);
            this.Controls.Add(this.uscFlterLicences1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInternenonlSet";
            this.Text = "FrmInternenonlSet";
            this.Load += new System.EventHandler(this.FrmInternenonlSet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UscFlterLicences uscFlterLicences1;
        private System.Windows.Forms.Button buttonIssuse;
        private System.Windows.Forms.Button buttonClos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelFees;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labeInterId;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}