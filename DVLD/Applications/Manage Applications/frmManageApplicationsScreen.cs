using DVLD.Applications.Manage_Applications.Manage_International_License;
using DVLD.MainScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Applications.Manage_Applications
{
    public partial class frmManageApplicationChoiceses : Form
    {
        public frmManageApplicationChoiceses()
        {
            InitializeComponent();
        }

        private void btnManageApplications_Click(object sender, EventArgs e)
        {
            frmMainScreen mainForm = (frmMainScreen)Application.OpenForms["frmMainScreen"];

            if (mainForm != null)
            {
                mainForm.EmbedForm(new frmManageLocalDrivingLicenseApplication());
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            frmMainScreen mainForm = (frmMainScreen)Application.OpenForms["frmMainScreen"];

            if (mainForm != null)
            {
                mainForm.EmbedForm(new frmServicesDashboard());
            }

            
        }

        private void btnManageInternationalLicenseApplications_Click(object sender, EventArgs e)
        {
            frmMainScreen mainForm = (frmMainScreen)Application.OpenForms["frmMainScreen"];

            if (mainForm != null)
            {
                mainForm.EmbedForm(new frmManageInternationalLicense());
            }
        }
    }
}
