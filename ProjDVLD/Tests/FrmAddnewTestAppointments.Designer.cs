namespace ProjDVLD
{
    partial class FrmAddnewTestAppointments
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buSve = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.labFees = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.laInfoPerson = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictourTitle = new System.Windows.Forms.PictureBox();
            this.labTitel = new System.Windows.Forms.Label();
            this.buClos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictourTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buSve);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.dateTime);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.labFees);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.laInfoPerson);
            this.groupBox1.Location = new System.Drawing.Point(49, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 342);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TestAppontmint";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buSve
            // 
            this.buSve.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buSve.Image = global::ProjDVLD.Properties.Resources.Save_32;
            this.buSve.Location = new System.Drawing.Point(312, 280);
            this.buSve.Name = "buSve";
            this.buSve.Size = new System.Drawing.Size(75, 34);
            this.buSve.TabIndex = 4;
            this.buSve.UseVisualStyleBackColor = false;
            this.buSve.Click += new System.EventHandler(this.buSve_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ProjDVLD.Properties.Resources.money_32;
            this.pictureBox4.Location = new System.Drawing.Point(104, 246);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(56, 45);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProjDVLD.Properties.Resources.Schedule_Test_32;
            this.pictureBox3.Location = new System.Drawing.Point(104, 145);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(56, 51);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(178, 165);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(164, 20);
            this.dateTime.TabIndex = 6;
            this.dateTime.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fees:";
            // 
            // labFees
            // 
            this.labFees.AutoSize = true;
            this.labFees.Location = new System.Drawing.Point(175, 266);
            this.labFees.Name = "labFees";
            this.labFees.Size = new System.Drawing.Size(13, 13);
            this.labFees.TabIndex = 4;
            this.labFees.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjDVLD.Properties.Resources.Person_32;
            this.pictureBox2.Location = new System.Drawing.Point(166, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // laInfoPerson
            // 
            this.laInfoPerson.AutoSize = true;
            this.laInfoPerson.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laInfoPerson.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.laInfoPerson.Location = new System.Drawing.Point(240, 61);
            this.laInfoPerson.Name = "laInfoPerson";
            this.laInfoPerson.Size = new System.Drawing.Size(103, 19);
            this.laInfoPerson.TabIndex = 0;
            this.laInfoPerson.Text = "Person Info";
            this.laInfoPerson.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictourTitle
            // 
            this.pictourTitle.Location = new System.Drawing.Point(195, 12);
            this.pictourTitle.Name = "pictourTitle";
            this.pictourTitle.Size = new System.Drawing.Size(135, 90);
            this.pictourTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictourTitle.TabIndex = 1;
            this.pictourTitle.TabStop = false;
            this.pictourTitle.Click += new System.EventHandler(this.pictourTitle_Click);
            // 
            // labTitel
            // 
            this.labTitel.AutoSize = true;
            this.labTitel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitel.ForeColor = System.Drawing.Color.IndianRed;
            this.labTitel.Location = new System.Drawing.Point(236, 116);
            this.labTitel.Name = "labTitel";
            this.labTitel.Size = new System.Drawing.Size(59, 29);
            this.labTitel.TabIndex = 2;
            this.labTitel.Text = "Test";
            // 
            // buClos
            // 
            this.buClos.BackColor = System.Drawing.Color.White;
            this.buClos.Image = global::ProjDVLD.Properties.Resources.cross_32;
            this.buClos.Location = new System.Drawing.Point(227, 577);
            this.buClos.Name = "buClos";
            this.buClos.Size = new System.Drawing.Size(68, 35);
            this.buClos.TabIndex = 3;
            this.buClos.UseVisualStyleBackColor = false;
            this.buClos.Click += new System.EventHandler(this.buClos_Click);
            // 
            // FrmAddnewTestAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(561, 669);
            this.Controls.Add(this.buClos);
            this.Controls.Add(this.labTitel);
            this.Controls.Add(this.pictourTitle);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddnewTestAppointments";
            this.Text = "FrmAddnewTestAppointments";
            this.Load += new System.EventHandler(this.FrmAddnewTestAppointments_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictourTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictourTitle;
        private System.Windows.Forms.Label labTitel;
        private System.Windows.Forms.Label laInfoPerson;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labFees;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Button buSve;
        private System.Windows.Forms.Button buClos;
    }
}