using DriverLincsesSystem.Applacation.ApplactionType;
using DriverLincsesSystem.Applacation.LocalDriverLicense;
using DriverLincsesSystem.Applacation.LocalDriverLicense.NewLocalDriverLicense;
using DriverLincsesSystem.Applacation.TestType;
using DriverLincsesSystem.Drivers;
using DriverLincsesSystem.GlobleClasses;
using DriverLincsesSystem.People;
using DriverLincsesSystem.User;
using DriverLincsesSystem.User.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriverLincsesSystem
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        public FrmMain(FrmLogInScreen logInScreen)
        {
            InitializeComponent();

           logInScreen.Close();

        }

        private void PeopleManegment_Click(object sender, EventArgs e)
        {
            FrmpeopleLists peopleList = new FrmpeopleLists();
            peopleList.ShowDialog();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            ClsSetting.logInUser = null;
            this.Close();
            //FrmLogInScreen logInScreen = new FrmLogInScreen();
            //logInScreen.ShowDialog();
        }

        private void btnCurrentUser_Click(object sender, EventArgs e)
        {
            if (ClsSetting.logInUser != null) {
                FrmCurrentUser CurrentUser = new FrmCurrentUser(ClsSetting.logInUser.UserID);
                CurrentUser.ShowDialog();
               }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            FrmChangePassword changePassword = new FrmChangePassword();
            changePassword.ShowDialog();
        }

        private void UserManegment_Click(object sender, EventArgs e)
        {
            // thisd is code of run form user list

            FrmUserList userList = new FrmUserList();
            userList.ShowDialog();
        }

        private void DriverManegment_Click(object sender, EventArgs e)
        {
            FrmDriverList Drivers = new FrmDriverList();
            Drivers.ShowDialog();
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmApplactionType applactionType = new FrmApplactionType();
            applactionType.ShowDialog();
        }

        private void manageTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTestTypelist testTypelist = new FrmTestTypelist();
            testTypelist.ShowDialog();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLocalDrivingLicenseApp LocalApplaication = new FrmLocalDrivingLicenseApp();
            LocalApplaication.ShowDialog();
        }

        private void localDrivingLicenseAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListLocalDriverLicense listLocalDriverLicense = new FrmListLocalDriverLicense();
            listLocalDriverLicense.ShowDialog();
        }
    }
}
