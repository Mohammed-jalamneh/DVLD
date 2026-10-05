using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsUsersDA
    {

        public static bool IsUserExist(string UserName, string Password)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select Found = 1 from Users where UserName = @UserName and Password = @Password and IsActive = 1 ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    isFound = true;
                }
            }
            catch (Exception e)
            {
                isFound = false;
                clsEventLogger.LogException(e);
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
        public static bool IsUserExist(int PersonID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select Found = 1 from Users where PersonID = @PersonID ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    isFound = true;
                }
            }
            catch (Exception e)
            {
                isFound = false;
                clsEventLogger.LogException(e);
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
        public static bool IsUserExist(string UserName)
        {
            bool isFound = false;

            string query = @"SELECT Found = 1 FROM Users WHERE UserName = @UserName";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@UserName", UserName.Trim());

                try
                {
                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        isFound = true;
                    }
                }
                catch (Exception e)
                {
                    isFound = false;
                    clsEventLogger.LogException(e);
                }
            }

            return isFound;
        }
        public static bool Find(  int PersonID, ref int UserID , ref string UserName , ref string Password , ref short IsActive)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT UserID , UserName, Password, IsActive FROM Users WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    UserID = Convert.ToInt32(reader["UserID"]);
                    UserName = reader["UserName"].ToString();
                    Password = reader["Password"].ToString();
                    IsActive = Convert.ToInt16(reader["IsActive"]);
                    isFound = true;
                }
            }
            catch (Exception e)
            {
                isFound = false;
                clsEventLogger.LogException(e);
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
        public static bool Find(string UserName, ref int UserID, ref int PersonID, ref string Password, ref short IsActive)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT UserID, PersonID, Password, IsActive 
                     FROM Users 
                     WHERE UserName = @UserName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    UserID = Convert.ToInt32(reader["UserID"]);
                    PersonID = Convert.ToInt32(reader["PersonID"]);
                    Password = reader["Password"].ToString();
                    IsActive = Convert.ToInt16(reader["IsActive"]);

                    isFound = true;
                }
            }
            catch (Exception e)
            {
                isFound = false;
                clsEventLogger.LogException(e);
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
        public static DataTable GetListOfUsers()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
                                SELECT  Users.UserID, Users.PersonID,
                                FullName = People.FirstName + ' ' + People.SecondName + ' ' + People.ThirdName + ' ' + People.LastName,
                                Users.UserName, Users.IsActive
                                FROM  Users INNER JOIN
                                People ON Users.PersonID = People.PersonID
                           ";

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
            catch (Exception e)
            {
                clsEventLogger.LogException(e);
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }
        public static int AddNewUser(string UserName , string Password , int PersonID , short IsActive)
        {
            int PersonIDFromDB = -1;

            string query = @"INSERT INTO Users(PersonID, UserName, Password, IsActive) 
                     VALUES (@PersonID, @UserName, @Password, @IsActive);                      
                     SELECT SCOPE_IDENTITY();";

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int Answer))
                {
                    PersonIDFromDB = Answer;
                }
            }
            catch (Exception e)
            {
                clsEventLogger.LogException(e);
            }
            finally
            {
                connection.Close();
            }


            return PersonIDFromDB;
        }
        public static bool UpdateUser(int PersonID , string UserName , string Password , short IsActive)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
                                  Update Users
                                  set 
                                   UserName = @UserName , 
                                   Password = @Password, 
                                   IsActive = @IsActive
                                 
                                    where PersonID = @PersonID
                        ";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);


            int effectedRows = 0;
            try
            {
                connection.Open();
                effectedRows = command.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                clsEventLogger.LogException(e);
            }
            finally
            {
                connection.Close();
            }

            return (effectedRows != 0);

        }
        public static bool UpdateUserPassword(int PersonID, string Password)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
                                  Update Users
                                  set 
                                   Password = @Password
                                    where PersonID = @PersonID
                        ";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@Password", Password);


            int effectedRows = 0;
            try
            {
                connection.Open();
                effectedRows = command.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                clsEventLogger.LogException(e);
            }
            finally
            {
                connection.Close();
            }

            return (effectedRows != 0);

        }
        public static bool DeleteUser(int UserID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
                                  delete from Users
                                    where UserID = @UserID
                           ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            int effectedRows = 0;
            try
            {
                connection.Open();
                effectedRows = command.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                clsEventLogger.LogException(e);
            }
            finally
            {
                connection.Close();
            }

            return (effectedRows != 0);

        }





    }
}
