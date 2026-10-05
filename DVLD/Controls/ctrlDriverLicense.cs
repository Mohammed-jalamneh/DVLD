using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DVLD_Business;

namespace DVLD.Controls
{
    public partial class ctrlDriverLicense : UserControl
    {
        private int _LicenseID;
        clsLicensesB _License;
        public ctrlDriverLicense()
        {
            InitializeComponent();
        }

        public int LicenseID { get { return _LicenseID; } }

        private void _LoadPersonImage()
        {
            if (_License.DriverInfo.PersonInfo.Gendor == 0)
                pbPersonImage.Image = Properties.Resources.unkownPerson;
            else
                pbPersonImage.Image = Properties.Resources.unknownWoman;

            string imagePath = _License.DriverInfo.PersonInfo.ImagePath;

            if (imagePath != "" && File.Exists(imagePath))
            {
                pbPersonImage.Load(imagePath);
            }
        }

        public void LoadInfo(int LicenseID)
        {
           
            _License = clsLicensesB.Find(LicenseID);

            if (_License == null)
            {
                MessageBox.Show("Could not find License ID = " + LicenseID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LicenseID = -1;
                return;
            }

            _LicenseID = _License.LicenseID;

            lblLicenseClass.Text = _License.LicenseClassInfo.ClassName;
            lblApplicantName.Text = _License.DriverInfo.PersonInfo.FullName;
            lblNationalNo.Text = _License.DriverInfo.PersonInfo.NationalID;
            lblGender.Text = _License.DriverInfo.PersonInfo.Gendor == 0 ? "Male" : "Female";
            lblIssueDate.Text = _License.IssueDate.ToShortDateString();
            lblExpirationDate.Text = _License.ExpirationDate.ToShortDateString();

            if (_License.IssueReason == 1)
            {
                lblIssueReason.Text = "First Time";
            }
            else if (_License.IssueReason == 2)
            {
                lblIssueReason.Text = "Renew";
            }
            else if (_License.IssueReason == 3)
            {
                lblIssueReason.Text = "Replacement for Damaged";
            }
            else if (_License.IssueReason == 4)
            {
                lblIssueReason.Text = "Replacement for Lost";
            }
            lblDateOfBirth.Text = _License.DriverInfo.PersonInfo.DateOfBirth.ToShortDateString();
            lblIsActive.Text = _License.IsActive ? "Yes" : "No";

            lblIsDetained.Text = clsDetainedLicensesB.IsLicenseDetained(_LicenseID) ? "Yes" : "No";
           
            _LoadPersonImage();
        }

        private void guna2ShadowPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
