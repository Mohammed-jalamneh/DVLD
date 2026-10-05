using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsTestTypesB
    {
       
            public int _TestTypeID = -1;
            public string _TestTypeTitle;
            public string _TestTypeDescription;
            public float _TestTyepsFees;

            public clsTestTypesB(int TestTypeID, string TestTypeTitle ,  string TestTypeDescription, float TestTyepsFees)
            {
                _TestTypeID = TestTypeID;
                _TestTypeTitle = TestTypeTitle;
            _TestTypeDescription = TestTypeDescription;
            _TestTyepsFees = TestTyepsFees;

        }
            public static DataTable GetTestTypes()
            {
            return clsTestTypesDA.GetTestTypesList();
            }

            public static clsTestTypesB FindTestType(int TypeID)
            {
                string Title = "";
                string Description="";
                float Fees = -1;

                if (clsTestTypesDA.FindTestType(TypeID , ref Title , ref Description , ref Fees))
                {
                    return new clsTestTypesB(TypeID, Title , Description , Fees);
                }
                else
                {
                    return null;
                }
            }

            private bool UpdateTestType()
            {
            return clsTestTypesDA.UpdateTestTypes(_TestTypeID, _TestTypeTitle, _TestTypeDescription, _TestTyepsFees);
            }
            public bool Save()
            {
                if (UpdateTestType()) return true;
                else return false;
            }

        }
    }

