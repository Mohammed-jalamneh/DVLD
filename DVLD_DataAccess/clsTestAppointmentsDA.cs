using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsTestAppointmentsDA
    {

             public static DataTable GetAllTestAppointments(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            DataTable dt = new DataTable();

            string query = @"SELECT TestAppointmentID, AppointmentDate, PaidFees, IsLocked 
                     FROM TestAppointments 
                     WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID 
                     AND TestTypeID = @TestTypeID
                     ORDER BY TestAppointmentID DESC";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                    command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

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

             public static int AddNewTestAppointment(int TestTypeID, int LocalDrivingLicenseApplicationID,
                DateTime AppointmentDate, float PaidFees, int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)
        {
            int TestAppointmentID = -1;

            string query = @"INSERT INTO TestAppointments 
                    (TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID)
                     VALUES 
                    (@TestTypeID, @LocalDrivingLicenseApplicationID, @AppointmentDate, @PaidFees, @CreatedByUserID, @IsLocked, @RetakeTestApplicationID);
                     SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                    command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
                    command.Parameters.AddWithValue("@PaidFees", PaidFees);
                    command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                    command.Parameters.AddWithValue("@IsLocked", IsLocked);

                    if (RetakeTestApplicationID == -1)
                    {
                        command.Parameters.AddWithValue("@RetakeTestApplicationID", System.DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);
                    }

                    try
                    {
                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            TestAppointmentID = insertedID;
                        }
                    }
                    catch (Exception e)
                    {
                        clsEventLogger.LogException(e);
                    }
                }
            }

            return TestAppointmentID;
        }



            public static bool UpdateTestAppointment(int TestAppointmentID, int TestTypeID,
                int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, float PaidFees,
                int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)
                {
                    int rowsAffected = 0;
            
                    string query = @"UPDATE TestAppointments 
                                 SET TestTypeID = @TestTypeID,
                                     LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID,
                                     AppointmentDate = @AppointmentDate,
                                     PaidFees = @PaidFees,
                                     CreatedByUserID = @CreatedByUserID,
                                     IsLocked = @IsLocked,
                                     RetakeTestApplicationID = @RetakeTestApplicationID
                                 WHERE TestAppointmentID = @TestAppointmentID";
            
                    using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
                            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
                            command.Parameters.AddWithValue("@PaidFees", PaidFees);
                            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                            command.Parameters.AddWithValue("@IsLocked", IsLocked);
            
                            if (RetakeTestApplicationID == -1)
                            {
                                command.Parameters.AddWithValue("@RetakeTestApplicationID", System.DBNull.Value);
                            }
                            else
                            {
                                command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);
                            }
            
                            try
                            {
                                connection.Open();
                                rowsAffected = command.ExecuteNonQuery();
                            }
                            catch (Exception e)
                            {
                        clsEventLogger.LogException(e);
                    }
                        }
                    }
            
                    return (rowsAffected > 0);
                }


                 public static bool FindTestAppointmentInfoByID(
             int TestAppointmentID, ref int TestTypeID, ref int LocalDrivingLicenseApplicationID,
             ref DateTime AppointmentDate, ref float PaidFees, ref int CreatedByUserID,
             ref bool IsLocked, ref int RetakeTestApplicationID)
        {
            bool isFound = false;

            string query = @"SELECT TestTypeID, LocalDrivingLicenseApplicationID, 
                            AppointmentDate, PaidFees, CreatedByUserID, 
                            IsLocked, RetakeTestApplicationID
                     FROM TestAppointments 
                     WHERE TestAppointmentID = @TestAppointmentID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                TestTypeID = (int)reader["TestTypeID"];
                                LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                                AppointmentDate = (DateTime)reader["AppointmentDate"];
                                PaidFees = Convert.ToSingle(reader["PaidFees"]);
                                CreatedByUserID = (int)reader["CreatedByUserID"];
                                IsLocked = (bool)reader["IsLocked"];

                                if (reader["RetakeTestApplicationID"] == DBNull.Value)
                                {
                                    RetakeTestApplicationID = -1;
                                }
                                else
                                {
                                    RetakeTestApplicationID = (int)reader["RetakeTestApplicationID"];
                                }
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

        public static bool IsAppointmentExistByIDandTestType(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            bool isFound = false;

            string query = @"SELECT 1 FROM TestAppointments 
                     WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID 
                     AND TestTypeID = @TestTypeID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                    command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

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
            }

            return isFound;
        }

        public static bool IsPassedTestExist(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            bool isFound = false;

            string query = @"SELECT top 1 1 
                     FROM TestAppointments 
                     INNER JOIN Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                     WHERE TestAppointments.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID 
                     AND TestAppointments.TestTypeID = @TestTypeID 
                     AND Tests.TestResult = 1;"; // 1 = Pass

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

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
    }

    

}
