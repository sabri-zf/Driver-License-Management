using BusinessLayer;
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
    public class ClsLicenses
    {
        enum EMode
        {eAddNew, eUpdate}
        public enum eIssueReason { eFirstTime, eRenew, eDamageReplacement, eLostReplacement }
        public eIssueReason TypeIssueReason { get;private set; } = eIssueReason.eFirstTime;
        private EMode _mode;
        public int LicenseID { get; private set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public ClsDrivers DriverInfo{ get;private set; }
        public int LicenseClass { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public decimal PaidFees { get; set; }
        public bool IsActive { get; set; }
        public byte IssueReason { get; set; }
        public int CreatedByUserID { get; set; }
        public ClsUsers UserInfo { get; private set; }
        public string IssueReasonText
        {
            get { return GetIssueReason((eIssueReason)IssueReason); }
        }

        /******************************************
         * Add Property Of Compoiest class Detain *
         *                                        *
         * Add Check Is Detain in Method here     *
         * 
         ******************************************/

        /*  
              Update below Property 
                                        */
        public bool IsDetained{
            get { return false; }
            }

        public ClsLicenses()
        {
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.LicenseClass = -1;
            this.IssueDate = new DateTime();
            this.ExpirationDate = new DateTime();
            this.Notes = "";
            this.PaidFees = 0;
            this.IsActive = false;
            this.IssueReason = (byte)eIssueReason.eFirstTime;
            this.CreatedByUserID = -1;
            _mode = EMode.eAddNew;
        }

        private ClsLicenses(int LicenseID, int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate, DateTime ExpirationDate, string Notes, decimal PaidFees, bool IsActive, byte IssueReason, int CreatedByUserID)
        {
            this.LicenseID = LicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.LicenseClass = LicenseClass;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.Notes = Notes;
            this.PaidFees = PaidFees;
            this.IsActive = IsActive;
            this.IssueReason = IssueReason;
            this.TypeIssueReason = (eIssueReason)IssueReason;
            this.CreatedByUserID = CreatedByUserID;
            _mode = EMode.eUpdate;

            //Composite Class
            this.DriverInfo = ClsDrivers.FindByDriverID(this.DriverID);
            /* 
             * may be will adding composite of detain class
             * 
             * this.detianinfo = clsDetains.Find();
             */

        }

        //-----------------****Find*** ---------------------
        public static ClsLicenses Find(int LicenseID)
        {
            int ApplicationID = 0;
            int DriverID = 0;
            int LicenseClass = 0;
            DateTime IssueDate = new DateTime();
            DateTime ExpirationDate = new DateTime();
            string Notes = "";
            decimal PaidFees = 0;
            bool IsActive = false;
            byte IssueReason = 0;
            int CreatedByUserID = 0;
            if (ClsDataAccessLicenses.FindLicenseID(LicenseID, ref ApplicationID, ref DriverID, ref LicenseClass, ref IssueDate, ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID))
            {
                return new ClsLicenses(LicenseID, ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID);
            }
            return null;
        }

        public static ClsLicenses FindByApplication(int ApplicationID)
        {
            int LicenseID = 0;
            int DriverID = 0;
            int LicenseClass = 0;
            DateTime IssueDate = new DateTime();
            DateTime ExpirationDate = new DateTime();
            string Notes = "";
            decimal PaidFees = 0;
            bool IsActive = false;
            byte IssueReason = 0;
            int CreatedByUserID = 0;
            if (ClsDataAccessLicenses.FindByApplicationID(ref LicenseID,  ApplicationID, ref DriverID, ref LicenseClass, ref IssueDate, ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID))
            {
                return new ClsLicenses(LicenseID, ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID);
            }
            return null;
        }
        //--------------------*** Add New ***------------------
        private bool _AddNewLicenses()
        {
            this.LicenseID = ClsDataAccessLicenses.AddNewLicenses(this.ApplicationID, this.DriverID, this.LicenseClass, this.IssueDate,
                this.ExpirationDate, this.Notes, this.PaidFees, this.IsActive, this.IssueReason, this.CreatedByUserID);


            return (this.LicenseID != -1);
        }

        //-------------------*** Update ***-------------------
        private bool _UpdateLicenses()
        {
            return ClsDataAccessLicenses.UpdateLicenses(this.LicenseID, this.ApplicationID, this.DriverID, this.LicenseClass, this.IssueDate,
                this.ExpirationDate, this.Notes, this.PaidFees, this.IsActive, this.IssueReason, this.CreatedByUserID);
        }

        //-------------------*** Save ***-------------------
        public bool Save()
        {
            switch (_mode)
            {

                case EMode.eAddNew:
                    if (_AddNewLicenses())
                    {
                        _mode = EMode.eUpdate;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case EMode.eUpdate:
                    return _UpdateLicenses();
            }
            return false;
        }

        //-------------------*** Delete ***-------------------
        public static bool DeleteLicenses(int LicenseID)
        {

            return ClsDataAccessLicenses.DeleteLicenses(LicenseID);

        }

        //-------------------*** Is Exist ***-------------------
        public static bool  IsExistsLicenses(int LicenseID)
        {
            return ClsDataAccessLicenses.IsExistsLicenses(LicenseID);

        }

        /*
         * Find If IsExist By Driver or Person 
         */

        //-----------------*** Get All ***---------------------
        public static DataTable GetAllLicenses()
        {

            return ClsDataAccessLicenses.GetAllLicenses();

        }


        public  static DataTable GetAllHistoryLicenseDetails(int DriverID)
        {
            return ClsDataAccessLicenses.GetAllLicensesHistory(DriverID);
        }


        public bool IsExpirationData()
        {
            return (this.ExpirationDate < DateTime.Now);
        }

        public bool DeActivateLicense()
        {
            /* 
             * Go To Project DataAccess And Adding The Connection deActivate ;
             */
            return false;


        }

        public static bool IsActiveThisLicens(int DriverID)
        {
            /* 
             * try to check if this Driver already has License or not 
             */
            return false ;
        }
        private string GetIssueReason(eIssueReason issueReason)
        {
            switch (issueReason)
            {
                case eIssueReason.eFirstTime:
                    return "First Time";
                case eIssueReason.eRenew:
                    return "Renew";
                case eIssueReason.eDamageReplacement:
                    return "Damage Replacement";
                case eIssueReason.eLostReplacement:
                    return "Lost Replacement";
            }


            return "UnKnow";
        }

       /*
        ****************************************************************
        * Remamber Here Sabri we need create control of filter license *
        * ------------------------------------------------------------ *
        * and create the classes of detain and Renew License           *
        ****************************************************************
        */
    }
}
