using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ClsDataAccessLocalDrivingLicenseApplications
    {
        public static bool FindLocalDrivingLicenseApplicationID(int LocalDrivingLicenseApplicationID, ref int ApplicationID,ref int LicenseClassID)
        {
            if (LocalDrivingLicenseApplicationID <= 0) return false;


            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionDB.ConnectionString);
            string query = "select * from LocalDrivingLicenseApplications where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue(@"LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ApplicationID = (int)reader["ApplicationID"];
                    LicenseClassID = (int)reader["LicenseClassID"];
                    IsFound = true;
                }
                reader.Close();
            }
            catch
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }
        //--------------------------------------

        public static int AddNewLocalDrivingLicenseApplications( int ApplicationID, int LicenseClassID)
        {

            int CreateID = -1;
            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);
            string query = @"Insert into LocalDrivingLicenseApplications values(@ApplicationID,@LicenseClassID)
                             select scope_identity();";
            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue(@"ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue(@"LicenseClassID", LicenseClassID);

            try
            {
                Connection.Open();
                object value = Command.ExecuteScalar();
                if (value != null && int.TryParse(value.ToString(), out int result))
                {
                    CreateID = result;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                CreateID = -1;
            }
            finally
            {
                Connection.Close();
            }
            return CreateID;
        }

        //--------------------------------------

        public static bool UpdateLocalDrivingLicenseApplications(int LocalDrivingLicenseApplicationID, int ApplicationID, int LicenseClassID)
        {

            if (LocalDrivingLicenseApplicationID <= 0) return false;

            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);

            string query = @"Update LocalDrivingLicenseApplications
                                set ApplicationID = @ApplicationID,
                                LicenseClassID = @LicenseClassID 
                                Where LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue(@"LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            Command.Parameters.AddWithValue(@"ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue(@"LicenseClassID", LicenseClassID);
            int Roweffected = 0;

            try
            {
                Connection.Open();
                Roweffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                Connection.Close();
            }
            return (Roweffected > 0);
        }

        //--------------------------------------

        public static bool DeleteLocalDrivingLicenseApplications(int LocalDrivingLicenseApplicationID)
        {

            if (LocalDrivingLicenseApplicationID <= 0) return false;

            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);

            string query = @"delete LocalDrivingLicenseApplications where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID"
            ;
            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue(@"LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            int Roweffected = 0;

            try
            {

                Connection.Open();
                Roweffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                Connection.Close();
            }
            return (Roweffected > 0);
        }

        //--------------------------------------

        public static bool IsExistsLocalDrivingLicenseApplications(int LocalDrivingLicenseApplicationID)
        {
            if (LocalDrivingLicenseApplicationID <= 0) return false;
            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);
            string query = @"Select Find = 1 from LocalDrivingLicenseApplications where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue(@"LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            bool IsAvailable = false;

            try
            {

                Connection.Open();

                object value = Command.ExecuteScalar();
                if (value != null)
                {
                    IsAvailable = true;
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                IsAvailable = false;
            }
            finally
            {
                Connection.Close();
            }
            return IsAvailable;

        }

        public static DataTable GetAllLocalDrivingLicenseApplications()
        {


            DataTable dt = new DataTable();

            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);

            string query = "Select * from LocalDrivingLicenseApplications";

            SqlCommand Command = new SqlCommand(query, Connection);

            try
            {

                Connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

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
                Connection.Close();
            }

            return dt;
        }

        public static bool FindIfChoiceClasssIDWithLocalDrivingLincese(int LicenseClassID, int ApplicantPersonID)
        {
            SqlConnection connection = new SqlConnection(clsConnectionDB.ConnectionString);

            string query = @"
                                select Find =1 from
                                (
                                select * from LocalDrivingLicenseApplications
                                where ApplicationID in(select   Applications.ApplicationID from Applications where ApplicantPersonID =@ApplicantPersonID)
                                ) R1
                                where R1.LicenseClassID = @LicenseClassID ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue(@"ApplicantPersonID", ApplicantPersonID);
            command.Parameters.AddWithValue(@"LicenseClassID", LicenseClassID);

            bool IsTrue = false;

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                if (Result != null) {

                    IsTrue = true;
                }
            }
            catch
            {
                IsTrue = false;
            }
            finally
            {
                connection.Close();
            }

            return (IsTrue);
        }


        public static bool FindIfChoiceClasssNameWithLocalDrivingLincese(string ClassName, string NationalNumber)
        {
            SqlConnection connection = new SqlConnection(clsConnectionDB.ConnectionString);

            string query = @"
                                select Find = 1 from(
                                select * from LocalDrivingLicenseApplications_View
                                where ClassName = @ClassName 
                                and 
                                NationalNo = @NationalNumber
                                
                                ) R2
                                where Status = 'New' or Status ='Completed' ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue(@"ClassName", ClassName);
            command.Parameters.AddWithValue(@"NationalNumber", NationalNumber);

            bool IsTrue = false;

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                if (Result != null)
                {

                    IsTrue = true;
                }
            }
            catch
            {
                IsTrue = false;
            }
            finally
            {
                connection.Close();
            }

            return (IsTrue);
        }


        public static DataTable GetFullDetailsAboutLoaclDrivingLinceseApplication()
        {
            DataTable dt = new DataTable();

            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);

            string query = "Select * from LocalDrivingLicenseApplications_View";

            SqlCommand Command = new SqlCommand(query, Connection);

            try
            {

                Connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

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
                Connection.Close();
            }

            return dt;
        }

        public static byte GetAllResultOfPassTest(int LocalDrivingLicenseApplicationID)
        {
            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);

            string query = "Select PassedTestCount from LocalDrivingLicenseApplications_View where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue(@"LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            byte PassTest = 0;

            try
            {
                Connection.Open();

                object val = Command.ExecuteScalar();

                if (val != null && int.TryParse(val.ToString(), out int Number)){
                    PassTest = (Byte)Number;
                }
            }
            catch
            {

            }
            finally
            {
                Connection.Close();

            }

            return PassTest;
        }
};
}
