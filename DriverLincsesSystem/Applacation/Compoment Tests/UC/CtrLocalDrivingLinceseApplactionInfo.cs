using BusinessLayer;
using DriverLincsesSystem.People;
using DriverLincsesSystem.People.UControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriverLincsesSystem.Applacation.Compoment_Tests.UC
{
    public partial class CtrLocalDrivingLinceseApplactionInfo : UserControl
    {

        private ClsLocalDrivingLicenseApplications _LocalApplicationInfo;

        private int _ApplicationPersonID;
        public CtrLocalDrivingLinceseApplactionInfo()
        {
            InitializeComponent();
        }


        public bool _loadLocalDrivingApplivationInfo(int L_D_LAppID)
        {

            if (ClsLocalDrivingLicenseApplications.IsExistsLocalDrivingLicenseApplications(L_D_LAppID))
            {

                 _LocalApplicationInfo = ClsLocalDrivingLicenseApplications.Find(L_D_LAppID);

                if (_LocalApplicationInfo == null)
                {
                    return false;
                }


               LabD_L_AppID.Text = _LocalApplicationInfo.LocalDrivingLicenseApplicationID.ToString();
                LabClassesName.Text = ClsLicenseClasses.GetClassName(_LocalApplicationInfo.LicenseClassID);
                labNumberSuccesTest.Text = _LocalApplicationInfo.NumberOfPassTestForCustomer().ToString() + "/3";

                return _LoadBasicApplicationInfo();
            }
          
            return false;
        }



        private bool _LoadBasicApplicationInfo()
        {
            ClsApplications AppInfo = ClsApplications.Find(_LocalApplicationInfo.ApplicationID);

            if (AppInfo == null)
            {
                return false ;
            }

            _ApplicationPersonID = AppInfo.ApplicantPersonID;
            LabApplicationID.Text = AppInfo.ApplactionID.ToString();
            LabStatus.Text = (AppInfo.ApplicationStatus == 1) ? "New" : (AppInfo.ApplicationStatus == 3) ? "Completed" : "Canceled";
            LabFees.Text =Convert.ToSingle(AppInfo.PaidFees).ToString();
            LabApplicationType.Text = clsApplicationTypes.GetApplicationTypeName(AppInfo.ApplicationTypeID);
            LabStatusDate.Text = AppInfo.ApplicationDate.ToShortDateString();
            LabRightDate.Text = AppInfo.ApplicationDate.ToShortDateString();
            LabCreatedByUser.Text = ClsUsers.GetUserName(AppInfo.CreatedByUserID);
            LabCustomer.Text = AppInfo.PersonInfo.FullName();
            

            return true;

        }
        private void LinkLabShowLiecnseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Sorry");
        }

        private void LinkLabPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmPeopleCardShowDetail PersonCard = new FrmPeopleCardShowDetail(_ApplicationPersonID); 
            PersonCard.ShowDialog();
        }
    }
}
