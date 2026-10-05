using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsApplicationTypesDA
    {
        public static DataTable GetListOfApplications()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
                                select * from ApplicationTypes
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
        public static bool UpdateApplicationTypes(int TypeID, string Title, float Fees)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
                                  Update ApplicationTypes
                                  set 
                                   ApplicationTypeTitle = @Title , 
                                   ApplicationFees = @Fees
                                  
                                 
                                    where ApplicationTypeID = @TypeID
                        ";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TypeID", TypeID);
            command.Parameters.AddWithValue("@Title", Title);
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

        public static bool FindApplicatinoType(int ID, ref string Title , ref float Fees)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT * 
                     FROM ApplicationTypes 
                     WHERE ApplicationTypeID = @ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Fees =Convert.ToSingle(reader["ApplicationFees"]);
                    Title = reader["ApplicationTypeTitle"].ToString();

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
