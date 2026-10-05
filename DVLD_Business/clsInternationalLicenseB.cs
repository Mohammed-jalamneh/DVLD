using System;
using System.Data;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsInternationalLicenseB
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int InternationalLicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int IssuedUsingLocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }

        public clsLicensesB LicenseInfo { get; }

        public clsInternationalLicenseB()
        {
            this.InternationalLicenseID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.IssuedUsingLocalLicenseID = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.IsActive = true;
            this.CreatedByUserID = -1;

            Mode = enMode.AddNew;
        }

        private clsInternationalLicenseB(int InternationalLicenseID, int ApplicationID, int DriverID,
            int IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            this.InternationalLicenseID = InternationalLicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.IssuedUsingLocalLicenseID = IssuedUsingLocalLicenseID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive;
            this.CreatedByUserID = CreatedByUserID;
            this.LicenseInfo = clsLicensesB.Find(IssuedUsingLocalLicenseID);
            Mode = enMode.Update;
        }

        private bool _AddNewInternationalLicense()
        {
            this.InternationalLicenseID = clsInternationalLicenseDA.AddNewInternationalLicense(
                this.ApplicationID, this.DriverID, this.IssuedUsingLocalLicenseID,
                this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);

            return (this.InternationalLicenseID != -1);
        }

        private bool _UpdateInternationalLicense()
        {
            return clsInternationalLicenseDA.UpdateInternationalLicense(
                this.InternationalLicenseID, this.ApplicationID, this.DriverID,
                this.IssuedUsingLocalLicenseID, this.IssueDate, this.ExpirationDate,
                this.IsActive, this.CreatedByUserID);
        }

        public static clsInternationalLicenseB Find(int InternationalLicenseID)
        {
            int ApplicationID = -1;
            int DriverID = -1;
            int IssuedUsingLocalLicenseID = -1;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpirationDate = DateTime.Now;
            bool IsActive = true;
            int CreatedByUserID = -1;

            if (clsInternationalLicenseDA.FindByInternationalLicenseID(InternationalLicenseID,
                ref ApplicationID, ref DriverID, ref IssuedUsingLocalLicenseID,
                ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID))
            {
                return new clsInternationalLicenseB(InternationalLicenseID, ApplicationID, DriverID,
                    IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);
            }
            else
            {
                return null;
            }
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewInternationalLicense())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateInternationalLicense();
            }
            return false;
        }

        public static DataTable GetAllInternationalLicenses()
        {
            return clsInternationalLicenseDA.GetAllInternationalLicenses();
        }

        public static DataTable GetDriverInternationalLicenses(int DriverID)
        {
            return clsInternationalLicenseDA.GetDriverInternationalLicenses(DriverID);
        }

        public static int GetActiveInternationalLicenseIDByDriverID(int DriverID)
        {
            return clsInternationalLicenseDA.GetActiveInternationalLicenseIDByDriverID(DriverID);
        }

    }
}