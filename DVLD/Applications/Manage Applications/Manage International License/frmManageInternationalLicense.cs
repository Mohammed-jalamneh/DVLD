using DVLD.Applications.Manage_Applications.Manage_Local_License.License;
using DVLD.MainScreen;
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

namespace DVLD.Applications.Manage_Applications.Manage_International_License
{
    public partial class frmManageInternationalLicense : Form
    {
        clsDriversB Driver;

        public frmManageInternationalLicense()
        {
            InitializeComponent();
        }

        private void _RefreshAllData()
        {
            dgvInternational.DataSource = clsInternationalLicenseB.GetAllInternationalLicenses();
            if (dgvInternational.Columns.Count > 0)
            {
                dgvInternational.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            lblTotalApplicatoins.Text = dgvInternational.Rows.Count.ToString();
        }
        private void frmManageInternationalLicense_Load(object sender, EventArgs e)
        {
            cbIsActive.Visible = false;
            cbFilterBy.SelectedIndex = 0;
            _RefreshAllData();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMainScreen mainForm = (frmMainScreen)Application.OpenForms["frmMainScreen"];

            if (mainForm != null)
            {
                mainForm.EmbedForm(new frmManageApplicationChoiceses());
            }
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.Text == "IsActive")
            {
                txtFiltering.Visible = false;
                cbIsActive.Visible = true;
                cbIsActive.SelectedIndex = 0; 
            }
            else
            {
                txtFiltering.Visible = (cbFilterBy.Text != "None");
                cbIsActive.Visible = false;

                txtFiltering.Text = "";
                txtFiltering.Focus();
            }
        }

        private void txtFiltering_TextChanged(object sender, EventArgs e)
        {
            DataTable dtInternational = (DataTable)dgvInternational.DataSource;

            if (string.IsNullOrWhiteSpace(txtFiltering.Text) || cbFilterBy.Text == "None")
            {
                dtInternational.DefaultView.RowFilter = "";
                return;
            }

            string filterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "DriverID":
                    filterColumn = "DriverID";
                    break;
                default:
                    filterColumn = "None";
                    break;
            }

            if (filterColumn == "None")
            {
                dtInternational.DefaultView.RowFilter = "";
                return;
            }

            // We only need the DriverID logic here now!
            if (filterColumn == "DriverID")
            {
                dtInternational.DefaultView.RowFilter = string.Format("CONVERT([{0}], 'System.String') LIKE '{1}%'", filterColumn, txtFiltering.Text.Trim());
            }
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DriverID = (int)dgvInternational.CurrentRow.Cells[2].Value;
            Driver = clsDriversB.FindByDriverID(DriverID);
            frmPersonCard frm = new frmPersonCard(Driver.PersonID);
            frm.ShowDialog();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int InternationalLicenseID = (int)dgvInternational.CurrentRow.Cells[0].Value;
            frmShowInternationalLicense frm = new frmShowInternationalLicense(InternationalLicenseID);
            frm.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DriverID = (int)dgvInternational.CurrentRow.Cells[2].Value;
            Driver = clsDriversB.FindByDriverID(DriverID);

            frmLicenseHistory frm = new frmLicenseHistory(Driver.PersonID , DriverID);
            frm.ShowDialog();

        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filterColumn = "IsActive";
            string filterValue = cbIsActive.Text;
            DataTable dtInternational = (DataTable)dgvInternational.DataSource;

            if (filterValue == "All")
            {
                dtInternational.DefaultView.RowFilter = "";
                return;
            }

            if (filterValue == "Yes")
            {
                dtInternational.DefaultView.RowFilter = string.Format("[{0}] = 1", filterColumn);
            }
            else if (filterValue == "No")
            {
                dtInternational.DefaultView.RowFilter = string.Format("[{0}] = 0", filterColumn);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddEditInternationalLicense frm = new frmAddEditInternationalLicense();
            frm.ShowDialog();
            _RefreshAllData();
        }
    }
}
