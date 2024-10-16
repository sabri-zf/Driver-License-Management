using BusinessLayer;
using DriverLincsesSystem.GlobleClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriverLincsesSystem.Applacation.LocalDriverLicense.IssueLicenseFirtsTime
{
    public partial class FrmIssueLinceseFirstTime : Form
    {

        private ClsLocalDrivingLicenseApplications _LDL_Applications=null;
        public FrmIssueLinceseFirstTime(int LocalDrivingLicenseID)
        {
            InitializeComponent();
            _LDL_Applications = ClsLocalDrivingLicenseApplications.Find(LocalDrivingLicenseID);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int _CreateDriver()
        {
          
            ClsDrivers Newdriver = new ClsDrivers();
            Newdriver.PersonID = _LDL_Applications.ApplicationsInfo.ApplicantPersonID;
            Newdriver.CreatedDate = DateTime.Now;
            Newdriver.CreatedByUser = ClsSetting.logInUser.UserID;

            if (!Newdriver.Save())
            {
                MessageBox.Show("Oops We Have error on your System ,Please Contact maintince Developer",
                    "Attention",MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Close();

                return -1;
            }

            return Newdriver.DriverID;
        }

        private bool _ConvertStatus(ClsLicenses First)
        {
            _LDL_Applications.ApplicationsInfo.ApplicationStatus = 3;

            if (!_LDL_Applications.ApplicationsInfo.Save())
            {
                ClsDrivers.DeleteDriver(First.DriverID);
                ClsLicenses.DeleteLicenses(First.LicenseID);
                return false;
            }

            return true;
        }
        private void BtnSaveIssueLicense_Click(object sender, EventArgs e)
        {
            ClsLicenses FirstTimeLicense = new ClsLicenses();

            FirstTimeLicense.ApplicationID = _LDL_Applications.ApplicationID;
            if (ClsDrivers.FindByPersonID(_LDL_Applications.ApplicationsInfo.PersonInfo.GetPersonID()) == null)
            {
            FirstTimeLicense.DriverID = _CreateDriver();
            }
            else
            {
                FirstTimeLicense.DriverID = ClsDrivers.FindByPersonID(_LDL_Applications.ApplicationsInfo.PersonInfo.GetPersonID()).DriverID;

            }

            FirstTimeLicense.LicenseClass = _LDL_Applications.LicenseClassID;
            FirstTimeLicense.IssueDate = DateTime.Now;
            FirstTimeLicense.ExpirationDate = DateTime.Now.AddYears(ClsLicenseClasses.GetLengthOfValidToExpirationLicense(_LDL_Applications.LicenseClassID));
            FirstTimeLicense.Notes = TBTakeNotes.Text;
            FirstTimeLicense.PaidFees =_LDL_Applications.ApplicationsInfo.PaidFees;
            FirstTimeLicense.IsActive = true;
            FirstTimeLicense.IssueReason = 1;
            FirstTimeLicense.CreatedByUserID = ClsSetting.logInUser.UserID;

            if (FirstTimeLicense.Save())
            {
                if (!_ConvertStatus(FirstTimeLicense))
                {
                    
                    MessageBox.Show("Fail To save ","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }

                MessageBox.Show("Done Issue License FirstTime", "Congratiolation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("Fail To save ","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void FrmIssueLinceseFirstTime_Load(object sender, EventArgs e)
        {
            if (_LDL_Applications != null)
            {
                ctrLocalDrivingLinceseApplactionInfo1._loadLocalDrivingApplivationInfo(_LDL_Applications.LocalDrivingLicenseApplicationID);
            }
            else
            {
                MessageBox.Show("Erro To Load information","Attention",MessageBoxButtons.OK,MessageBoxIcon.Error);
                BtnSaveIssueLicense.Enabled = false;
            }
        }

    }
}
