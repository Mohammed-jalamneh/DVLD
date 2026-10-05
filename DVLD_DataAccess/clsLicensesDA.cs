using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsLicensesDA
    {
         public static int AddNewLicense(int ApplicationID, int DriverID, int LicenseClass,
         DateTime IssueDate, DateTime ExpirationDate, string Notes, float PaidFees,
         bool IsActive, byte IssueReason, int CreatedByUserID)
        {
            int insertedID = -1;

            string query = @"INSERT INTO Licenses 
                     (ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID)
                     VALUES 
                     (@ApplicationID, @DriverID, @LicenseClass, @IssueDate, @ExpirationDate, @Notes, @PaidFees, @IsActive, @IssueReason, @CreatedByUserID);
                     SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                command.Parameters.AddWithValue("@DriverID", DriverID);
                command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
                command.Parameters.AddWithValue("@IssueDate", IssueDate);
                command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);

                if (string.IsNullOrEmpty(Notes))
                {
                    command.Parameters.AddWithValue("@Notes", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@Notes", Notes);
                }

                command.Parameters.AddWithValue("@PaidFees", PaidFees);
                command.Parameters.AddWithValue("@IsActive", IsActive);
                command.Parameters.AddWithValue("@IssueReason", IssueReason);
                command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

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


         public static bool UpdateLicense(int LicenseID, int ApplicationID, int DriverID, int LicenseClass,
            DateTime IssueDate, DateTime ExpirationDate, string Notes, float PaidFees,
            bool IsActive, byte IssueReason, int CreatedByUserID)
        {
            int rowsAffected = 0;

            string query = @"UPDATE Licenses 
                     SET ApplicationID = @ApplicationID,
                         DriverID = @DriverID,
                         LicenseClass = @LicenseClass,
                         IssueDate = @IssueDate,
                         ExpirationDate = @ExpirationDate,
                         Notes = @Notes,
                         PaidFees = @PaidFees,
                         IsActive = @IsActive,
                         IssueReason = @IssueReason,
                         CreatedByUserID = @CreatedByUserID
                     WHERE LicenseID = @LicenseID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@LicenseID", LicenseID);
                command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                command.Parameters.AddWithValue("@DriverID", DriverID);
                command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
                command.Parameters.AddWithValue("@IssueDate", IssueDate);
                command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);

                if (string.IsNullOrEmpty(Notes))
                    command.Parameters.AddWithValue("@Notes", DBNull.Value);
                else
                    command.Parameters.AddWithValue("@Notes", Notes);

                command.Parameters.AddWithValue("@PaidFees", PaidFees);
                command.Parameters.AddWithValue("@IsActive", IsActive);
                command.Parameters.AddWithValue("@IssueReason", IssueReason);
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

            return (rowsAffected > 0);
        }
    

         public static bool GetLicenseInfoByID(int LicenseID, ref int ApplicationID, ref int DriverID, ref int LicenseClass,
         ref DateTime IssueDate, ref DateTime ExpirationDate, ref string Notes, ref float PaidFees,
         ref bool IsActive, ref byte IssueReason, ref int CreatedByUserID)
        {
            bool isFound = false;

            string query = "SELECT * FROM Licenses WHERE LicenseID = @LicenseID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
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

                            ApplicationID = (int)reader["ApplicationID"];
                            DriverID = (int)reader["DriverID"];
                            LicenseClass = (int)reader["LicenseClass"];
                            IssueDate = (DateTime)reader["IssueDate"];
                            ExpirationDate = (DateTime)reader["ExpirationDate"];

                          
                            if (reader["Notes"] != DBNull.Value)
                            {
                                Notes = (string)reader["Notes"];
                            }
                            else
                            {
                                Notes = "";
                            }

                           
                            PaidFees = Convert.ToSingle(reader["PaidFees"]);
                            IsActive = (bool)reader["IsActive"];
                            IssueReason = (byte)reader["IssueReason"];
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

            return isFound;
        }

        public static bool IsLicenseExistByPersonID(int PersonID, int LicenseClassID)
        {
            bool isFound = false;
            string query = @"SELECT TOP 1 1 FROM Licenses 
                     JOIN Drivers ON Licenses.DriverID = Drivers.DriverID
                     WHERE Drivers.PersonID = @PersonID 
                       AND Licenses.LicenseClass = @LicenseClassID 
                       AND Licenses.IsActive = 1;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@PersonID", PersonID);
                command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

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

        public static int GetLicenseIDByApplicationID(int ApplicationID)
        {
            int LicenseID = -1;

            string query = "SELECT LicenseID FROM Licenses WHERE ApplicationID = @ApplicationID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int foundID))
                    {
                        LicenseID = foundID;
                    }
                }
                catch (Exception e)
                {
                    LicenseID = -1;
                    clsEventLogger.LogException(e);
                }
            }

            return LicenseID;
        }

        public static DataTable GetAllLicenseWithDriverID(int DriverID)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"SELECT 
                                    LicenseID, 
                                    ApplicationID, 
                                    LicenseClass, 
                                    IssueDate, 
                                    ExpirationDate, 
                                    IsActive
                                 FROM Licenses 
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


    }



}
