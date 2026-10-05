using DVLD.Applications.Driving_Licenses_Services;
using DVLD.Applications.Manage_Applications.Manage_Local_License.License;
using DVLD.Applications.Manage_Applications.Tests;
using DVLD.MainScreen;
using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DVLD.Applications.Manage_Applications
{
    public partial class frmManageLocalDrivingLicenseApplication : Form
    {
        public frmManageLocalDrivingLicenseApplication()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private  void _RefreshAllApplications()
        {
            dgvApplications.DataSource = clsApplicationsB.GetListOfAllApplications();
            if (dgvApplications.Columns.Count > 0)
            {
                dgvApplications.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            lblTotalApplicatoins.Text = dgvApplications.Rows.Count.ToString();
        }

        public void ControlWhatToDisableAndWhatToEnableInContextStrip()
        {
            int PassedTest = (int)dgvApplications.CurrentRow.Cells[5].Value;
            string Status = dgvApplications.CurrentRow.Cells[6].Value.ToString();

            updateApplicationToolStripMenuItem.Enabled = true;
            deleteApplicationToolStripMenuItem.Enabled = true;
            cancelApplicationToolStripMenuItem.Enabled = true;
            sechduleTestsToolStripMenuItem.Enabled = true;
            showPersonLicenseHistoryToolStripMenuItem.Enabled = true;

            scheduleVisionTestToolStripMenuItem.Enabled = (PassedTest == 0);
            scheduleWrittenToolStripMenuItem.Enabled = (PassedTest == 1);
            scheduleStreetTestToolStripMenuItem.Enabled = (PassedTest == 2);

            if (PassedTest == 3)
            {
                int localDrivingLicenseApplicationID = (int)dgvApplications.CurrentRow.Cells[0].Value;
                clsLocalDrivingLicenseApplicationB localApp = clsLocalDrivingLicenseApplicationB.FindApplicationUsingLDLID(localDrivingLicenseApplicationID);
                bool licenseExists = localApp != null && clsLicensesB.IsLicenseExistByPersonIDAndLicenseClassID(localApp.ApplicantPersonID, localApp.LicenseClassID);

                updateApplicationToolStripMenuItem.Enabled = !licenseExists;
                deleteApplicationToolStripMenuItem.Enabled = !licenseExists;
                cancelApplicationToolStripMenuItem.Enabled = !licenseExists;
                sechduleTestsToolStripMenuItem.Enabled = !licenseExists;

                issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = !licenseExists;
                showLicenseToolStripMenuItem.Enabled = licenseExists;
            }
            else
            {
                issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
                showLicenseToolStripMenuItem.Enabled = false;
            }

            if (Status == "Cancelled")
            {
                updateApplicationToolStripMenuItem.Enabled = false;
                cancelApplicationToolStripMenuItem.Enabled = false;
                sechduleTestsToolStripMenuItem.Enabled = false;
                issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
                showLicenseToolStripMenuItem.Enabled = false;
            }
        }
        private void frmManageLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            txtFiltering.Visible = false;
            cbFilterBy.SelectedIndex = cbFilterBy.FindString("None");
            _RefreshAllApplications();

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddUpdateLocalDrivingLicenseApplication frm = new frmAddUpdateLocalDrivingLicenseApplication();
            frm.ShowDialog();
            _RefreshAllApplications();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMainScreen mainForm = (frmMainScreen)Application.OpenForms["frmMainScreen"];

            if (mainForm != null)
            {
                mainForm.EmbedForm(new frmManageApplicationChoiceses());
            }
        }

        private bool DeleteApplication(int LDLApplicationID)
        {
            int ApplicationID = clsLocalDrivingLicenseApplicationB.GetApplicationIDByLDLid(LDLApplicationID);
            if(clsLocalDrivingLicenseApplicationB.DeleteApplicationFromLocalLicenseTable(LDLApplicationID))
            {
                if(clsApplicationsB.DeleteApplicationFromApplicationsTable(ApplicationID))
                {
                    return true;
                }else
                {
                    return false;
                }
                   
            }
            return false;
        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this application?", "Confirm Delete",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            int localDrivingLicenseAppID = (int)dgvApplications.CurrentRow.Cells[0].Value;

            if (DeleteApplication(localDrivingLicenseAppID))
            {
                MessageBox.Show("Application deleted successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the grid
               _RefreshAllApplications();
            }
            else
            {
                MessageBox.Show("Could not delete this application. It may have linked appointments or test records.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbFilterBy_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtFiltering_TextChanged(object sender, EventArgs e)
        {

            DataTable dtApplication = (DataTable)dgvApplications.DataSource;

            if (string.IsNullOrWhiteSpace(txtFiltering.Text) || cbFilterBy.Text == "None")
            {
                dtApplication.DefaultView.RowFilter = "";
                return;
            }

            string filterColumn = "";

            switch (cbFilterBy.Text)
            {
                
                case "NationalNo":
                    filterColumn = "NationalNo";
                    break;
                case "Full Name":
                    filterColumn = "FullName";
                    break;
                case "Status":
                    filterColumn = "Status";
                    break;
                default:
                    filterColumn = "None";
                    break;
            }

            if (filterColumn == "None")
            {
                dtApplication.DefaultView.RowFilter = "";
                return;
            }
                dtApplication.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterColumn, txtFiltering.Text.Trim());
            
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFiltering.Text = "";
            txtFiltering.Focus();

            if (cbFilterBy.Text == "None")
                txtFiltering.Visible = false;
            else
                txtFiltering.Visible = true;
        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Cancel this application?", "Confirm Delete",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            int localDrivingLicenseAppID = (int)dgvApplications.CurrentRow.Cells[0].Value;
            int ApplicationID = clsLocalDrivingLicenseApplicationB.GetApplicationIDByLDLid(localDrivingLicenseAppID);

            if (clsApplicationsB.CancelApplication(ApplicationID))
            {
                MessageBox.Show("Application Caneled successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the grid
                _RefreshAllApplications();
            }
            else
            {
                MessageBox.Show("Could not Cancel this application.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PassedTest = (int)dgvApplications.CurrentRow.Cells[5].Value;

            if(PassedTest>0)
            {
                    MessageBox.Show("Could not Edit on this Application Cause you are already Take Test on this Class.",
                    "Not Allowed!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else {
                     int LDLID = (int)dgvApplications.CurrentRow.Cells[0].Value;
                     frmAddUpdateLocalDrivingLicenseApplication frm = new frmAddUpdateLocalDrivingLicenseApplication(LDLID);
                     frm.ShowDialog();
                     _RefreshAllApplications();
            }
        }

        private void applicationINfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDLID = (int)dgvApplications.CurrentRow.Cells[0].Value;
            int PassedTest = (int)dgvApplications.CurrentRow.Cells[5].Value;

            frmApplicationDetails frm = new frmApplicationDetails(LDLID , PassedTest);
            frm.ShowDialog();

        }

        private void scheduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDLID = (int)dgvApplications.CurrentRow.Cells[0].Value;
            int PassedTest = (int)dgvApplications.CurrentRow.Cells[5].Value;

            frmTestTypeAppointments frm = new frmTestTypeAppointments(LDLID ,1 , PassedTest);
            frm.ShowDialog();
            _RefreshAllApplications();


        }

        private void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDLID = (int)dgvApplications.CurrentRow.Cells[0].Value;
            int PassedTest = (int)dgvApplications.CurrentRow.Cells[5].Value;

            frmTestTypeAppointments frm = new frmTestTypeAppointments(LDLID, 2 , PassedTest);
            frm.ShowDialog();
            _RefreshAllApplications();

        }

        private void scheduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDLID = (int)dgvApplications.CurrentRow.Cells[0].Value;
            int PassedTest = (int)dgvApplications.CurrentRow.Cells[5].Value;

            frmTestTypeAppointments frm = new frmTestTypeAppointments(LDLID, 3 , PassedTest);
            frm.ShowDialog();
            _RefreshAllApplications();

        }

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            ControlWhatToDisableAndWhatToEnableInContextStrip();

        }

        private void issueDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDLID = (int)dgvApplications.CurrentRow.Cells[0].Value;
            int PassedTest = (int)dgvApplications.CurrentRow.Cells[5].Value;

            frmIssueLicense frm = new frmIssueLicense(LDLID,  PassedTest);
            frm.ShowDialog();
            _RefreshAllApplications();

        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDLID = (int)dgvApplications.CurrentRow.Cells[0].Value;

            clsLocalDrivingLicenseApplicationB LocalLicense = clsLocalDrivingLicenseApplicationB.FindApplicationUsingLDLID(LDLID);

            if (LocalLicense != null)
            {
                int LicenseID = clsLicensesB.GetLicenseIDbyApplicationID(LocalLicense.ApplicationID);

                if (LicenseID != -1)
                {
                    frmShowLicense frm = new frmShowLicense(LicenseID);
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No license has been issued for this application yet.", "Not Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDLID = (int)dgvApplications.CurrentRow.Cells[0].Value;

            clsLocalDrivingLicenseApplicationB LocalLicense = clsLocalDrivingLicenseApplicationB.FindApplicationUsingLDLID(LDLID);

            if(clsDriversB.IsPersonDriver(LocalLicense.ApplicantPersonID))
            {
                int DriverID = clsDriversB.GetDriverIDbyPersonID(LocalLicense.ApplicantPersonID);
                frmLicenseHistory frm =
                new frmLicenseHistory(LocalLicense.ApplicantPersonID , DriverID);
                frm.ShowDialog();
            }

             
        }
    }
}
