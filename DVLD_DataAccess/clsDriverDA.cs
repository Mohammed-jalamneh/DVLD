using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsDriverDA
    {
        public static int AddNewDriver(int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            int insertedID = -1;

            string query = @"INSERT INTO Drivers (PersonID, CreatedByUserID, CreatedDate)
                             VALUES (@PersonID, @CreatedByUserID, @CreatedDate);
                             SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@PersonID", PersonID);
                command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                command.Parameters.AddWithValue("@CreatedDate", CreatedDate);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int lastID))
                    {
                        insertedID = lastID;
                    }
                }
                catch (Exception e)
                {
                    insertedID = -1;
                    clsEventLogger.LogException(e);
                }
            }

            return insertedID;
        }

        public static bool UpdateDriver(int DriverID, int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            int rowsAffected = 0;

            string query = @"UPDATE Drivers 
                             SET PersonID = @PersonID,
                                 CreatedByUserID = @CreatedByUserID,
                                 CreatedDate = @CreatedDate
                             WHERE DriverID = @DriverID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@DriverID", DriverID);
                command.Parameters.AddWithValue("@PersonID", PersonID);
                command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                command.Parameters.AddWithValue("@CreatedDate", CreatedDate);

                try
                {
                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    clsEventLogger.LogException(e);
                    return false;
                }
            }

            return (rowsAffected > 0);
        }

        public static bool GetDriverInfoByDriverID(int DriverID, ref int PersonID, ref int CreatedByUserID, ref DateTime CreatedDate)
        {
            bool isFound = false;

            string query = "SELECT * FROM Drivers WHERE DriverID = @DriverID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@DriverID", DriverID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;
                            PersonID = (int)reader["PersonID"];
                            CreatedByUserID = (int)reader["CreatedByUserID"];
                            CreatedDate = (DateTime)reader["CreatedDate"];
                        }
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

        public static bool GetDriverInfoByPersonID(int PersonID, ref int DriverID, ref int CreatedByUserID, ref DateTime CreatedDate)
        {
            bool isFound = false;

            string query = "SELECT * FROM Drivers WHERE PersonID = @PersonID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@PersonID", PersonID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;
                            DriverID = (int)reader["DriverID"];
                            CreatedByUserID = (int)reader["CreatedByUserID"];
                            CreatedDate = (DateTime)reader["CreatedDate"];
                        }
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

        public static DataTable GetAllDrivers()
        {
            DataTable dt = new DataTable();
            string query = @"SELECT * from Drivers_View";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            dt.Load(reader);
                        }
                    }
                }
                catch (Exception e)
                {
                    clsEventLogger.LogException(e);
                }
            }

            return dt;
        }

        public static bool IsThisPersonDriver(int PersonID)
        {
            bool isDriver = false;

            string query = "SELECT TOP 1 1 FROM Drivers WHERE PersonID = @PersonID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@PersonID", PersonID);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        isDriver = true;
                    }
                }
                catch (Exception e)
                {
                    isDriver = false;
                    clsEventLogger.LogException(e);
                }
            }

            return isDriver;
        }

        public static int GetDriverIDbyPersonID(int PersonID)
        {
            int DriverID = -1; 

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT DriverID FROM Drivers WHERE PersonID = @PersonID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", PersonID);

                    try
                    {
                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int retrievedID))
                        {
                            DriverID = retrievedID;
                        }
                    }
                    catch (Exception e)
                    {
                        clsEventLogger.LogException(e);
                    }
                }
            }

            return DriverID;
        }

    }
}