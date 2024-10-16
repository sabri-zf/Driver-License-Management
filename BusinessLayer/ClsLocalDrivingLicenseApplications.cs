using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.Data;

namespace BusinessLayer
{
    public class ClsLocalDrivingLicenseApplications
    {

        enum EMode
        {
            eAddNew, eUpdate
        }

        private EMode _mode;
        public int LocalDrivingLicenseApplicationID { get; set; }
        public int ApplicationID { get; set; }
        public ClsApplications ApplicationsInfo {  get; set; }
        public int LicenseClassID { get; set; }

        public ClsLocalDrivingLicenseApplications()
        {
            this.LocalDrivingLicenseApplicationID = -1;
            this.ApplicationID = -1;
            this.LicenseClassID = 1;
            _mode = EMode.eAddNew;
        }

        private ClsLocalDrivingLicenseApplications(int LocalDrivingLicenseApplicationID, int ApplicationID, int LicenseClassID)
        {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.ApplicationID = ApplicationID;
            this.ApplicationsInfo = ClsApplications.Find(ApplicationID);
            this.LicenseClassID = LicenseClassID;
            _mode = EMode.eUpdate;
        }

        //-----------------****Find*** ---------------------
        public static ClsLocalDrivingLicenseApplications Find(int LocalDrivingLicenseApplicationID)
        {
            int ApplicationID = 0;
            int LicenseClassID = 0;
            if (ClsDataAccessLocalDrivingLicenseApplications.FindLocalDrivingLicenseApplicationID(LocalDrivingLicenseApplicationID, ref ApplicationID, ref LicenseClassID))
            {
                return new ClsLocalDrivingLicenseApplications(LocalDrivingLicenseApplicationID, ApplicationID, LicenseClassID);
            }
            return null;
        }
        //--------------------*** Add New ***------------------
        private bool _AddNewLocalDrivingLicenseApplications()
        {

            this.LocalDrivingLicenseApplicationID = ClsDataAccessLocalDrivingLicenseApplications.AddNewLocalDrivingLicenseApplications(this.ApplicationID, this.LicenseClassID);

            return (this.LocalDrivingLicenseApplicationID != -1);
        }

        //-------------------*** Update ***-------------------
        private bool _UpdateLocalDrivingLicenseApplications()
        {
            return ClsDataAccessLocalDrivingLicenseApplications.UpdateLocalDrivingLicenseApplications(this.LocalDrivingLicenseApplicationID, this.ApplicationID, this.LicenseClassID);
        }

        //-------------------*** Save ***-------------------
        public bool Save()
        {

            switch (_mode)
            {

                case EMode.eAddNew:
                    if (_AddNewLocalDrivingLicenseApplications())
                    {
                        _mode = EMode.eUpdate;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case EMode.eUpdate:
                    return _UpdateLocalDrivingLicenseApplications();
            }
            return false;
        }

        //-------------------*** Delete ***-------------------
        public static bool DeleteLocalDrivingLicenseApplications(int LocalDrivingLicenseApplicationID)
        {

            return ClsDataAccessLocalDrivingLicenseApplications.DeleteLocalDrivingLicenseApplications(LocalDrivingLicenseApplicationID);

        }

        //-------------------*** Is Exist ***-------------------
        public static bool IsExistsLocalDrivingLicenseApplications(int LocalDrivingLicenseApplicationID)
        {
            return ClsDataAccessLocalDrivingLicenseApplications.IsExistsLocalDrivingLicenseApplications(LocalDrivingLicenseApplicationID);

        }

        //-----------------*** Get All ***---------------------
        public static DataTable GetAllLocalDrivingLicenseApplications()
        {

            return ClsDataAccessLocalDrivingLicenseApplications.GetAllLocalDrivingLicenseApplications();

        }

        public static DataTable FullDetailsApplicationType()
        {
            return ClsDataAccessLocalDrivingLicenseApplications.GetFullDetailsAboutLoaclDrivingLinceseApplication();
        }
        //-----------------** Find Class is AlReady Choice ---------

        public static bool CheckLicenseClassIDIsAlreadyChoice(int LicenseClassID, int ApplicationPersonID)
        {
            return ClsDataAccessLocalDrivingLicenseApplications.FindIfChoiceClasssIDWithLocalDrivingLincese(LicenseClassID, ApplicationPersonID);
        }

        public static bool CheckIfTheApplicationCanceledFromBeforeOrNot(string ClassName, string NationalNumber)
        {
            return ClsDataAccessLocalDrivingLicenseApplications.FindIfChoiceClasssNameWithLocalDrivingLincese(ClassName, NationalNumber);
        }


        public static byte NumberOfPassTestForCustomer(int L_D_L_ApplicationID)
        {
            return ClsDataAccessLocalDrivingLicenseApplications.GetAllResultOfPassTest(L_D_L_ApplicationID);
        }
        
        public byte NumberOfPassTestForCustomer()
        {
            return NumberOfPassTestForCustomer(this.LocalDrivingLicenseApplicationID);
        }


    }
}
