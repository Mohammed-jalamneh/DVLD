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
using System.IO;


namespace DVLD.Applications.Manage_Applications.Manage_International_License
{
    public partial class frmShowInternationalLicense : Form
    {
        private int _InternationalLicenseID;
        clsInternationalLicenseB _InternationalLicense;
        public frmShowInternationalLicense(int InternationalLicenseID)
        {
            InitializeComponent();
            _InternationalLicenseID = InternationalLicenseID;
        
        }

        private void _LoadPersonImage()
        {
            if (_InternationalLicense.LicenseInfo.DriverInfo.PersonInfo.Gendor == 0)
                pbPersonImage.Image = Properties.Resources.unkownPerson;
            else
                pbPersonImage.Image = Properties.Resources.unknownWoman;

            string imagePath = _InternationalLicense.LicenseInfo.DriverInfo.PersonInfo.ImagePath;

            if (imagePath != "" && File.Exists(imagePath))
            {
                pbPersonImage.Load(imagePath);
            }
        }

        private void _LoadInfo()
        {
            if (_InternationalLicense == null)
            {
                MessageBox.Show("Could not find International License ID = " + _InternationalLicense.LicenseInfo.LicenseID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _InternationalLicense.LicenseInfo.LicenseID = -1;
                return;
            }

            lblInternationLicenseID.Text = _InternationalLicense.InternationalLicenseID.ToString();
            lblLicenseClass.Text = _InternationalLicense.LicenseInfo.LicenseClassInfo.ClassName;
            lblApplicantName.Text = _InternationalLicense.LicenseInfo.DriverInfo.PersonInfo.FullName;
            lblNationalNo.Text = _InternationalLicense.LicenseInfo.DriverInfo.PersonInfo.NationalID;
            lblGender.Text = _InternationalLicense.LicenseInfo.DriverInfo.PersonInfo.Gendor == 0 ? "Male" : "Female";
            lblIssueDate.Text = _InternationalLicense.IssueDate.ToShortDateString();
            lblExpirationDate.Text = _InternationalLicense.ExpirationDate.ToShortDateString();
            lblDateOfBirth.Text = _InternationalLicense.LicenseInfo.DriverInfo.PersonInfo.DateOfBirth.ToShortDateString();
            lblIsActive.Text = _InternationalLicense.IsActive ? "Yes" : "No";


            _LoadPersonImage();
        }

        private void frmShowInternationalLicense_Load(object sender, EventArgs e)
        {
            _InternationalLicense = clsInternationalLicenseB.Find(_InternationalLicenseID);
            _LoadInfo();
        }
    }
}
