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
    public partial class frmReleaseDetainedLicense : Form
    {
        private int _LicenseID = -1;
        private clsLicensesB _License;
        private clsDetainedLicensesB _DetainedLicense;

        public frmReleaseDetainedLicense()
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
                btnRelease.Enabled = false;
                return;
            }

            if (!_License.IsActive)
            {
                MessageBox.Show("Selected license is not active, choose an active license.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRelease.Enabled = false;
                return;
            }

            if (_License.ExpirationDate < DateTime.Now)
            {
                MessageBox.Show("Selected license is expired. You must renew it first.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRelease.Enabled = false;
                return;
            }

            if (!clsDetainedLicensesB.IsLicenseDetained(_LicenseID))
            {
                MessageBox.Show("Selected license is not Detained.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRelease.Enabled = false;
                return;
            }

            btnRelease.Enabled = true;
            _LoadFirstData();
        }

        private void _LoadFirstData()
        {
            _DetainedLicense = clsDetainedLicensesB.FindByLicenseID(_LicenseID);

            lblDetainID.Text = _DetainedLicense.DetainID.ToString();
            lblDetainDate.Text = _DetainedLicense.DetainDate.ToString("dd/MM/yyyy");

            clsApplicationTypesB AppType = clsApplicationTypesB.FindApplicationType(5); // Application Type ID for release detained licenses
            lblApplicationFees.Text = AppType._ApplicationTyepsFees.ToString();
            lblFineFees.Text = _DetainedLicense.FineFees.ToString();
            lblLicenseID.Text = _License.LicenseID.ToString();
            lblCreatedBy.Text = clsLoggedUser.CurrentUser._UserName;

            lblTotalFees.Text = (Convert.ToDecimal(lblFineFees.Text) + Convert.ToDecimal(lblApplicationFees.Text)).ToString();
        }

        private void frmReleaseDetainedLicense_Load(object sender, EventArgs e)
        {
            btnRelease.Enabled = false;
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

        private void btnRelease_Click(object sender, EventArgs e)
        {
            if (_License == null)
                return;

            if (!clsDetainedLicensesB.IsLicenseDetained(_LicenseID))
            {
                MessageBox.Show("Selected license is not Detained.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRelease.Enabled = false;
                return;
            }

            if (MessageBox.Show("Are you sure you want to release this license?", "Confirm Release", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            {
                return;
            }

            clsApplicationsB Application = new clsApplicationsB();

            Application.ApplicantPersonID = _License.DriverInfo.PersonID;
            Application.ApplicationDate = DateTime.Now;
            Application.ApplicationTypeID = 5; 

            Application.ApplicationStatus = 3;

            Application.LastStatusDate = DateTime.Now;
            Application.PaidFees = Convert.ToSingle(lblApplicationFees.Text);
            Application.CreatedByUserID = clsLoggedUser.CurrentUser._UserID;

            if (!Application.Save())
            {
                MessageBox.Show("Failed to create the application. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isReleased = _DetainedLicense.ReleaseDetainedLicense(clsLoggedUser.CurrentUser._UserID, Application.ApplicationID);

            if (isReleased)
            {
                MessageBox.Show("License Released Successfully.", "Released", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnRelease.Enabled = false;
                ctrlDriverLicenseWithFilter1.Enabled = false;
            }
            else
            {
                MessageBox.Show("Application created but failed to release the license.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}