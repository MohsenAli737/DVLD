namespace ProjDVLD
{
    partial class uscFilterPerson
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
            this.textBoxFiletr = new System.Windows.Forms.TextBox();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butserch = new System.Windows.Forms.Button();
            this.buttonAddnew = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxFiletr
            // 
            this.textBoxFiletr.Location = new System.Drawing.Point(209, 40);
            this.textBoxFiletr.Name = "textBoxFiletr";
            this.textBoxFiletr.Size = new System.Drawing.Size(100, 20);
            this.textBoxFiletr.TabIndex = 0;
            this.textBoxFiletr.TextChanged += new System.EventHandler(this.textBoxFiletr_TextChanged);
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Location = new System.Drawing.Point(82, 39);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFilter.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filter By:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAddnew);
            this.groupBox1.Controls.Add(this.butserch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxFiletr);
            this.groupBox1.Controls.Add(this.comboBoxFilter);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 85);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Flter";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // butserch
            // 
            this.butserch.BackgroundImage = global::ProjDVLD.Properties.Resources.SearchPerson;
            this.butserch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butserch.Location = new System.Drawing.Point(330, 29);
            this.butserch.Name = "butserch";
            this.butserch.Size = new System.Drawing.Size(42, 40);
            this.butserch.TabIndex = 2;
            this.butserch.UseVisualStyleBackColor = true;
            this.butserch.Click += new System.EventHandler(this.butserch_Click);
            // 
            // buttonAddnew
            // 
            this.buttonAddnew.BackgroundImage = global::ProjDVLD.Properties.Resources.Add_Person_40;
            this.buttonAddnew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAddnew.Location = new System.Drawing.Point(388, 29);
            this.buttonAddnew.Name = "buttonAddnew";
            this.buttonAddnew.Size = new System.Drawing.Size(37, 40);
            this.buttonAddnew.TabIndex = 4;
            this.buttonAddnew.UseVisualStyleBackColor = true;
            this.buttonAddnew.Click += new System.EventHandler(this.buttonAddnew_Click);
            // 
            // uscFilterPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "uscFilterPerson";
            this.Size = new System.Drawing.Size(546, 90);
            this.Load += new System.EventHandler(this.uscFilterPerson_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFiletr;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Button butserch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAddnew;
    }
}
