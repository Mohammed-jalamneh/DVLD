using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsTestsB
    {
        public int TestID { get; set; }
        public int TestAppointmentID { get; set; }
        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }

        public clsTestAppointmentsB TestAppointments { get; }

        public clsTestsB()
        {
            this.TestID = -1;
            this.TestAppointmentID = -1;
            this.TestResult = false;
            this.Notes = "";
            this.CreatedByUserID = -1;

            TestAppointments = null;
        }

        private bool _AddTestResult()
        {
            TestID = clsTestsDA.AddNewTestResult(this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);
            return (TestID != -1);
        }

        public bool Save()
        {
            return _AddTestResult();
        }








    }
}
