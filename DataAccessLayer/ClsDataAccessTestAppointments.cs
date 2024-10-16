using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace DataAccessLayer
{
    public class ClsDataAccessTestAppointments
    {
        public static bool FindTestAppointmentID(int TestAppointmentID, ref int TestTypeID, ref int LocalDrivingLicenseApplicationID,
            ref DateTime AppointmentDate, ref decimal PaidFees, ref int CreatedByUserID, ref bool IsLocked, ref int RetakeTestApplicationID)
        {

            if (TestAppointmentID <= 0) return false;


            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionDB.ConnectionString);
            string query = "select * from TestAppointments where TestAppointmentID = @TestAppointmentID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue(@"TestAppointmentID", TestAppointmentID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {

                    TestTypeID = (int)reader["TestTypeID"];
                    LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                    AppointmentDate = (DateTime)reader["AppointmentDate"];
                    PaidFees = (decimal)reader["PaidFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsLocked = (bool)reader["IsLocked"];
                    RetakeTestApplicationID = reader["RetakeTestApplicationID"] == System.DBNull.Value ? -1 : (int)reader["RetakeTestApplicationID"];

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

        public static bool FindLocalDrivingLiecnseApplicationID( ref int TestAppointmentID, ref int TestTypeID,  int LocalDrivingLicenseApplicationID,
            ref DateTime AppointmentDate, ref decimal PaidFees, ref int CreatedByUserID, ref bool IsLocked, ref int RetakeTestApplicationID)
        {

            if (LocalDrivingLicenseApplicationID <= 0) return false;


            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionDB.ConnectionString);
            string query = "select * from TestAppointments where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue(@"LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {

                    TestTypeID = (int)reader["TestTypeID"];
                    TestAppointmentID = (int)reader["TestAppointmentID"];
                    AppointmentDate = (DateTime)reader["AppointmentDate"];
                    PaidFees = (decimal)reader["PaidFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsLocked = (bool)reader["IsLocked"];
                    RetakeTestApplicationID = reader["RetakeTestApplicationID"] == System.DBNull.Value ? -1 : (int)reader["RetakeTestApplicationID"];

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

        public static int AddNewTestAppointments(int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate,
            decimal PaidFees, int CreatedByUserID, bool IsLocked, int? RetakeTestApplicationID)
        {

            int CreateID = -1;
            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);
            string query = @"Insert into TestAppointments values(@TestTypeID,@LocalDrivingLicenseApplicationID,@AppointmentDate,@PaidFees,@CreatedByUserID,@IsLocked,@RetakeTestApplicationID)
                            select scope_identity();";

            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue(@"TestTypeID", TestTypeID);
            Command.Parameters.AddWithValue(@"LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            Command.Parameters.AddWithValue(@"AppointmentDate", AppointmentDate);
            Command.Parameters.AddWithValue(@"PaidFees", PaidFees);
            Command.Parameters.AddWithValue(@"CreatedByUserID", CreatedByUserID);
            Command.Parameters.AddWithValue(@"IsLocked", IsLocked);

            if (RetakeTestApplicationID == 0 || RetakeTestApplicationID == -1)
            {
                Command.Parameters.AddWithValue(@"RetakeTestApplicationID", System.DBNull.Value);

            }
            else
            {
                Command.Parameters.AddWithValue(@"RetakeTestApplicationID", RetakeTestApplicationID);
            }

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

        public static bool UpdateTestAppointments(int TestAppointmentID, int TestTypeID, int LocalDrivingLicenseApplicationID,
            DateTime AppointmentDate, decimal PaidFees, int CreatedByUserID, bool IsLocked, int? RetakeTestApplicationID)
        {

            if (TestAppointmentID <= 0) return false;

            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);

            string query = @"Update TestAppointments
                            set TestTypeID = @TestTypeID,
                            LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID,
                            AppointmentDate = @AppointmentDate,
                            PaidFees = @PaidFees,
                            CreatedByUserID = @CreatedByUserID,
                            IsLocked = @IsLocked,
                            RetakeTestApplicationID = @RetakeTestApplicationID Where TestAppointmentID=@TestAppointmentID";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue(@"TestAppointmentID", TestAppointmentID);
            Command.Parameters.AddWithValue(@"TestTypeID", TestTypeID);
            Command.Parameters.AddWithValue(@"LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            Command.Parameters.AddWithValue(@"AppointmentDate", AppointmentDate);
            Command.Parameters.AddWithValue(@"PaidFees", PaidFees);
            Command.Parameters.AddWithValue(@"CreatedByUserID", CreatedByUserID);
            Command.Parameters.AddWithValue(@"IsLocked", IsLocked);

            if (RetakeTestApplicationID == 0 || RetakeTestApplicationID == -1)
            {
                Command.Parameters.AddWithValue(@"RetakeTestApplicationID", System.DBNull.Value);

            }
            else
            {
                Command.Parameters.AddWithValue(@"RetakeTestApplicationID", RetakeTestApplicationID);
            }

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

        public static bool DeleteTestAppointments(int TestAppointmentID)
        {

            if (TestAppointmentID <= 0) return false;

            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);

            string query = @"delete TestAppointments where TestAppointmentID = @TestAppointmentID"
            ;
            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue(@"TestAppointmentID", TestAppointmentID);
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

        public static bool IsExistsTestAppointments(int TestAppointmentID)
        {
            if (TestAppointmentID <= 0) return false;

            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);
            string query = @"Select Find = 1 from TestAppointments where TestAppointmentID = @TestAppointmentID";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue(@"TestAppointmentID", TestAppointmentID);

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

        public static DataTable GetAllTestAppointments()
        {

            DataTable dt = new DataTable();

            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);

            string query = "Select * from TestAppointments";

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


        //Table Test Schedule
        public static DataTable GetTestAppointmentsofVison(int LDL_AppID)
        {

            DataTable dt = new DataTable();

            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);

            string query = "select TestAppointmentID,AppointmentDate,PaidFees,IsLocked from TestAppointments_View where LocalDrivingLicenseApplicationID = @LDL_AppID  and TestTypeTitle = 'Vision Test'";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue(@"LDL_AppID", LDL_AppID);

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

        public static DataTable GetTestAppointmentsofWrite(int LDL_AppID)
        {

            DataTable dt = new DataTable();

            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);

            string query = "select TestAppointmentID,AppointmentDate,PaidFees,IsLocked from TestAppointments_View where LocalDrivingLicenseApplicationID = @LDL_AppID  and TestTypeTitle = 'Written (Theory) Test'";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue(@"LDL_AppID", LDL_AppID);

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

        public static DataTable GetTestAppointmentsofStreet(int LDL_AppID)
        {

            DataTable dt = new DataTable();

            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);

            string query = @"select TestAppointmentID,AppointmentDate,PaidFees,IsLocked from TestAppointments_View 
                                where LocalDrivingLicenseApplicationID = @LDL_AppID  
                                and TestTypeTitle = 'Practical (Street) Test'";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue(@"LDL_AppID", LDL_AppID);

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


        //-----------------------------------

        public static bool IsTestAppoitmentIsLocked(int LDL_ApplictionID, int TypeTestID)
        {
            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);

            string query = @"select Find = 1 from TestAppointments 
                            where LocalDrivingLicenseApplicationID = @LDL_ApplictionID and TestTypeID =@TypeTestID and IsLocked = 0";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue(@"LDL_ApplictionID", LDL_ApplictionID);
            Command.Parameters.AddWithValue(@"TypeTestID", TypeTestID);

            bool Checked = false; 
            try
            {
                Connection.Open();

                object obj = Command.ExecuteScalar();

                if (obj != null)
                {
                    Checked = true;
                }

            }
            catch
            {
                Checked=false;
            }
            finally{
                Connection.Close();
            }

            return Checked;
        }
        public static byte GetTrail(int LDL_ApplictionID, int TypeTestID)
        {

            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);

            string query = @"
                            select count(TestAppointmentID) as trail from TestAppointments
                            where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID and TestTypeID = @TestTypeID and IsLocked = 1
                            ";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue(@"LocalDrivingLicenseApplicationID", LDL_ApplictionID);
            Command.Parameters.AddWithValue(@"TestTypeID", TypeTestID);


            byte TralNumber = 0;
            try
            {
                Connection.Open();

                object val = Command.ExecuteScalar();

                if (val != null && int.TryParse(val.ToString(), out int Number))
                {

                    TralNumber = (byte)val;
                }
            }
            catch
            {

            }
            finally
            {
                Connection.Close();
            }

            return TralNumber;
        }


    }
}
