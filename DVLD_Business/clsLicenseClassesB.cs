using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsLicenseClassesB
    {

        public int LicenseClassID {  get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public byte MinimumAllowedAge { get; set; }
        public int DefaultValidityLength { get; set; }
        public float ClassFees { get; set; }

        public clsLicenseClassesB(int LicenseClassID,
     string ClassName,  string ClassDescription,
     byte MinimumAllowedAge,  byte DefaultValidityLength,  float ClassFees)
        {
            this.LicenseClassID = LicenseClassID;
            this.ClassName = ClassName;
            this.ClassDescription = ClassDescription;
            this.MinimumAllowedAge = MinimumAllowedAge;
            this.DefaultValidityLength = DefaultValidityLength;
            this.ClassFees = ClassFees;
        }
        public static DataTable GetAllLicenseClasses()
        {
            return clsLicenseClassesDA.GetAllLicenseClasses();
        }

        public static clsLicenseClassesB Find(int LicenseClassID)
        {
            string ClassName = "", ClassDescription = "";
            byte MinimumAllowedAge = 18, DefaultValidityLength = 10;
            float ClassFees = 0;

            bool IsFound = clsLicenseClassesDA.GetLicenseClassInfoByID(
                LicenseClassID, ref ClassName, ref ClassDescription,
                ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees);

            if (IsFound)
            {
                return new clsLicenseClassesB(
                    LicenseClassID,
                    ClassName,
                    ClassDescription,
                    MinimumAllowedAge,
                    DefaultValidityLength,
                    ClassFees
                );
            }
            else
            {
                return null;
            }
        }

    }
}
