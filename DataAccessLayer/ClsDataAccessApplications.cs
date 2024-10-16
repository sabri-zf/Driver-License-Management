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
    public class ClsDataAccessApplications
    {
        public static bool FindApplicationID(int ApplicationID, ref int ApplicantPersonID, ref DateTime ApplicationDate, ref int ApplicationTypeID,
            ref byte ApplicationStatus, ref DateTime LastStatusDate, ref decimal PaidFees, ref int CreatedByUserID)
        {
            if (ApplicationID <= 0) return false;


            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionDB.ConnectionString);
            string query = "select * from Applications where ApplicationID = @ApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue(@"ApplicationID", ApplicationID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ApplicantPersonID = (int)reader["ApplicantPersonID"];
                    ApplicationDate = (DateTime)reader["ApplicationDate"];
                    ApplicationTypeID = (int)reader["ApplicationTypeID"];
                    ApplicationStatus = (byte)reader["ApplicationStatus"];
                    LastStatusDate = (DateTime)reader["LastStatusDate"];
                    PaidFees = (decimal)reader["PaidFees"];
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

        public static int AddNewApplications(int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID,
            byte ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID)
        {

            int CreateID = -1;
            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);
            string query = @"Insert into Applications values(@ApplicantPersonID,@ApplicationDate,@ApplicationTypeID,@ApplicationStatus,@LastStatusDate,@PaidFees,@CreatedByUserID)
                            select scope_identity();";
            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue(@"ApplicantPersonID", ApplicantPersonID);
            Command.Parameters.AddWithValue(@"ApplicationDate", ApplicationDate);
            Command.Parameters.AddWithValue(@"ApplicationTypeID", ApplicationTypeID);
            Command.Parameters.AddWithValue(@"ApplicationStatus", ApplicationStatus);
            Command.Parameters.AddWithValue(@"LastStatusDate", LastStatusDate);
            Command.Parameters.AddWithValue(@"PaidFees", PaidFees);
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

        public static bool UpdateApplications(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID,
            byte ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID)
        {

            if (ApplicationID <= 0) return false;

            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);

            string query = @"Update Applications
                            set ApplicantPersonID = @ApplicantPersonID,
                            ApplicationDate = @ApplicationDate,
                            ApplicationTypeID = @ApplicationTypeID,
                            ApplicationStatus = @ApplicationStatus,
                            LastStatusDate = @LastStatusDate,
                            PaidFees = @PaidFees,
                            CreatedByUserID = @CreatedByUserID 
                            Where ApplicationID=@ApplicationID";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue(@"ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue(@"ApplicantPersonID", ApplicantPersonID);
            Command.Parameters.AddWithValue(@"ApplicationDate", ApplicationDate);
            Command.Parameters.AddWithValue(@"ApplicationTypeID", ApplicationTypeID);
            Command.Parameters.AddWithValue(@"ApplicationStatus", ApplicationStatus);
            Command.Parameters.AddWithValue(@"LastStatusDate", LastStatusDate);
            Command.Parameters.AddWithValue(@"PaidFees", PaidFees);
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

        public static bool DeleteApplications(int ApplicationID)
        {

            if (ApplicationID <= 0) return false;

            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);

            string query = @"delete Applications where ApplicationID = @ApplicationID"
            ;
            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue(@"ApplicationID", ApplicationID);
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

        public static bool IsExistsApplications(int ApplicationID)
        {
            if (ApplicationID <= 0) return false;
            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);
            string query = @"Select Find = 1 from Applications where ApplicationID = @ApplicationID";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue(@"ApplicationID", ApplicationID);

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

        public static DataTable GetAllApplications()
        {

            DataTable dt = new DataTable();

            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);

            string query = "Select * from Applications";

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
    }

}
