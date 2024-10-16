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

namespace DriverLincsesSystem.Applacation.Compoment_Tests.UC
{
    public partial class CtrTakeTestInformation : UserControl
    {
        public CtrTakeTestInformation()
        {
            InitializeComponent();
        }

        private void _ResteControl()
        {
            LabDLAppID.Text = "??";
            LabClassName.Text = "??";
           lab3.Text = "??";
            Lab4.Text = "??";
            Lab5.Text = "??";
            Lab6.Text = "??";
        }

        public void LoadData(int LocalDrivingLicenseID,int TestTypeID)
        {

            if (ClsLocalDrivingLicenseApplications.IsExistsLocalDrivingLicenseApplications(LocalDrivingLicenseID))
            {

                ClsLocalDrivingLicenseApplications NewLocalDrivingLiceseApplication = ClsLocalDrivingLicenseApplications.Find(LocalDrivingLicenseID);


                if (NewLocalDrivingLiceseApplication == null)
                {
                    MessageBox.Show("Oops , You have problem to load information of Application contact maintenec","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _ResteControl();
                    return;
                }

                LabDLAppID.Text = NewLocalDrivingLiceseApplication.LocalDrivingLicenseApplicationID.ToString();
                LabClassName.Text = ClsLicenseClasses.GetClassName(NewLocalDrivingLiceseApplication.LicenseClassID);
                LabFullName.Text = NewLocalDrivingLiceseApplication.ApplicationsInfo.PersonInfo.FullName();
                LabTrail.Text = clsTestAppointments.GetTrailNumber(NewLocalDrivingLiceseApplication.LocalDrivingLicenseApplicationID, TestTypeID).ToString();
                LabDate.Text = NewLocalDrivingLiceseApplication.ApplicationsInfo.ApplicationDate.ToShortDateString();
                LabFees.Text = NewLocalDrivingLiceseApplication.ApplicationsInfo.PaidFees.ToString();

                return;
            }

        }

    }
}
