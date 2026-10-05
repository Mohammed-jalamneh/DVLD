using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsInternationalLicenseDA
    {
        public static bool FindByInternationalLicenseID(int InternationalLicenseID,
            ref int ApplicationID, ref int DriverID, ref int IssuedUsingLocalLicenseID,
            ref DateTime IssueDate, ref DateTime ExpirationDate, ref bool IsActive, ref int CreatedByUserID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT * FROM InternationalLicenses WHERE InternationalLicenseID = @InternationalLicenseID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                ApplicationID = (int)reader["ApplicationID"];
                                DriverID = (int)reader["DriverID"];
                                IssuedUsingLocalLicenseID = (int)reader["IssuedUsingLocalLicenseID"];
                                IssueDate = (DateTime)reader["IssueDate"];
                                ExpirationDate = (DateTime)reader["ExpirationDate"];
                                IsActive = (bool)reader["IsActive"];
                                CreatedByUserID = (int)reader["CreatedByUserID"];
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        isFound = false;
                        clsEventLogger.LogException(e);
                    }
                }
            }
            return isFound;
        }

        public static int AddNewInternationalLicense(int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID,
            DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            int InternationalLicenseID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"
                    INSERT INTO InternationalLicenses 
                        (ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID)
                    VALUES 
                        (@ApplicationID, @DriverID, @IssuedUsingLocalLicenseID, @IssueDate, @ExpirationDate, @IsActive, @CreatedByUserID);
                    SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                    command.Parameters.AddWithValue("@DriverID", DriverID);
                    command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
                    command.Parameters.AddWithValue("@IssueDate", IssueDate);
                    command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
                    command.Parameters.AddWithValue("@IsActive", IsActive);
                    command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            InternationalLicenseID = insertedID;
                        }
                    }
                    catch (Exception e)
                    {
                        clsEventLogger.LogException(e);
                    }
                }
            }
            return InternationalLicenseID;
        }

        public static bool UpdateInternationalLicense(int InternationalLicenseID, int ApplicationID, int DriverID,
            int IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"
                    UPDATE InternationalLicenses 
                    SET ApplicationID = @ApplicationID,
                        DriverID = @DriverID,
                        IssuedUsingLocalLicenseID = @IssuedUsingLocalLicenseID,
                        IssueDate = @IssueDate,
                        ExpirationDate = @ExpirationDate,
                        IsActive = @IsActive,
                        CreatedByUserID = @CreatedByUserID
                    WHERE InternationalLicenseID = @InternationalLicenseID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);
                    command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                    command.Parameters.AddWithValue("@DriverID", DriverID);
                    command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
                    command.Parameters.AddWithValue("@IssueDate", IssueDate);
                    command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
                    command.Parameters.AddWithValue("@IsActive", IsActive);
                    command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

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
            }
            return (rowsAffected > 0);
        }

        public static DataTable GetAllInternationalLicenses()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT * FROM InternationalLicenses ORDER BY IsActive DESC, ExpirationDate DESC";
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
            }
            return dt;
        }

        public static DataTable GetDriverInternationalLicenses(int DriverID)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"
                    SELECT 
                        InternationalLicenseID, ApplicationID, IssuedUsingLocalLicenseID, 
                        IssueDate, ExpirationDate, IsActive
                    FROM InternationalLicenses 
                    WHERE DriverID = @DriverID
                    ORDER BY ExpirationDate DESC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DriverID", DriverID);
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
            }
            return dt;
        }

        public static int GetActiveInternationalLicenseIDByDriverID(int DriverID)
        {
            int InternationalLicenseID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"
            SELECT Top 1 InternationalLicenseID
            FROM InternationalLicenses 
            WHERE DriverID = @DriverID AND IsActive = 1
            ORDER BY ExpirationDate DESC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DriverID", DriverID);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            InternationalLicenseID = insertedID;
                        }
                    }
                    catch (Exception e)
                    {
                        clsEventLogger.LogException(e);
                    }
                }
            }
            return InternationalLicenseID;
        }
    }
}