using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataAccessLayer.ClsDataAccessUser;
using System.Xml.Linq;
using System.Data;

namespace BusinessLayer
{
    public class ClsUsers
    {
        enum EMode
        {
            eAddNew, eUpdate }

 private EMode _mode;
 public int UserID  { get; set;}
 public int PersonID  { get; set;}
public string UserName  { get; set;}
public string Password { get; set;}
public bool IsActive  { get; set;}

public ClsUsers()
{
            this.UserID = -1;
            this.PersonID = 0; 
            this.UserName = "";
            this.Password = "";
            this.IsActive = false;

    _mode = EMode.eAddNew;
}

        protected ClsUsers(int UserID, int PersonID, string UserName, string Password, bool IsActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;
            _mode = EMode.eUpdate;
        }

        //-----------------****Find*** ---------------------
        public static ClsUsers Find(int UserID)
        {
            int PersonID = 0;
            string UserName = "";
            string Password = "";
            bool IsActive = false;

            if (ClsDataAccessUsers.FindUserID(UserID, ref PersonID, ref UserName, ref Password, ref IsActive))
            {
                return new ClsUsers(UserID, PersonID, UserName, Password, IsActive);
            }
            return null;
        }


        public static ClsUsers FindUserNameAndPassword(string UserName,string Password)
        {
            int PersonID = -1, UserID = -1;
            bool IsActive = false;

            if (ClsDataAccessUsers.FindByUserNameAndPassword(ref UserID, ref PersonID,  UserName, Password, ref IsActive))
            {
                return new ClsUsers(UserID, PersonID, UserName, Password, IsActive);
            }
            return null;
        }

        //--------------------*** Add New ***------------------
        private bool _AddNewUsers() {

            this.UserID = ClsDataAccessUsers.AddNewUsers(this.PersonID, this.UserName, this.Password, this.IsActive);

            return (this.UserID == -1);
        }

        //-------------------*** Update ***-------------------
        private bool _UpdateUsers()
        {
            return ClsDataAccessUsers.UpdateUsers(this.UserID, this.PersonID, this.UserName, this.Password, this.IsActive);
        }

        //-------------------*** Save ***-------------------
        public bool Save()
        {

            switch (_mode)
            {

                case EMode.eAddNew:
                    if (_AddNewUsers())
                    {
                        _mode = EMode.eUpdate;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case EMode.eUpdate:
                    return _UpdateUsers();
            }
            return false;
        }

        //-------------------*** Delete ***-------------------
        public static bool DeleteUsers(int UserID)
        {

            return ClsDataAccessUsers.DeleteUsers(UserID);

        }

        //-------------------*** Is Exist ***-------------------
        public static bool IsExistsUsers(int UserID)
        {
            return ClsDataAccessUsers.IsExistsUsers(UserID);

        }

        public static bool IsExistsUsers(string UserName)
        {
            return ClsDataAccessUsers.IsExistsUsers(UserName);
        }

        public static bool IsExistsUsersByPersonID(int PersonID)
        {
            return ClsDataAccessUsers.IsExistsUsersByPersonID(PersonID);
        }

        //-----------------*** Get All ***---------------------
        public static DataTable GetAllUsers()
        {

            return ClsDataAccessUsers.GetAllUsers();

        }

        //---------------------------------------------------------------

        public static DataTable GetAllUsersWithDetail()
        {
            return ClsDataAccessUsers.GetAllUsersWithDetail();
        }
        //---------------------------------------------------------------

        public static string GetUserName(int UserID)
        {
            return ClsDataAccessUsers.GetUserNamer(UserID);
        }
    }
}
