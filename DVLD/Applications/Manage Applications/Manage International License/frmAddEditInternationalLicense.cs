using DVLD.Applications.Manage_Applications.Manage_Local_License.License;
using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD.Applications.Manage_Applications.Manage_International_License
{
    public partial class frmAddEditInternationalLicense : Form
    {
        private int _LicenseID;
        clsLicensesB _License;
        clsInternationalLicenseB _InternationalLicense;
        clsApplicationsB _Applications;

        public frmAddEditInternationalLicense()
        {
            InitializeComponent();
            ctrlDriverLicenseWithFilter1.OnLicenseSelected += GetLicenseIDFromCtrl;
        }

        private void frmAddEditInternationalLicense_Load(object sender, EventArgs e)
        {
            lblApplicationDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblIssueDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblExpirationDate.Text = DateTime.Now.AddYears(1).ToString("dd/MM/yyyy");

            lblApplicationFees.Text = clsApplicationTypesB.FindApplicationType(6)._ApplicationTyepsFees.ToString();
            lblCreatedBy.Text = clsLoggedUser.CurrentUser._UserName;

            btnIssue.Enabled = false; 
            llShowNewLicenseInfo.Enabled = false;
        }

        private void GetLicenseIDFromCtrl(int LicenseID)
        {
            _LicenseID = LicenseID;
            _License = clsLicensesB.Find(_LicenseID);

            if (_License != null)
            {
                lblLocalLicenseID.Text = _License.LicenseID.ToString();

                if (IsLicenseExpired())
                {
                    MessageBox.Show("This License is expired.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnIssue.Enabled = false;
                    return;
                }

                if (!IsLicenseActive())
                {
                    MessageBox.Show("This License is not active.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnIssue.Enabled = false;
                    return;
                }

                if (_License.LicenseClassID != 3)
                {
                    MessageBox.Show("International License can only be issued using an ordinary driving license (Class 3).", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnIssue.Enabled = false;
                    return;
                }

                int ActiveInternationalLicenseID = clsInternationalLicenseB.GetActiveInternationalLicenseIDByDriverID(_License.DriverID);

                if (ActiveInternationalLicenseID != -1)
                {
                    MessageBox.Show($"Person already has an active international license with ID = {ActiveInternationalLicenseID}.",
                        "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    _InternationalLicense = clsInternationalLicenseB.Find(ActiveInternationalLicenseID);

                    lblLocalLicenseID.Text = _License.LicenseID.ToString();
                    lblInternationalLicenseID.Text = ActiveInternationalLicenseID.ToString();

                    btnIssue.Enabled = false;
                    llShowNewLicenseInfo.Enabled = true; 
                    return;
                }


                btnIssue.Enabled = true;
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

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (_License == null) return;

            _Applications = new clsApplicationsB();
            _Applications.ApplicantPersonID = _License.DriverInfo.PersonID;
            _Applications.ApplicationDate = DateTime.Now;
            _Applications.ApplicationTypeID = 6; // International Application
            _Applications.ApplicationStatus = 3; // Completed
            _Applications.LastStatusDate = DateTime.Now;
            _Applications.PaidFees = clsApplicationTypesB.FindApplicationType(6)._ApplicationTyepsFees;
            _Applications.CreatedByUserID = clsLoggedUser.CurrentUser._UserID;

            if (_Applications.Save())
            {
                _InternationalLicense = new clsInternationalLicenseB();
                _InternationalLicense.ApplicationID = _Applications.ApplicationID;
                _InternationalLicense.DriverID = _License.DriverID;
                _InternationalLicense.IssuedUsingLocalLicenseID = _License.LicenseID;
                _InternationalLicense.IssueDate = DateTime.Now;
                _InternationalLicense.ExpirationDate = DateTime.Now.AddYears(1);
                _InternationalLicense.IsActive = true;
                _InternationalLicense.CreatedByUserID = clsLoggedUser.CurrentUser._UserID;

                if (_InternationalLicense.Save())
                {
                    MessageBox.Show("International License Issued Successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    lblInternationalApplicationID.Text = _Applications.ApplicationID.ToString();
                    lblInternationalLicenseID.Text = _InternationalLicense.InternationalLicenseID.ToString();

                    llShowNewLicenseInfo.Enabled = true;
                    btnIssue.Enabled = false; 
                    ctrlDriverLicenseWithFilter1.Enabled = false; 
                }
                else
                {
                    MessageBox.Show("Failed to save International License.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error Happened while Saving Application...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_License == null)
            {
                MessageBox.Show("Please select a license first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            frmLicenseHistory frm = new frmLicenseHistory(_License.DriverInfo.PersonID, _License.DriverInfo.DriverID);
            frm.ShowDialog();
        }

        private void llShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_InternationalLicense != null)
            {
                frmShowInternationalLicense frm = new frmShowInternationalLicense(_InternationalLicense.InternationalLicenseID);
                frm.ShowDialog();
            }
        }
    }
}