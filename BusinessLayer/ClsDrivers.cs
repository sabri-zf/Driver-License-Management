using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class ClsDrivers
    {
        enum Mode { eAddNew,eUpdate}
        private Mode _mode;

        public int DriverID { get; set; }
        public int PersonID { get; set; }
        public ClsPeople SelectedPerson { get; set; }

       public int CreatedByUser { get; set; }
        public ClsUsers SelectedUser { get; set; }
        public DateTime CreatedDate { get; set; }


        public ClsDrivers()
        {
            DriverID = -1;
            PersonID = -1;
            CreatedByUser = -1;

            SelectedPerson = null;
            SelectedUser = null;
            CreatedDate = DateTime.Now;

            _mode = Mode.eAddNew;
        }

        private ClsDrivers( int driverID, int personID,int createdByUser, DateTime createdDate)
        {
            _mode = Mode.eUpdate;
            DriverID = driverID;
            PersonID = personID;
            SelectedPerson = ClsPeople.Find(personID);
            CreatedByUser = createdByUser;
            SelectedUser = ClsUsers.Find(createdByUser);
            CreatedDate = createdDate;
        }


        public static ClsDrivers FindByDriverID( int driverID)
        {
            int PersonID = -1,CreateByUser = -1;
            DateTime CreatedDate = DateTime.Now;

            if (ClsDataAccessDrivers.FindDriver(driverID, ref PersonID, ref CreateByUser, ref CreatedDate)){

                return new ClsDrivers(driverID,PersonID,CreateByUser, CreatedDate);
            }

            return null;
            
        }

        public static ClsDrivers FindByPersonID(int PersonID)
        {
            int DriverID = -1, CreateByUser = -1;
            DateTime CreatedDate = DateTime.Now;

            if (ClsDataAccessDrivers.FindDriverByPerson(ref DriverID,  PersonID, ref CreateByUser, ref CreatedDate)){

                return new ClsDrivers(DriverID, PersonID, CreateByUser, CreatedDate);
            }

            return null;

        }

        private bool _AddNewDriver()
        {
            this.DriverID = ClsDataAccessDrivers.AddNew(this.PersonID,this.CreatedByUser,this.CreatedDate);

            return (this.DriverID != -1);
        }


        private bool _UpdateDriver()
        {
            //this feature in Futer

            return true;
        }

        public bool Save()
        {
            switch (_mode)
            {
                case Mode.eAddNew:

                    if (_AddNewDriver())
                    {
                        _mode = Mode.eUpdate;
                        return true;
                    }

                    return false;

               case Mode.eUpdate:

                    return _UpdateDriver();

            }

            return false;
        }



        public static bool DeleteDriver(int DriverID)
        {
            return ClsDataAccessDrivers.DeleteDriver(DriverID);
        }
        public static DataTable GetAllDriver()
        {
            return ClsDataAccessDrivers.GetAllDrivers();
        }

        public static bool IsExistDriver(int DriverID)
        {
            return ClsDataAccessDrivers.IsExistDriver(DriverID);
        }

    }
}
