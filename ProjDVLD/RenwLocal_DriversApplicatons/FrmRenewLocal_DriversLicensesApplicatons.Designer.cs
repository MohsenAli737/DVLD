namespace ProjDVLD
{
    partial class FrmRenewLocal_DriversLicensesApplicatons
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
            this.uscFlterLicences1 = new ProjDVLD.UscFlterLicences();
            this.buttRenew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelFees = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelLicensesId = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uscFlterLicences1
            // 
            this.uscFlterLicences1.BackColor = System.Drawing.Color.White;
            this.uscFlterLicences1.Location = new System.Drawing.Point(13, 13);
            this.uscFlterLicences1.Margin = new System.Windows.Forms.Padding(4);
            this.uscFlterLicences1.Name = "uscFlterLicences1";
            this.uscFlterLicences1.Size = new System.Drawing.Size(700, 915);
            this.uscFlterLicences1.TabIndex = 0;
            // 
            // buttRenew
            // 
            this.buttRenew.Location = new System.Drawing.Point(832, 504);
            this.buttRenew.Name = "buttRenew";
            this.buttRenew.Size = new System.Drawing.Size(140, 38);
            this.buttRenew.TabIndex = 1;
            this.buttRenew.Text = "Renw";
            this.buttRenew.UseVisualStyleBackColor = true;
            this.buttRenew.Click += new System.EventHandler(this.buttRenew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(759, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Renw Licenses Driver";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fees:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelLicensesId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelFees);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(720, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 322);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ApplicatonRenwLocalLicenses";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // labelFees
            // 
            this.labelFees.AutoSize = true;
            this.labelFees.Location = new System.Drawing.Point(182, 36);
            this.labelFees.Name = "labelFees";
            this.labelFees.Size = new System.Drawing.Size(44, 17);
            this.labelFees.TabIndex = 4;
            this.labelFees.Text = ".........";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "licensesIDnew :";
            // 
            // labelLicensesId
            // 
            this.labelLicensesId.AutoSize = true;
            this.labelLicensesId.Location = new System.Drawing.Point(182, 78);
            this.labelLicensesId.Name = "labelLicensesId";
            this.labelLicensesId.Size = new System.Drawing.Size(44, 17);
            this.labelLicensesId.TabIndex = 6;
            this.labelLicensesId.Text = ".........";
            // 
            // FrmRenewLocal_DriversLicensesApplicatons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1139, 808);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttRenew);
            this.Controls.Add(this.uscFlterLicences1);
            this.Name = "FrmRenewLocal_DriversLicensesApplicatons";
            this.Text = "FrmRenewLocal_DriversLicensesApplicatons";
            this.Load += new System.EventHandler(this.FrmRenewLocal_DriversLicensesApplicatons_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UscFlterLicences uscFlterLicences1;
        private System.Windows.Forms.Button buttRenew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelLicensesId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelFees;
    }
}