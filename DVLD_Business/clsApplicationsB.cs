using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsApplicationsB
    {
        public enum enMode { Add, Update };
        public enMode Mode = enMode.Add;

        public int ApplicationID { get; set; }
        public int ApplicantPersonID { get; set; } 
        public DateTime ApplicationDate { get; set; }
        public int ApplicationTypeID { get; set; }
        public byte ApplicationStatus { get; set; } 
        public DateTime LastStatusDate { get; set; }
        public float PaidFees { get; set; } 
        public int CreatedByUserID { get; set; }

        public clsApplicationsB()
        {
            this.ApplicationID = -1;
            this.ApplicantPersonID = -1;
            this.ApplicationDate = DateTime.Now;
            this.ApplicationTypeID = -1;
            this.ApplicationStatus = 1;
            this.LastStatusDate = DateTime.Now;
            this.PaidFees = 0;
            this.CreatedByUserID = -1;

            Mode = enMode.Add;
        }

        public clsApplicationsB(
            int applicationID, int applicantPersonID, DateTime applicationDate,
            int applicationTypeID, byte applicationStatus, DateTime lastStatusDate,
            float paidFees, int createdByUserID)
        {
            this.ApplicationID = applicationID;
            this.ApplicantPersonID = applicantPersonID;
            this.ApplicationDate = applicationDate;
            this.ApplicationTypeID = applicationTypeID;
            this.ApplicationStatus = applicationStatus;
            this.LastStatusDate = lastStatusDate;
            this.PaidFees = paidFees;
            this.CreatedByUserID = createdByUserID;

            this.Mode = enMode.Update;
        }

        private bool _AddApplication()
        {
            ApplicationID = clsApplicationsDA.AddApplication(ApplicantPersonID, ApplicationDate, ApplicationTypeID,
                ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);

            return ApplicationID != -1;
        }

        private bool _UpdateApplication()
        {
           
            return clsApplicationsDA.UpdateApplication(
                this.ApplicationID,
                this.ApplicantPersonID,
                this.ApplicationDate,
                this.ApplicationTypeID,
                this.ApplicationStatus,
                this.LastStatusDate,
                this.PaidFees,
                this.CreatedByUserID
            );
        }

        public static clsApplicationsB FindBaseApplication(int applicationID)
        {
            int applicantPersonID = -1;
            DateTime applicationDate = DateTime.Now;
            int applicationTypeID = -1;
            byte applicationStatus = 1;
            DateTime lastStatusDate = DateTime.Now;
            float paidFees = 0;
            int createdByUserID = -1;

            bool isFound = clsApplicationsDA.GetApplicationInfoByID(
                applicationID, ref applicantPersonID, ref applicationDate,
                ref applicationTypeID, ref applicationStatus, ref lastStatusDate,
                ref paidFees, ref createdByUserID);

            if (isFound)
            {
                return new clsApplicationsB(applicationID, applicantPersonID, applicationDate,
                                            applicationTypeID, applicationStatus, lastStatusDate,
                                            paidFees, createdByUserID);
            }
            else
            {
                return null;
            }
        }
        public virtual bool Save()
        {
            switch (Mode)
            {
                case enMode.Add:
                    if (_AddApplication())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateApplication();

                default:
                    return false;
            }
        }

        public static bool IsPersonHasActiveApplication(int PersonID, int LicenseClassID)
        {
            return clsApplicationsDA.IsPersonHasActiveApplication(PersonID, LicenseClassID);
        }

        public static DataTable GetListOfAllApplications()
        {
            return clsApplicationsDA.GetListOfApplications();
        }

        public static bool DeleteApplicationFromApplicationsTable(int ApplicationID)
        {
            return clsApplicationsDA.DeleteApplicationFromApplicatoinsTable(ApplicationID);
        }

        public static bool CancelApplication(int applicationID)
        {
            return clsApplicationsDA.CancelApplication(applicationID);
        }
    }
}