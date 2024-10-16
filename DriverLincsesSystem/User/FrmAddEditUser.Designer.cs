namespace DriverLincsesSystem.User
{
    partial class FrmAddEditUser
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
            this.components = new System.ComponentModel.Container();
            this.LabTitleMode = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabPeronInfo = new System.Windows.Forms.TabPage();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.ctrCardPersonWithFilter2 = new DriverLincsesSystem.People.UControl.CtrCardPersonWithFilter();
            this.tbLoginInfo = new System.Windows.Forms.TabPage();
            this.PLUserInfo = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ChB_IsActive = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LabUserID = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.TBConfirmPassword = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.TBNewPassword = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.TBUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSaveUser = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.TabPeronInfo.SuspendLayout();
            this.tbLoginInfo.SuspendLayout();
            this.PLUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabTitleMode
            // 
            this.LabTitleMode.AutoSize = true;
            this.LabTitleMode.Font = new System.Drawing.Font("Segoe UI Semibold", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabTitleMode.ForeColor = System.Drawing.Color.Red;
            this.LabTitleMode.Location = new System.Drawing.Point(328, 9);
            this.LabTitleMode.Name = "LabTitleMode";
            this.LabTitleMode.Size = new System.Drawing.Size(257, 72);
            this.LabTitleMode.TabIndex = 11;
            this.LabTitleMode.Text = "Add User";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabPeronInfo);
            this.tabControl1.Controls.Add(this.tbLoginInfo);
            this.tabControl1.ItemSize = new System.Drawing.Size(150, 22);
            this.tabControl1.Location = new System.Drawing.Point(2, 121);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(944, 509);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 1;
            // 
            // TabPeronInfo
            // 
            this.TabPeronInfo.BackColor = System.Drawing.Color.White;
            this.TabPeronInfo.Controls.Add(this.btnNextPage);
            this.TabPeronInfo.Controls.Add(this.ctrCardPersonWithFilter2);
            this.TabPeronInfo.Location = new System.Drawing.Point(4, 26);
            this.TabPeronInfo.Name = "TabPeronInfo";
            this.TabPeronInfo.Size = new System.Drawing.Size(936, 479);
            this.TabPeronInfo.TabIndex = 0;
            this.TabPeronInfo.Text = "Person Info";
            // 
            // btnNextPage
            // 
            this.btnNextPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextPage.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextPage.Image = global::DriverLincsesSystem.Properties.Resources.Next_32;
            this.btnNextPage.Location = new System.Drawing.Point(785, 420);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(138, 38);
            this.btnNextPage.TabIndex = 13;
            this.btnNextPage.Text = "next";
            this.btnNextPage.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // ctrCardPersonWithFilter2
            // 
            this.ctrCardPersonWithFilter2.AddNewPerson = true;
            this.ctrCardPersonWithFilter2.BackColor = System.Drawing.Color.White;
            this.ctrCardPersonWithFilter2.FilterEnable = true;
            this.ctrCardPersonWithFilter2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrCardPersonWithFilter2.Location = new System.Drawing.Point(0, 0);
            this.ctrCardPersonWithFilter2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrCardPersonWithFilter2.Name = "ctrCardPersonWithFilter2";
            this.ctrCardPersonWithFilter2.Size = new System.Drawing.Size(936, 474);
            this.ctrCardPersonWithFilter2.TabIndex = 0;
            // 
            // tbLoginInfo
            // 
            this.tbLoginInfo.BackColor = System.Drawing.Color.White;
            this.tbLoginInfo.Controls.Add(this.PLUserInfo);
            this.tbLoginInfo.Controls.Add(this.btnSaveUser);
            this.tbLoginInfo.Location = new System.Drawing.Point(4, 26);
            this.tbLoginInfo.Name = "tbLoginInfo";
            this.tbLoginInfo.Size = new System.Drawing.Size(936, 479);
            this.tbLoginInfo.TabIndex = 1;
            this.tbLoginInfo.Text = "Login";
            // 
            // PLUserInfo
            // 
            this.PLUserInfo.Controls.Add(this.label4);
            this.PLUserInfo.Controls.Add(this.pictureBox1);
            this.PLUserInfo.Controls.Add(this.ChB_IsActive);
            this.PLUserInfo.Controls.Add(this.pictureBox2);
            this.PLUserInfo.Controls.Add(this.LabUserID);
            this.PLUserInfo.Controls.Add(this.pictureBox3);
            this.PLUserInfo.Controls.Add(this.TBConfirmPassword);
            this.PLUserInfo.Controls.Add(this.pictureBox4);
            this.PLUserInfo.Controls.Add(this.TBNewPassword);
            this.PLUserInfo.Controls.Add(this.pictureBox5);
            this.PLUserInfo.Controls.Add(this.TBUserName);
            this.PLUserInfo.Controls.Add(this.label1);
            this.PLUserInfo.Controls.Add(this.label2);
            this.PLUserInfo.Controls.Add(this.label3);
            this.PLUserInfo.Location = new System.Drawing.Point(49, 56);
            this.PLUserInfo.Name = "PLUserInfo";
            this.PLUserInfo.Size = new System.Drawing.Size(462, 268);
            this.PLUserInfo.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(113, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "UserName";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DriverLincsesSystem.Properties.Resources.Number_321;
            this.pictureBox1.Location = new System.Drawing.Point(205, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 29);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // ChB_IsActive
            // 
            this.ChB_IsActive.AutoSize = true;
            this.ChB_IsActive.Location = new System.Drawing.Point(253, 193);
            this.ChB_IsActive.Name = "ChB_IsActive";
            this.ChB_IsActive.Size = new System.Drawing.Size(78, 21);
            this.ChB_IsActive.TabIndex = 13;
            this.ChB_IsActive.Text = "Is Active";
            this.ChB_IsActive.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DriverLincsesSystem.Properties.Resources.Local_32;
            this.pictureBox2.Location = new System.Drawing.Point(205, 182);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 32);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // LabUserID
            // 
            this.LabUserID.AutoSize = true;
            this.LabUserID.Location = new System.Drawing.Point(253, 16);
            this.LabUserID.Name = "LabUserID";
            this.LabUserID.Size = new System.Drawing.Size(34, 17);
            this.LabUserID.TabIndex = 7;
            this.LabUserID.Text = "[???]";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DriverLincsesSystem.Properties.Resources.Password_32;
            this.pictureBox3.Location = new System.Drawing.Point(205, 136);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 29);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // TBConfirmPassword
            // 
            this.TBConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBConfirmPassword.HideSelection = false;
            this.TBConfirmPassword.Location = new System.Drawing.Point(253, 137);
            this.TBConfirmPassword.MaxLength = 20;
            this.TBConfirmPassword.Name = "TBConfirmPassword";
            this.TBConfirmPassword.PasswordChar = '*';
            this.TBConfirmPassword.ShortcutsEnabled = false;
            this.TBConfirmPassword.Size = new System.Drawing.Size(154, 25);
            this.TBConfirmPassword.TabIndex = 6;
            this.TBConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TBConfirmPassword_Validating);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DriverLincsesSystem.Properties.Resources.Password_32;
            this.pictureBox4.Location = new System.Drawing.Point(205, 94);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 29);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // TBNewPassword
            // 
            this.TBNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBNewPassword.HideSelection = false;
            this.TBNewPassword.Location = new System.Drawing.Point(253, 94);
            this.TBNewPassword.MaxLength = 20;
            this.TBNewPassword.Name = "TBNewPassword";
            this.TBNewPassword.PasswordChar = '*';
            this.TBNewPassword.ShortcutsEnabled = false;
            this.TBNewPassword.Size = new System.Drawing.Size(154, 25);
            this.TBNewPassword.TabIndex = 5;
            this.TBNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TBNewPassword_Validating);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::DriverLincsesSystem.Properties.Resources.Person_32;
            this.pictureBox5.Location = new System.Drawing.Point(205, 52);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(34, 29);
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // TBUserName
            // 
            this.TBUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBUserName.HideSelection = false;
            this.TBUserName.Location = new System.Drawing.Point(253, 51);
            this.TBUserName.MaxLength = 20;
            this.TBUserName.Name = "TBUserName";
            this.TBUserName.ShortcutsEnabled = false;
            this.TBUserName.Size = new System.Drawing.Size(154, 25);
            this.TBUserName.TabIndex = 4;
            this.TBUserName.Validating += new System.ComponentModel.CancelEventHandler(this.TBUserName_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Confirm Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveUser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveUser.Image = global::DriverLincsesSystem.Properties.Resources.Save_32;
            this.btnSaveUser.Location = new System.Drawing.Point(776, 424);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Size = new System.Drawing.Size(138, 38);
            this.btnSaveUser.TabIndex = 14;
            this.btnSaveUser.Text = "Save";
            this.btnSaveUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveUser.UseVisualStyleBackColor = true;
            this.btnSaveUser.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DriverLincsesSystem.Properties.Resources.Close_32;
            this.btnClose.Location = new System.Drawing.Point(791, 636);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 38);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmAddEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(951, 691);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.LabTitleMode);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAddEditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " Add User";
            this.Load += new System.EventHandler(this.FrmAddEditUser_Load);
            this.tabControl1.ResumeLayout(false);
            this.TabPeronInfo.ResumeLayout(false);
            this.tbLoginInfo.ResumeLayout(false);
            this.PLUserInfo.ResumeLayout(false);
            this.PLUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label LabTitleMode;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabPeronInfo;
        private System.Windows.Forms.TabPage tbLoginInfo;
        private System.Windows.Forms.Button btnNextPage;
        private People.UControl.CtrCardPersonWithFilter ctrCardPersonWithFilter2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBUserName;
        private System.Windows.Forms.TextBox TBConfirmPassword;
        private System.Windows.Forms.TextBox TBNewPassword;
        private System.Windows.Forms.Label LabUserID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox ChB_IsActive;
        private System.Windows.Forms.Button btnSaveUser;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel PLUserInfo;
    }
}