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
    public class clsCountries
    {
        enum EMode
        {
            eAddNew, eUpdate
        }
        private EMode _mode;
        public int CountryID { get; set; }
        public string CountryName { get; set; }

        public clsCountries()
        {
            this.CountryID = -1;
            this.CountryName = string.Empty;
            _mode = EMode.eAddNew;
        }

        protected clsCountries(int CountryID, string CountryName)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
            _mode = EMode.eUpdate;
        }

        //-----------------****FindByID*** ---------------------
        public static clsCountries Find(int CountryID)
        {
            string CountryName = "";
            if (ClsDataAccessCountries.FindCountryID(CountryID, ref CountryName))
            {
                return new clsCountries(CountryID, CountryName);
            }
            return null;
        }

        public static clsCountries Find(string CountryName)
        {
            int CountryID = -1;

            if (ClsDataAccessCountries.FindCountryName(ref CountryID,CountryName))
            {
                return new clsCountries(CountryID,CountryName);
            }

            return null;
        }
        //--------------------*** Add New ***------------------
        private bool _AddNewCountries()
        {
            this.CountryID = ClsDataAccessCountries.AddNewCountries(this.CountryName);


            return (this.CountryID <= -1);
        }

        //-------------------*** Update ***-------------------
        private bool _UpdateCountries()
        {
            return ClsDataAccessCountries.UpdateCountries(this.CountryID, this.CountryName);
        }

        //-------------------*** Save ***-------------------
        public bool Save()
        {

            switch (_mode)
            {

                case EMode.eAddNew:
                    if (_AddNewCountries())
                    {
                        _mode = EMode.eUpdate;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case EMode.eUpdate:
                    return _UpdateCountries();
            }
            return false;
        }

        //-------------------*** Delete ***-------------------
        public bool DeleteCountries(int CountryID)
        {

            return ClsDataAccessCountries.DeleteCountries(CountryID);

        }

        //-------------------*** Is Exist ***-------------------
        public bool IsExistsCountries(int CountryID)
        {
            return ClsDataAccessCountries.IsExistsCountries(CountryID);

        }

        //-----------------*** Get All ***---------------------
        public static DataTable GetAllCountries()
        {

            return ClsDataAccessCountries.GetAllCountries();

        }

        public static sbyte GetCountryID(string CountryName)
        {
            return ClsDataAccessCountries.GetCountryID(CountryName);
        }

        public static string GetCountryName(byte CountryID)
        {
            return ClsDataAccessCountries.GetCountryName(CountryID);
        }



    }
}
