namespace ProjDVLD
{
    partial class UseShowFilter
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
            this.uscShowPerson1 = new ProjDVLD.uscShowPerson();
            this.uscFilterPerson1 = new ProjDVLD.uscFilterPerson();
            this.SuspendLayout();
            // 
            // uscShowPerson1
            // 
            this.uscShowPerson1.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uscShowPerson1.Location = new System.Drawing.Point(-29, 119);
            this.uscShowPerson1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.uscShowPerson1.Name = "uscShowPerson1";
            this.uscShowPerson1.Size = new System.Drawing.Size(905, 394);
            this.uscShowPerson1.TabIndex = 0;
            this.uscShowPerson1.Load += new System.EventHandler(this.uscShowPerson1_Load);
            // 
            // uscFilterPerson1
            // 
            this.uscFilterPerson1.Location = new System.Drawing.Point(89, 22);
            this.uscFilterPerson1.Name = "uscFilterPerson1";
            this.uscFilterPerson1.Size = new System.Drawing.Size(427, 90);
            this.uscFilterPerson1.TabIndex = 1;
            this.uscFilterPerson1.Load += new System.EventHandler(this.uscFilterPerson1_Load);
            // 
            // UseShowFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uscFilterPerson1);
            this.Controls.Add(this.uscShowPerson1);
            this.Name = "UseShowFilter";
            this.Size = new System.Drawing.Size(898, 573);
            this.Load += new System.EventHandler(this.UseShowFilter_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private uscShowPerson uscShowPerson1;
        private uscFilterPerson uscFilterPerson1;
    }
}
