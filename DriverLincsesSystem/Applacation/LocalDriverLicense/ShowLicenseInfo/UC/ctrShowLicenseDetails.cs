using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using DriverLincsesSystem.Properties;

namespace DriverLincsesSystem.Applacation.LocalDriverLicense.ShowApplicationInfo.UC
{
    public partial class ctrShowLicenseDetails : UserControl
    {


        public ctrShowLicenseDetails()
        {
            InitializeComponent();
        }

        public bool _loadShowApplicationDetails(ClsLocalDrivingLicenseApplications _LocalDriveApp)
        {
            ClsLicenses ShowLicens = ClsLicenses.FindByApplication(_LocalDriveApp.ApplicationID);

            if (ShowLicens == null)
            {
                MessageBox.Show("Error For The System","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }

            LabClassName.Text = ClsLicenseClasses.GetClassName(ShowLicens.LicenseClass).Trim();
            LabName.Text = _LocalDriveApp.ApplicationsInfo.PersonInfo.FullName().Trim();
            LabLicenseID.Text = ShowLicens.LicenseID.ToString().Trim();
            labNationalNumber.Text = _LocalDriveApp.ApplicationsInfo.PersonInfo.NationalNo.Trim();
            LabGendor.Text = _LocalDriveApp.ApplicationsInfo.PersonInfo.Gendor == 0 ? "Male" : "Femail";
            LabBirthDay.Text = _LocalDriveApp.ApplicationsInfo.PersonInfo.DateOfBirth.ToShortDateString();
            LabIssueDate.Text = ShowLicens.IssueDate.ToShortDateString();
            LabIssueReason.Text = ShowLicens.IssueReason == 1 ? "First Time" : "Old";
            LabNotes.Text = ShowLicens.Notes == ""?"No Note":ShowLicens.Notes;
            LabIsActive.Text = ShowLicens.IsActive ? "Yes" : "No";
            LabDriverID.Text = ShowLicens.DriverID.ToString().Trim();
            labeExpirationDate.Text = ShowLicens.ExpirationDate.ToShortDateString();
            LabIsDetained.Text = "NO";

            if (string.IsNullOrEmpty(_LocalDriveApp.ApplicationsInfo.PersonInfo.ImagePath))
            {
                ImgPerson.Image = Resources.Male_512;
            }
            else
            {
                ImgPerson.ImageLocation = _LocalDriveApp.ApplicationsInfo.PersonInfo.ImagePath;
            }

            return true;

        }
    }
}
