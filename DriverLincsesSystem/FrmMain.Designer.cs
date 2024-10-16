namespace DriverLincsesSystem
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ApplacationMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.drivingLicensesServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDriverLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renewDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReplacementforLostorDamagedLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseDetainedDriveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retakeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplacationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localDrivingLicenseAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalLicenseAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detainLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTestTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PeopleManegment = new System.Windows.Forms.ToolStripMenuItem();
            this.DriverManegment = new System.Windows.Forms.ToolStripMenuItem();
            this.UserManegment = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCurrentUser = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ApplacationMenu,
            this.PeopleManegment,
            this.DriverManegment,
            this.UserManegment,
            this.AccountSetting});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 43);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ApplacationMenu
            // 
            this.ApplacationMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drivingLicensesServicesToolStripMenuItem,
            this.manageApplacationToolStripMenuItem,
            this.detainLicensesToolStripMenuItem,
            this.manageApplicationTypesToolStripMenuItem,
            this.manageTestTypeToolStripMenuItem});
            this.ApplacationMenu.Image = global::DriverLincsesSystem.Properties.Resources.Applications1;
            this.ApplacationMenu.Name = "ApplacationMenu";
            this.ApplacationMenu.Size = new System.Drawing.Size(171, 39);
            this.ApplacationMenu.Text = "Applacation";
            // 
            // drivingLicensesServicesToolStripMenuItem
            // 
            this.drivingLicensesServicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDriverLicenseToolStripMenuItem,
            this.renewDrivingLicenseToolStripMenuItem,
            this.ReplacementforLostorDamagedLicense,
            this.releaseDetainedDriveToolStripMenuItem,
            this.retakeTestToolStripMenuItem});
            this.drivingLicensesServicesToolStripMenuItem.Image = global::DriverLincsesSystem.Properties.Resources.Driver_License_48;
            this.drivingLicensesServicesToolStripMenuItem.Name = "drivingLicensesServicesToolStripMenuItem";
            this.drivingLicensesServicesToolStripMenuItem.Size = new System.Drawing.Size(351, 42);
            this.drivingLicensesServicesToolStripMenuItem.Text = "Driving Licenses Services";
            // 
            // newDriverLicenseToolStripMenuItem
            // 
            this.newDriverLicenseToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.newDriverLicenseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localLicenseToolStripMenuItem,
            this.inteToolStripMenuItem});
            this.newDriverLicenseToolStripMenuItem.Image = global::DriverLincsesSystem.Properties.Resources.New_Driving_License_32;
            this.newDriverLicenseToolStripMenuItem.Name = "newDriverLicenseToolStripMenuItem";
            this.newDriverLicenseToolStripMenuItem.Size = new System.Drawing.Size(497, 42);
            this.newDriverLicenseToolStripMenuItem.Text = "New Driving license";
            // 
            // localLicenseToolStripMenuItem
            // 
            this.localLicenseToolStripMenuItem.Image = global::DriverLincsesSystem.Properties.Resources.Local_321;
            this.localLicenseToolStripMenuItem.Name = "localLicenseToolStripMenuItem";
            this.localLicenseToolStripMenuItem.Size = new System.Drawing.Size(297, 42);
            this.localLicenseToolStripMenuItem.Text = "Local License";
            this.localLicenseToolStripMenuItem.Click += new System.EventHandler(this.localLicenseToolStripMenuItem_Click);
            // 
            // inteToolStripMenuItem
            // 
            this.inteToolStripMenuItem.Image = global::DriverLincsesSystem.Properties.Resources.International_32;
            this.inteToolStripMenuItem.Name = "inteToolStripMenuItem";
            this.inteToolStripMenuItem.Size = new System.Drawing.Size(297, 42);
            this.inteToolStripMenuItem.Text = "International License";
            // 
            // renewDrivingLicenseToolStripMenuItem
            // 
            this.renewDrivingLicenseToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.renewDrivingLicenseToolStripMenuItem.Image = global::DriverLincsesSystem.Properties.Resources.Renew_Driving_License_32;
            this.renewDrivingLicenseToolStripMenuItem.Name = "renewDrivingLicenseToolStripMenuItem";
            this.renewDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(497, 42);
            this.renewDrivingLicenseToolStripMenuItem.Text = "Renew Driving License";
            // 
            // ReplacementforLostorDamagedLicense
            // 
            this.ReplacementforLostorDamagedLicense.Image = global::DriverLincsesSystem.Properties.Resources.New_Driving_License_321;
            this.ReplacementforLostorDamagedLicense.Name = "ReplacementforLostorDamagedLicense";
            this.ReplacementforLostorDamagedLicense.Size = new System.Drawing.Size(497, 42);
            this.ReplacementforLostorDamagedLicense.Text = "Replacement for Lost or Damaged License";
            // 
            // releaseDetainedDriveToolStripMenuItem
            // 
            this.releaseDetainedDriveToolStripMenuItem.Image = global::DriverLincsesSystem.Properties.Resources.Detained_Driving_License_32;
            this.releaseDetainedDriveToolStripMenuItem.Name = "releaseDetainedDriveToolStripMenuItem";
            this.releaseDetainedDriveToolStripMenuItem.Size = new System.Drawing.Size(497, 42);
            this.releaseDetainedDriveToolStripMenuItem.Text = "Release Detained Driving License";
            // 
            // retakeTestToolStripMenuItem
            // 
            this.retakeTestToolStripMenuItem.Image = global::DriverLincsesSystem.Properties.Resources.Retake_Test_32;
            this.retakeTestToolStripMenuItem.Name = "retakeTestToolStripMenuItem";
            this.retakeTestToolStripMenuItem.Size = new System.Drawing.Size(497, 42);
            this.retakeTestToolStripMenuItem.Text = "Retake Test";
            // 
            // manageApplacationToolStripMenuItem
            // 
            this.manageApplacationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localDrivingLicenseAppToolStripMenuItem,
            this.internationalLicenseAppToolStripMenuItem});
            this.manageApplacationToolStripMenuItem.Image = global::DriverLincsesSystem.Properties.Resources.Manage_Applications_64;
            this.manageApplacationToolStripMenuItem.Name = "manageApplacationToolStripMenuItem";
            this.manageApplacationToolStripMenuItem.Size = new System.Drawing.Size(351, 42);
            this.manageApplacationToolStripMenuItem.Text = "Manage Applacation";
            // 
            // localDrivingLicenseAppToolStripMenuItem
            // 
            this.localDrivingLicenseAppToolStripMenuItem.Image = global::DriverLincsesSystem.Properties.Resources.Lost_Driving_License_32;
            this.localDrivingLicenseAppToolStripMenuItem.Name = "localDrivingLicenseAppToolStripMenuItem";
            this.localDrivingLicenseAppToolStripMenuItem.Size = new System.Drawing.Size(343, 42);
            this.localDrivingLicenseAppToolStripMenuItem.Text = "Local Driving License App";
            this.localDrivingLicenseAppToolStripMenuItem.Click += new System.EventHandler(this.localDrivingLicenseAppToolStripMenuItem_Click);
            // 
            // internationalLicenseAppToolStripMenuItem
            // 
            this.internationalLicenseAppToolStripMenuItem.Image = global::DriverLincsesSystem.Properties.Resources.International_321;
            this.internationalLicenseAppToolStripMenuItem.Name = "internationalLicenseAppToolStripMenuItem";
            this.internationalLicenseAppToolStripMenuItem.Size = new System.Drawing.Size(343, 42);
            this.internationalLicenseAppToolStripMenuItem.Text = "International License App";
            // 
            // detainLicensesToolStripMenuItem
            // 
            this.detainLicensesToolStripMenuItem.Image = global::DriverLincsesSystem.Properties.Resources.Detain_64;
            this.detainLicensesToolStripMenuItem.Name = "detainLicensesToolStripMenuItem";
            this.detainLicensesToolStripMenuItem.Size = new System.Drawing.Size(351, 42);
            this.detainLicensesToolStripMenuItem.Text = "Detain Licenses";
            // 
            // manageApplicationTypesToolStripMenuItem
            // 
            this.manageApplicationTypesToolStripMenuItem.Image = global::DriverLincsesSystem.Properties.Resources.Application_Types_64;
            this.manageApplicationTypesToolStripMenuItem.Name = "manageApplicationTypesToolStripMenuItem";
            this.manageApplicationTypesToolStripMenuItem.Size = new System.Drawing.Size(351, 42);
            this.manageApplicationTypesToolStripMenuItem.Text = "Manage Application Types";
            this.manageApplicationTypesToolStripMenuItem.Click += new System.EventHandler(this.manageApplicationTypesToolStripMenuItem_Click);
            // 
            // manageTestTypeToolStripMenuItem
            // 
            this.manageTestTypeToolStripMenuItem.Image = global::DriverLincsesSystem.Properties.Resources.Test_Type_64;
            this.manageTestTypeToolStripMenuItem.Name = "manageTestTypeToolStripMenuItem";
            this.manageTestTypeToolStripMenuItem.Size = new System.Drawing.Size(351, 42);
            this.manageTestTypeToolStripMenuItem.Text = "Manage Test Type";
            this.manageTestTypeToolStripMenuItem.Click += new System.EventHandler(this.manageTestTypeToolStripMenuItem_Click);
            // 
            // PeopleManegment
            // 
            this.PeopleManegment.Image = global::DriverLincsesSystem.Properties.Resources.People_400;
            this.PeopleManegment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PeopleManegment.Name = "PeopleManegment";
            this.PeopleManegment.Size = new System.Drawing.Size(123, 39);
            this.PeopleManegment.Text = "People";
            this.PeopleManegment.Click += new System.EventHandler(this.PeopleManegment_Click);
            // 
            // DriverManegment
            // 
            this.DriverManegment.Image = global::DriverLincsesSystem.Properties.Resources.Drivers_64;
            this.DriverManegment.Name = "DriverManegment";
            this.DriverManegment.Size = new System.Drawing.Size(115, 39);
            this.DriverManegment.Text = "Driver";
            this.DriverManegment.Click += new System.EventHandler(this.DriverManegment_Click);
            // 
            // UserManegment
            // 
            this.UserManegment.Image = global::DriverLincsesSystem.Properties.Resources.Users_2_400;
            this.UserManegment.Name = "UserManegment";
            this.UserManegment.Size = new System.Drawing.Size(101, 39);
            this.UserManegment.Text = "User";
            this.UserManegment.Click += new System.EventHandler(this.UserManegment_Click);
            // 
            // AccountSetting
            // 
            this.AccountSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCurrentUser,
            this.btnChangePassword,
            this.btnLogOut});
            this.AccountSetting.Image = global::DriverLincsesSystem.Properties.Resources.account_settings_64;
            this.AccountSetting.Name = "AccountSetting";
            this.AccountSetting.Size = new System.Drawing.Size(123, 39);
            this.AccountSetting.Text = "setting";
            // 
            // btnCurrentUser
            // 
            this.btnCurrentUser.BackColor = System.Drawing.Color.White;
            this.btnCurrentUser.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurrentUser.Image = global::DriverLincsesSystem.Properties.Resources.User_32__2;
            this.btnCurrentUser.Name = "btnCurrentUser";
            this.btnCurrentUser.Size = new System.Drawing.Size(226, 42);
            this.btnCurrentUser.Text = "Current User";
            this.btnCurrentUser.Click += new System.EventHandler(this.btnCurrentUser_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.White;
            this.btnChangePassword.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Image = global::DriverLincsesSystem.Properties.Resources.Password_32;
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(226, 42);
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.White;
            this.btnLogOut.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Image = global::DriverLincsesSystem.Properties.Resources.sign_out_32__2;
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(226, 42);
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::DriverLincsesSystem.Properties.Resources.Logo_Final;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1200, 727);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 727);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.Text = "Driver Lincses / Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem ApplacationMenu;
        private System.Windows.Forms.ToolStripMenuItem PeopleManegment;
        private System.Windows.Forms.ToolStripMenuItem DriverManegment;
        private System.Windows.Forms.ToolStripMenuItem UserManegment;
        private System.Windows.Forms.ToolStripMenuItem AccountSetting;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem btnCurrentUser;
        private System.Windows.Forms.ToolStripMenuItem btnChangePassword;
        private System.Windows.Forms.ToolStripMenuItem btnLogOut;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem drivingLicensesServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplacationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detainLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTestTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDriverLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renewDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReplacementforLostorDamagedLicense;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainedDriveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retakeTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localDrivingLicenseAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalLicenseAppToolStripMenuItem;
    }
}

