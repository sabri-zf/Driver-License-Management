using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ClsDataAccessLicenseClasses
    {

        public static byte GetExpiarationDate(int LicenseClassID)
        {
            byte LengthOfValiidationLicense = 0;

            SqlConnection connection = new SqlConnection(clsConnectionDB.ConnectionString);

            string query = "Select DefaultValidityLength from LicenseClasses where LicenseClassID = @LicenseClassID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue(@"LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();

                object val = command.ExecuteScalar();

                if (val != null && int.TryParse(val.ToString(),out int Length))
                {
                    LengthOfValiidationLicense = (byte)Length;
                }
            }
            catch
            {

            }
            finally { connection.Close(); }

            return LengthOfValiidationLicense;
        }
        public static DataTable GetAllClasses()
        {
            DataTable dt = new DataTable();

            SqlConnection connection  = new SqlConnection(clsConnectionDB.ConnectionString);

            string query = "Select * from LicenseClasses";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return dt;  
        }
        public static string GetClassName(int LicenseClassID)
        {

            string ClassName =string.Empty;

            SqlConnection connection = new SqlConnection(clsConnectionDB.ConnectionString);

            string query = "Select ClassName from LicenseClasses where LicenseClassID = @LicenseClassID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue(@"LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();

               object val = command.ExecuteScalar();

                if(val != null)
                {
                    ClassName = val.ToString();
                }
            }
            catch
            {

            }finally { connection.Close(); }

            return ClassName;

        }


        public static int GetLicenseClassID(string ClassName)
        {

            int ClassID =-1;

            SqlConnection connection = new SqlConnection(clsConnectionDB.ConnectionString);

            string query = "Select LicenseClassID from LicenseClasses where ClassName = @ClassName";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue(@"ClassName", ClassName);

            try
            {
                connection.Open();

                object val = command.ExecuteScalar();

                if (val != null && int.TryParse(val.ToString(),out int ID))
                {
                    ClassID = ID;
                }
            }
            catch
            {

            }
            finally { connection.Close(); }

            return ClassID;

        }

    }
}
