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
    public class clsInternationalLicenses
    {

        enum EMode
        {
            eAddNew, eUpdate
        }
        private EMode _mode;
        public int InternationalLicenseID { get; private set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int IssuedUsingLocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }

        public clsInternationalLicenses()
        {
            this.InternationalLicenseID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.IssuedUsingLocalLicenseID = -1;
            this.IssueDate = new DateTime();
            this.ExpirationDate = new DateTime();
            this.IsActive = false;
            this.CreatedByUserID = 0;
            _mode = EMode.eAddNew;
        }

        private clsInternationalLicenses(int InternationalLicenseID, int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            this.InternationalLicenseID = InternationalLicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.IssuedUsingLocalLicenseID = IssuedUsingLocalLicenseID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive;
            this.CreatedByUserID = CreatedByUserID;
            _mode = EMode.eUpdate;
        }

        //-----------------****Find*** ---------------------
        public static clsInternationalLicenses Find(int InternationalLicenseID)
        {
            int ApplicationID = -1;
            int DriverID = -1;
            int IssuedUsingLocalLicenseID = -1;
            DateTime IssueDate = new DateTime();
            DateTime ExpirationDate = new DateTime();
            bool IsActive = false;
            int CreatedByUserID = -1;
            if (ClsDataAccessInternationalLicenses.FindInternationalLicenseID(InternationalLicenseID, ref ApplicationID, ref DriverID, ref IssuedUsingLocalLicenseID, ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID))
            {
                return new clsInternationalLicenses(InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);
            }
            return null;
        }
        //--------------------*** Add New ***------------------
        private bool _AddNewInternationalLicenses()
        {

            this.InternationalLicenseID = ClsDataAccessInternationalLicenses.AddNewInternationalLicenses(this.ApplicationID, this.DriverID, this.IssuedUsingLocalLicenseID,
                this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);


            return (this.InternationalLicenseID != -1);
        }

        //-------------------*** Update ***-------------------
        private bool _UpdateInternationalLicenses()
        {
            return ClsDataAccessInternationalLicenses.UpdateInternationalLicenses(this.InternationalLicenseID, this.ApplicationID, this.DriverID,
                this.IssuedUsingLocalLicenseID, this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);
        }

        //-------------------*** Save ***-------------------
        public bool Save()
        {

            switch (_mode)
            {

                case EMode.eAddNew:
                    if (_AddNewInternationalLicenses())
                    {
                        _mode = EMode.eUpdate;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case EMode.eUpdate:
                    return _UpdateInternationalLicenses();
            }
            return false;
        }

        //-------------------*** Delete ***-------------------
        public static bool DeleteInternationalLicenses(int InternationalLicenseID)
        {

            return ClsDataAccessInternationalLicenses.DeleteInternationalLicenses(InternationalLicenseID);

        }

        //-------------------*** Is Exist ***-------------------
        public static bool IsExistsInternationalLicenses(int InternationalLicenseID)
        {
            return ClsDataAccessInternationalLicenses.IsExistsInternationalLicenses(InternationalLicenseID);

        }

        //-----------------*** Get All ***---------------------
        public static DataTable GetAllInternationalLicenses()
        {

            return ClsDataAccessInternationalLicenses.GetAllInternationalLicenses();

        }


        public static DataTable GetAllHistoryLinceseDetils(int DriverID)
        {
            return ClsDataAccessInternationalLicenses.GetAllLicenseHistory(DriverID);
        }

    }
}
