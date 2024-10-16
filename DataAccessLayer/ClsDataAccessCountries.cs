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
    public class ClsDataAccessCountries
    {
        public static bool FindCountryID(int CountryID, ref string CountryName)
        {
            if (CountryID >= 0) return false;


            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionDB.ConnectionString);
            string query = "select * from Countries where CountryID = @CountryID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue(@"CountryID", CountryID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    CountryName = (string)reader["CountryName"];
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


        public static bool FindCountryName(ref int CountryID, string CountryName)
        {
            if (string.IsNullOrEmpty(CountryName)) return false;


            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionDB.ConnectionString);
            string query = "select * from Countries where CountryName = @CountryName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue(@"CountryName", CountryName);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    CountryID = (int)reader["CountryID"];
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

        public static int AddNewCountries(string CountryName)
        {

            int CreateID = 0;
            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);
            string query = @"Insert into Countries values(
@CountryName)
scope_identity()";
            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue(@"CountryName", CountryName);

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

        public static bool UpdateCountries(int CountryID, string CountryName)
        {

            if (CountryID <= 0) return false;

            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);

            string query = @"Update Countries
 set CountryName = @CountryName Where CountryID=@CountryID";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue(@"CountryID", CountryID);
            Command.Parameters.AddWithValue(@"CountryName", CountryName);
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

        public static bool DeleteCountries(int CountryID)
        {

            if (CountryID <= 0) return false;

            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);

            string query = @"delete Countries where CountryID = @CountryID"
            ;
            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue(@"CountryID", CountryID);
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

        public static bool IsExistsCountries(int CountryID)
        {
            if (CountryID >= 0) return false;
            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);
            string query = @"Select Find = 1 from Countries where ID = @CountryID";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue(@"CountryID", CountryID);

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

        public static DataTable GetAllCountries()
        {

            DataTable dt = new DataTable();

            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);

            string query = "Select * from Countries";

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


        public static sbyte GetCountryID(string CountryName)
        {
            if (string.IsNullOrEmpty(CountryName)) return -1;

            SqlConnection connection = new SqlConnection(clsConnectionDB.ConnectionString);

            string query = @"select CountryID From Countries where CountryName = @CountryName ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue(@"CountryName", CountryName);

            sbyte IDCountry = -1;

            try
            {
                connection.Open();

                object value = command.ExecuteScalar();
                if (value != null && int.TryParse(value.ToString(), out int ID))
                {
                    IDCountry = (sbyte)ID;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            } finally { connection.Close(); }

            return IDCountry;
        }
        public static string GetCountryName(byte CountryID)
        {
            if (CountryID <= 0) return "";

            SqlConnection connection = new SqlConnection(clsConnectionDB.ConnectionString);

            string query = @"select CountryName From Countries where CountryID = @CountryID ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue(@"CountryID", CountryID);

           string CountryName= string.Empty;

            try
            {
                connection.Open();

                object value = command.ExecuteScalar();
                if (value != null )
                {
                    CountryName = value.ToString().Trim();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally { connection.Close(); }

            return CountryName;

        }


    };
}
