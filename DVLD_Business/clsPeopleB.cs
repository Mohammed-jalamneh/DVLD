using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccess;


namespace DVLD_Business
{
    public class clsPeopleB
    {

        public int PersonID {  get; set; }
        public string NationalID { get; set; }
        public string FirstName { get; set; }
        public string SecondName {  get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }    
        public DateTime DateOfBirth {  get; set; }
        public short Gendor {  get; set; }
        public string Address { get; set; } 
        public string Phone { get; set; }   
        public string Email { get; set; }
        public int NationalityCountryID {  get; set; }
        public clsCountriesB CountryInfo;
        public string ImagePath { get; set; }

        public string FullName
        {
            get
            {
                return FirstName +" " + this.SecondName + " " + this.ThirdName + " " + this.LastName;
            }
        }


        enum enMode {enAddNew , Update};

        enMode _Mode = enMode.enAddNew;


        public clsPeopleB()
        {
            this.PersonID = -1;
            this.NationalID = "";
            this.FirstName = "";
            this.SecondName ="";
            this.ThirdName = "";
            this.LastName = "";
            this.DateOfBirth = DateTime.Now.AddYears(-18);
            this.Gendor = -1;
            this.Address = "";
            this.Phone = "";
            this.Email = "";
            this.NationalityCountryID = -1;
            this.ImagePath = "";

            _Mode = enMode.enAddNew;
        
        }

        public clsPeopleB(int PersonID, string NationalNo, string FirstName, string SecondName, string ThirdName,
      string LastName, DateTime DateOfBirth, short Gendor, string Address, string Phone, string Email,
      int NationalityCountryID, string ImagePath)
        {
            this.PersonID = PersonID;
            this.NationalID = NationalNo;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gendor = Gendor;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = ImagePath;

            this.CountryInfo = clsCountriesB.FindCountry(NationalityCountryID);


            _Mode = enMode.Update;

        }


        public  bool _AddNewPerson()
        {
            this.PersonID = clsPeopleDA.AddNew(NationalID , FirstName , SecondName , ThirdName, LastName, DateOfBirth , 
                Gendor , Address , Phone , Email , NationalityCountryID , ImagePath);

            return this.PersonID != -1;
        }
        public bool UpdatePerson()
        {
            bool isUpdated = false;
            isUpdated = clsPeopleDA.UpdatePerson( PersonID,  NationalID,  FirstName,  SecondName,  ThirdName,
             LastName,  DateOfBirth,  Gendor,  Address,  Phone,  Email,
             NationalityCountryID,  ImagePath);
        
            return isUpdated;
        }

        public static DataTable GetListOfPeople()
        {
            return clsPeopleDA.GetListOfPeople();
        }

        public static bool DeletePerson(int PersonID)
        {
            return clsPeopleDA.DeletePerson(PersonID);
        }
        public static clsPeopleB Find(int PersonID)
        {
            string NationalNo = "";
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.Now;
            short Gendor = 0;
            string Address = "";
            string Phone = "";
            string Email = "";
            int NationalityCountryID = -1;
            string ImagePath = "";


                if( clsPeopleDA.FindPerson(PersonID, ref NationalNo, ref FirstName,
                ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth,
                ref Gendor, ref Address, ref Phone, ref Email,
                ref NationalityCountryID, ref ImagePath))
                {
                

                        return new clsPeopleB(PersonID, NationalNo, FirstName, SecondName, ThirdName,
             LastName, DateOfBirth, Gendor, Address, Phone, Email,
             NationalityCountryID, ImagePath);
                 }else
                  {
                      return null;
                  }

            
           
        }

        public static clsPeopleB Find(string NationalNo)
        {
            int PersonID = -1;
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.Now;
            short Gendor = 0;
            string Address = "";
            string Phone = "";
            string Email = "";
            int NationalityCountryID = -1;
            string ImagePath = "";


            if (clsPeopleDA.FindPerson( NationalNo, ref PersonID ,  ref FirstName,
            ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth,
            ref Gendor, ref Address, ref Phone, ref Email,
            ref NationalityCountryID, ref ImagePath))
            {


                return new clsPeopleB(PersonID, NationalNo, FirstName, SecondName, ThirdName,
     LastName, DateOfBirth, Gendor, Address, Phone, Email,
     NationalityCountryID, ImagePath);
            }
            else
            {
                return null;
            }



        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.enAddNew:
                    if(_AddNewPerson())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    
                    break;

                case enMode.Update:
                    if (UpdatePerson()) return true;

                    break;
                default:
                    break;
            }

            return false;
        }

        public static bool IsPersonExist(int PersonID)
        {
            return clsPeopleDA.IsPersonExist(PersonID);
        }

        public static bool IsPersonExist(string NationalNo)
        {
            return clsPeopleDA.IsPersonExist( NationalNo);
        }

    }
}
