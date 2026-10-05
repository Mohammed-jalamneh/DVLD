using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsTestTypesDA
    {
        public static DataTable GetTestTypesList()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
                                select * from TestTypes
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
        public static bool UpdateTestTypes(int TestID, string TestTypeTitle, string TestTypeDescription, float Fees)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
                                  Update TestTypes
                                  set 

                                   TestTypeTitle = @TestTypeTitle , 
                                   TestTypeDescription =  @TestTypeDescription ,
                                   TestTypeFees = @Fees
                                 
                                    where TestTypeID = @TestID
                        ";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestID", TestID);
            command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
            command.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);
            command.Parameters.AddWithValue("@Fees", Fees);


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

        public static bool FindTestType(int TestID, ref string TestTypeTitle , ref string TestTypeDescription, ref float Fees)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT * 
                     FROM TestTypes 
                     WHERE TestTypeID = @TestID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestID", TestID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    TestTypeTitle = reader["TestTypeTitle"].ToString();
                    TestTypeDescription = reader["TestTypeDescription"].ToString();
                    Fees = Convert.ToSingle(reader["TestTypeFees"]);


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
