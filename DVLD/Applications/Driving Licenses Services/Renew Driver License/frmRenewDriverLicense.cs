using DVLD.Applications.Manage_Applications.Manage_Local_License.License;
using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD.Applications.Renew_Driver_License
{
    public partial class frmRenewDriverLicense : Form
    {
        private int _LicenseID;
        clsLicensesB _License;
        clsApplicationsB _Application;
        clsApplicationsB NewApplication;
        clsLicensesB NewLicense;

        public frmRenewDriverLicense()
        {
            InitializeComponent();

            ctrlDriverLicenseWithFilter1.OnLicenseSelected += GetLicenseIDFromCtrl;
        }

        private void GetLicenseIDFromCtrl(int LicenseID)
        {
            _LicenseID = LicenseID;
            _License = clsLicensesB.Find(_LicenseID);

            if (_License != null)
            {
                _Application = clsApplicationsB.FindBaseApplication(_License.ApplicationID);

                if (!IsLicenseExpired())
                {
                    MessageBox.Show("This License is not expired yet.", "Note", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNotes.Enabled = false;
                    btnRenew.Enabled = false;
                    return;
                }else if(!IsLicenseActive())
                {
                    MessageBox.Show("This License is already not active.", "Note", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNotes.Enabled = false;
                    btnRenew.Enabled = false;
                    return;
                }
                else
                {
                    txtNotes.Enabled = true;
                    btnRenew.Enabled = true;
                }
            }
        }
        private bool IsLicenseExpired()
        {
            return (_License.ExpirationDate < DateTime.Now);
        }
        private bool IsLicenseActive()
        {
            return _License.IsActive;
        }

        private void LoadNewApplicationInfo()
        {
            lblApplicationDate.Text = NewApplication.ApplicationDate.ToString("dd/MM/yyyy");
            lblIssueDate.Text = NewLicense.IssueDate.ToString("dd/MM/yyyy");
            lblApplicationFees.Text = NewApplication.PaidFees.ToString();
            lblLicenseFees.Text = NewLicense.PaidFees.ToString();

            lblOldLicenseID.Text = _License.LicenseID.ToString();
            lblExpirationDate.Text = NewLicense.ExpirationDate.ToString("dd/MM/yyyy");
            lblCreatedBy.Text = clsLoggedUser.CurrentUser._UserName;

            lblTotalFees.Text = (NewLicense.PaidFees + NewApplication.PaidFees).ToString();
        }

        private void frmRenewDriverLicense_Load(object sender, EventArgs e)
        {
            llShowNewLicenseInfo.Enabled = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_License == null) return;

            int PersonID = _License.DriverInfo.PersonID;
            int DriverID = _License.DriverInfo.DriverID;
            frmLicenseHistory frm = new frmLicenseHistory(PersonID, DriverID);
            frm.ShowDialog();
        }

        private void _DisActiveOldLicense()
        {
            _License.IsActive = false;
            if(!_License.Save())
            {
                MessageBox.Show("Can't DisActive Old License.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        



        private void btnRenew_Click(object sender, EventArgs e)
        {
            NewApplication = new clsApplicationsB();
            NewApplication.ApplicantPersonID = _License.DriverInfo.PersonID;
            NewApplication.ApplicationDate = DateTime.Now;
            NewApplication.ApplicationTypeID = 2; 
            NewApplication.ApplicationStatus = 3; 
            NewApplication.LastStatusDate = DateTime.Now;
            NewApplication.CreatedByUserID = clsLoggedUser.CurrentUser._UserID;

            NewApplication.PaidFees = clsApplicationTypesB.FindApplicationType(NewApplication.ApplicationTypeID)._ApplicationTyepsFees;

            if (NewApplication.Save())
            {
                NewLicense = new clsLicensesB();
                NewLicense.ApplicationID = NewApplication.ApplicationID; 
                NewLicense.DriverID = _License.DriverInfo.DriverID;
                NewLicense.LicenseClassID = _License.LicenseClassID;
                NewLicense.IssueDate = DateTime.Now;
                NewLicense.ExpirationDate = DateTime.Now.AddYears(_License.LicenseClassInfo.DefaultValidityLength);
                NewLicense.Notes = txtNotes.Text;

                NewLicense.PaidFees = _License.LicenseClassInfo.ClassFees;
                NewLicense.IsActive = true;
                NewLicense.IssueReason = 2;
                NewLicense.CreatedByUserID = clsLoggedUser.CurrentUser._UserID;

                if (NewLicense.Save())
                {
                    _DisActiveOldLicense();
                    llShowNewLicenseInfo.Enabled = true;
                    MessageBox.Show("License Renewed Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    lblRenewedApplicationID.Text = NewApplication.ApplicationID.ToString();
                    lblRenewedLicenseID.Text = NewLicense.LicenseID.ToString();

                    btnRenew.Enabled = false;
                    ctrlDriverLicenseWithFilter1.Enabled = false;
                    LoadNewApplicationInfo();
                    return;
                }
            }

            MessageBox.Show("Error Happened while Saving...", "Not Saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void llShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (NewLicense != null)
            {
                frmShowLicense frm = new frmShowLicense(NewLicense.LicenseID);
                frm.ShowDialog();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }