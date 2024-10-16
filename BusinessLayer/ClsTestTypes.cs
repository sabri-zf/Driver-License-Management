using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ClsTestTypes
    {

        enum eMode { eAddnew ,eEdit}
        eMode _mode;

        public int TestTypeID { get; set; }

        public string TestTypeTitle { get; set; }

        public string TestTypDescription { get; set; }

        public decimal TestTypeFees { get; set; } 


        private ClsTestTypes()
        {
            TestTypeID = -1;
            TestTypeTitle = string.Empty;
            TestTypDescription = string.Empty;
            TestTypeFees = 0;

            _mode = eMode.eAddnew;
        }


        private ClsTestTypes (int TestTypeID,string TestTypeTitle,string TestTypDescription,decimal TestTypeFees)
        {
            this.TestTypeID = TestTypeID;
            this.TestTypeTitle = TestTypeTitle;
            this.TestTypeFees = TestTypeFees;
            this.TestTypDescription = TestTypDescription;   

            _mode= eMode.eEdit;
        }

        public static ClsTestTypes FindByID(int ID)
        {
            string Title = string.Empty, Description = string.Empty;
            decimal Fees = 0;

            if(ClsDataAccessTestsTypes.FindTestTypeID(ID,ref Title,ref Description,ref Fees))
            {
                return new ClsTestTypes(ID,Title,Description,Fees);
            }

            return null;
        }


        public static bool IsExistTestTypes(int ID)
        {
            return ClsDataAccessTestsTypes.IsExistsTestTypes(ID);
        }

        public static DataTable GetAllTestTypes()
        {
            return ClsDataAccessTestsTypes.GetAllTestTypes();
        }


        private bool _UpdateTestType()
        {
            return ClsDataAccessTestsTypes.UpdateTestTypes(this.TestTypeID,this.TestTypeTitle,this.TestTypDescription,this.TestTypeFees);
        }
        public bool Save()
        {
            if (_mode == eMode.eEdit)
            {
                return _UpdateTestType();
            }


            return false;
        }


    }
}
