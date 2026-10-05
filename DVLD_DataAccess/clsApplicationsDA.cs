using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsApplicationsDA
    {
        public static int AddApplication(int ApplicantPersonID , DateTime ApplicationDate
       ,int ApplicationTypeID, short ApplicationStatus , DateTime LastStatusDate , float PaidFees , int CreatedByUserID)
        
        {
            int ApplicationIDFromDB = -1;

            string query = @"INSERT INTO Applications ( ApplicantPersonID, ApplicationDate,
                                ApplicationTypeID , ApplicationStatus , LastStatusDate , PaidFees , CreatedByUserID) 
                     VALUES (@ApplicationPersonID, @ApplicationDate, @ApplicationTypeID, @ApplicationStatus
                              , @LastStatusDate , @PaidFees , @CreatedByUserID);                      
                     SELECT SCOPE_IDENTITY();";

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationPersonID", ApplicantPersonID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

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

        public static bool UpdateApplication(
    int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate,
    int ApplicationTypeID, byte ApplicationStatus, DateTime LastStatusDate,
    float PaidFees, int CreatedByUserID)
        {
            int rowsAffected = 0;

            string query = @"UPDATE Applications  
                     SET ApplicantPersonID = @ApplicantPersonID,
                         ApplicationDate = @ApplicationDate,
                         ApplicationTypeID = @ApplicationTypeID,
                         ApplicationStatus = @ApplicationStatus,
                         LastStatusDate = @LastStatusDate,
                         PaidFees = @PaidFees,
                         CreatedByUserID = @CreatedByUserID
                     WHERE ApplicationID = @ApplicationID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                    command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
                    command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
                    command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
                    command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
                    command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
                    command.Parameters.AddWithValue("@PaidFees", PaidFees);
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

        public static bool IsPersonHasActiveApplication(int ApplicantPersonID, int LicenseClassID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
                             SELECT Found = 1 
                             FROM Applications 
                             INNER JOIN LocalDrivingLicenseApplications 
                             ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
                             WHERE Applications.ApplicantPersonID = @ApplicantPersonID 
                             AND LocalDrivingLicenseApplications.LicenseClassID = @LicenseClassID 
                             AND Applications.ApplicationStatus IN (1,3)"; 

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
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
            finally
            {
                connection.Close();
            }

            return isFound;
        }
        public static DataTable GetListOfApplications()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
                                select * from LocalDrivingLicenseApplications_View
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
        public static bool GetApplicationInfoByID(int ApplicationID,
    ref int ApplicantPersonID, ref DateTime ApplicationDate,
    ref int ApplicationTypeID, ref byte ApplicationStatus,
    ref DateTime LastStatusDate, ref float PaidFees, ref int CreatedByUserID)
        {
            bool isFound = false;

            string query = @"SELECT * FROM Applications 
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

                                ApplicantPersonID = (int)reader["ApplicantPersonID"];
                                ApplicationDate = (DateTime)reader["ApplicationDate"];
                                ApplicationTypeID = (int)reader["ApplicationTypeID"];

                                ApplicationStatus = Convert.ToByte(reader["ApplicationStatus"]);
                                LastStatusDate = (DateTime)reader["LastStatusDate"];

                                PaidFees =Convert.ToSingle(reader["PaidFees"]);

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
        public static bool DeleteApplicationFromApplicatoinsTable(int ApplicationID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
                                  delete from Applications
                                    where ApplicationID = @ApplicationID
                           ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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
        public static bool CancelApplication(int applicationID)
        {
            int rowsAffected = 0;

            string query = @"UPDATE Applications 
                     SET ApplicationStatus = 2, 
                         LastStatusDate = @LastStatusDate 
                     WHERE ApplicationID = @ApplicationID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationID", applicationID);
                    command.Parameters.AddWithValue("@LastStatusDate", DateTime.Now);

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
    }
}
