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

namespace DVLD.Users
{
    public partial class AddEditUser : Form
    {
        private int _PersonID =-1;
        private int _UserID =-1;
        private bool _AllowToPass = false;

        enum enMode {Add , Update};

        enMode _Mode = enMode.Add;

        clsUsersB User;

        public AddEditUser()
        {
            InitializeComponent();

            ctrlPersonCardWithFilter1.OnPersonSelected += GetPersonIDFromCtrl;
            _Mode = enMode.Add;
            ctrlPersonCardWithFilter1.FilterEnabled = true;

        }

        public AddEditUser(int PersonID )
        {
            InitializeComponent();
            this._PersonID = PersonID;
            
            this._Mode = enMode.Update;
            ctrlPersonCardWithFilter1.LoadPersonDefInfo(_PersonID);
            ctrlPersonCardWithFilter1.FilterEnabled = false;
            
        }

        private void GetPersonIDFromCtrl(int PerosonID)
        {
            _PersonID = PerosonID;

            btnNext.Enabled = true;
        }

        private void LoadUserInfo()
        {
            User._UserName = txtUserName.Text;
            User._Password = txtPassword.Text;
            if(ckbIsActive.Checked)
            {
                User._IsActive = 1;
            }
            else
            {
                User._IsActive = 0;
            }

            User._PersonID = _PersonID;
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            _AllowToPass = true;
            if (_Mode == enMode.Add)
            {
                if (!clsUsersB.IsUserExist(_PersonID))
                {
                    guna2TabControl1.SelectedTab = TabLogin;
                }
                else
                {
                    MessageBox.Show("This Person Already is  User.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                guna2TabControl1.SelectedTab = TabLogin;
            }

            _AllowToPass = false;
        }

        private void LoadDataFromDB()
        {
            if(_Mode == enMode.Add)
            {
                lblProcessState.Text = "Add New User";
                User = new clsUsersB();
            }else
            {
                lblProcessState.Text = "Update User...";
                User = clsUsersB.Find(_PersonID);

                if (User == null)
                {
                    MessageBox.Show("User Not Found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }
                
                txtUserName.Text = User._UserName;

                if (User._IsActive == 1) ckbIsActive.Checked = true;
                else ckbIsActive.Checked = false;

                btnNext.Enabled = true;

                


            }
        }
        private void AddUser_Load(object sender, EventArgs e)
        {
            btnNext.Enabled = false;
           
            LoadDataFromDB();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string enteredUserName = txtUserName.Text.Trim();

            if (string.IsNullOrWhiteSpace(enteredUserName))
            {
                errorProvider1.SetError(txtUserName, "Username cannot be empty!");
                txtUserName.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtUserName, "");
            }

            if (User._UserName != enteredUserName && clsUsersB.IsUserExist(enteredUserName))
            {
                errorProvider1.SetError(txtUserName, "Username is already taken by another user!");
                txtUserName.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtUserName, "");
            }

            // Password validation
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "Password cannot be empty!");
                txtPassword.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtPassword, "");
            }

            // Confirm Password validation (Null/Empty check)
            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                errorProvider1.SetError(txtConfirmPassword, "Confirm Password cannot be empty!");
                txtConfirmPassword.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, "");
            }

            // Passwords match check
            if (txtConfirmPassword.Text != txtPassword.Text)
            {
                errorProvider1.SetError(txtConfirmPassword, "Password Does not Match!");
                txtConfirmPassword.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, "");
            }

            LoadUserInfo();

            if (User.Save())
            {
                MessageBox.Show("Saved Successfully.", "Saving Process", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Didn't Save.", "Saving Process", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TabLogin_Click(object sender, EventArgs e)
        {

        }

        private void guna2TabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
           if (_AllowToPass == false) 
                e.Cancel = true;
           
        
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (clsValidate.IsNumber(txtUserName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "Invalid input type!");
                System.Media.SystemSounds.Exclamation.Play();
            }
            else
            {
                errorProvider1.SetError(txtUserName, null);
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (clsValidate.IsNumber(txtPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "Invalid input type Password Must Containes Letters and Numbers.");
                System.Media.SystemSounds.Exclamation.Play();
            }
            else
            {
                errorProvider1.SetError(txtPassword, null);
            }
        }

        private void guna2TextBox1_Validating(object sender, CancelEventArgs e)
        {
            if (clsValidate.IsNumber(txtConfirmPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Invalid input type!");
                System.Media.SystemSounds.Exclamation.Play();
            }
            else
            {
                

                errorProvider1.SetError(txtConfirmPassword, null);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _AllowToPass = true;
            guna2TabControl1.SelectedTab = TabPersonInfo;
            _AllowToPass = false;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void ckbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == true)
                txtPassword.UseSystemPasswordChar = false;
            else
                txtPassword.UseSystemPasswordChar = true;
        }
    }
}
