using DVLD.OtherClasses;
using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsUsersB
    {
        public  int _UserID { get; set; }
        public int _PersonID { get; set; }
        public string _UserName { get; set; }
        public string _Password { get; set; }
        public short _IsActive { get; set; }
        enum enMode {Add , Update};

        enMode _Mode = enMode.Add;
        

        public clsUsersB()
        {
            _PersonID = -1;
            _UserID = -1;
            _UserName = "";
            _Password = "";
            _IsActive = 0;

            _Mode = enMode.Add;
        }

        public clsUsersB( int PersonID , int UserID , string UserName , string Password , short IsActive)
        {
           
            _PersonID  =PersonID;
            _UserID =UserID;
            _UserName = UserName;
            _Password = Password;
            _IsActive = IsActive;

            _Mode = enMode.Update;
        }

        
        public bool AddUser()
        {
            if (!clsCryptography.IsSha256Hash(this._Password))
            {
                this._Password = clsCryptography.ComputeHash(this._Password);
            }

            this._UserID =  clsUsersDA.AddNewUser(_UserName, _Password, _PersonID , _IsActive);

            return this._UserID != -1;
        }

        public bool UpdateUser()
        {
            if (!clsCryptography.IsSha256Hash(this._Password))
            {
                this._Password = clsCryptography.ComputeHash(this._Password);
            } 
            return clsUsersDA.UpdateUser(_PersonID , _UserName , _Password , _IsActive);
        }

        public bool UpdateUserPassword(string Password)
        {
            string CrypPassword = clsCryptography.ComputeHash(Password);
            return clsUsersDA.UpdateUserPassword(_PersonID, CrypPassword);
        }

        public static clsUsersB Find(int PersonID)
        {
            int UserID = -1;
            string UserName = "";
            string Password = "";
            short IsActive = -1;

            if(clsUsersDA.Find(PersonID , ref UserID  , ref UserName , ref Password , ref IsActive))
            {
                return new clsUsersB( PersonID,UserID, UserName, Password, IsActive);
            }
            else
            {
                return null;
            }

        }

        public static clsUsersB Find(string UserName)
        {
            int UserID = -1;
            int PersonID = -1;
            string Password = "";
            short IsActive = -1;

            if (clsUsersDA.Find(UserName , ref UserID , ref PersonID, ref Password, ref IsActive))
            {
                return new clsUsersB(PersonID, UserID, UserName, Password, IsActive);
            }
            else
            {
                return null;
            }

        }

        public static clsUsersB Find(string UserName, string PlainPassword)
        {
            clsUsersB user = Find(UserName);

            if (user != null && user._Password ==clsCryptography.ComputeHash(PlainPassword.Trim()))
            {
                return user;
            }

            return null;
        }

        public static bool IsUserExist(string UserName , string Password)
        {
            return clsUsersDA.IsUserExist(UserName, Password);
        }
        public static bool IsUserExist(int PersonID)
        {
            return clsUsersDA.IsUserExist(PersonID);
        }

        public static bool IsUserExist(string UserName)
        {
            return clsUsersDA.IsUserExist(UserName);
        }

        public static DataTable GetListOfUsers()
        {
            return clsUsersDA.GetListOfUsers();
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.Add:

                    if (AddUser())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    
                    break;

                case enMode.Update:
                    if(UpdateUser())
                    {
                        return true;
                    }
                    break;
                default:
                    break;

            }

            return false;
        }

        public static bool DeleteUser(int UserID)
        {
            return clsUsersDA.DeleteUser(UserID);
        }


    }
}
