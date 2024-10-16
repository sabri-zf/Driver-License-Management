using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public static class ClsLicenseClasses
    {


        public static byte GetLengthOfValidToExpirationLicense(int LicenseClassID)
        {
            return ClsDataAccessLicenseClasses.GetExpiarationDate(LicenseClassID);
        }
        public static DataTable GetAllLicenseClasses()
        {
            return ClsDataAccessLicenseClasses.GetAllClasses();
        }

        public static string GetClassName(int LicenseClassID)
        {
            return ClsDataAccessLicenseClasses.GetClassName(LicenseClassID);
        }

        public static int GetLicenseClassID(string LicenseClassName)
        {
            return ClsDataAccessLicenseClasses.GetLicenseClassID(LicenseClassName);
        }
    }
}
