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
    public class ClsDataAccessLicenses
    {
        public static bool FindLicenseID(int LicenseID, ref int ApplicationID, ref int DriverID,
          ref int LicenseClass, ref DateTime IssueDate, ref DateTime ExpirationDate, ref string Notes,
          ref decimal PaidFees, ref bool IsActive, ref byte IssueReason, ref int CreatedByUserID)
        {
            if (LicenseID <= 0) return false;


            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionDB.ConnectionString);
            string query = "select * from Licenses where LicenseID = @LicenseID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue(@"LicenseID", LicenseID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    ApplicationID = (int)reader["ApplicationID"];
                    DriverID = (int)reader["DriverID"];
                    LicenseClass = (int)reader["LicenseClass"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    Notes = reader["Notes"] == System.DBNull.Value ? "" : (string)reader["Notes"];
                    PaidFees = (decimal)reader["PaidFees"];
                    IsActive = (bool)reader["IsActive"];
                    IssueReason = (byte)reader["IssueReason"];
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

        public static bool FindByApplicationID(ref int LicenseID,  int ApplicationID, ref int DriverID,
        ref int LicenseClass, ref DateTime IssueDate, ref DateTime ExpirationDate, ref string Notes,
        ref decimal PaidFees, ref bool IsActive, ref byte IssueReason, ref int CreatedByUserID)
        {
            if (ApplicationID <= 0) return false;


            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionDB.ConnectionString);
            string query = "select * from Licenses where ApplicationID = @ApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue(@"ApplicationID", ApplicationID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    LicenseID = (int)reader["LicenseID"];
                    DriverID = (int)reader["DriverID"];
                    LicenseClass = (int)reader["LicenseClass"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    Notes = reader["Notes"] == System.DBNull.Value ? "" : (string)reader["Notes"];
                    PaidFees = (decimal)reader["PaidFees"];
                    IsActive = (bool)reader["IsActive"];
                    IssueReason = (byte)reader["IssueReason"];
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

        public static int AddNewLicenses(int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate,
            DateTime ExpirationDate, string Notes, decimal PaidFees, bool IsActive, byte IssueReason, int CreatedByUserID)
        {

            int CreateID = -1;
            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);
            string query = @"Insert into Licenses values(@ApplicationID,@DriverID,@LicenseClass,@IssueDate,@ExpirationDate,@Notes,@PaidFees,@IsActive,@IssueReason,@CreatedByUserID)
                            select scope_identity();";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue(@"ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue(@"DriverID", DriverID);
            Command.Parameters.AddWithValue(@"LicenseClass", LicenseClass);
            Command.Parameters.AddWithValue(@"IssueDate", IssueDate);
            Command.Parameters.AddWithValue(@"ExpirationDate", ExpirationDate);
            if (Notes == "N/A" || string.IsNullOrEmpty(Notes))
            {
                Command.Parameters.AddWithValue(@"Notes", System.DBNull.Value);

            }
            else
            {
                Command.Parameters.AddWithValue(@"Notes", Notes);
            };

            Command.Parameters.AddWithValue(@"PaidFees", PaidFees);
            Command.Parameters.AddWithValue(@"IsActive", IsActive);
            Command.Parameters.AddWithValue(@"IssueReason", IssueReason);
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

        public static bool UpdateLicenses(int LicenseID, int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate,
            DateTime ExpirationDate, string Notes, decimal PaidFees, bool IsActive, byte IssueReason, int CreatedByUserID)
        {

            if (LicenseID <= 0) return false;

            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);

            string query = @"Update Licenses
                            set ApplicationID = @ApplicationID,
                            DriverID = @DriverID,
                            LicenseClass = @LicenseClass,
                            IssueDate = @IssueDate,
                            ExpirationDate = @ExpirationDate,
                            Notes = @Notes,
                            PaidFees = @PaidFees,
                            IsActive = @IsActive,
                            IssueReason = @IssueReason,
                            CreatedByUserID = @CreatedByUserID Where LicenseID=@LicenseID";

            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue(@"LicenseID", LicenseID);
            Command.Parameters.AddWithValue(@"ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue(@"DriverID", DriverID);
            Command.Parameters.AddWithValue(@"LicenseClass", LicenseClass);
            Command.Parameters.AddWithValue(@"IssueDate", IssueDate);
            Command.Parameters.AddWithValue(@"ExpirationDate", ExpirationDate);
            if (Notes == "N/A" || string.IsNullOrEmpty(Notes))
            {
                Command.Parameters.AddWithValue(@"Notes", System.DBNull.Value);

            }
            else
            {
                Command.Parameters.AddWithValue(@"Notes", Notes);
            };

            Command.Parameters.AddWithValue(@"PaidFees", PaidFees);
            Command.Parameters.AddWithValue(@"IsActive", IsActive);
            Command.Parameters.AddWithValue(@"IssueReason", IssueReason);
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

        public static bool DeleteLicenses(int LicenseID)
        {

            if (LicenseID <= 0) return false;

            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);

            string query = @"delete Licenses where LicenseID = @LicenseID"
            ;
            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue(@"LicenseID", LicenseID);
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

        public static bool IsExistsLicenses(int LicenseID)
        {
            if (LicenseID <= 0) return false;
            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);
            string query = @"Select Find = 1 from Licenses where ID = @LicenseID";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue(@"LicenseID", LicenseID);

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

        public static DataTable GetAllLicenses()
        {

            DataTable dt = new DataTable();

            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);

            string query = "Select * from Licenses";

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


        public static DataTable GetAllLicensesHistory(int DriverID)
        {

            DataTable dt = new DataTable();

            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);

            string query = "select * from  LicenseHistoryDetails where DriverID =@DriverID";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue(@"DriverID", DriverID);

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
