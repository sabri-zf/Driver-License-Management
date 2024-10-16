using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BusinessLayer
{
    public class clsTestAppointments
    {

        enum EMode
        {
            eAddNew, eUpdate
        }
        private EMode _mode; public int TestAppointmentID { get; set; }
        public int TestTypeID { get; set; }
        public int LocalDrivingLicenseApplicationID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsLocked { get; set; }
        public int? RetakeTestApplicationID { get; set; }

        public clsTestAppointments()
        {
            this.TestAppointmentID = -1;
            this.TestTypeID = -1;
            this.LocalDrivingLicenseApplicationID = -1;
            this.AppointmentDate = new DateTime();
            this.PaidFees = 0; this.CreatedByUserID = -1;
            this.IsLocked = false;
            this.RetakeTestApplicationID = -1;
            _mode = EMode.eAddNew;
        }


        private clsTestAppointments(int TestAppoitmentID, int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, decimal PaidFees, int CreatedByUserID, bool IsLocked, int? RetakeTestApplicationID)
        {
            this.TestAppointmentID = TestAppoitmentID;
            this.TestTypeID = TestTypeID; 
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.AppointmentDate = AppointmentDate; 
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsLocked = IsLocked; 
            this.RetakeTestApplicationID = RetakeTestApplicationID;
            _mode = EMode.eUpdate;
        }

        //-----------------****Find*** ---------------------
        public static clsTestAppointments FindByLocalDrivingLicenseID(int LocalDrivingLicenseApplicationID)
        {
            int TestTypeID = 0;
            int TestAppointmentID = -1;
            DateTime AppointmentDate = new DateTime();
            decimal PaidFees = 0;
            int CreatedByUserID = 0;
            bool IsLocked = false;
            int RetakeTestApplicationID = 0;
            if (ClsDataAccessTestAppointments.FindLocalDrivingLiecnseApplicationID( ref TestAppointmentID, ref TestTypeID,  LocalDrivingLicenseApplicationID, ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked, ref RetakeTestApplicationID))
            {
                return new clsTestAppointments(TestAppointmentID, TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID);
            }
            return null;
        }

        public static clsTestAppointments Find(int TestAppointmentID)
        {
            int TestTypeID = 0;
            int LocalDrivingLicenseApplicationID = 0;
            DateTime AppointmentDate = new DateTime();
            decimal PaidFees = 0;
            int CreatedByUserID = 0;
            bool IsLocked = false;
            int RetakeTestApplicationID = 0;
            if (ClsDataAccessTestAppointments.FindTestAppointmentID(TestAppointmentID, ref TestTypeID, ref LocalDrivingLicenseApplicationID, ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked, ref RetakeTestApplicationID))
            {
                return new clsTestAppointments(TestAppointmentID, TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID);
            }
            return null;
        }
        //--------------------*** Add New ***------------------
        private bool _AddNewTestAppointments()
        {

            this.TestAppointmentID = ClsDataAccessTestAppointments.AddNewTestAppointments(this.TestTypeID, this.LocalDrivingLicenseApplicationID, this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked, this.RetakeTestApplicationID);


            return (this.TestAppointmentID != -1);
        }

        //-------------------*** Update ***-------------------
        private bool _UpdateTestAppointments()
        {
            return ClsDataAccessTestAppointments.UpdateTestAppointments(this.TestAppointmentID, this.TestTypeID, this.LocalDrivingLicenseApplicationID, this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked, this.RetakeTestApplicationID);
        }

        //-------------------*** Save ***-------------------
        public bool Save()
        {

            switch (_mode)
            {

                case EMode.eAddNew:
                    if (_AddNewTestAppointments())
                    {
                        _mode = EMode.eUpdate;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case EMode.eUpdate:
                    return _UpdateTestAppointments();
            }
            return false;
        }

        //-------------------*** Delete ***-------------------
        public bool DeleteTestAppointments(int TestAppointmentID)
        {

            return ClsDataAccessTestAppointments.DeleteTestAppointments(TestAppointmentID);

        }

        //-------------------*** Is Exist ***-------------------
        public static bool IsExistsTestAppointments(int TestAppointmentID)
        {
            return ClsDataAccessTestAppointments.IsExistsTestAppointments(TestAppointmentID);

        }

        //-----------------*** Get All ***---------------------
        public DataTable GetAllTestAppointments()
        {

            return ClsDataAccessTestAppointments.GetAllTestAppointments();

        }

        //..................Test Table 
        public static DataTable GetAllTestAppoitmentOfVisionTest(int LocalDrivingLinceseApplicaionID)
        {
            return ClsDataAccessTestAppointments.GetTestAppointmentsofVison(LocalDrivingLinceseApplicaionID);
        }

        public static DataTable GetAllTestAppoitmentOfWriteTest(int LocalDrivingLinceseApplicaionID)
        {
            return ClsDataAccessTestAppointments.GetTestAppointmentsofWrite(LocalDrivingLinceseApplicaionID);
        }

        public static DataTable GetAllTestAppoitmentOfPracticalTest(int LocalDrivingLinceseApplicaionID)
        {
            return ClsDataAccessTestAppointments.GetTestAppointmentsofStreet(LocalDrivingLinceseApplicaionID);
        }

        //------------------------------------------

        public static byte GetTrailNumber(int LDL_AppID,int TestTypeID)
        {
            return ClsDataAccessTestAppointments.GetTrail(LDL_AppID, TestTypeID);
        }

        //______________________________

        public static bool IsLockedTest(int Local_DL_AppID,int TestTypeID)
        {
            return ClsDataAccessTestAppointments.IsTestAppoitmentIsLocked(Local_DL_AppID, TestTypeID);
        }

    }
}
