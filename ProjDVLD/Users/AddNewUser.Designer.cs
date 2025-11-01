namespace ProjDVLD
{
    partial class AddNewUser
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
            this.tabControlI = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.butNext = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.labUserId = new System.Windows.Forms.Label();
            this.check_Is_Achin = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textPassord = new System.Windows.Forms.TextBox();
            this.textoxPassordAgin = new System.Windows.Forms.TextBox();
            this.butSave = new System.Windows.Forms.Button();
            this.butClose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.useShowFilter1 = new ProjDVLD.UseShowFilter();
            this.tabControlI.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBoxLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlI
            // 
            this.tabControlI.Controls.Add(this.tabPage1);
            this.tabControlI.Controls.Add(this.tabPage2);
            this.tabControlI.Location = new System.Drawing.Point(13, 60);
            this.tabControlI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControlI.Name = "tabControlI";
            this.tabControlI.SelectedIndex = 0;
            this.tabControlI.Size = new System.Drawing.Size(1227, 665);
            this.tabControlI.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.useShowFilter1);
            this.tabPage1.Controls.Add(this.butNext);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1219, 636);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Person Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // butNext
            // 
            this.butNext.BackgroundImage = global::ProjDVLD.Properties.Resources.Next_32;
            this.butNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butNext.Enabled = false;
            this.butNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butNext.Location = new System.Drawing.Point(807, 52);
            this.butNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butNext.Name = "butNext";
            this.butNext.Size = new System.Drawing.Size(135, 49);
            this.butNext.TabIndex = 5;
            this.butNext.Text = "Next";
            this.butNext.UseVisualStyleBackColor = true;
            this.butNext.Click += new System.EventHandler(this.butNext_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBoxLogin);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1219, 636);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Login Info";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBoxLogin.Controls.Add(this.pictureBox6);
            this.groupBoxLogin.Controls.Add(this.pictureBox4);
            this.groupBoxLogin.Controls.Add(this.pictureBox2);
            this.groupBoxLogin.Controls.Add(this.pictureBox1);
            this.groupBoxLogin.Controls.Add(this.textUserName);
            this.groupBoxLogin.Controls.Add(this.labUserId);
            this.groupBoxLogin.Controls.Add(this.check_Is_Achin);
            this.groupBoxLogin.Controls.Add(this.label4);
            this.groupBoxLogin.Controls.Add(this.label1);
            this.groupBoxLogin.Controls.Add(this.label2);
            this.groupBoxLogin.Controls.Add(this.label3);
            this.groupBoxLogin.Controls.Add(this.textPassord);
            this.groupBoxLogin.Controls.Add(this.textoxPassordAgin);
            this.groupBoxLogin.Enabled = false;
            this.groupBoxLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxLogin.Location = new System.Drawing.Point(54, 50);
            this.groupBoxLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxLogin.Size = new System.Drawing.Size(280, 314);
            this.groupBoxLogin.TabIndex = 9;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "Login";
            this.groupBoxLogin.Enter += new System.EventHandler(this.groupBoxLogin_Enter);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.BackgroundImage = global::ProjDVLD.Properties.Resources.Password_32;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.Location = new System.Drawing.Point(125, 178);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 37);
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::ProjDVLD.Properties.Resources.User_32__2;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(156, 20);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 25);
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = global::ProjDVLD.Properties.Resources.Password_32;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(120, 114);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 37);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ProjDVLD.Properties.Resources.User_32__2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(120, 63);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 25);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // textUserName
            // 
            this.textUserName.Location = new System.Drawing.Point(156, 63);
            this.textUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(116, 24);
            this.textUserName.TabIndex = 2;
            // 
            // labUserId
            // 
            this.labUserId.AutoSize = true;
            this.labUserId.Location = new System.Drawing.Point(206, 20);
            this.labUserId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labUserId.Name = "labUserId";
            this.labUserId.Size = new System.Drawing.Size(29, 17);
            this.labUserId.TabIndex = 7;
            this.labUserId.Text = "???";
            // 
            // check_Is_Achin
            // 
            this.check_Is_Achin.AutoSize = true;
            this.check_Is_Achin.Location = new System.Drawing.Point(120, 272);
            this.check_Is_Achin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.check_Is_Achin.Name = "check_Is_Achin";
            this.check_Is_Achin.Size = new System.Drawing.Size(81, 21);
            this.check_Is_Achin.TabIndex = 8;
            this.check_Is_Achin.Text = "Is Active";
            this.check_Is_Achin.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "UserId";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Agin Password";
            // 
            // textPassord
            // 
            this.textPassord.Location = new System.Drawing.Point(156, 114);
            this.textPassord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textPassord.Name = "textPassord";
            this.textPassord.Size = new System.Drawing.Size(116, 24);
            this.textPassord.TabIndex = 0;
            // 
            // textoxPassordAgin
            // 
            this.textoxPassordAgin.Location = new System.Drawing.Point(156, 191);
            this.textoxPassordAgin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textoxPassordAgin.Name = "textoxPassordAgin";
            this.textoxPassordAgin.Size = new System.Drawing.Size(116, 24);
            this.textoxPassordAgin.TabIndex = 1;
            // 
            // butSave
            // 
            this.butSave.BackgroundImage = global::ProjDVLD.Properties.Resources.Save_32;
            this.butSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butSave.Enabled = false;
            this.butSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSave.Location = new System.Drawing.Point(1074, 743);
            this.butSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(162, 46);
            this.butSave.TabIndex = 3;
            this.butSave.Text = "Save";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // butClose
            // 
            this.butClose.BackgroundImage = global::ProjDVLD.Properties.Resources.Close_32;
            this.butClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butClose.Location = new System.Drawing.Point(877, 743);
            this.butClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(146, 50);
            this.butClose.TabIndex = 4;
            this.butClose.Text = "close";
            this.butClose.UseVisualStyleBackColor = true;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(462, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(270, 45);
            this.label5.TabIndex = 5;
            this.label5.Text = "Add New User";
            // 
            // useShowFilter1
            // 
            this.useShowFilter1.Location = new System.Drawing.Point(54, 110);
            this.useShowFilter1.Margin = new System.Windows.Forms.Padding(5);
            this.useShowFilter1.Name = "useShowFilter1";
            this.useShowFilter1.Size = new System.Drawing.Size(1040, 615);
            this.useShowFilter1.TabIndex = 6;
            this.useShowFilter1.Load += new System.EventHandler(this.useShowFilter1_Load);
            // 
            // AddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1253, 826);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.tabControlI);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddNewUser";
            this.Text = "AddNewUser";
            this.Load += new System.EventHandler(this.AddNewUser_Load);
            this.tabControlI.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControlI;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button butNext;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.TextBox textoxPassordAgin;
        private System.Windows.Forms.TextBox textPassord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labUserId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox check_Is_Achin;
        private System.Windows.Forms.GroupBox groupBoxLogin;
        private UseShowFilter useShowFilter1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label5;
    }
}