using DVLD.Applications.Manage_Applications;
using DVLD.Applications.Manage_Applications.Manage_Local_License.License;
using DVLD.MainScreen;
using DVLD_Business;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace DVLD.Applications.Driving_Licenses_Services.Released_Detained_Licneses
{
    public partial class frmManageDetainedLicneses : Form
    {
        private DataTable _dtDetainedLicenses;
        private clsLicensesB _License;

        public frmManageDetainedLicneses()
        {
            InitializeComponent();
        }

        private void frmManageDetainedLicneses_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0; // Initialize ComboBox to "None"
            _RefreshAllData();
        }

        private void _RefreshAllData()
        {
            _dtDetainedLicenses = clsDetainedLicensesB.GetAllDetainedLicenses();
            dgvDetainedLicenses.DataSource = _dtDetainedLicenses;

            if (dgvDetainedLicenses.Rows.Count > 0)
            {
                dgvDetainedLicenses.Columns[0].HeaderText = "D.ID";
                dgvDetainedLicenses.Columns[0].Width = 90;

                dgvDetainedLicenses.Columns[1].HeaderText = "L.ID";
                dgvDetainedLicenses.Columns[1].Width = 90;

                dgvDetainedLicenses.Columns[2].HeaderText = "D.Date";
                dgvDetainedLicenses.Columns[2].Width = 150;

                dgvDetainedLicenses.Columns[3].HeaderText = "Is Released";
                dgvDetainedLicenses.Columns[3].Width = 100;

                dgvDetainedLicenses.Columns[4].HeaderText = "Fine Fees";
                dgvDetainedLicenses.Columns[4].Width = 110;

                dgvDetainedLicenses.Columns[5].HeaderText = "Release Date";
                dgvDetainedLicenses.Columns[5].Width = 150;

                dgvDetainedLicenses.Columns[6].HeaderText = "N.No.";
                dgvDetainedLicenses.Columns[6].Width = 90;

                dgvDetainedLicenses.Columns[7].HeaderText = "Full Name";
                dgvDetainedLicenses.Columns[7].Width = 300;

                dgvDetainedLicenses.Columns[8].HeaderText = "Release App.ID";
                dgvDetainedLicenses.Columns[8].Width = 120;
            }

            lblTotalCount.Text = dgvDetainedLicenses.Rows.Count.ToString();
        }

        private void txtFiltering_TextChanged(object sender, EventArgs e)
        {
            if (_dtDetainedLicenses == null || _dtDetainedLicenses.Rows.Count == 0)
                return;

            if (string.IsNullOrWhiteSpace(txtFiltering.Text) || cbFilterBy.Text == "None")
            {
                _dtDetainedLicenses.DefaultView.RowFilter = "";
                return;
            }

            string filterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "Detain ID":
                    filterColumn = "DetainID"; 
                    break;
                case "Is Released":
                    filterColumn = "IsReleased";
                    break;
                case "National No.":
                    filterColumn = "NationalNo";
                    break;
                case "Full Name":
                    filterColumn = "FullName";
                    break;
                case "Release Application ID":
                    filterColumn = "ReleaseApplicationID";
                    break;
                default:
                    filterColumn = "None";
                    break;
            }

            if (filterColumn == "None")
            {
                _dtDetainedLicenses.DefaultView.RowFilter = "";
                return;
            }

            if (filterColumn == "DetainID" || filterColumn == "ReleaseApplicationID" || filterColumn == "IsReleased")
            {
                _dtDetainedLicenses.DefaultView.RowFilter = string.Format("CONVERT([{0}], 'System.String') LIKE '{1}%'", filterColumn, txtFiltering.Text.Trim());
            }
            else
            {
                _dtDetainedLicenses.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterColumn, txtFiltering.Text.Trim());
            }
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMainScreen mainForm = (frmMainScreen)Application.OpenForms["frmMainScreen"];

            if (mainForm != null)
            {
                mainForm.EmbedForm(new frmServicesDashboard());
            }
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            frmDetainLicense frm = new frmDetainLicense();
            frm.ShowDialog();
            _RefreshAllData();
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense();
            frm.ShowDialog();
            _RefreshAllData();
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDetainedLicenses.CurrentRow == null) return;

            int licenseID = (int)dgvDetainedLicenses.CurrentRow.Cells[1].Value;
            _License = clsLicensesB.Find(licenseID);

            if (_License != null)
            {
                frmPersonCard frm = new frmPersonCard(_License.DriverInfo.PersonID);
                frm.ShowDialog();
            }
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDetainedLicenses.CurrentRow == null) return;

            int licenseID = (int)dgvDetainedLicenses.CurrentRow.Cells[1].Value;

            frmShowLicense frm = new frmShowLicense(licenseID);
            frm.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDetainedLicenses.CurrentRow == null) return;

            int licenseID = (int)dgvDetainedLicenses.CurrentRow.Cells[1].Value;
            _License = clsLicensesB.Find(licenseID);

            if (_License != null)
            {
                frmLicenseHistory frm = new frmLicenseHistory(_License.DriverInfo.PersonID, _License.DriverInfo.DriverID);
                frm.ShowDialog();
            }
        }

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dgvDetainedLicenses.Rows.Count == 0 || dgvDetainedLicenses.CurrentRow == null)
            {
                e.Cancel = true;
                return;
            }

            bool isReleased = Convert.ToBoolean(dgvDetainedLicenses.CurrentRow.Cells[3].Value);
            releaseDetainedLicenseToolStripMenuItem.Enabled = !isReleased;
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDetainedLicenses.CurrentRow == null) return;

            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense();
            frm.ShowDialog();
            _RefreshAllData();
        }
    }
}