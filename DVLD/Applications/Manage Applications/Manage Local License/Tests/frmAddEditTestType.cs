using DVLD_Business;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD.Applications.Manage_Applications.Tests
{
    public partial class frmAddEditTestType : Form
    {
        private enum enMode { Add, Update }
        private enMode _Mode = enMode.Add;
        private int Trials = 0;
        private int _LDLID = -1;
        private int _TestAppointmentID = -1;
        private int _TestTypeID = 1;

        private clsLocalDrivingLicenseApplicationB _LocalLicense;
        private clsTestAppointmentsB _TestAppointment;
        private clsApplicationsB _Application;

        public frmAddEditTestType(int LDLID, int TestType , int TestAppointmentID = -1)
        {
            InitializeComponent();
            _LDLID = LDLID;
            _TestTypeID = TestType;
            _TestAppointmentID = TestAppointmentID;
            _Mode = (_TestAppointmentID == -1) ? enMode.Add : enMode.Update;
        }

        private void _CheckIfAppointmentIsLocked()
        {
            if (_TestAppointment.IsLocked == true)
            {
                dtpDate.Enabled = false;
                btnSave.Enabled = false;
                lblNotification.Text = "Person Already sat for the test, Appointment Locked.";
            }
            else
            {
                lblNotification.Text = "";
            }
        }

        private void CheckWhichTestTypeToApply()
        {
            if (_TestTypeID == 1)
            {
                lblHeadLine.Text = "Schedule Vision Test";
                pbHeadLine.Image = Properties.Resources.Eye;
            }
            else if (_TestTypeID == 2)
            {
                lblHeadLine.Text = "Schedule Written Test";
                pbHeadLine.Image = Properties.Resources.WrittenTest;
            }
            else if (_TestTypeID == 3)
            {
                lblHeadLine.Text = "Schedule Street Test";
                pbHeadLine.Image = Properties.Resources.SteetTest;
            }
            else
            {
                lblHeadLine.Text = "None!";
                pbHeadLine.Enabled = false;
            }
        }

        private void frmAddEditVisionTest_Load(object sender, EventArgs e)
        {
            CheckWhichTestTypeToApply();
            Trials = clsTestAppointmentsB.GetAppointmentsInfoByLDLIDandTestTypeID(_LDLID, _TestTypeID).Rows.Count;
            if (Trials > 0) lblHeadLine.Text = "Retake Vision Test";

            _LoadData();

            if (_Mode == enMode.Update)
                _CheckIfAppointmentIsLocked();
        }

        private void _LoadData()
        {
            _LocalLicense = clsLocalDrivingLicenseApplicationB.FindApplicationUsingLDLID(_LDLID);

            if (_LocalLicense == null)
            {
                MessageBox.Show("No Application found with this ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblLDLApplicationID.Text = _LocalLicense.LocalDrivingLicenseApplicationID.ToString();

            clsLicenseClassesB LicenseClass = clsLicenseClassesB.Find(_LocalLicense.LicenseClassID);
            lblAppliedForLicense.Text = (LicenseClass != null) ? LicenseClass.ClassName : "Unknown";

            clsPeopleB Person = clsPeopleB.Find(_LocalLicense.ApplicantPersonID);
            lblApplicantName.Text = (Person != null) ? Person.FullName : "Unknown";

            clsTestTypesB TestType = clsTestTypesB.FindTestType(1);
            lblFees.Text = TestType._TestTyepsFees.ToString();

            lblTrail.Text = Trials.ToString();

            _Application = clsApplicationsB.FindBaseApplication(_LocalLicense.ApplicationID);

            if (_Mode == enMode.Add)
            {
                _TestAppointment = new clsTestAppointmentsB();
                dtpDate.MinDate = DateTime.Now;

                if (Trials > 0)
                {
                    lblReateApplicationFees.Text = clsApplicationTypesB.FindApplicationType(7)._ApplicationTyepsFees.ToString();
                    lblTotalFees.Text = (TestType._TestTyepsFees + Convert.ToSingle(lblReateApplicationFees.Text)).ToString();
                    lblRetakeAppID.Text = "N/A";
                }
                else
                {
                    lblReateApplicationFees.Text = "0";
                    lblTotalFees.Text = lblFees.Text;
                    lblRetakeAppID.Text = "N/A";
                }
            }
            else
            {
                _TestAppointment = clsTestAppointmentsB.Find(_TestAppointmentID);

                if (_TestAppointment == null)
                {
                    MessageBox.Show("Appointment not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                dtpDate.Value = _TestAppointment.AppointmentDate;
                if (_TestAppointment.AppointmentDate < DateTime.Now)
                {
                    dtpDate.MinDate = _TestAppointment.AppointmentDate;
                }

                lblTotalFees.Text = _TestAppointment.PaidFees.ToString();
                lblRetakeAppID.Text = (_TestAppointment.RetakeTestApplicationID == -1) ? "N/A" : _TestAppointment.RetakeTestApplicationID.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Add)
            {
                if (clsTestAppointmentsB.IsPassedTestExist(_LDLID, _TestTypeID))
                {
                    MessageBox.Show("This person already passed this test. You cannot schedule a new appointment.",
                                    "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
            }

            _TestAppointment.TestTypeID = _TestTypeID;
            _TestAppointment.LocalDrivingLicenseApplicationID = _LDLID;
            _TestAppointment.AppointmentDate = dtpDate.Value;

            if (_Mode == enMode.Add)
            {
                _TestAppointment.PaidFees = Convert.ToSingle(lblTotalFees.Text);
                _TestAppointment.CreatedByUserID = clsLoggedUser.CurrentUser._UserID;
                _TestAppointment.IsLocked = false;

                if (Trials > 0)
                {
                    clsApplicationsB RetakeApp = new clsApplicationsB();

                    RetakeApp.ApplicantPersonID = _LocalLicense.ApplicantPersonID;
                    RetakeApp.ApplicationDate = DateTime.Now;
                    RetakeApp.ApplicationTypeID = 7; 
                    RetakeApp.ApplicationStatus = 3; 
                    RetakeApp.LastStatusDate = DateTime.Now;
                    RetakeApp.PaidFees = Convert.ToSingle(lblReateApplicationFees.Text);
                    RetakeApp.CreatedByUserID = clsLoggedUser.CurrentUser._UserID;

                    if (!RetakeApp.Save())
                    {
                        MessageBox.Show("Failed to create Retake Application financial record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; 
                    }

                    _TestAppointment.RetakeTestApplicationID = RetakeApp.ApplicationID;
                }
                else
                {
                    _TestAppointment.RetakeTestApplicationID = -1;
                }
            }

            if (_TestAppointment.Save())
            {
                lblRetakeAppID.Text = (_TestAppointment.RetakeTestApplicationID == -1) ? "N/A" : _TestAppointment.RetakeTestApplicationID.ToString();

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Mode = enMode.Update;

                btnSave.Enabled = false;
                dtpDate.Enabled = false;
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}