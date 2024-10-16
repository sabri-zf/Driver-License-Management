using BusinessLayer;
using DriverLincsesSystem.GlobleClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriverLincsesSystem.Applacation.LocalDriverLicense.NewLocalDriverLicense
{
    public partial class FrmLocalDrivingLicenseApp : Form
    {

        private int _PersonID = -1;
        private int D_L_ApplacationID = -1;
        private ClsApplications _Applications;

        private ClsLocalDrivingLicenseApplications _ObjLocalApplications;
       enum Mode { eAddnew ,eUpdate}

        private Mode _mode;
        public FrmLocalDrivingLicenseApp()
        {
            InitializeComponent();
        _mode = Mode.eAddnew;

            _Applications = new ClsApplications();
            
        }


        public FrmLocalDrivingLicenseApp(int D_L_ApplacationID)
        {
            InitializeComponent();
            this.D_L_ApplacationID = D_L_ApplacationID;
            _mode = Mode.eUpdate;
        }


        private bool ChekChoiceClass()
        {
            return(ClsLocalDrivingLicenseApplications.CheckLicenseClassIDIsAlreadyChoice(_ObjLocalApplications.LicenseClassID,_PersonID));
        }

        private bool IsCanceled()
        {
            return (ClsLocalDrivingLicenseApplications.CheckIfTheApplicationCanceledFromBeforeOrNot(CBLinsesClasses.Text.Trim(), ctrCardPersonWithFilter1.SelectedPeople.NationalNo.Trim()));

        }
        private void _loadClassesName()
        {
            DataTable dt_ClassesName = ClsLicenseClasses.GetAllLicenseClasses();

            foreach (DataRow Row in dt_ClassesName.Rows)
            {
                CBLinsesClasses.Items.Add(Row["ClassName"]);
            }
        }
        private int AddNewApplication()
        {

            _Applications.ApplicantPersonID = ctrCardPersonWithFilter1.personID;
            _Applications.ApplicationStatus = 1;
            _Applications.ApplicationTypeID = 1;
            _Applications.LastStatusDate = DateTime.Now;

            if (_Applications.Save()) {

                return _Applications.ApplactionID;
            }

            return -1;
        }
        private void _Restart()
        {
            _loadClassesName();
            CBLinsesClasses.SelectedIndex = 0;

         

            if (_mode == Mode.eAddnew)
            {

                PLApplacationInfo.Enabled = false;
                btnSaveLocal_D_L_App.Enabled = false;

                this.Text = "Add Local Licnses";

                LabTitleMode.Text = "New Local Driving Licnses Applacation";

                _ObjLocalApplications = new ClsLocalDrivingLicenseApplications();

                _Applications.ApplicationDate = DateTime.Now;
                _Applications.PaidFees = clsApplicationTypes.Find(1).ApplicationFees; // futer can update this to get fees direct from database coding;
                _Applications.CreatedByUserID = ClsSetting.logInUser.UserID;


                LabDateApp.Text = _Applications.ApplicationDate.ToShortDateString();
                LabbFeesApp.Text = _Applications.PaidFees.ToString();
                LabUserNameCreted.Text = ClsSetting.logInUser.UserName;

                return;
            }
            
                this.Text = "Edit Local Licnses";

                LabTitleMode.Text = "Edit Local Driving Licnses Applacation";

            _ObjLocalApplications = ClsLocalDrivingLicenseApplications.Find(D_L_ApplacationID);

            if (_ObjLocalApplications == null)
            {
                MessageBox.Show("This Object Is not Exist ");
                this.Close();
                return;
            }


            ctrCardPersonWithFilter1.FilterEnable = false;
            ctrCardPersonWithFilter1.GetDataOfIdPerson(null,_ObjLocalApplications.ApplicationsInfo.ApplicantPersonID);
            LabL_D_App.Text = _ObjLocalApplications.LocalDrivingLicenseApplicationID.ToString();
            LabDateApp.Text = _ObjLocalApplications.ApplicationsInfo.ApplicationDate.ToShortDateString();
            CBLinsesClasses.Text = ClsLicenseClasses.GetClassName(_ObjLocalApplications.LicenseClassID);
            LabbFeesApp.Text = _ObjLocalApplications.ApplicationsInfo.PaidFees.ToString();
            LabUserNameCreted.Text = _ObjLocalApplications.ApplicationsInfo.UserInfo.UserName.Trim();
        }
        private void btnNextPage_Click(object sender, EventArgs e)
        {

            if(_mode == Mode.eAddnew)
            {
            if (_PersonID == -1 || _PersonID == 0)
            {
                MessageBox.Show("Pelses Enter  Person ID Or National Number");
                return;
            }

                PLApplacationInfo.Enabled = true;
               btnSaveLocal_D_L_App.Enabled = true;

            }


            

            tabNewLocalLicenseApplacation.SelectedIndex = 1;

        }

        private void ctrCardPersonWithFilter1_OnSelectedPerson(int obj)
        {
            if (obj == 0)
            {
                btnNextPage.Enabled = false;
            }
            else
            {
                btnNextPage.Enabled = true;
            }

            _PersonID = obj;


        }

        private void btnSaveLocal_D_L_App_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())return;
            if (_ObjLocalApplications == null) return;

            _ObjLocalApplications.LicenseClassID = ClsLicenseClasses.GetLicenseClassID(CBLinsesClasses.Text);
            _ObjLocalApplications.ApplicationID = AddNewApplication();



            if (IsCanceled())
            {
            bool statusOFClass = ChekChoiceClass();
                if ((_Applications.ApplicationStatus == 1 && statusOFClass) || (_Applications.ApplicationStatus == 3 && statusOFClass))
                {
                    MessageBox.Show("Sorry you can not save this Applaction Becauser this Class Already Exist Or Complite " +
                        $" for this Person ID = {_Applications.ApplicantPersonID}"
                        , "Local Dirving Linses Application", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;

                }
            }


            if (_ObjLocalApplications.Save())
            {
                MessageBox.Show("Save is Successfylly :D");

                LabL_D_App.Text = _ObjLocalApplications.LocalDrivingLicenseApplicationID.ToString();
            }
            else
            {
                MessageBox.Show("Save is Fail :D");
            }

        }

        private void FrmLocalDrivingLicenseApp_Load(object sender, EventArgs e)
        {
            _Restart();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
