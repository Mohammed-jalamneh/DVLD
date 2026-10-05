using DVLD.Users;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD.MainScreen
{
    public partial class frmMainScreen : Form
    {
        public frmMainScreen()
        {
            InitializeComponent();
        }

        private void frmMainScreen_Load(object sender, EventArgs e)
        {
            if (TapControl.TabCount > 0)
            {
                EmbedForm(new frmServicesDashboard());
            }
        }

        public void EmbedForm(Form childForm)
        {
            if (TapControl.SelectedTab == null)
                return;

            TabPage currentTab = TapControl.SelectedTab;

            foreach (Control ctrl in currentTab.Controls)
            {
                if (ctrl is Form oldForm)
                {
                    oldForm.Close();
                    oldForm.Dispose();
                }
            }

            currentTab.Controls.Clear();

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            currentTab.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void TapControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (TapControl.SelectedIndex)
            {
                case 0:
                    EmbedForm(new frmServicesDashboard());
                    break;
                case 1:
                    EmbedForm(new frmPeople());
                    break;
                case 2:
                    EmbedForm(new frmDrivers());
                    break;
                case 3:
                    EmbedForm(new frmUsers());
                    break;
            }
        }

        private void TapControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex == 4)
            {
                e.Cancel = true;

                Rectangle tabRect = TapControl.GetTabRect(e.TabPageIndex);
                contextMenuStrip1.Show(TapControl, new Point(tabRect.Right, tabRect.Top));
            }
            else if (e.TabPageIndex == 5)
            {
                e.Cancel = true;

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to sign out?",
                    "Confirm Sign Out",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    clsLoggedUser.Logout();
                    this.Close();
                }
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword frm = new ChangePassword(clsLoggedUser.CurrentUser._UserName);
            frm.ShowDialog();
        }

        private void currentUserInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserInfo frmUserInfo = new frmUserInfo(clsLoggedUser.CurrentUser._UserName);
            frmUserInfo.ShowDialog();
        }
    }
}