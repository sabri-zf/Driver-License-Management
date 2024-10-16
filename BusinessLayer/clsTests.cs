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
    public class clsTests
    {
        enum EMode
        {
            eAddNew, eUpdate
        }
        private EMode _mode;
        public int TestID { get; set; }
        public int TestAppointmentID { get; set; }
        public clsTestAppointments TestAppoitmentInfo { get; set; }
        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }

        public clsTests()
        {
            this.TestID = -1;
            this.TestAppointmentID = -1; 
            this.TestResult = false;
            this.Notes = ""; 
            this.CreatedByUserID = -1;
            _mode = EMode.eAddNew;
        }

        private clsTests(int testID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            this.TestID = testID;
            this.TestAppointmentID = TestAppointmentID; 
            this.TestResult = TestResult; 
            this.Notes = Notes; 
            this.CreatedByUserID = CreatedByUserID; 
            _mode = EMode.eUpdate;

            this.TestAppoitmentInfo = clsTestAppointments.Find(TestAppointmentID);
        }

        //-----------------****Find*** ---------------------
        public static clsTests FindbyID(int TestID)
        {
            int TestAppointmentID = 0;
            bool TestResult = false;
            string Notes = "";
            int CreatedByUserID = 0;
            if (ClsDataAccessTests.FindTestID(TestID, ref TestAppointmentID, ref TestResult, ref Notes, ref CreatedByUserID))
            {
                return new clsTests(TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID);
            }
            return null;
        }

        //--------------------*** Add New ***------------------
        private bool _AddNewTests()
        {

            this.TestID = ClsDataAccessTests.AddNewTests(this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);


            return (this.TestID != -1);
        }

        //-------------------*** Update ***-------------------
        private bool _UpdateTests()
        {
            return ClsDataAccessTests.UpdateTests(this.TestID, this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);
        }

        //-------------------*** Save ***-------------------
        public bool Save()
        {

            switch (_mode)
            {

                case EMode.eAddNew:
                    if (_AddNewTests())
                    {
                        _mode = EMode.eUpdate;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case EMode.eUpdate:
                    return _UpdateTests();
            }
            return false;
        }

        //-------------------*** Delete ***-------------------
        public static bool DeleteTests(int TestID)
        {

            return ClsDataAccessTests.DeleteTests(TestID);

        }

        //-------------------*** Is Exist ***-------------------
        public static  bool IsExistsTests(int TestID)
        {
            return ClsDataAccessTests.IsExistsTests(TestID);

        }

        //-----------------*** Get All ***---------------------
        public DataTable GetAllTests()
        {

            return ClsDataAccessTests.GetAllTests();

        }


        public static bool IsPassedInTest(int L_D_L_ApplicationID,int TestTypeID)
        {
            return ClsDataAccessTests.IfUserPassedInThisTest(L_D_L_ApplicationID, TestTypeID);                                                                                                                                                             
        }

        public static bool IsExistsTests(int LDLAppID,int TestTypeID)
        {
            return ClsDataAccessTests.IsExistsTests(LDLAppID, TestTypeID);
        }

    }
}
