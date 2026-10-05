using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsDetainedLicensesDA
    {
        public static bool GetDetainedLicenseInfoByID(int DetainID,
            ref int LicenseID, ref DateTime DetainDate, ref decimal FineFees, ref int CreatedByUserID,
            ref bool IsReleased, ref DateTime? ReleaseDate, ref int? ReleasedByUserID, ref int? ReleaseApplicationID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT * FROM DetainedLicenses WHERE DetainID = @DetainID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DetainID", DetainID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                LicenseID = (int)reader["LicenseID"];
                                DetainDate = (DateTime)reader["DetainDate"];
                                FineFees = Convert.ToDecimal(reader["FineFees"]);
                                CreatedByUserID = (int)reader["CreatedByUserID"];
                                IsReleased = (bool)reader["IsReleased"];

                                ReleaseDate = (reader["ReleaseDate"] == DBNull.Value) ? null : (DateTime?)reader["ReleaseDate"];
                                ReleasedByUserID = (reader["ReleasedByUserID"] == DBNull.Value) ? null : (int?)reader["ReleasedByUserID"];
                                ReleaseApplicationID = (reader["ReleaseApplicationID"] == DBNull.Value) ? null : (int?)reader["ReleaseApplicationID"];
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

        public static bool GetDetainedLicenseInfoByLicenseID(int LicenseID,
            ref int DetainID, ref DateTime DetainDate, ref decimal FineFees, ref int CreatedByUserID,
            ref bool IsReleased, ref DateTime? ReleaseDate, ref int? ReleasedByUserID, ref int? ReleaseApplicationID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                // Returns the most recent detain record for this license
                string query = "SELECT TOP 1 * FROM DetainedLicenses WHERE LicenseID = @LicenseID ORDER BY DetainID DESC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LicenseID", LicenseID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                DetainID = (int)reader["DetainID"];
                                DetainDate = (DateTime)reader["DetainDate"];
                                FineFees = Convert.ToDecimal(reader["FineFees"]);
                                CreatedByUserID = (int)reader["CreatedByUserID"];
                                IsReleased = (bool)reader["IsReleased"];

                                ReleaseDate = (reader["ReleaseDate"] == DBNull.Value) ? null : (DateTime?)reader["ReleaseDate"];
                                ReleasedByUserID = (reader["ReleasedByUserID"] == DBNull.Value) ? null : (int?)reader["ReleasedByUserID"];
                                ReleaseApplicationID = (reader["ReleaseApplicationID"] == DBNull.Value) ? null : (int?)reader["ReleaseApplicationID"];
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

        public static int AddNewDetainedLicense(int LicenseID, DateTime DetainDate, decimal FineFees, int CreatedByUserID)
        {
            int DetainID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"
                    INSERT INTO DetainedLicenses 
                        (LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID)
                    VALUES 
                        (@LicenseID, @DetainDate, @FineFees, @CreatedByUserID, 0, NULL, NULL, NULL);
                    SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LicenseID", LicenseID);
                    command.Parameters.AddWithValue("@DetainDate", DetainDate);
                    command.Parameters.AddWithValue("@FineFees", FineFees);
                    command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            DetainID = insertedID;
                        }
                    }
                    catch (Exception e)
                    {
                        clsEventLogger.LogException(e);
                    }
                }
            }
            return DetainID;
        }

        public static bool UpdateDetainedLicense(int DetainID, int LicenseID, DateTime DetainDate, decimal FineFees,
            int CreatedByUserID, bool IsReleased, DateTime? ReleaseDate, int? ReleasedByUserID, int? ReleaseApplicationID)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"
                    UPDATE DetainedLicenses 
                    SET LicenseID = @LicenseID,
                        DetainDate = @DetainDate,
                        FineFees = @FineFees,
                        CreatedByUserID = @CreatedByUserID,
                        IsReleased = @IsReleased,
                        ReleaseDate = @ReleaseDate,
                        ReleasedByUserID = @ReleasedByUserID,
                        ReleaseApplicationID = @ReleaseApplicationID
                    WHERE DetainID = @DetainID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DetainID", DetainID);
                    command.Parameters.AddWithValue("@LicenseID", LicenseID);
                    command.Parameters.AddWithValue("@DetainDate", DetainDate);
                    command.Parameters.AddWithValue("@FineFees", FineFees);
                    command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                    command.Parameters.AddWithValue("@IsReleased", IsReleased);

                    command.Parameters.AddWithValue("@ReleaseDate", (object)ReleaseDate ?? DBNull.Value);
                    command.Parameters.AddWithValue("@ReleasedByUserID", (object)ReleasedByUserID ?? DBNull.Value);
                    command.Parameters.AddWithValue("@ReleaseApplicationID", (object)ReleaseApplicationID ?? DBNull.Value);

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

        public static bool ReleaseDetainedLicense(int DetainID, int ReleasedByUserID, int ReleaseApplicationID)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"
                    UPDATE DetainedLicenses 
                    SET IsReleased = 1,
                        ReleaseDate = @ReleaseDate,
                        ReleasedByUserID = @ReleasedByUserID,
                        ReleaseApplicationID = @ReleaseApplicationID
                    WHERE DetainID = @DetainID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DetainID", DetainID);
                    command.Parameters.AddWithValue("@ReleaseDate", DateTime.Now);
                    command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
                    command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);

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

        public static bool IsLicenseDetained(int LicenseID)
        {
            bool isDetained = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT IsDetained = 1 FROM DetainedLicenses WHERE LicenseID = @LicenseID AND IsReleased = 0";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LicenseID", LicenseID);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            isDetained = true;
                        }
                    }
                    catch (Exception e)
                    {
                        clsEventLogger.LogException(e);
                        isDetained = false;
                    }
                }
            }
            return isDetained;
        }

        public static DataTable GetAllDetainedLicenses()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT * FROM DetainedLicenses_View ORDER BY DetainID DESC";

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
    }
}