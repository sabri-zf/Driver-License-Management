using DataAccessLayer;
using System;
using System.Data;

namespace BusinessLayer
{
    public class ClsApplications
    {

        enum EMode
        {
            eAddNew, eUpdate
        }
        private EMode _mode;
        public int ApplactionID { get; set; }
        public int ApplicantPersonID { get; set; }
        public ClsPeople PersonInfo { get; set; }
        public DateTime ApplicationDate { get; set; }
        public int ApplicationTypeID { get; set; }
        public clsApplicationTypes ApplicationTypesInfo { get; set; }
        public byte ApplicationStatus { get; set; }
        public DateTime LastStatusDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public ClsUsers UserInfo { get; set; }

        public ClsApplications()
        {
            this.ApplactionID = -1;
            this.ApplicantPersonID = -10;
            this.ApplicationDate = new DateTime();
            this.ApplicationTypeID = -1;
            this.ApplicationStatus = 1;
            this.LastStatusDate = new DateTime();
            this.PaidFees = 0;
            this.CreatedByUserID = 0;
            _mode = EMode.eAddNew;
        }

        private ClsApplications(int ApplactionID, int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID,
                  byte ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID)
        {
            this.ApplactionID = ApplactionID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;

            this.PersonInfo = ClsPeople.Find(this.ApplicantPersonID);
            this.UserInfo = ClsUsers.Find(this.CreatedByUserID);
            this.ApplicationTypesInfo = clsApplicationTypes.Find(this.ApplicationTypeID);

            _mode = EMode.eUpdate;


        }

        //-----------------****Find*** ---------------------
        public static ClsApplications Find(int ApplicationID)
        {
            int ApplicantPersonID = 0;
            DateTime ApplicationDate = new DateTime();
            int ApplicationTypeID = 0;
            byte ApplicationStatus = 0;
            DateTime LastStatusDate = new DateTime();
            decimal PaidFees = 0;
            int CreatedByUserID = 0;

            if (ClsDataAccessApplications.FindApplicationID(ApplicationID, ref ApplicantPersonID, ref ApplicationDate, ref ApplicationTypeID, ref ApplicationStatus, ref LastStatusDate, ref PaidFees, ref CreatedByUserID))
            {
                return new ClsApplications(ApplicationID, ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
            }
            return null;
        }

        //--------------------*** Add New ***------------------
        private bool _AddNewApplications()
        {
            this.ApplactionID = ClsDataAccessApplications.AddNewApplications(this.ApplicantPersonID, this.ApplicationDate, this.ApplicationTypeID,
                this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID);


            return (this.ApplactionID != -1);
        }

        //-------------------*** Update ***-------------------
        private bool _UpdateApplications()
        {
            return ClsDataAccessApplications.UpdateApplications(this.ApplactionID, this.ApplicantPersonID, this.ApplicationDate, this.ApplicationTypeID,
                this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID);
        }

        //-------------------*** Save ***-------------------
        public bool Save()
        {

            switch (_mode)
            {

                case EMode.eAddNew:
                    if (_AddNewApplications())
                    {
                        _mode = EMode.eUpdate;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case EMode.eUpdate:
                    return _UpdateApplications();
            }
            return false;
        }

        //-------------------*** Delete ***-------------------
        public bool DeleteApplications(int ApplicationID)
        {

            return ClsDataAccessApplications.DeleteApplications(ApplicationID);

        }

        //-------------------*** Is Exist ***-------------------
        public bool IsExistsApplications(int ApplicationID)
        {
            return ClsDataAccessApplications.IsExistsApplications(ApplicationID);

        }

        //-----------------*** Get All ***---------------------
        public DataTable GetAllApplications()
        {
            return ClsDataAccessApplications.GetAllApplications();
        }


    }
}
