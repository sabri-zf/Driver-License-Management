using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BusinessLayer;
using System.Net;
using System.Security.Policy;
using System.Xml.Linq;
using DataAccessLayer;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace BusinessLayer
{
    public class ClsPeople
    {
        enum EMode { eAddNew, eUpdate }
        private EMode _mode;
          private  int PersonID { get; set; }
       
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public byte Gendor { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }
        public string ImagePath { get; set; }

        public ClsPeople()
        {
            this.PersonID = -1;
            this.NationalNo = "";
            this.FirstName = ""; 
            this.LastName = ""; 
            this.DateOfBirth = new DateTime(); 
            this.Gendor = 0; this.Address = "";
            this.Phone = ""; 
            this.Email = ""; 
            this.NationalityCountryID = -1;
            this.ImagePath = "";
            _mode = EMode.eAddNew;
        }

        protected ClsPeople(int PersontID, string NationalNo, string FirstName, string LastName, DateTime DateOfBirth, byte Gendor, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {

            this.PersonID = PersontID;
            this.NationalNo = NationalNo; this.FirstName = FirstName; this.LastName = LastName; this.DateOfBirth = DateOfBirth; this.Gendor = Gendor; this.Address = Address; this.Phone = Phone; this.Email = Email; this.NationalityCountryID = NationalityCountryID; this.ImagePath = ImagePath; _mode = EMode.eUpdate;
        }

        //-----------------****FindByID*** ---------------------
        public static ClsPeople Find(int PersonID)
        {
            string NationalNo = "";
            string FirstName = "";
            string LastName = "";
            DateTime DateOfBirth = new DateTime();
            byte Gendor = 0;
            string Address = "";
            string Phone = "";
            string Email = "";
            int NationalityCountryID = 0;
            string ImagePath = "";
            if (ClsDataAccessPeople.FindPersonID(PersonID, ref NationalNo, ref FirstName, ref LastName, ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
            {
                return new ClsPeople(PersonID, NationalNo, FirstName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            }
            return null;
        }


        public int GetPersonID()
        {
            return this.PersonID;
        }
        public static ClsPeople FindNational(string NationalNo)
        {
            int PersonID = -1;
            string FirstName = "";
            string LastName = "";
            DateTime DateOfBirth = new DateTime();
            byte Gendor = 0;
            string Address = "";
            string Phone = "";
            string Email = "";
            int NationalityCountryID = 0;
            string ImagePath = "";
            if (ClsDataAccessPeople.FindNationalNo(ref PersonID,  NationalNo, ref FirstName, ref LastName, ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
            {
                return new ClsPeople(PersonID, NationalNo, FirstName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            }
            return null;
        }
        //--------------------*** Add New ***------------------
        private bool _AddNewPeople()
        {

            this.PersonID = ClsDataAccessPeople.AddNewPeople(this.NationalNo, this.FirstName, this.LastName, this.DateOfBirth, this.Gendor, this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);

            

            return (this.PersonID != -1);
        }

        //-------------------*** Update ***-------------------
        private bool _UpdatePeople()
        {
            return ClsDataAccessPeople.UpdatePeople(this.PersonID, this.NationalNo, this.FirstName, this.LastName, this.DateOfBirth, this.Gendor, this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);
        }

        //-------------------*** Save ***-------------------
        public bool Save()
        {

            switch (_mode)
            {

                case EMode.eAddNew:
                    if (_AddNewPeople())
                    {
                        _mode = EMode.eUpdate;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case EMode.eUpdate:
                    return _UpdatePeople();
            }
            return false;
        }

        //-------------------*** Delete ***-------------------
        public static bool DeletePeople(int PersonID)
        {

            return ClsDataAccessPeople.DeletePeople(PersonID);

        }

        //-------------------*** Is Exist ***-------------------
        public static bool IsExistsPeople(int PersonID)
        {
            return ClsDataAccessPeople.IsExistsPeople(PersonID);

        }
        public static bool IsExistsNationalNO(string NationalNo)
        {
            return ClsDataAccessPeople.IsExistsPeopleWithNational(NationalNo);

        }
        //-----------------*** Get All ***---------------------
        public static DataTable GetAllPeople()
        {

            return ClsDataAccessPeople.GetAllPeople();

        }

        public static DataTable GetAllPeopleDetails()
        {
            return ClsDataAccessPeople.GetAllPeopleDetails();
        }


        public static bool CheckValidNatonal(string input)
        {
            return ClsDataAccessPeople.CheckAboutNationalNO(input);
        }


        public  string FullName()
        {
            return this.FirstName + " " + this.LastName;
        }
    };
}
