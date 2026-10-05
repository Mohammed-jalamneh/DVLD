using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsLicenseClassesDA
    {
        public static DataTable GetAllLicenseClasses()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT LicenseClassID, ClassName FROM LicenseClasses";

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

        public static bool GetLicenseClassInfoByID(int LicenseClassID,
    ref string ClassName, ref string ClassDescription,
    ref byte MinimumAllowedAge, ref byte DefaultValidityLength, ref float ClassFees)
        {
            bool isFound = false;

            string query = @"SELECT * FROM LicenseClasses 
                     WHERE LicenseClassID = @LicenseClassID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                ClassName = (string)reader["ClassName"];
                                ClassDescription = (string)reader["ClassDescription"];

                                MinimumAllowedAge = Convert.ToByte(reader["MinimumAllowedAge"]);
                                DefaultValidityLength = Convert.ToByte(reader["DefaultValidityLength"]);

                                ClassFees = Convert.ToSingle(reader["ClassFees"]);
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
