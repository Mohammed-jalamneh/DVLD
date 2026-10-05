using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsTestsDA
    {

        public static int AddNewTestResult(int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            int TestID = -1;

            string query = @"INSERT INTO Tests (TestAppointmentID, TestResult, Notes, CreatedByUserID)
                     VALUES (@TestAppointmentID, @TestResult, @Notes, @CreatedByUserID);
                     SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
                    command.Parameters.AddWithValue("@TestResult", TestResult);
                    command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                    if (string.IsNullOrWhiteSpace(Notes))
                    {
                        command.Parameters.AddWithValue("@Notes", System.DBNull.Value);  // Null handling
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@Notes", Notes);
                    }

                    try
                    {
                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            TestID = insertedID;
                        }
                    }
                    catch (Exception e)
                    {
                        TestID = -1;
                        clsEventLogger.LogException(e);
                    }
                }
            }

            return TestID;
        }


    }
}
