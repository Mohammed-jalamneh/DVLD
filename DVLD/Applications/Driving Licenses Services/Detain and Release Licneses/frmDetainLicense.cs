using DVLD.Applications.Manage_Applications.Manage_Local_License.License;
using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Applications.Driving_Licenses_Services.Released_Detained_Licneses
{
    public partial class frmDetainLicense : Form
    {
        private int _LicenseID = -1;
        private clsLicensesB _License;
        private clsDetainedLicensesB _DetainedLicense;

        public frmDetainLicense()
        {
            InitializeComponent();
            ctrlDriverLicenseWithFilter1.OnLicenseSelected += GetLicenseIDFromCtrl;
        }

        private void GetLicenseIDFromCtrl(int LicenseID)
        {
            _LicenseID = LicenseID;
            _License = clsLicensesB.Find(_LicenseID);

            if (_License == null)
            {
                btnDetain.Enabled = false;
                return;
            }

            if (!_License.IsActive)
            {
                MessageBox.Show("Selected license is not active, choose an active license.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnDetain.Enabled = false;
                return;
            }

            if (_License.ExpirationDate < DateTime.Now)
            {
                MessageBox.Show("Selected license is expired. You must renew it first.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnDetain.Enabled = false;
                return;
            }

            if (clsDetainedLicensesB.IsLicenseDetained(_LicenseID))
            {
                MessageBox.Show("Selected license is already Detained.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnDetain.Enabled = false;
                return; 
            }

            btnDetain.Enabled = true;
            _LoadFirstData();
        }

        private void _LoadFirstData()
        {
            lblDetainDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblLicenseID.Text = _License.LicenseID.ToString();
            lblCreatedBy.Text = clsLoggedUser.CurrentUser._UserName;
        }

        private void frmDetainLicense_Load(object sender, EventArgs e)
        {
            btnDetain.Enabled = false;
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            if (_License == null)
                return;

            if (string.IsNullOrWhiteSpace(txtFineFees.Text))
            {
                MessageBox.Show("Please enter Fine Fees Value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFineFees.Focus();
                return;
            }

            if (!decimal.TryParse(txtFineFees.Text.Trim(), out decimal fineFees) || fineFees < 0)
            {
                MessageBox.Show("Please enter a valid numeric value for Fine Fees.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFineFees.Focus();
                return;
            }

            if (clsDetainedLicensesB.IsLicenseDetained(_LicenseID))
            {
                MessageBox.Show("Selected license is already Detained.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnDetain.Enabled = false;
                return;
            }

            if (MessageBox.Show("Are you sure you want to detain this license?", "Confirm Detain", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            {
                return;
            }

            _DetainedLicense = new clsDetainedLicensesB
            {
                LicenseID = _License.LicenseID,
                DetainDate = DateTime.Now,
                FineFees = fineFees,
                CreatedByUserID = clsLoggedUser.CurrentUser._UserID,
                IsReleased = false,
                ReleaseDate = null,
                ReleasedByUserID = null,
                ReleaseApplicationID = null
            };

            if (_DetainedLicense.Save())
            {
                lblDetainID.Text = _DetainedLicense.DetainID.ToString();
                MessageBox.Show($"License Detained Successfully with ID = {_DetainedLicense.DetainID}.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnDetain.Enabled = false;
                txtFineFees.Enabled = false;
                ctrlDriverLicenseWithFilter1.Enabled = false;
            }
            else
            {
                MessageBox.Show("Failed to detain license. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicense frm = new frmShowLicense(_LicenseID);
            frm.ShowDialog();
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistory frm = new frmLicenseHistory(_License.DriverInfo.PersonID, _License.DriverInfo.DriverID);
            frm.ShowDialog();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}