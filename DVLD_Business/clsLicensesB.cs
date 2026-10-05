using DVLD_Business;
using DVLD_DataAccess;
using System;
using System.Data;

public class clsLicensesB
{
    public enum enMode { AddNew = 0, Update = 1 };
    public enMode Mode = enMode.AddNew;

    public int LicenseID { get; set; }
    public int ApplicationID { get; set; }
    public int DriverID { get; set; }
    public int LicenseClassID { get; set; }
    public DateTime IssueDate { get; set; }
    public DateTime ExpirationDate { get; set; }
    public string Notes { get; set; }
    public float PaidFees { get; set; }
    public bool IsActive { get; set; }
    public byte IssueReason { get; set; }
    public int CreatedByUserID { get; set; }

    public clsLicenseClassesB LicenseClassInfo { get; }
    public clsDriversB DriverInfo { get; }
    public clsApplicationsB ApplicationInfo { get; }

    public clsLicensesB()
    {
        this.LicenseID = -1;
        this.ApplicationID = -1;
        this.DriverID = -1;
        this.LicenseClassID = -1;
        this.IssueDate = DateTime.Now;
        this.ExpirationDate = DateTime.Now;
        this.Notes = "";
        this.PaidFees = 0;
        this.IsActive = true;
        this.IssueReason = 1;
        this.CreatedByUserID = -1;
        this.LicenseClassInfo = null;
        this.DriverInfo = null;
        this.ApplicationInfo = null;
        Mode = enMode.AddNew;
    }

    private clsLicensesB(int LicenseID, int ApplicationID, int DriverID, int LicenseClassID,
        DateTime IssueDate, DateTime ExpirationDate, string Notes, float PaidFees,
        bool IsActive, byte IssueReason, int CreatedByUserID)
    {
        this.LicenseID = LicenseID;
        this.ApplicationID = ApplicationID;
        this.DriverID = DriverID;
        this.LicenseClassID = LicenseClassID;
        this.IssueDate = IssueDate;
        this.ExpirationDate = ExpirationDate;
        this.Notes = Notes;
        this.PaidFees = PaidFees;
        this.IsActive = IsActive;
        this.IssueReason = IssueReason;
        this.CreatedByUserID = CreatedByUserID;
        LicenseClassInfo = clsLicenseClassesB.Find(LicenseClassID);
        DriverInfo = clsDriversB.FindByDriverID(DriverID);
        ApplicationInfo = clsApplicationsB.FindBaseApplication(ApplicationID);
        Mode = enMode.Update;
    }

    private bool _AddNewLicense()
    {
        this.LicenseID = clsLicensesDA.AddNewLicense(this.ApplicationID, this.DriverID, this.LicenseClassID,
            this.IssueDate, this.ExpirationDate, this.Notes, this.PaidFees,
            this.IsActive, this.IssueReason, this.CreatedByUserID);

        return (this.LicenseID != -1);
    }

    private bool _UpdateLicense()
    {
        return clsLicensesDA.UpdateLicense(this.LicenseID, this.ApplicationID, this.DriverID, this.LicenseClassID,
            this.IssueDate, this.ExpirationDate, this.Notes, this.PaidFees,
            this.IsActive, this.IssueReason, this.CreatedByUserID);
    }

    public static clsLicensesB Find(int LicenseID)
    {
        int ApplicationID = -1, DriverID = -1, LicenseClassID = -1, CreatedByUserID = -1;
        DateTime IssueDate = DateTime.Now, ExpirationDate = DateTime.Now;
        string Notes = "";
        float PaidFees = 0;
        bool IsActive = true;
        byte IssueReason = 1;

        bool IsFound = clsLicensesDA.GetLicenseInfoByID(LicenseID, ref ApplicationID, ref DriverID, ref LicenseClassID,
            ref IssueDate, ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID);

        if (IsFound)
            return new clsLicensesB(LicenseID, ApplicationID, DriverID, LicenseClassID, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID);
        else
            return null;
    }

    public bool Save()
    {
        switch (Mode)
        {
            case enMode.AddNew:
                if (_AddNewLicense())
                {
                    Mode = enMode.Update;
                    return true;
                }
                else
                {
                    return false;
                }

            case enMode.Update:
                return _UpdateLicense();
        }

        return false;
    }

    public static bool IsLicenseExistByPersonIDAndLicenseClassID(int PersonID , int LicenseClassID)
    {
        return clsLicensesDA.IsLicenseExistByPersonID(PersonID, LicenseClassID);
    }

    public static int GetLicenseIDbyApplicationID(int ApplicationID)
    {
        return clsLicensesDA.GetLicenseIDByApplicationID(ApplicationID);
    }

    public static DataTable GetAllLicensesByDriverID(int DriverID)
    {
        return clsLicensesDA.GetAllLicenseWithDriverID(DriverID);
    }

}