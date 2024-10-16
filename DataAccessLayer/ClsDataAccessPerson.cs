using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.Runtime.Remoting.Messaging;

namespace DataAccessLayer
{
    public class ClsDataAccessPeople
    {
        public static bool FindPersonID(int PersonID, ref string NationalNo, ref string FirstName, ref string LastName,
            ref DateTime DateOfBirth, ref byte Gendor, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            if (PersonID<= 0) return false;


            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionDB.ConnectionString);
            string query = "select * from People where PersonID = @PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue(@"PersonID", PersonID);
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    NationalNo = (string)reader["NationalNo"];
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gendor = (byte)reader["Gendor"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    Email = reader["Email"] == System.DBNull.Value ? "N/A" : (string)reader["Email"];
                    NationalityCountryID = (int)reader["NationalityCountryID"];
                    ImagePath = reader["ImagePath"] == System.DBNull.Value ? "" : (string)reader["ImagePath"];
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

        
        public static bool FindNationalNo(ref int PersonID,  string NationalNo, ref string FirstName, ref string LastName,
            ref DateTime DateOfBirth, ref byte Gendor, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            if (string.IsNullOrEmpty(NationalNo)) return false;


            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionDB.ConnectionString);
            string query = "select * from People where NationalNo = @NationalNo";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue(@"NationalNo", NationalNo);
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    PersonID = (int)reader["PersonID"];
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gendor = (byte)reader["Gendor"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    Email = reader["Email"] == System.DBNull.Value ? "N/A" : (string)reader["Email"];
                    NationalityCountryID = (int)reader["NationalityCountryID"];
                    ImagePath = reader["ImagePath"] == System.DBNull.Value ? "" : (string)reader["ImagePath"];
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


        //---------------------------------------------
        public static int AddNewPeople(string NationalNo, string FirstName, string LastName, DateTime DateOfBirth,
            byte Gendor, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {

            int CreateID = 0;
            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);
            string query = @"INSERT INTO [dbo].[People](NationalNo,FirstName,LastName,DateOfBirth,Gendor,Address,Phone,Email,NationalityCountryID,ImagePath) 
                            VALUES(@NationalNo,@FirstName,@LastName,@DateOfBirth,@Gendor,@Address,@Phone,@Email,@NationalityCountryID,@ImagePath)
                             select SCOPE_IDENTITY()";
            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue(@"NationalNo", NationalNo);
            Command.Parameters.AddWithValue(@"FirstName", FirstName);
            Command.Parameters.AddWithValue(@"LastName", LastName);
            Command.Parameters.AddWithValue(@"DateOfBirth", DateOfBirth);
            Command.Parameters.AddWithValue(@"Gendor", Gendor);
            Command.Parameters.AddWithValue(@"Address", Address);
            Command.Parameters.AddWithValue(@"Phone", Phone);
            if (Email == "N/A" ||string.IsNullOrEmpty(Email))
            {
                
                Command.Parameters.AddWithValue(@"Email", System.DBNull.Value);

            }
            else
            {
                Command.Parameters.AddWithValue(@"Email", Email);
            };
            Command.Parameters.AddWithValue(@"NationalityCountryID", NationalityCountryID);
            if (ImagePath == "N/A" || string.IsNullOrEmpty(ImagePath))
            {
                Command.Parameters.AddWithValue(@"ImagePath", System.DBNull.Value);

            }
            else
            {
                Command.Parameters.AddWithValue(@"ImagePath", ImagePath);
            };

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

        public static bool UpdatePeople(int PersonID, string NationalNo, string FirstName, string LastName, DateTime DateOfBirth,
            byte Gendor, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {

            if (PersonID <= 0) return false;

            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);

            string query = @"Update People
                             set NationalNo = @NationalNo,
                            FirstName = @FirstName,
                            LastName = @LastName,
                            DateOfBirth = @DateOfBirth,
                            Gendor = @Gendor,
                            Address = @Address,
                            Phone = @Phone,
                            Email = @Email,
                            NationalityCountryID = @NationalityCountryID,
                            ImagePath = @ImagePath Where PersonID=@PersonID";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue(@"PersonID", PersonID);
            Command.Parameters.AddWithValue(@"NationalNo", NationalNo);
            Command.Parameters.AddWithValue(@"FirstName", FirstName);
            Command.Parameters.AddWithValue(@"LastName", LastName);
            Command.Parameters.AddWithValue(@"DateOfBirth", DateOfBirth);
            Command.Parameters.AddWithValue(@"Gendor", Gendor);
            Command.Parameters.AddWithValue(@"Address", Address);
            Command.Parameters.AddWithValue(@"Phone", Phone);
            if (Email == "N/A" || string.IsNullOrEmpty(Email))
            {
                Command.Parameters.AddWithValue(@"Email", System.DBNull.Value);

            }
            else
            {
                Command.Parameters.AddWithValue(@"Email", Email);
            };
            Command.Parameters.AddWithValue(@"NationalityCountryID", NationalityCountryID);
            if (ImagePath == "" || string.IsNullOrEmpty(ImagePath))
            {
                Command.Parameters.AddWithValue(@"ImagePath", System.DBNull.Value);

            }
            else
            {
                Command.Parameters.AddWithValue(@"ImagePath", ImagePath);
            };
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

        public static bool DeletePeople(int PersonID)
        {

            if (PersonID <= 0) return false;

            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);

            string query = @"delete People where PersonID = @PersonID"
            ;
            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue(@"PersonID", PersonID);
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

        public static bool IsExistsPeople(int PersonID)
        {
            if (PersonID <= 0) return false;
            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);
            string query = @"Select Find = 1 from People where PersonID = @PersonID";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue(@"PersonID", PersonID);

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

        public static bool IsExistsPeopleWithNational(string Natinaol)
        {
            if (string.IsNullOrEmpty(Natinaol)) return false;
            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);
            string query = @"Select Find = 1 from People where NationalNo = @NationalNo";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue(@"NationalNo", Natinaol);

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

        public static DataTable GetAllPeople()
        {

            DataTable dt = new DataTable();

            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);

            string query = "Select * from People";

            SqlCommand Command = new SqlCommand(query, Connection);

            try {

                Connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                if (reader.HasRows) {

                    dt.Load(reader);
                }

                reader.Close();
            }

            catch {

            }
            finally {
                Connection.Close();
            }

            return dt; 
        }
        public static DataTable GetAllPeopleDetails()
        {

            DataTable dt = new DataTable();

            SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);

            string query = "select * from DetailsPeople";

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

        public static bool CheckAboutNationalNO(string Natial)
        {
            if (string.IsNullOrEmpty(Natial)) return false;

            SqlConnection connection = new SqlConnection(clsConnectionDB.ConnectionString);

            string querey = "select Resut =1 from People where NationalNo =" + "'" + Natial+"'";

            SqlCommand command = new SqlCommand(querey, connection);
          //  command.Parameters.AddWithValue(@"NationalNo", Natial);

            bool IsValid = false;

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                if (Result != null)
                {

                    IsValid = true;
                }
            }
            catch
            {
                IsValid = false;
            }
            finally
            {
                connection.Close();
            }

            return IsValid;
        }
    };
}

