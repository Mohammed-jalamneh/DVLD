using DVLD.MainScreen;
using DVLD.OtherClasses;
using DVLD_Business;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DVLD.Users
{
    public partial class frmLogicScreen : Form
    {

        clsUsersB _User;
        public frmLogicScreen()
        {
            InitializeComponent();
        }

        private void frmLogicScreen_Load(object sender, EventArgs e)
        {
            string Username="" , Password="";

            if(GetStoredCredential(ref Username , ref Password))
            {
                txtUserName.Text = Username;
                txtPassword.Text = Password;
                ckRememberMe.Checked = true;
            }else
            {
                txtUserName.Focus();
            }
        }

        private bool IsUserInSystem()
        {
            string UserName = txtUserName.Text;
            string pass = txtPassword.Text;

            _User = clsUsersB.Find(UserName , pass );

            return _User != null;
        }

        private void RegisterToWindowsRegistry(string userName, string password)
        {
            string subKeyPath = @"Software\DVLD\LoginCredentials";

            try
            {
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey(subKeyPath))
                {
                    if (key != null)
                    {
                        key.SetValue("Username", userName);
                        key.SetValue("Password", password);
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception or handle appropriately
                // EventLog.WriteEntry("DVLD", ex.Message, EventLogEntryType.Error);
            }
        }
        public static bool GetStoredCredential(ref string username, ref string password)
        {

            string subKeyPath = @"Software\DVLD\LoginCredentials";
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(subKeyPath))
                {
                    if (key != null)
                    {
                        object userObj = key.GetValue("Username");
                        object passObj = key.GetValue("Password");

                        if (userObj != null && passObj != null)
                        {
                            username = userObj.ToString();
                            password = passObj.ToString();
                            return true;
                        }
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                // Handle or log error when u learn it
                return false;
            }
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(IsUserInSystem())
            {

                if(_User._IsActive != 1)
                {
                    MessageBox.Show("User Not Active!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Clear();
                    txtPassword.Clear();
                    ckbShowPassword.Checked = false;
                    txtUserName.Focus();
                    return;
                }

                if (ckRememberMe.Checked == true)
                {
                    RegisterToWindowsRegistry(txtUserName.Text, txtPassword.Text);
                }

                clsLoggedUser.SetCurrentUser(txtUserName.Text);
                this.Hide();
                frmMainScreen frm = new frmMainScreen();
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong Password or User Name!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.Focus();
            }
        }

        private void ckbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == true)
                txtPassword.UseSystemPasswordChar = false;
            else
                txtPassword.UseSystemPasswordChar = true;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
