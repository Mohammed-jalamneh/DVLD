using DVLD.Applications;
using DVLD.Applications.Driving_Licenses_Services;
using DVLD.Applications.Manage_Applications;
using System;
using System.Drawing;
using System.Windows.Forms;
using DVLD.MainScreen;
using DVLD.Applications.Driving_Licenses_Services.Released_Detained_Licneses; // Make sure this matches your main screen's namespace

namespace DVLD
{
    public partial class frmServicesDashboard : Form
    {
        public frmServicesDashboard()
        {
            InitializeComponent();
        }

        private void btnDrivingLiencesServices_MouseEnter(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button btn = (Guna.UI2.WinForms.Guna2Button)sender;
            btn.TextOffset = new Point(2, 2);
        }

        private void btnDrivingLiencesServices_MouseLeave(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button btn = (Guna.UI2.WinForms.Guna2Button)sender;
            btn.TextOffset = new Point(10, 0);
        }

        private void btnManageApplicationTypes_Click(object sender, EventArgs e)
        {
            frmManageApplicationTypes frm = new frmManageApplicationTypes();
            frm.ShowDialog();
        }

        private void btnManageTestTypes_Click(object sender, EventArgs e)
        {
            frmManageTestTypes frm = new frmManageTestTypes();
            frm.ShowDialog();
        }

        // --- UPDATED NAVIGATION CLICKS ---
        private void btnDrivingLiencesServices_Click(object sender, EventArgs e)
        {
            frmMainScreen mainForm = (frmMainScreen)Application.OpenForms["frmMainScreen"];

            if (mainForm != null)
            {
                mainForm.EmbedForm(new frmDrivingLicensesServices());
            }
        }

        private void btnManageApplications_Click(object sender, EventArgs e)
        {
            frmMainScreen mainForm = (frmMainScreen)Application.OpenForms["frmMainScreen"];

            if (mainForm != null)
            {
                mainForm.EmbedForm(new frmManageApplicationChoiceses());
            }
        }

        private void btnDetainLicences_Click(object sender, EventArgs e)
        {
            frmMainScreen mainForm = (frmMainScreen)Application.OpenForms["frmMainScreen"];

            if (mainForm != null)
            {
                mainForm.EmbedForm(new frmManageDetainedLicneses());
            }
        }
    }
}