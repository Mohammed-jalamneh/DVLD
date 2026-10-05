using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsLocalDrivingLicenseApplicationB : clsApplicationsB
    {


        public enum enMode {Add , Update};
        public enMode Mode = enMode.Add;

        public int LocalDrivingLicenseApplicationID { get; set; }
        public int LicenseClassID { get; set; }

        

        public clsLocalDrivingLicenseApplicationB()
        {
            this.LocalDrivingLicenseApplicationID = -1;
            this.LicenseClassID = -1;

            Mode = enMode.Add;
        }

        private clsLocalDrivingLicenseApplicationB(
            int localDrivingLicenseApplicationID, int applicationID, int applicantPersonID,
            DateTime applicationDate, int applicationTypeID,
            byte applicationStatus, DateTime lastStatusDate,
            float paidFees, int createdByUserID, int licenseClassID)
            : base(applicationID, applicantPersonID, applicationDate,
                   applicationTypeID, applicationStatus, lastStatusDate,
                   paidFees, createdByUserID)
        {
            this.LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            this.LicenseClassID = licenseClassID;
            //this.LicenseClassInfo = clsLicenseClass.Find(licenseClassID);

            this.Mode = enMode.Update;
        }

        private bool _AddNew()
        {
            this.LocalDrivingLicenseApplicationID =
                clsLocalDrivingLicenseApplicationDA.AddLocalLicenseApplication(this.ApplicationID, this.LicenseClassID);

            return (this.LocalDrivingLicenseApplicationID != -1);
        }

        private bool _Update()
        {

            return clsLocalDrivingLicenseApplicationDA.UpdateLocalDrivingLicenseApplication
                (this.LocalDrivingLicenseApplicationID ,
                this.ApplicationID, this.LicenseClassID);
        }
        public bool Save()
        {
            if (!base.Save())
                return false;

            switch (Mode)
            {
                case enMode.Add:
                    return _AddNew();
                    
                case enMode.Update:
                    return _Update();
                   
                default:
                    break;
            }
            return false;
        }

        public static bool DeleteApplicationFromLocalLicenseTable(int LDLApplicationID)
        {
            return clsLocalDrivingLicenseApplicationDA.DeleteApplicationFromLocalLicense(LDLApplicationID);
        }

        public static int GetApplicationIDByLDLid(int LDLApplicationID)
        {
            return clsLocalDrivingLicenseApplicationDA.GetApplicationIDByID(LDLApplicationID);
        }

        public static clsLocalDrivingLicenseApplicationB FindApplicationUsingLDLID(int LDLID)
        {
            int ApplicationID = -1 , LicenseClassID = -1;

            bool IsFound =
                clsLocalDrivingLicenseApplicationDA.GetLocalDrivingLicenseApplicationInfoByLDLID(LDLID , ref ApplicationID , ref LicenseClassID);
            
            if(IsFound)
            {
               clsApplicationsB Application =  clsApplicationsB.FindBaseApplication(ApplicationID);

                return new clsLocalDrivingLicenseApplicationB(
                                 LDLID,
                                 Application.ApplicationID,
                                 Application.ApplicantPersonID,
                                 Application.ApplicationDate,
                                 Application.ApplicationTypeID,
                                 Application.ApplicationStatus,
                                 Application.LastStatusDate,
                                 Application.PaidFees,
                                 Application.CreatedByUserID,
                                 LicenseClassID
                                );
            }else
                return null;
        }

        public static clsLocalDrivingLicenseApplicationB FindApplicationUsingApplicationID(int ApplicationID)
        {
            int LDLID = -1, LicenseClassID = -1;

            bool IsFound =
                clsLocalDrivingLicenseApplicationDA.GetLocalDrivingLicenseApplicationInfoByApplicationID(ApplicationID, ref LDLID, ref LicenseClassID);

            if (IsFound)
            {
                clsApplicationsB Application = clsApplicationsB.FindBaseApplication(ApplicationID);

                if (Application != null)
                {
                    return new clsLocalDrivingLicenseApplicationB(
                        LDLID,
                        Application.ApplicationID,
                        Application.ApplicantPersonID,
                        Application.ApplicationDate,
                        Application.ApplicationTypeID,
                        Application.ApplicationStatus,
                        Application.LastStatusDate,
                        Application.PaidFees,
                        Application.CreatedByUserID,
                        LicenseClassID
                    );
                }
            }

            return null;
        }

    }
}
