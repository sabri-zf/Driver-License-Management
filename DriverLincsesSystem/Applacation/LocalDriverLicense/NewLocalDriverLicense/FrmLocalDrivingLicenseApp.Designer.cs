namespace DriverLincsesSystem.Applacation.LocalDriverLicense.NewLocalDriverLicense
{
    partial class FrmLocalDrivingLicenseApp
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
            this.tabNewLocalLicenseApplacation = new System.Windows.Forms.TabControl();
            this.TabPeronInfo = new System.Windows.Forms.TabPage();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.ctrCardPersonWithFilter1 = new DriverLincsesSystem.People.UControl.CtrCardPersonWithFilter();
            this.tbApplicationInfo = new System.Windows.Forms.TabPage();
            this.PLApplacationInfo = new System.Windows.Forms.Panel();
            this.CBLinsesClasses = new System.Windows.Forms.ComboBox();
            this.LabUserNameCreted = new System.Windows.Forms.Label();
            this.LabbFeesApp = new System.Windows.Forms.Label();
            this.LabDateApp = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LabL_D_App = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSaveLocal_D_L_App = new System.Windows.Forms.Button();
            this.LabTitleMode = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabNewLocalLicenseApplacation.SuspendLayout();
            this.TabPeronInfo.SuspendLayout();
            this.tbApplicationInfo.SuspendLayout();
            this.PLApplacationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // tabNewLocalLicenseApplacation
            // 
            this.tabNewLocalLicenseApplacation.Controls.Add(this.TabPeronInfo);
            this.tabNewLocalLicenseApplacation.Controls.Add(this.tbApplicationInfo);
            this.tabNewLocalLicenseApplacation.ItemSize = new System.Drawing.Size(150, 22);
            this.tabNewLocalLicenseApplacation.Location = new System.Drawing.Point(2, 145);
            this.tabNewLocalLicenseApplacation.Name = "tabNewLocalLicenseApplacation";
            this.tabNewLocalLicenseApplacation.SelectedIndex = 0;
            this.tabNewLocalLicenseApplacation.Size = new System.Drawing.Size(949, 509);
            this.tabNewLocalLicenseApplacation.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabNewLocalLicenseApplacation.TabIndex = 12;
            // 
            // TabPeronInfo
            // 
            this.TabPeronInfo.BackColor = System.Drawing.Color.White;
            this.TabPeronInfo.Controls.Add(this.btnNextPage);
            this.TabPeronInfo.Controls.Add(this.ctrCardPersonWithFilter1);
            this.TabPeronInfo.Location = new System.Drawing.Point(4, 26);
            this.TabPeronInfo.Name = "TabPeronInfo";
            this.TabPeronInfo.Size = new System.Drawing.Size(941, 479);
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
            // ctrCardPersonWithFilter1
            // 
            this.ctrCardPersonWithFilter1.AddNewPerson = true;
            this.ctrCardPersonWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrCardPersonWithFilter1.FilterEnable = true;
            this.ctrCardPersonWithFilter1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrCardPersonWithFilter1.Location = new System.Drawing.Point(0, 0);
            this.ctrCardPersonWithFilter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrCardPersonWithFilter1.Name = "ctrCardPersonWithFilter1";
            this.ctrCardPersonWithFilter1.Size = new System.Drawing.Size(944, 474);
            this.ctrCardPersonWithFilter1.TabIndex = 0;
            this.ctrCardPersonWithFilter1.OnSelectedPerson += new System.Action<int>(this.ctrCardPersonWithFilter1_OnSelectedPerson);
            // 
            // tbApplicationInfo
            // 
            this.tbApplicationInfo.BackColor = System.Drawing.Color.White;
            this.tbApplicationInfo.Controls.Add(this.PLApplacationInfo);
            this.tbApplicationInfo.Controls.Add(this.btnSaveLocal_D_L_App);
            this.tbApplicationInfo.Location = new System.Drawing.Point(4, 26);
            this.tbApplicationInfo.Name = "tbApplicationInfo";
            this.tbApplicationInfo.Size = new System.Drawing.Size(941, 479);
            this.tbApplicationInfo.TabIndex = 1;
            this.tbApplicationInfo.Text = "Applaction Info";
            // 
            // PLApplacationInfo
            // 
            this.PLApplacationInfo.Controls.Add(this.CBLinsesClasses);
            this.PLApplacationInfo.Controls.Add(this.LabUserNameCreted);
            this.PLApplacationInfo.Controls.Add(this.LabbFeesApp);
            this.PLApplacationInfo.Controls.Add(this.LabDateApp);
            this.PLApplacationInfo.Controls.Add(this.pictureBox2);
            this.PLApplacationInfo.Controls.Add(this.label5);
            this.PLApplacationInfo.Controls.Add(this.label4);
            this.PLApplacationInfo.Controls.Add(this.pictureBox1);
            this.PLApplacationInfo.Controls.Add(this.LabL_D_App);
            this.PLApplacationInfo.Controls.Add(this.pictureBox3);
            this.PLApplacationInfo.Controls.Add(this.pictureBox4);
            this.PLApplacationInfo.Controls.Add(this.pictureBox5);
            this.PLApplacationInfo.Controls.Add(this.label1);
            this.PLApplacationInfo.Controls.Add(this.label2);
            this.PLApplacationInfo.Controls.Add(this.label3);
            this.PLApplacationInfo.Location = new System.Drawing.Point(49, 56);
            this.PLApplacationInfo.Name = "PLApplacationInfo";
            this.PLApplacationInfo.Size = new System.Drawing.Size(861, 268);
            this.PLApplacationInfo.TabIndex = 15;
            // 
            // CBLinsesClasses
            // 
            this.CBLinsesClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBLinsesClasses.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBLinsesClasses.FormattingEnabled = true;
            this.CBLinsesClasses.Location = new System.Drawing.Point(257, 102);
            this.CBLinsesClasses.Name = "CBLinsesClasses";
            this.CBLinsesClasses.Size = new System.Drawing.Size(244, 25);
            this.CBLinsesClasses.TabIndex = 18;
            // 
            // LabUserNameCreted
            // 
            this.LabUserNameCreted.AutoSize = true;
            this.LabUserNameCreted.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabUserNameCreted.Location = new System.Drawing.Point(253, 193);
            this.LabUserNameCreted.Name = "LabUserNameCreted";
            this.LabUserNameCreted.Size = new System.Drawing.Size(40, 20);
            this.LabUserNameCreted.TabIndex = 17;
            this.LabUserNameCreted.Text = "[???]";
            // 
            // LabbFeesApp
            // 
            this.LabbFeesApp.AutoSize = true;
            this.LabbFeesApp.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabbFeesApp.Location = new System.Drawing.Point(253, 150);
            this.LabbFeesApp.Name = "LabbFeesApp";
            this.LabbFeesApp.Size = new System.Drawing.Size(40, 20);
            this.LabbFeesApp.TabIndex = 16;
            this.LabbFeesApp.Text = "[???]";
            // 
            // LabDateApp
            // 
            this.LabDateApp.AutoSize = true;
            this.LabDateApp.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDateApp.Location = new System.Drawing.Point(253, 59);
            this.LabDateApp.Name = "LabDateApp";
            this.LabDateApp.Size = new System.Drawing.Size(40, 20);
            this.LabDateApp.TabIndex = 15;
            this.LabDateApp.Text = "[???]";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DriverLincsesSystem.Properties.Resources.User_32__2;
            this.pictureBox2.Location = new System.Drawing.Point(205, 186);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(94, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Create By";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Application Date";
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
            // LabL_D_App
            // 
            this.LabL_D_App.AutoSize = true;
            this.LabL_D_App.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabL_D_App.Location = new System.Drawing.Point(253, 16);
            this.LabL_D_App.Name = "LabL_D_App";
            this.LabL_D_App.Size = new System.Drawing.Size(40, 20);
            this.LabL_D_App.TabIndex = 7;
            this.LabL_D_App.Text = "[???]";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DriverLincsesSystem.Properties.Resources.money_32;
            this.pictureBox3.Location = new System.Drawing.Point(205, 142);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DriverLincsesSystem.Properties.Resources.Notes_32;
            this.pictureBox4.Location = new System.Drawing.Point(205, 98);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 29);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::DriverLincsesSystem.Properties.Resources.AddAppointment_32;
            this.pictureBox5.Location = new System.Drawing.Point(205, 54);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(34, 29);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "D_L Application ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Applacation Fees";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "License Classes";
            // 
            // btnSaveLocal_D_L_App
            // 
            this.btnSaveLocal_D_L_App.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveLocal_D_L_App.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveLocal_D_L_App.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveLocal_D_L_App.Image = global::DriverLincsesSystem.Properties.Resources.Save_32;
            this.btnSaveLocal_D_L_App.Location = new System.Drawing.Point(776, 424);
            this.btnSaveLocal_D_L_App.Name = "btnSaveLocal_D_L_App";
            this.btnSaveLocal_D_L_App.Size = new System.Drawing.Size(138, 38);
            this.btnSaveLocal_D_L_App.TabIndex = 14;
            this.btnSaveLocal_D_L_App.Text = "Save";
            this.btnSaveLocal_D_L_App.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveLocal_D_L_App.UseVisualStyleBackColor = true;
            this.btnSaveLocal_D_L_App.Click += new System.EventHandler(this.btnSaveLocal_D_L_App_Click);
            // 
            // LabTitleMode
            // 
            this.LabTitleMode.AutoSize = true;
            this.LabTitleMode.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabTitleMode.ForeColor = System.Drawing.Color.Red;
            this.LabTitleMode.Location = new System.Drawing.Point(107, 37);
            this.LabTitleMode.Name = "LabTitleMode";
            this.LabTitleMode.Size = new System.Drawing.Size(701, 54);
            this.LabTitleMode.TabIndex = 14;
            this.LabTitleMode.Text = "New Local Driving License Applcation";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DriverLincsesSystem.Properties.Resources.Close_32;
            this.btnClose.Location = new System.Drawing.Point(778, 660);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 38);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmLocalDrivingLicenseApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(955, 710);
            this.Controls.Add(this.tabNewLocalLicenseApplacation);
            this.Controls.Add(this.LabTitleMode);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmLocalDrivingLicenseApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Local Driving License";
            this.Load += new System.EventHandler(this.FrmLocalDrivingLicenseApp_Load);
            this.tabNewLocalLicenseApplacation.ResumeLayout(false);
            this.TabPeronInfo.ResumeLayout(false);
            this.tbApplicationInfo.ResumeLayout(false);
            this.PLApplacationInfo.ResumeLayout(false);
            this.PLApplacationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabNewLocalLicenseApplacation;
        private System.Windows.Forms.TabPage TabPeronInfo;
        private System.Windows.Forms.Button btnNextPage;
        private People.UControl.CtrCardPersonWithFilter ctrCardPersonWithFilter1;
        private System.Windows.Forms.TabPage tbApplicationInfo;
        private System.Windows.Forms.Panel PLApplacationInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LabL_D_App;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSaveLocal_D_L_App;
        private System.Windows.Forms.Label LabTitleMode;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox CBLinsesClasses;
        private System.Windows.Forms.Label LabUserNameCreted;
        private System.Windows.Forms.Label LabbFeesApp;
        private System.Windows.Forms.Label LabDateApp;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
    }
}