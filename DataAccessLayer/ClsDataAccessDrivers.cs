using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace DataAccessLayer
{
    public class ClsDataAccessDrivers
    {


        public static bool FindDriver(int DriverID, ref int PersonID, ref int CreateByUser, ref DateTime CreatedDate)
        {
            if (DriverID <= 0) return false;

            SqlConnection connection = new SqlConnection(clsConnectionDB.ConnectionString);

            string query = "select * form Drivers where DriverID = @DriverID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue(@"DriverID", DriverID);

            bool IsFill = false;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    PersonID = (int)reader["PersonID"];
                    CreateByUser = (int)reader["CreatedByUser"];
                    CreatedDate = (DateTime)reader["CreatedDate"];

                    IsFill = true;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                IsFill = false;

            }
            finally
            {
                connection.Close();
            }

            return IsFill;

        }


        public static bool FindDriverByPerson(ref int DriverID, int PersonID, ref int CreateByUser, ref DateTime CreatedDate)
        {
            if (PersonID <= 0) return false;

            SqlConnection connection = new SqlConnection(clsConnectionDB.ConnectionString);

            string query = "select * from drivers  where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue(@"PersonID", PersonID);

            bool IsFill = false;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    DriverID = (int)reader["DriverID"];
                    CreateByUser = (int)reader["CreatedByUserID"];
                    CreatedDate = (DateTime)reader["CreatedDate"];

                    IsFill = true;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                IsFill = false;

            }
            finally
            {
                connection.Close();
            }

            return IsFill;

        }


        public static int AddNew(int PersonID, int CreateByUser, DateTime CreatedDate)
        {
            int DriverID = -1;



            SqlConnection connection = new SqlConnection(clsConnectionDB.ConnectionString);

            string query = @"insert into Drivers values (@PersonID,@CreatedByUser,@CreatedDate)
                              select scope_identity();";

            SqlCommand command = new SqlCommand(@query, connection);
            command.Parameters.AddWithValue(@"PersonID", PersonID);
            command.Parameters.AddWithValue(@"CreatedByUser", CreateByUser);
            command.Parameters.AddWithValue(@"CreatedDate", CreatedDate);

            try
            {
                connection.Open();

                object val = command.ExecuteScalar();

                if (val != null && int.TryParse(val.ToString(), out int ID))
                {
                    DriverID = ID;
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
            finally
            {

                connection.Close();
            }

            return DriverID;
        }

        public static DataTable GetAllDrivers()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionDB.ConnectionString);

            string query = @"select Drivers.DriverID,Drivers.PersonID ,People.FirstName+' '+people.LastName as FullName from Drivers
                            inner join People on People.PersonID = Drivers.PersonID";

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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

                connection.Close();
            }

           return dt;
        }

        public static bool IsExistDriver(int DriverID)
        {
            if (DriverID <= 0) return false;

            SqlConnection connection = new SqlConnection(clsConnectionDB.ConnectionString);
            string query = "select Find = 1 from Drivers where DriverID = @DriverID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue(@"DriverID", DriverID);

            byte RowEffected = 0;
            try
            {
                connection.Open();

                RowEffected = (byte)command.ExecuteNonQuery();

            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
            return (RowEffected > 0);


        }


        public static bool DeleteDriver(int DriverID)
        {
            SqlConnection connection = new SqlConnection(clsConnectionDB.ConnectionString);

            string query = @"delete Drivers where DriverID = @DriverID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue(@"DriverID", DriverID);

            byte RowEffected = 0;

            try
            {
                connection.Open();

               RowEffected = (byte)command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {

                connection.Close();
            }

            return (RowEffected > 0);
        }
    }
}
