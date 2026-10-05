using DVLD.Applications.Manage_Applications.Manage_International_License;
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
    public partial class frmLicenseHistory : Form
    {
        private int _PersonID , _DriverID;
        public frmLicenseHistory(int PersonID ,int DriverID)
        {
            _PersonID = PersonID;
            _DriverID = DriverID;
            InitializeComponent();
        }

        private void _RefreshLocalLicensesData()
        {
            dgvLicensesHistory.DataSource = clsLicensesB.GetAllLicensesByDriverID(_DriverID);
            lblLocalLicensesTotalCount.Text = dgvLicensesHistory.Rows.Count.ToString();

            if (dgvLicensesHistory.Columns.Count > 0)
            {
                dgvLicensesHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
           
        }

        private void _RefreshInternationalLicensesData()
        {
            dgvInternationalLicenses.DataSource = clsInternationalLicenseB.GetDriverInternationalLicenses(_DriverID);
            lblInternationalLicensesTotalCount.Text = dgvInternationalLicenses.Rows.Count.ToString();

            if (dgvInternationalLicenses.Columns.Count > 0)
            {
                dgvInternationalLicenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

        }

        private void LoadDataToControl()
        {
            ctrlPersonCardWithFilter1.LoadPersonDefInfo(_PersonID);
            ctrlPersonCardWithFilter1.Enabled = false;
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvLicensesHistory.CurrentRow.Cells[0].Value;
            frmShowLicense frm = new frmShowLicense(LicenseID);
            frm.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int IntrnationalLicenseID = (int)dgvInternationalLicenses.CurrentRow.Cells[0].Value;
            frmShowInternationalLicense frm = new frmShowInternationalLicense(IntrnationalLicenseID);
            frm.ShowDialog();
        }

        private void frmLicenseHistory_Load(object sender, EventArgs e)
        {
            _RefreshLocalLicensesData();
            _RefreshInternationalLicensesData();
            LoadDataToControl();
        }
    }
}
