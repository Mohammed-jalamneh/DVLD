using DVLD.Applications.Manage_Applications.Manage_Local_License.License;
using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD.Applications.Driving_Licenses_Services.Damaged_or_Lost_License_Replacment
{
    public partial class frmDamagedOrLostLicenseReplacement : Form
    {
        public enum enApplicationType
        {
            ReplaceLostDrivingLicense = 3,
            ReplaceDamagedDrivingLicense = 4
        }

        public enum enIssueReason
        {
            FirstTime = 1,
            Renew = 2,
            ReplacementForDamaged = 3,
            ReplacementForLost = 4
        }

        private int _LicenseID = -1;
        private clsLicensesB _License;
        private clsApplicationsB _NewApplication;
        private clsLicensesB _NewLicense;

        public frmDamagedOrLostLicenseReplacement()
        {
            InitializeComponent();
            ctrlDriverLicenseWithFilter1.OnLicenseSelected += GetLicenseIDFromCtrl;
        }

        private enApplicationType _GetApplicationType()
        {
            return rbDamagedLicense.Checked
                ? enApplicationType.ReplaceDamagedDrivingLicense
                : enApplicationType.ReplaceLostDrivingLicense;
        }

        private enIssueReason _GetIssueReason()
        {
            return rbDamagedLicense.Checked
                ? enIssueReason.ReplacementForDamaged
                : enIssueReason.ReplacementForLost;
        }

        private void _LoadInitialData()
        {
            lblApplicationDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblCreatedBy.Text = clsLoggedUser.CurrentUser._UserName;
            lblApplicationFees.Text = clsApplicationTypesB.FindApplicationType((int)_GetApplicationType())._ApplicationTyepsFees.ToString();
        }

        private void frmDamagedOrLostLicenseReplacement_Load(object sender, EventArgs e)
        {
            rbDamagedLicense.Checked = true;
            _LoadInitialData();

            btnIssueReplacement.Enabled = false;
            llShowReplacementLicenseInfo.Enabled = false;
        }

        private void rbDamagedLicense_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDamagedLicense.Checked)
            {
                
                lblTitle.Text = "Replacement for Damaged License";
                lblApplicationFees.Text = clsApplicationTypesB.FindApplicationType((int)_GetApplicationType())._ApplicationTyepsFees.ToString();
            }
        }

        private void rbLostLicense_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLostLicense.Checked)
            {
                lblTitle.Text = "Replacement for Lost License";
                lblApplicationFees.Text = clsApplicationTypesB.FindApplicationType((int)_GetApplicationType())._ApplicationTyepsFees.ToString();
            }
        }

        private void GetLicenseIDFromCtrl(int LicenseID)
        {
            _LicenseID = LicenseID;
            _License = clsLicensesB.Find(_LicenseID);

            if (_License == null)
            {
                btnIssueReplacement.Enabled = false;
                return;
            }

            lblOldLicenseID.Text = _License.LicenseID.ToString();

            if (!_License.IsActive)
            {
                MessageBox.Show("Selected license is not active, choose an active license.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssueReplacement.Enabled = false;
                return;
            }

            if (_License.ExpirationDate < DateTime.Now)
            {
                MessageBox.Show("Selected license is expired. You must renew it instead of replacing it.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssueReplacement.Enabled = false;
                return;
            }

            btnIssueReplacement.Enabled = true;
        }

        private bool _CreateReplacementApplication()
        {
            enApplicationType appType = _GetApplicationType();

            _NewApplication = new clsApplicationsB
            {
                ApplicantPersonID = _License.DriverInfo.PersonID,
                ApplicationDate = DateTime.Now,
                ApplicationTypeID = (int)appType,
                ApplicationStatus = 3, 
                LastStatusDate = DateTime.Now,
                PaidFees = clsApplicationTypesB.FindApplicationType((int)appType)._ApplicationTyepsFees,
                CreatedByUserID = clsLoggedUser.CurrentUser._UserID
            };

            return _NewApplication.Save();
        }

        private bool _CreateReplacementLicense()
        {
            _NewLicense = new clsLicensesB
            {
                ApplicationID = _NewApplication.ApplicationID,
                DriverID = _License.DriverID,
                LicenseClassID = _License.LicenseClassID,
                IssueDate = _License.IssueDate,
                ExpirationDate = _License.ExpirationDate,
                Notes = _License.Notes,
                PaidFees = 0,
                IsActive = true,
                IssueReason = (byte)_GetIssueReason(),
                CreatedByUserID = clsLoggedUser.CurrentUser._UserID
            };

            return _NewLicense.Save();
        }

        private void btnIssueReplacement_Click(object sender, EventArgs e)
        {
            if (_License == null) return;

            if (MessageBox.Show("Are you sure you want to issue a replacement for this license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (!_CreateReplacementApplication())
            {
                MessageBox.Show("Failed to create application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_CreateReplacementLicense())
            {
                MessageBox.Show("Failed to create replacement license.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _License.IsActive = false;
            _License.Save();

            lblReplacementApplicationID.Text = _NewApplication.ApplicationID.ToString();
            lblReplacedLicenseID.Text = _NewLicense.LicenseID.ToString();

            MessageBox.Show($"License Replaced Successfully with ID = {_NewLicense.LicenseID}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ctrlDriverLicenseWithFilter1.Enabled = false;
            rbDamagedLicense.Enabled = false;
            rbLostLicense.Enabled = false;
            btnIssueReplacement.Enabled = false;
            llShowReplacementLicenseInfo.Enabled = true;
        }

        private void llShowReplacementLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_NewLicense != null)
            {
                frmShowLicense frm = new frmShowLicense(_NewLicense.LicenseID);
                frm.ShowDialog();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}