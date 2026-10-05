using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DVLD_DataAccess
{


    public class clsPeopleDA 
    {
        public static int AddNew(string NationalNo, string FirstName, string SecondName, string ThirdName,
      string LastName, DateTime DateOfBirth, short Gendor, string Address, string Phone, string Email,
      int NationalityCountryID, string ImagePath)
        {
            int PersonIDFromDB = -1;

            string query = @"INSERT INTO People(NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath) 
                     VALUES (@NationalNo, @FirstName, @SecondName, @ThirdName, @LastName, @DateOfBirth, @Gendor, @Address, @Phone, @Email, @NationalityCountryID, @ImagePath);                      
                     SELECT SCOPE_IDENTITY();";

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(query, connection);
                
                    command.Parameters.AddWithValue("@NationalNo", NationalNo);
                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@SecondName", SecondName);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    command.Parameters.AddWithValue("@Gendor", Gendor);
                     command.Parameters.AddWithValue("@Address", Address);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

                    if (!string.IsNullOrEmpty(ThirdName))
                    {
                        command.Parameters.AddWithValue("@ThirdName", ThirdName);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@ThirdName", DBNull.Value);
                    }

                    if (!string.IsNullOrEmpty(Email))
                    {
                        command.Parameters.AddWithValue("@Email", Email);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@Email", DBNull.Value);
                    }

                    if (!string.IsNullOrEmpty(ImagePath))
                    {
                        command.Parameters.AddWithValue("@ImagePath", ImagePath);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
                    }

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

        public static DataTable GetListOfPeople()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
                                 SELECT * FROM People
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

        public static bool UpdatePerson(int PersonID , string NationalNo, string FirstName, string SecondName, string ThirdName,
      string LastName, DateTime DateOfBirth, short Gendor, string Address, string Phone, string Email,
      int NationalityCountryID, string ImagePath)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
                                  Update People
                                  set 
                                   NationalNo = @NationalNo , 
                                   FirstName = @FirstName,
                                   SecondName = @SecondName,
                                   ThirdName = @ThirdName,
                                   LastName = @LastName,
                                   Email = @Email,
                                   Phone = @Phone,
                                   Gendor = @Gendor,
                                   Address = @Address,
                                   DateOfBirth = @DateOfBirth,
                                   NationalityCountryID = @NationalityCountryID,
                                   ImagePath = @ImagePath
                                 
                                    where PersonID = @PersonID
                        ";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

            if (!string.IsNullOrEmpty(ThirdName))
                command.Parameters.AddWithValue("@ThirdName", ThirdName);
            else
                command.Parameters.AddWithValue("@ThirdName", DBNull.Value);

            if (!string.IsNullOrEmpty(Email))
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email", DBNull.Value);
            
            if (!string.IsNullOrEmpty(ImagePath))
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);

           

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


        public static bool FindPerson(int PersonID, ref string NationalNo, ref string FirstName,
    ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth,
    ref short Gendor, ref string Address, ref string Phone, ref string Email,
    ref int NationalityCountryID, ref string ImagePath)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM People WHERE PersonID = @PersonID;";
            
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    NationalNo = (string)reader["NationalNo"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];

                    Gendor = Convert.ToInt16(reader["Gendor"]);

                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    NationalityCountryID = (int)reader["NationalityCountryID"];

                    
                    if (reader["ThirdName"] != DBNull.Value)
                        ThirdName = (string)reader["ThirdName"];
                    else
                        ThirdName = "";

                    if (reader["Email"] != DBNull.Value)
                        Email = (string)reader["Email"];
                    else
                        Email = "";

                    if (reader["ImagePath"] != DBNull.Value)
                        ImagePath = (string)reader["ImagePath"];
                    else
                        ImagePath = "";
                }
                else
                {
                    IsFound = false;
                }

                reader.Close();
            }
            catch (Exception e)
            {
                IsFound = false;
                clsEventLogger.LogException(e);
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }

        public static bool FindPerson(string NationalNo ,ref int PersonID, ref string FirstName,
   ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth,
   ref short Gendor, ref string Address, ref string Phone, ref string Email,
   ref int NationalityCountryID, ref string ImagePath)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM People WHERE NationalNo = @NationalNo;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    PersonID = (int)reader["PersonID"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];

                    Gendor = Convert.ToInt16(reader["Gendor"]);

                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    NationalityCountryID = (int)reader["NationalityCountryID"];


                    if (reader["ThirdName"] != DBNull.Value)
                        ThirdName = (string)reader["ThirdName"];
                    else
                        ThirdName = "";

                    if (reader["Email"] != DBNull.Value)
                        Email = (string)reader["Email"];
                    else
                        Email = "";

                    if (reader["ImagePath"] != DBNull.Value)
                        ImagePath = (string)reader["ImagePath"];
                    else
                        ImagePath = "";
                }
                else
                {
                    IsFound = false;
                }

                reader.Close();
            }
            catch (Exception e)
            {
                IsFound = false;
                clsEventLogger.LogException(e);
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }

        public static bool DeletePerson(int PersonID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
                                  delete from People
                                    where PersonID = @PersonID
                           ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

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

        public static bool IsPersonExist(int PersonID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select Found = 1 from People where PersonID = @PersonID";

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

        public static bool IsPersonExist(string NationalNo)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select Found = 1 from People where NationalNo = @NationalNo";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);

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















































    }
}
