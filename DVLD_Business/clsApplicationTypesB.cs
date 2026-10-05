using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsApplicationTypesB
    {
        public int _ApplicationTypeID =-1;
        public string _ApplicationTypeTitle;
        public float _ApplicationTyepsFees;

        public clsApplicationTypesB(int ApplicationTypeID  , string ApplicationTypesTitle, float ApplicationTyepsFees)
        {
            _ApplicationTypeID = ApplicationTypeID;
            _ApplicationTyepsFees = ApplicationTyepsFees;
            _ApplicationTypeTitle = ApplicationTypesTitle;
        }
        public static DataTable GetListOfApplicationTypes()
        {
            return clsApplicationTypesDA.GetListOfApplications();
        }

        public static clsApplicationTypesB FindApplicationType(int TypeID)
        {
            string Title = "";
            float Fees = -1;

             if(clsApplicationTypesDA.FindApplicatinoType(TypeID , ref Title, ref Fees))
            {
                return new clsApplicationTypesB(TypeID, Title, Fees);
            }
            else
            {
                return null;
            }
        }

        private bool UpdateApplicationType()
        {
            return clsApplicationTypesDA.UpdateApplicationTypes(_ApplicationTypeID , _ApplicationTypeTitle , _ApplicationTyepsFees);
        }
        public bool Save()
        {
            if (UpdateApplicationType()) return true;
            else return false;
        }

    }
}
