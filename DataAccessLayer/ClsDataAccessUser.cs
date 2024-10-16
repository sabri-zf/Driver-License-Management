using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ClsDataAccessUser
    {
        public class ClsDataAccessUsers
        {
            public static bool FindUserID(int UserID,  ref int PersonID, ref string UserName, ref string Password, ref bool IsActive)
            {
                if (UserID <= 0) return false;


                bool IsFound = false;
                SqlConnection connection = new SqlConnection(clsConnectionDB.ConnectionString);
                string query = "select * from Users where UserID = @UserID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue(@"UserID", UserID);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        PersonID = (int)reader["PersonID"];
                        UserName = (string)reader["UserName"];
                        Password = (string)reader["Password"];
                        IsActive = (bool)reader["IsActive"];
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

            public static bool FindByUserNameAndPassword(ref int UserID, ref int PersonID, string UserName,  string Password, ref bool IsActive)
            {
                if (string.IsNullOrEmpty(UserName) && string.IsNullOrEmpty(Password)) return false;


                bool IsFound = false;
                SqlConnection connection = new SqlConnection(clsConnectionDB.ConnectionString);
                string query = $"select * from Users where UserName = '{UserName}' and  Password = '{Password}'";
                SqlCommand command = new SqlCommand(query, connection);



                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        PersonID = (int)reader[1];
                        IsActive = (bool)reader[4];
                        UserID = (int)reader[0];
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

            public static bool FindUserName(ref int UserID, ref int PersonID, string UserName, ref string Password, ref bool IsActive)
            {
                if (string.IsNullOrEmpty(UserName)) return false;


                bool IsFound = false;
                SqlConnection connection = new SqlConnection(clsConnectionDB.ConnectionString);
                string query = "select * from Users where UserName = @UserName";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue(@"UserName", UserName);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        UserID = (int)reader["UserID"];
                        PersonID = (int)reader["PersonID"];
                        Password = (string)reader["Password"];
                        IsActive = (bool)reader["IsActive"];
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

            public static int AddNewUsers(int PersonID, string UserName, string Password, bool IsActive)
            {
                int CreateID = -1;
                SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);
                string query = @"Insert into Users values(@PersonID,@UserName,@Password,@IsActive)
                                select scope_identity();";
                SqlCommand Command = new SqlCommand(query, Connection);
                Command.Parameters.AddWithValue(@"PersonID", PersonID);
                Command.Parameters.AddWithValue(@"UserName", UserName);
                Command.Parameters.AddWithValue(@"Password", Password);
                Command.Parameters.AddWithValue(@"IsActive", IsActive);

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

            public static bool UpdateUsers(int UserID, int PersonID, string UserName, string Password, bool IsActive)
            {

                if (UserID <= 0) return false;

                SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);

                string query = @"Update Users
                                set PersonID = @PersonID,
                                UserName = @UserName,
                                Password = @Password,
                                IsActive = @IsActive Where UserID=@UserID
                                ";

                SqlCommand Command = new SqlCommand(query, Connection);

                Command.Parameters.AddWithValue(@"UserID", UserID);
                Command.Parameters.AddWithValue(@"PersonID", PersonID);
                Command.Parameters.AddWithValue(@"UserName", UserName);
                Command.Parameters.AddWithValue(@"Password", Password);
                Command.Parameters.AddWithValue(@"IsActive", IsActive);

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

            public static bool DeleteUsers(int UserID)
            {

                if (UserID <= 0) return false;

                SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);

                string query = @"delete Users where UserID = @UserID"
                ;
                SqlCommand Command = new SqlCommand(query, Connection);

                Command.Parameters.AddWithValue(@"UserID", UserID);
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

            public static bool IsExistsUsers(int UserID)
            {
                if (UserID <= 0) return false;
                SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);
                string query = @"Select Find = 1 from Users where UserID = @UserID";

                SqlCommand Command = new SqlCommand(query, Connection);
                Command.Parameters.AddWithValue(@"UserID", UserID);

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

            public static bool IsExistsUsers(string UserName)
            {
                if (string.IsNullOrEmpty(UserName)) return false;
                SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);
                string query = @"Select Find = 1 from Users where UserName ='"+UserName+"'";

                SqlCommand Command = new SqlCommand(query, Connection);

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

            public static bool IsExistsUsersByPersonID(int PersonID)
            {
                if (PersonID <= 0) return false;
                SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);
                string query = @"Select Find = 1 from Users where PersonID = @PersonID";

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


            public static DataTable GetAllUsers()
            {

                DataTable dt = new DataTable();

                SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);

                string query = "Select * from Users";

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

                return dt; }

            public static DataTable GetAllUsersWithDetail()
            {

                DataTable dt = new DataTable();

                SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);

                string query = "Select UserID,Users.PersonID, People.FirstName +''+ People.LastName as FullName" +
                    ",UserName,IsActive " +
                    " from Users inner join People on People.PersonID = Users.PersonID";

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


            public static string GetUserNamer(int UserID)
            {
                if (UserID <= 0) return "";


                SqlConnection Connection = new SqlConnection(clsConnectionDB.ConnectionString);

                string query = "Select UserName from Users where UserID =@UserID";

                SqlCommand Command = new SqlCommand(query, Connection);
                Command.Parameters.AddWithValue(@"UserID", UserID);

                string UserName = "";
                try
                {
                    Connection.Open();

                    object val = Command.ExecuteScalar();

                    if(val != null)
                    {
                        UserName = val.ToString();
                    }
                }
                catch
                {

                }
                finally
                {
                    Connection.Close();
                }

                return UserName;

            }

        };
    };

}
