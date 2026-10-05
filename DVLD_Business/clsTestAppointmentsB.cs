using DVLD_DataAccess;
using System;
using System.Data;
using System.Diagnostics;

namespace DVLD_Business
{
    public class clsTestAppointmentsB
    {
        enum enMode { Add, Update }
        private enMode _Mode = enMode.Add;

        public int TestAppointmentID { get; private set; }
        public int TestTypeID { get; set; }
        public int LocalDrivingLicenseApplicationID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public float PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsLocked { get; set; }
        public int RetakeTestApplicationID { get; set; }

        public static DataTable GetAppointmentsInfoByLDLIDandTestTypeID(int LDLID, int TestTypeID)
        {
            return clsTestAppointmentsDA.GetAllTestAppointments(LDLID, TestTypeID);
        }

        public clsTestAppointmentsB()
        {
            TestAppointmentID = -1;
            TestTypeID = -1;
            LocalDrivingLicenseApplicationID = -1;
            AppointmentDate = DateTime.Now;
            PaidFees = 0;
            CreatedByUserID = -1;
            IsLocked = false;
            RetakeTestApplicationID = -1;

            _Mode = enMode.Add;
        }

        private clsTestAppointmentsB(int TestAppointmentID, int TestTypeID, int LocalDrivingLicenseApplicationID,
                                    DateTime AppointmentDate, float PaidFees, int CreatedByUserID, bool IsLocked,
                                    int RetakeTestApplicationID)
        {
            this.TestAppointmentID = TestAppointmentID;
            this.TestTypeID = TestTypeID;
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsLocked = IsLocked;
            this.RetakeTestApplicationID = RetakeTestApplicationID;

            _Mode = enMode.Update;
        }

        // 3. Added Missing Find Method
        public static clsTestAppointmentsB Find(int TestAppointmentID)
        {
            int TestTypeID = -1, LocalDrivingLicenseApplicationID = -1, CreatedByUserID = -1, RetakeTestApplicationID = -1;
            DateTime AppointmentDate = DateTime.Now;
            float PaidFees = 0;
            bool IsLocked = false;

            if (clsTestAppointmentsDA.FindTestAppointmentInfoByID(TestAppointmentID, ref TestTypeID,
                ref LocalDrivingLicenseApplicationID, ref AppointmentDate, ref PaidFees,
                ref CreatedByUserID, ref IsLocked, ref RetakeTestApplicationID))
            {
                return new clsTestAppointmentsB(TestAppointmentID, TestTypeID, LocalDrivingLicenseApplicationID,
                    AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID);
            }
            return null;
        }

        private bool _AddNewAppointment()
        {
            this.TestAppointmentID = clsTestAppointmentsDA.AddNewTestAppointment(this.TestTypeID,
                this.LocalDrivingLicenseApplicationID, this.AppointmentDate, this.PaidFees,
                this.CreatedByUserID, this.IsLocked, this.RetakeTestApplicationID);

            return (this.TestAppointmentID != -1);
        }

        private bool _UpdateAppointment()
        {
            return clsTestAppointmentsDA.UpdateTestAppointment(
                this.TestAppointmentID, this.TestTypeID, this.LocalDrivingLicenseApplicationID,
                this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked,
                this.RetakeTestApplicationID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.Add:
                    if (_AddNewAppointment())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateAppointment();
            }

            return false;
        }

        public static bool IsAppointmentExistByIDandTestType(int LocalDLID, int TestTypeID)
        {
            return clsTestAppointmentsDA.IsAppointmentExistByIDandTestType(LocalDLID, TestTypeID);
        }

        public static bool IsPassedTestExist(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            return clsTestAppointmentsDA.IsPassedTestExist(LocalDrivingLicenseApplicationID, TestTypeID);
        }
    }
}