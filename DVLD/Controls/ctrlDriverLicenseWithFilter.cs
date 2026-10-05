using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Controls
{
    public partial class ctrlDriverLicenseWithFilter : UserControl
    {
        public event Action<int> OnLicenseSelected;

        protected virtual void LicenseSelected(int LicenseID)
        {
            Action<int> handler = OnLicenseSelected;
            if(handler != null)
            {
                handler(LicenseID);
            }
        }
        public ctrlDriverLicenseWithFilter()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtLicenseID.Text == null)
            {
                MessageBox.Show("LicenseID Required.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int LicenseID;

            if (int.TryParse(txtLicenseID.Text, out LicenseID))
            {
                ctrlDriverLicense1.LoadInfo(LicenseID);
                OnLicenseSelected(LicenseID);
            }
            else
            {
                MessageBox.Show("Invalid number format.");
            }



        }

        private void ctrlDriverLicenseWithFilter_Load(object sender, EventArgs e)
        {
            txtLicenseID.Focus();
        }

        private void txtLicenseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            if (e.KeyChar == (char)13)
            {
                btnSearch.PerformClick();
            }
        }
    }
}
