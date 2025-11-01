namespace ProjDVLD
{
    partial class LoginScren
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
            this.textBoxPassord = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checMemember = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.butLogin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPassord
            // 
            this.textBoxPassord.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassord.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxPassord.Location = new System.Drawing.Point(690, 195);
            this.textBoxPassord.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassord.Multiline = true;
            this.textBoxPassord.Name = "textBoxPassord";
            this.textBoxPassord.Size = new System.Drawing.Size(116, 29);
            this.textBoxPassord.TabIndex = 0;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxUserName.Location = new System.Drawing.Point(690, 128);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUserName.Multiline = true;
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(116, 26);
            this.textBoxUserName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(608, 346);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 34);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(550, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "UserName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(550, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // checMemember
            // 
            this.checMemember.AutoSize = true;
            this.checMemember.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checMemember.Location = new System.Drawing.Point(681, 242);
            this.checMemember.Margin = new System.Windows.Forms.Padding(4);
            this.checMemember.Name = "checMemember";
            this.checMemember.Size = new System.Drawing.Size(107, 21);
            this.checMemember.TabIndex = 7;
            this.checMemember.Text = "Memember";
            this.checMemember.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ProjDVLD.Properties.Resources.closeBlack32;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(906, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 44);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // butLogin
            // 
            this.butLogin.BackColor = System.Drawing.Color.White;
            this.butLogin.BackgroundImage = global::ProjDVLD.Properties.Resources.sign_in_32;
            this.butLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butLogin.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLogin.Location = new System.Drawing.Point(851, 280);
            this.butLogin.Margin = new System.Windows.Forms.Padding(4);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(122, 47);
            this.butLogin.TabIndex = 3;
            this.butLogin.Tag = "Login";
            this.butLogin.UseVisualStyleBackColor = false;
            this.butLogin.Click += new System.EventHandler(this.butLogin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(607, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 38);
            this.label4.TabIndex = 10;
            this.label4.Text = "برنامج رخصه القياده";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(23, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(276, 38);
            this.label5.TabIndex = 11;
            this.label5.Text = "برمجه : محسن الواحدي";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(31, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 89);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // LoginScren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ProjDVLD.Properties.Resources.cabriolet_5031360__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(999, 475);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checMemember);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butLogin);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.textBoxPassord);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginScren";
            this.Text = "LoginScren";
            this.Load += new System.EventHandler(this.LoginScren_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPassord;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Button butLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checMemember;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}