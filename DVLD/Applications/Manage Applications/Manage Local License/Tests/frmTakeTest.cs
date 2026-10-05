using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD.Applications.Manage_Applications.Tests
{
    public partial class frmTakeTest : Form
    {

        private int _AppointmentID=-1;
        clsTestAppointmentsB TestAppointment;
        clsLocalDrivingLicenseApplicationB LocalLicense;
        clsTestsB Test;
        private int _TestType = 1;
        public frmTakeTest(int AppointmentID , int TestTypeID)
        {
            _AppointmentID = AppointmentID;
            _TestType = TestTypeID;
            InitializeComponent();
            
          
        }

        public void LoadData()
        {
             TestAppointment = clsTestAppointmentsB.Find(_AppointmentID);
            if (TestAppointment == null)
            {
                MessageBox.Show("Error: Appointment not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            LocalLicense = clsLocalDrivingLicenseApplicationB.FindApplicationUsingLDLID(TestAppointment.LocalDrivingLicenseApplicationID);


            lblLDLApplicationID.Text = TestAppointment.LocalDrivingLicenseApplicationID.ToString();
            lblApplicantName.Text = clsPeopleB.Find(LocalLicense.ApplicantPersonID).FullName;
            lblAppliedForLicense.Text = clsLicenseClassesB.Find(LocalLicense.LicenseClassID).ClassName;
            lblDate.Text = TestAppointment.AppointmentDate.ToShortDateString();
            lblFees.Text = TestAppointment.PaidFees.ToString();
            lblTestID.Text = "Not Taken Yet!";

            lblTrail.Text = clsTestAppointmentsB.GetAppointmentsInfoByLDLIDandTestTypeID(
            LocalLicense.LocalDrivingLicenseApplicationID, 
            TestAppointment.TestTypeID).Rows.Count.ToString();


        }

        private void CheckWhichTestTypeToApply()
        {
            if (_TestType == 1)
            {
                lblHeadLine.Text = "Vision Test Result";
                pbHeadLine.Image = Properties.Resources.Eye;
            }
            else if (_TestType == 2)
            {
                lblHeadLine.Text = "Written Test Result";
                pbHeadLine.Image = Properties.Resources.WrittenTest;
            }
            else if (_TestType == 3)
            {
                lblHeadLine.Text = "Street Test Result";
                pbHeadLine.Image = Properties.Resources.SteetTest;
            }
            else
            {
                lblHeadLine.Text = "None!";
                pbHeadLine.Enabled = false;
            }
        }
        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            CheckWhichTestTypeToApply();
            LoadData();
            if (TestAppointment.IsLocked == true)
            {
                btnSave.Enabled = false;
                rbFail.Enabled = false;
                rbPass.Enabled = false;
                txtNotes.Enabled = false;

                lblNotification.Text = "Person Already sat for the test , Appointment Locked.";
            }else
            {
                lblNotification.Text = "";
            }

            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(rbPass.Checked == false && rbFail.Checked == false)
    {
                MessageBox.Show("Please Set Applicant Test Result.", "Can't Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to save this result? You cannot change it later.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            Test = new clsTestsB();
            Test.TestAppointmentID = TestAppointment.TestAppointmentID;

            Test.TestResult = rbPass.Checked;

            Test.Notes = txtNotes.Text;
            Test.CreatedByUserID = clsLoggedUser.CurrentUser._UserID;

            if (Test.Save())
            {
                MessageBox.Show("Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TestAppointment.IsLocked = true;
                TestAppointment.Save();

                lblTestID.Text = Test.TestID.ToString();

                btnSave.Enabled = false;

                rbPass.Enabled = false;
                rbFail.Enabled = false;
                txtNotes.Enabled = false;
            }
            else
            {
                MessageBox.Show("Does Not Save.", "Saving Interrupt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
