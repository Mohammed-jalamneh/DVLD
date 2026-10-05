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

namespace DVLD.Applications.Manage_Applications.Manage_Local_License.License
{
    public partial class frmIssueLicense : Form
    {
        private int _LDLID;
        private int _PassedTest;
        clsLicensesB License;
        clsDriversB Driver;

        enum enIssueReason : byte {FirstTime =1 , Renew , ReplacmentForDamaged , ReplacementForaLost }
        
        public frmIssueLicense(int LDLID , int PassedTest)
        {
            _LDLID = LDLID;
            _PassedTest = PassedTest;

            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmIssueLicense_Load(object sender, EventArgs e)
        {
            ctrlLocalLicenseAndBaseApplication1.LoadApplicationData(_LDLID, _PassedTest);

        }

        private void LoadDataToLicense()
        {
            License = new clsLicensesB();
            License.ApplicationID = ctrlLocalLicenseAndBaseApplication1.LocalLicense.ApplicationID;
            License.DriverID = Driver.DriverID;
            int LicenseClassID = ctrlLocalLicenseAndBaseApplication1.LocalLicense.LicenseClassID;
            License.LicenseClassID = LicenseClassID;
            License.IssueDate = DateTime.Now;

            clsLicenseClassesB LicenseClass =clsLicenseClassesB.Find(LicenseClassID);
            License.ExpirationDate = DateTime.Now.AddYears(LicenseClass.DefaultValidityLength);

            License.Notes = txtNotes.Text;
            License.PaidFees = LicenseClass.ClassFees;
            License.IsActive = true;
            License.IssueReason =(byte)enIssueReason.FirstTime;
            License.CreatedByUserID = clsLoggedUser.CurrentUser._UserID;
            

        }

        private void AddDriverToSystem()
        {
             Driver = new clsDriversB();
            Driver.PersonID = ctrlLocalLicenseAndBaseApplication1.LocalLicense.ApplicantPersonID;
            Driver.CreatedDate = DateTime.Now;
            Driver.CreatedByUserID = clsLoggedUser.CurrentUser._UserID;

            if(!Driver.Save())
            {
                MessageBox.Show("Cant Add Person To Drivers.", "Save Fail", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            

            int LicenseClassID = ctrlLocalLicenseAndBaseApplication1.LocalLicense.LicenseClassID;
            int PersonID = ctrlLocalLicenseAndBaseApplication1.LocalLicense.ApplicantPersonID;

            if (clsLicensesB.IsLicenseExistByPersonIDAndLicenseClassID(PersonID, LicenseClassID))
            {
                MessageBox.Show("This person already has an active license for this class. Cannot issue duplicate license.",
                    "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssue.Enabled = false;
                txtNotes.Enabled = false;
                return; 
            }

            if (!clsDriversB.IsPersonDriver(PersonID))
            {
                AddDriverToSystem();
            }
            else
            {
                Driver = clsDriversB.FindByPersonID(PersonID);
            }

            if (Driver == null || Driver.DriverID == -1)
            {
                MessageBox.Show("Error finding or creating driver.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            LoadDataToLicense();

            if (License.Save())
            {
                clsLocalDrivingLicenseApplicationB localApp = ctrlLocalLicenseAndBaseApplication1.LocalLicense;

                localApp.ApplicationStatus = 3; 
                localApp.Save(); 

                MessageBox.Show("License Issued Successfully!", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnIssue.Enabled = false;
            }
            else
            {
                MessageBox.Show("License Does Not Add Successfully.", "Save Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!clsDriversB.IsPersonDriver(ctrlLocalLicenseAndBaseApplication1.LocalLicense.ApplicantPersonID))
            {
                Driver = new clsDriversB();
                Driver.PersonID = ctrlLocalLicenseAndBaseApplication1.LocalLicense.ApplicantPersonID;
                Driver.CreatedByUserID = clsLoggedUser.CurrentUser._UserID;
                Driver.CreatedDate = DateTime.Now;

                if(Driver != null)
                {
                    if(!Driver.Save())
                    {
                        MessageBox.Show("Does Not Accepted As a Driver!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
    }
}
