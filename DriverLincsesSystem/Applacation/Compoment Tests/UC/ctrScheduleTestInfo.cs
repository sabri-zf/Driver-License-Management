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

namespace DriverLincsesSystem.Applacation.Compoment_Tests.UC
{
    public partial class ctrScheduleTestInfo : UserControl
    {

        private ClsLocalDrivingLicenseApplications _LocalDrivingAppllication;
        private ClsApplications _Applications;
        private clsTestAppointments _Appointments = new clsTestAppointments();
        private int _TestTypeID;

        enum Mode { eAdd, eUpdate }
        Mode _mode = Mode.eAdd;


        public ctrScheduleTestInfo()
        {
            InitializeComponent();
        }

        public void _CreateNewApplicationRetest()
        {
            _Applications = new ClsApplications();

            _Applications.ApplicantPersonID = _LocalDrivingAppllication.ApplicationsInfo.ApplicantPersonID;
            _Applications.ApplicationDate = DateTime.Now;
            _Applications.ApplicationTypeID = clsApplicationTypes.Find("Retake Test").ApplicationTypeID;
            _Applications.ApplicationStatus = 1;
            _Applications.LastStatusDate = DateTime.Now;
            _Applications.PaidFees = clsApplicationTypes.Find("Retake Test").ApplicationFees;
            _Applications.CreatedByUserID = ClsSetting.logInUser.UserID;

            if (_Applications.Save())
            {
                LabReTakeTestID.Text = _Applications.ApplactionID.ToString();
                return;
            }

        }


        public int TestTypeID{
            set
            {
                _TestTypeID = value;
            }
            }

        //public int LocalDrivingLicenseID
        //{
        //    get { return _LocalDrivingAppllication.LocalDrivingLicenseApplicationID; }
        //}

        //public int ApplicationID
        //{
        //    get { return _Applications.ApplactionID; }
        //}

      


        public void checkingIFTestApointmentexist(int TestApointment)
        {
            if (_mode != Mode.eAdd)
            {

                if (clsTestAppointments.IsExistsTestAppointments(TestApointment))
                {

                    if (_Appointments.IsLocked)
                    {
                        DTChoiceDateTest.Enabled = false;
                        BtnSave.Enabled = false;
                    }
                    else
                    {
                        DTChoiceDateTest.Enabled = true;
                        BtnSave.Enabled = true;
                    }

                }
            }
        }

        public void _loadScheduleinfo(int LDL_ApplicationID)
        {

            DTChoiceDateTest.MinDate = DateTime.Now;

            if (_mode != Mode.eAdd)
            {
                DTChoiceDateTest.Value = _Appointments.AppointmentDate;
            }
           
            if (ClsLocalDrivingLicenseApplications.IsExistsLocalDrivingLicenseApplications(LDL_ApplicationID))
            {
                _LocalDrivingAppllication = ClsLocalDrivingLicenseApplications.Find(LDL_ApplicationID);

                if (_LocalDrivingAppllication == null)
                {
                    return;
                }

                Lab_D_LAppID.Text = _LocalDrivingAppllication.LocalDrivingLicenseApplicationID.ToString();
                LabClassName.Text = ClsLicenseClasses.GetClassName(_LocalDrivingAppllication.LicenseClassID);
                LabCustomerName.Text = _LocalDrivingAppllication.ApplicationsInfo.PersonInfo.FullName();
                LabTrail.Text = clsTestAppointments.GetTrailNumber(_LocalDrivingAppllication.LocalDrivingLicenseApplicationID, 1).ToString();
                LabFees.Text = ClsTestTypes.FindByID(1).TestTypeFees.ToString();
                LabRetakeFees.Text = clsApplicationTypes.Find("Retake Test").ApplicationFees.ToString();



                if (clsTests.IsExistsTests(_LocalDrivingAppllication.LocalDrivingLicenseApplicationID, _TestTypeID))
                {
                    if (!clsTests.IsPassedInTest(_LocalDrivingAppllication.LocalDrivingLicenseApplicationID, _TestTypeID))
                    {
                        GBRetakeTest.Enabled = true;
                        LabRetakeTotalFees.Text = (Convert.ToDecimal(LabFees.Text) + Convert.ToDecimal(LabRetakeFees.Text)).ToString();
                        LabTitleModeSchedule.Text = "Schedule ReTake Test";
                    }
                }
               


            }

        }

        public void UpdateApointment(int TestAppoitmentID)
        {
            _Appointments = clsTestAppointments.Find(TestAppoitmentID);

            if (_Appointments == null) {

                return;
            }
            _mode = Mode.eUpdate;
        }

        private void ctrScheduleTestInfo_Load(object sender, EventArgs e)
        {


        }//no Used

        private void BtnSave_Click(object sender, EventArgs e)
        {

            if (_mode == Mode.eAdd)
            {
                if (GBRetakeTest.Enabled)
                {
                    _CreateNewApplicationRetest();
                    _Appointments.RetakeTestApplicationID = _Applications.ApplactionID;
                }
            }


            _Appointments.TestTypeID = _TestTypeID;
            _Appointments.LocalDrivingLicenseApplicationID = _LocalDrivingAppllication.LocalDrivingLicenseApplicationID;
            _Appointments.AppointmentDate = Convert.ToDateTime(DTChoiceDateTest.Text);
            _Appointments.PaidFees = ClsTestTypes.FindByID(_TestTypeID).TestTypeFees;
            _Appointments.IsLocked = false;
            _Appointments.CreatedByUserID = ClsSetting.logInUser.UserID;


            if (_Appointments.Save())
            {
                MessageBox.Show("Save Successfully :D");
                return;
            }

            MessageBox.Show("Fail Save :| ");



        }

    }
}
