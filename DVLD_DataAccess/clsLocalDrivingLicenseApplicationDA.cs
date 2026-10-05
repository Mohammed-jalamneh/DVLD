using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsLocalDrivingLicenseApplicationDA
    {

        public static int AddLocalLicenseApplication(int ApplicationID , int LicenseClassID)

        {
            int ApplicationIDFromDB = -1;

            string query = @"INSERT INTO LocalDrivingLicenseApplications (ApplicationID , LicenseClassID) 
                     VALUES (@ApplicationID, @LicenseClassID);                      
                     SELECT SCOPE_IDENTITY();";

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int Answer))
                {
                    ApplicationIDFromDB = Answer;
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


            return ApplicationIDFromDB;
        }

        public static bool UpdateLocalDrivingLicenseApplication(
    int LocalDrivingLicenseApplicationID, int ApplicationID, int LicenseClassID)
        {
            int rowsAffected = 0;

            string query = @"UPDATE LocalDrivingLicenseApplications 
                     SET ApplicationID = @ApplicationID,
                         LicenseClassID = @LicenseClassID
                     WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                    command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                    command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

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
        public static bool DeleteApplicationFromLocalLicense(int LDLApplicatoinID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
                                  delete from LocalDrivingLicenseApplications
                                    where LocalDrivingLicenseApplicationID = @LDLApplicatoinID
                           ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LDLApplicatoinID", LDLApplicatoinID);

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
        public static int GetApplicationIDByID(int localDrivingLicenseApplicationID)
        {
            int applicationID = -1;

            string query = @"SELECT ApplicationID 
                     FROM LocalDrivingLicenseApplications 
                     WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", localDrivingLicenseApplicationID);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            applicationID = insertedID;
                        }
                    }
                    catch (Exception e)
                    {
                        applicationID = -1;
                        clsEventLogger.LogException(e);
                    }
                }
            }

            return applicationID;
        }

        public static bool GetLocalDrivingLicenseApplicationInfoByLDLID(
    int LocalDrivingLicenseApplicationID, ref int ApplicationID, ref int LicenseClassID)
        {
            bool isFound = false;
            string query = @"SELECT ApplicationID, LicenseClassID 
                     FROM LocalDrivingLicenseApplications 
                     WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                ApplicationID = (int)reader["ApplicationID"];
                                LicenseClassID = (int)reader["LicenseClassID"];
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

        public static bool GetLocalDrivingLicenseApplicationInfoByApplicationID(
            int ApplicationID, ref int LocalDrivingLicenseApplicationID, ref int LicenseClassID)
        {
            bool isFound = false;
            string query = @"SELECT LocalDrivingLicenseApplicationID, LicenseClassID 
                     FROM LocalDrivingLicenseApplications 
                     WHERE ApplicationID = @ApplicationID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                                LicenseClassID = (int)reader["LicenseClassID"];
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


    }
}
