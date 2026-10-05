using DVLD.Applications.Driving_Licenses_Services.Damaged_or_Lost_License_Replacment;
using DVLD.Applications.Driving_Licenses_Services.Released_Detained_Licneses;
using DVLD.Applications.Manage_Applications;
using DVLD.Applications.Manage_Applications.Manage_International_License;
using DVLD.Applications.Manage_Applications.Tests;
using DVLD.Applications.Renew_Driver_License;
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

namespace DVLD.Applications.Driving_Licenses_Services
{
    public partial class frmDrivingLicensesServices : Form
    {
        public frmDrivingLicensesServices()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pnlContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmDrivingLicensesServices_Load(object sender, EventArgs e)
        {
            pnlSubLicense.Visible = false;
            pnlDetainLicensesSubMenu.Visible = false;
        }

        private void btNewDrivingLicenses_Click(object sender, EventArgs e)
        {
            pnlDetainLicensesSubMenu.Visible = false;


            pnlSubLicense.Visible = !pnlSubLicense.Visible;
            pnlLicensesServices.PerformLayout();
            if (pnlSubLicense.Visible)
            {
                pnlSubLicense.Height = 170; 
            }
            else
            {
                pnlSubLicense.Height = 0;   
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

        private void btnLocalLicense_Click(object sender, EventArgs e)
        {

            frmAddUpdateLocalDrivingLicenseApplication frm = new frmAddUpdateLocalDrivingLicenseApplication();
            frm.ShowDialog();
        }

        private void btnRenewDrivingLicenses_Click(object sender, EventArgs e)
        {
            

            frmRenewDriverLicense frm = new frmRenewDriverLicense();
            frm.ShowDialog();


        }

        private void btnInternationalLicense_Click(object sender, EventArgs e)
        {
            frmAddEditInternationalLicense frm = new frmAddEditInternationalLicense();
            frm.ShowDialog();
        }

        private void btnReplacmentForLostOrDamageLicenses_Click(object sender, EventArgs e)
        {
            frmDamagedOrLostLicenseReplacement frm = new frmDamagedOrLostLicenseReplacement();
            frm.ShowDialog();
        }

        private void btnRetakeTest_Click(object sender, EventArgs e)
        {
            frmMainScreen mainForm = (frmMainScreen)Application.OpenForms["frmMainScreen"];

            if (mainForm != null)
            {
                mainForm.EmbedForm(new frmManageLocalDrivingLicenseApplication());
            }
        }

        private void btnReleaseDetainedDrivingLicense_Click(object sender, EventArgs e)
        {
            pnlSubLicense.Visible = false;
            pnlDetainLicensesSubMenu.Visible = !pnlDetainLicensesSubMenu.Visible;
        }

        private void btnDetainLicense_Click(object sender, EventArgs e)
        {
            frmDetainLicense frm = new frmDetainLicense();
            frm.ShowDialog();
        }

        private void btnReleaseDetainedLicense_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense();
            frm.ShowDialog();
        }
    }
}
