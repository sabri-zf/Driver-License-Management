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
    public class clsApplicationTypes
    {

        enum EMode
        {
            eAddNew, eUpdate
        }
        private EMode _mode;
        public int ApplicationTypeID { get; set; }
        public string ApplicationTypeTitle { get; set; }
        public decimal ApplicationFees { get; set; }

        public clsApplicationTypes()
        {
            this.ApplicationTypeID = -1;
            this.ApplicationTypeTitle = "";
            this.ApplicationFees = 0;
            _mode = EMode.eAddNew;
        }

        clsApplicationTypes(int ApplacationTypesID, string ApplicationTypeTitle, decimal ApplicationFees)
        {
            this.ApplicationTypeID = ApplacationTypesID;
            this.ApplicationTypeTitle = ApplicationTypeTitle;
            this.ApplicationFees = ApplicationFees;
            _mode = EMode.eUpdate;
        }

        //-----------------****Find*** ---------------------
        public static clsApplicationTypes Find(int ApplicationTypeID)
        {
            string ApplicationTypeTitle = "";
            decimal ApplicationFees = 0;
            if (ClsDataAccessApplicationTypes.FindApplicationTypeID(ApplicationTypeID, ref ApplicationTypeTitle, ref ApplicationFees))
            {
                return new clsApplicationTypes(ApplicationTypeID, ApplicationTypeTitle, ApplicationFees);
            }
            return null;
        }

        public static clsApplicationTypes Find(string ApplicationTypeTitle)
        {
            int ApplicationTypeID = -1;
            decimal ApplicationFees = 0;
            if (ClsDataAccessApplicationTypes.FindTitle(ref ApplicationTypeID,  ApplicationTypeTitle, ref ApplicationFees))
            {
                return new clsApplicationTypes(ApplicationTypeID, ApplicationTypeTitle, ApplicationFees);
            }
            return null;
        }

        //--------------------*** Add New ***------------------
        private bool _AddNewApplicationTypes()
        {

            this.ApplicationTypeID = ClsDataAccessApplicationTypes.AddNewApplicationTypes(this.ApplicationTypeTitle, this.ApplicationFees);


            return (this.ApplicationTypeID > 0);
        }

        //-------------------*** Update ***-------------------
        private bool _UpdateApplicationTypes()
        {
            return ClsDataAccessApplicationTypes.UpdateApplicationTypes(this.ApplicationTypeID, this.ApplicationTypeTitle, this.ApplicationFees);
        }

        //-------------------*** Save ***-------------------
        public bool Save()
        {

            switch (_mode)
            {

                case EMode.eAddNew:
                    if (_AddNewApplicationTypes())
                    {
                        _mode = EMode.eUpdate;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case EMode.eUpdate:
                    return _UpdateApplicationTypes();
            }
            return false;
        }

        //-------------------*** Delete ***-------------------
        public static bool DeleteApplicationTypes(int ApplicationTypeID)
        {

            return ClsDataAccessApplicationTypes.DeleteApplicationTypes(ApplicationTypeID);

        }

        //-------------------*** Is Exist ***-------------------
        public static bool IsExistsApplicationTypes(int ApplicationTypeID)
        {
            return ClsDataAccessApplicationTypes.IsExistsApplicationTypes(ApplicationTypeID);

        }

        //-----------------*** Get All ***---------------------
        public static DataTable GetAllApplicationTypes()
        {

            return ClsDataAccessApplicationTypes.GetAllApplicationTypes();

        }

        //---------------------------- ++Name Value++ -------------------------
        public static string GetApplicationTypeName(int ApplicationTypeID)
        {
            return ClsDataAccessApplicationTypes.ApplicationTypeName(ApplicationTypeID);
        }

        public  string GetApplicationTypeName()
        {
            return ClsDataAccessApplicationTypes.ApplicationTypeName(this.ApplicationTypeID);
        }

        //---------------------- ++Fees Value++ -----------------------------

        public static float GetFeesValue(int ApplicationTypeID)
        {
            return ClsDataAccessApplicationTypes.ApplicationTypeFees(ApplicationTypeID);
        }

        public  float GetFeesValue()
        {
            return ClsDataAccessApplicationTypes.ApplicationTypeFees(this.ApplicationTypeID);
        }

        //-------------------------------------------------------------



    }
}
