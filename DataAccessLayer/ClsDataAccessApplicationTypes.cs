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
    public class ClsDataAccessApplicationTypes
    {

        //--------------------------------------

        public static int AddNewApplicationTypes(string ApplicationTypeTitle, decimal ApplicationFees)
        {

            int CreateID = -1;
            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);
            string query = @"Insert into ApplicationTypes values(@ApplicationTypeTitle,@ApplicationFees)
                    select scope_identity();";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue(@"ApplicationTypeTitle", ApplicationTypeTitle);
            Command.Parameters.AddWithValue(@"ApplicationFees", ApplicationFees);

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
        public static bool DeleteApplicationTypes(int ApplicationTypeID)
        {

            if (ApplicationTypeID <= 0) return false;

            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);

            string query = @"delete ApplicationTypes where ApplicationTypeID = @ApplicationTypeID"
            ;
            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue(@"ApplicationTypeID", ApplicationTypeID);
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


        public static bool FindApplicationTypeID(int ApplicationTypeID, ref string ApplicationTypeTitle, ref decimal ApplicationFees)
        {
            if (ApplicationTypeID <= 0) return false;


            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionDB.ConnectionString);
            string query = "select * from ApplicationTypes where ApplicationTypeID = @ApplicationTypeID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue(@"ApplicationTypeID", ApplicationTypeID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ApplicationTypeTitle = (string)reader["ApplicationTypeTitle"];
                    ApplicationFees = (decimal)reader["ApplicationFees"];
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

        public static bool FindTitle(ref int ApplicationTypeID,  string ApplicationTypeTitle, ref decimal ApplicationFees)
        {
            if (string.IsNullOrEmpty(ApplicationTypeTitle)) return false;


            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionDB.ConnectionString);
            string query = "select * from ApplicationTypes where ApplicationTypeTitle = @ApplicationTypeTitle";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue(@"ApplicationTypeTitle", ApplicationTypeTitle);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ApplicationTypeID = (int)reader["ApplicationTypeID"];
                    ApplicationFees = (decimal)reader["ApplicationFees"];
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
        public static bool UpdateApplicationTypes(int ApplicationTypeID, string ApplicationTypeTitle, decimal ApplicationFees)
        {

            if (ApplicationTypeID <= 0) return false;

            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);

            string query = @"Update ApplicationTypes
                            set ApplicationTypeTitle = @ApplicationTypeTitle,
                            ApplicationFees = @ApplicationFees 
                            Where ApplicationTypeID = @ApplicationTypeID";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue(@"ApplicationTypeID", ApplicationTypeID);
            Command.Parameters.AddWithValue(@"ApplicationTypeTitle", ApplicationTypeTitle);
            Command.Parameters.AddWithValue(@"ApplicationFees", ApplicationFees);
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

        public static bool IsExistsApplicationTypes(int ApplicationTypeID)
        {
            if (ApplicationTypeID <= 0) return false;

            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);
            string query = @"Select Find = 1 from ApplicationTypes where ApplicationTypeID = @ApplicationTypeID";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue(@"ApplicationTypeID", ApplicationTypeID);

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

        public static DataTable GetAllApplicationTypes()
        {

            DataTable dt = new DataTable();

            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);

            string query = "Select * from ApplicationTypes";

            SqlCommand Command = new SqlCommand(query, Connection);

            try
            {

                Connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                if (reader.Read())
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


        //----------------------------------------------

        public static string  ApplicationTypeName(int ApplicationTypeID)
        {

            if (ApplicationTypeID <= 0) return "";

            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);

            string query = "Select ApplicationTypeTitle from ApplicationTypes where ApplicationTypeID = @ApplicationTypeID";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue(@"ApplicationTypeID", ApplicationTypeID);


            string ApplicationName = string.Empty;
            try
            {
                Connection.Open();

                object val = Command.ExecuteScalar();

                if (val != null)
                { 
                    ApplicationName = val.ToString();
                }

            }
            catch
            {

            }
            finally
            {
                Connection.Close();
            }

            return ApplicationName;
        }


        public static float ApplicationTypeFees(int ApplicationTypeID)
        {

            if (ApplicationTypeID <= 0) return 0;

            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);

            string query = "Select ApplicationFees from ApplicationTypes where ApplicationTypeID = @ApplicationTypeID";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue(@"ApplicationTypeID", ApplicationTypeID);


            float ApplicationFees=00;
            try
            {
                Connection.Open();

                object val = Command.ExecuteScalar();

                if (val != null)
                {
                    ApplicationFees = Convert.ToSingle(val.ToString());
                }

            }
            catch
            {

            }
            finally
            {
                Connection.Close();
            }

            return ApplicationFees;
        }

        //----------------------------------------------------------------


    }
}
