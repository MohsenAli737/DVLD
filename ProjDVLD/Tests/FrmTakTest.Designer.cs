namespace ProjDVLD
{
    partial class FrmTakTest
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
            this.radioFaild = new System.Windows.Forms.RadioButton();
            this.radioPassed = new System.Windows.Forms.RadioButton();
            this.textNotes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.laAppId = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labenameClass = new System.Windows.Forms.Label();
            this.laFees = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.buSve = new System.Windows.Forms.Button();
            this.butClos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // radioFaild
            // 
            this.radioFaild.AutoSize = true;
            this.radioFaild.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioFaild.Location = new System.Drawing.Point(150, 52);
            this.radioFaild.Name = "radioFaild";
            this.radioFaild.Size = new System.Drawing.Size(45, 20);
            this.radioFaild.TabIndex = 2;
            this.radioFaild.Text = "Fail";
            this.radioFaild.UseVisualStyleBackColor = true;
            // 
            // radioPassed
            // 
            this.radioPassed.AutoSize = true;
            this.radioPassed.Checked = true;
            this.radioPassed.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPassed.Location = new System.Drawing.Point(150, 91);
            this.radioPassed.Name = "radioPassed";
            this.radioPassed.Size = new System.Drawing.Size(71, 20);
            this.radioPassed.TabIndex = 3;
            this.radioPassed.TabStop = true;
            this.radioPassed.Text = "Passed";
            this.radioPassed.UseVisualStyleBackColor = true;
            // 
            // textNotes
            // 
            this.textNotes.Location = new System.Drawing.Point(26, 206);
            this.textNotes.Multiline = true;
            this.textNotes.Name = "textNotes";
            this.textNotes.Size = new System.Drawing.Size(195, 86);
            this.textNotes.TabIndex = 4;
            this.textNotes.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nots:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(172, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "TakTest";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textNotes);
            this.groupBox1.Controls.Add(this.radioPassed);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioFaild);
            this.groupBox1.Location = new System.Drawing.Point(72, 298);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 327);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjDVLD.Properties.Resources.PassedTests_32;
            this.pictureBox2.Location = new System.Drawing.Point(76, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Result:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox7);
            this.groupBox3.Controls.Add(this.pictureBox6);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.laAppId);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.labName);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.labenameClass);
            this.groupBox3.Controls.Add(this.laFees);
            this.groupBox3.Controls.Add(this.pictureBox5);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(34, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(347, 200);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "InfPerson";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::ProjDVLD.Properties.Resources.Number_32;
            this.pictureBox7.Location = new System.Drawing.Point(81, 103);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(28, 27);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 20;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::ProjDVLD.Properties.Resources.Number_32;
            this.pictureBox6.Location = new System.Drawing.Point(227, 5);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(28, 27);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 19;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjDVLD.Properties.Resources.Number_32;
            this.pictureBox1.Location = new System.Drawing.Point(61, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // laAppId
            // 
            this.laAppId.AutoSize = true;
            this.laAppId.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laAppId.Location = new System.Drawing.Point(269, 16);
            this.laAppId.Name = "laAppId";
            this.laAppId.Size = new System.Drawing.Size(15, 16);
            this.laAppId.TabIndex = 18;
            this.laAppId.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(164, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Ap.L.Id:";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labName.Location = new System.Drawing.Point(102, 51);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(27, 16);
            this.labName.TabIndex = 16;
            this.labName.Text = ".....";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = " Name:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(-2, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "class Name:";
            // 
            // labenameClass
            // 
            this.labenameClass.AutoSize = true;
            this.labenameClass.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labenameClass.Location = new System.Drawing.Point(115, 114);
            this.labenameClass.Name = "labenameClass";
            this.labenameClass.Size = new System.Drawing.Size(31, 16);
            this.labenameClass.TabIndex = 13;
            this.labenameClass.Text = "......";
            // 
            // laFees
            // 
            this.laFees.AutoSize = true;
            this.laFees.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laFees.Location = new System.Drawing.Point(111, 156);
            this.laFees.Name = "laFees";
            this.laFees.Size = new System.Drawing.Size(15, 16);
            this.laFees.TabIndex = 12;
            this.laFees.Text = "0";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::ProjDVLD.Properties.Resources.money_32;
            this.pictureBox5.Location = new System.Drawing.Point(69, 150);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(28, 27);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(7, 156);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 16);
            this.label14.TabIndex = 10;
            this.label14.Text = "Fees:";
            // 
            // buSve
            // 
            this.buSve.BackColor = System.Drawing.Color.White;
            this.buSve.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buSve.Image = global::ProjDVLD.Properties.Resources.Save_32;
            this.buSve.Location = new System.Drawing.Point(222, 683);
            this.buSve.Name = "buSve";
            this.buSve.Size = new System.Drawing.Size(74, 39);
            this.buSve.TabIndex = 20;
            this.buSve.UseVisualStyleBackColor = false;
            this.buSve.Click += new System.EventHandler(this.buSve_Click);
            // 
            // butClos
            // 
            this.butClos.BackColor = System.Drawing.Color.White;
            this.butClos.ForeColor = System.Drawing.Color.White;
            this.butClos.Image = global::ProjDVLD.Properties.Resources.Close_32;
            this.butClos.Location = new System.Drawing.Point(92, 683);
            this.butClos.Name = "butClos";
            this.butClos.Size = new System.Drawing.Size(79, 39);
            this.butClos.TabIndex = 21;
            this.butClos.UseVisualStyleBackColor = false;
            // 
            // FrmTakTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 750);
            this.Controls.Add(this.butClos);
            this.Controls.Add(this.buSve);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Name = "FrmTakTest";
            this.Text = "FrmTakTest";
            this.Load += new System.EventHandler(this.FrmTakTest_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioFaild;
        private System.Windows.Forms.RadioButton radioPassed;
        private System.Windows.Forms.TextBox textNotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label laAppId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labenameClass;
        private System.Windows.Forms.Label laFees;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buSve;
        private System.Windows.Forms.Button butClos;
    }
}