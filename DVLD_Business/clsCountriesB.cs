using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DVLD_Business
{
    public class clsCountriesB
    {

        public int CountryID { get; set; }
        public string CountryName { get; set; }

        public clsCountriesB()
        {
            CountryID = -1;
            CountryName = "";
        }
        public clsCountriesB(int CountryID , string CountryName)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
        }

        public clsCountriesB( string CountryName , int CountryID)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
        }

        public static DataTable GetListOfCountries()
        {
            return clsCountriesDA.GetListOfCountries();
        }

        public static clsCountriesB FindCountry(string countryName)
        {
            int CountryID = -1;
            if (clsCountriesDA.FindCountry(countryName, ref CountryID))
            {
                return new clsCountriesB(countryName, CountryID);
            }
            else
                return null;


        }

        public static clsCountriesB FindCountry(int NationalCountryID)
        {
            string CountryName = "";
            if (clsCountriesDA.FindCountry(NationalCountryID, ref CountryName))
            {
                return new clsCountriesB(NationalCountryID, CountryName);
            }
            else
                return null;

            
        }
    }
}
