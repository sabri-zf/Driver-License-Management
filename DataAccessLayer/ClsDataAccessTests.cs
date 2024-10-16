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
    public class ClsDataAccessTests
    {
        public static bool FindTestID(int TestID, ref int TestAppointmentID, ref bool TestResult, ref string Notes, ref int CreatedByUserID)
        {
            if (TestID <= 0) return false;


            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionDB.ConnectionString);
            string query = "select * from Tests where TestID = @TestID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue(@"TestID", TestID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    TestAppointmentID = (int)reader["TestAppointmentID"];
                    TestResult = (bool)reader["TestResult"];
                    Notes = reader["Notes"] == System.DBNull.Value ? "N/A" : (string)reader["Notes"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
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

        public static int AddNewTests(int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {

            int CreateID = -1;
            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);
            string query = @"Insert into Tests values(@TestAppointmentID,@TestResult,@Notes,@CreatedByUserID)
                            select scope_identity();";
            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue(@"TestAppointmentID", TestAppointmentID);
            Command.Parameters.AddWithValue(@"TestResult", TestResult);

            if (string.IsNullOrEmpty(Notes) || Notes == "N/A")
            {
                Command.Parameters.AddWithValue(@"Notes", System.DBNull.Value);
            }
            else
            {
                Command.Parameters.AddWithValue(@"Notes", Notes);
            };

            Command.Parameters.AddWithValue(@"CreatedByUserID", CreatedByUserID);

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

        public static bool UpdateTests(int TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {

            if (TestID <= 0) return false;

            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);

            string query = @"Update Tests
                            set TestAppointmentID = @TestAppointmentID,
                            TestResult = @TestResult,
                            Notes = @Notes,
                            CreatedByUserID = @CreatedByUserID Where TestID=@TestID";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue(@"TestID", TestID);
            Command.Parameters.AddWithValue(@"TestAppointmentID", TestAppointmentID);
            Command.Parameters.AddWithValue(@"TestResult", TestResult);
            if (string.IsNullOrEmpty(Notes) || Notes == "N/A")
            {
                Command.Parameters.AddWithValue(@"Notes", System.DBNull.Value);

            }
            else
            {
                Command.Parameters.AddWithValue(@"Notes", Notes);
            };

            Command.Parameters.AddWithValue(@"CreatedByUserID", CreatedByUserID);
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

        public static bool DeleteTests(int TestID)
        {

            if (TestID <= 0) return false;

            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);

            string query = @"delete Tests where TestID = @TestID"
            ;
            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue(@"TestID", TestID);
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

        public static bool IsExistsTests(int TestID)
        {
            if (TestID <= 0) return false;

            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);
            string query = @"Select Find = 1 from Tests where ID = @TestID";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue(@"TestID", TestID);

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

        public static DataTable GetAllTests()
        {

            DataTable dt = new DataTable();

            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);

            string query = "Select * from Tests";

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


        public static bool IfUserPassedInThisTest(int DL_AppID, int TestTypeID)
        {
            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);

            string query = @"select Result = 1 from Tests
                                where TestAppointmentID in (select TestAppointmentID from TestAppointments 
                                where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID and TestAppointments.TestTypeID = @TestTypeID) and TestResult = 1
                            ";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue(@"LocalDrivingLicenseApplicationID", DL_AppID);
            Command.Parameters.AddWithValue(@"TestTypeID", TestTypeID);

            bool IsPassed = false;

            try
            {
                Connection.Open();

                object val = Command.ExecuteScalar();

                if (val != null)
                {
                    IsPassed = true;
                }

            }
            catch
            {
                IsPassed = false;
            }
            finally
            {
                Connection.Close();
            }

            return IsPassed;
        }

       
        public static bool IsExistsTests(int DL_AppID, int TestTypeID)
        {
            if (DL_AppID <= 0 || TestTypeID <= 0) return false;

            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);

            string query = @"select distinct Result = 1 from Tests
                                where TestAppointmentID in (select TestAppointmentID from TestAppointments 
                                where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID and TestAppointments.TestTypeID = @TestTypeID);
                            ";

            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue(@"LocalDrivingLicenseApplicationID", DL_AppID);
            Command.Parameters.AddWithValue(@"TestTypeID", TestTypeID);

            bool IsPassed = false;

            try
            {
                Connection.Open();

                object val = Command.ExecuteScalar();

                if (val != null)
                {
                    IsPassed = true;
                }

            }
            catch
            {
                IsPassed = false;
            }
            finally
            {
                Connection.Close();
            }

            return IsPassed;
        }

    }
}
