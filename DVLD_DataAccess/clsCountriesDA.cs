using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public  class clsCountriesDA
    {
        public static bool FindCountry(int CountryID, ref string CountryName)
        {

            bool IsCountryFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
                                select * from Countries where CountryID = @CountryID;
                        ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryID", CountryID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsCountryFound = true;
                    CountryName = (string)reader["CountryName"];


                }
                else
                {
                    IsCountryFound = false;
                }

                reader.Close();
            }
            catch (Exception e)
            {
                IsCountryFound = false;
                clsEventLogger.LogException(e);

            }
            finally
            {
                connection.Close();
            }


            return IsCountryFound;
        }
        public static bool FindCountry(string CountryName, ref int CountryID)
        {

            bool IsCountryFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
                                select * from Countries where CountryName = @CountryName;
                        ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryName", CountryName);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsCountryFound = true;
                    CountryID = (int)reader["CountryID"];

                }
                else
                {
                    IsCountryFound = false;
                }

                reader.Close();
            }
            catch (Exception e)
            {
                IsCountryFound = false;
                clsEventLogger.LogException(e);

            }
            finally
            {
                connection.Close();
            }


            return IsCountryFound;
        }

        public static DataTable GetListOfCountries()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
                                 SELECT * FROM COUNTRIES    
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

    }
}
