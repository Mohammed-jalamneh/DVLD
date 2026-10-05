using DVLD.OtherClasses;
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
    public partial class ChangePassword : Form
    {
        int _PersonID;
        clsUsersB _User;
        public ChangePassword()
        {
            InitializeComponent();
        }

        public ChangePassword(int personID)
        {
            InitializeComponent();
            _PersonID = personID;
            ctrlPersonCard1.LoadPersonInfo(personID);
        }

        public ChangePassword(string UserName)
        {
            InitializeComponent();

            _User = clsUsersB.Find(UserName);
            _PersonID = _User._PersonID;
            ctrlPersonCard1.LoadPersonInfo(_PersonID);
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            _User = clsUsersB.Find(_PersonID);
            lblUserID.Text = _User._UserID.ToString();
            lblUserName.Text = _User._UserName.ToString();
            if (_User._IsActive == 1) lblIsActive.Text = "Yes";
            else lblIsActive.Text = "No";
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void lblUserID_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtConfirmPassword.Text == "" || txtPassword.Text =="" || txtCurrentPassword.Text == "")
            {
                errorProvider1.SetError(txtCurrentPassword, "Fill Password!");
                errorProvider1.SetError(txtPassword, "Fill Password!");
                errorProvider1.SetError(txtCurrentPassword, "Fill Password!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCurrentPassword, null);
                errorProvider1.SetError(txtPassword, null);
                errorProvider1.SetError(txtCurrentPassword, null);

            }


            if (clsCryptography.ComputeHash(txtCurrentPassword.Text) != _User._Password.ToString() )
            {
                errorProvider1.SetError( txtCurrentPassword , "Incorrect Password!");
                return;
            } else
            {
                errorProvider1.SetError(txtCurrentPassword, null);
            }

            if(txtConfirmPassword.Text != txtPassword.Text)
            {
                errorProvider1.SetError(txtConfirmPassword, "Passwords Does Not Match!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);

            }


            if(_User.UpdateUserPassword(txtPassword.Text))
            {
                MessageBox.Show("Password Changed Succefully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                MessageBox.Show("Password Does Not Changed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void ckbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (txtCurrentPassword.UseSystemPasswordChar == true)
                txtCurrentPassword.UseSystemPasswordChar = false;
            else
                txtCurrentPassword.UseSystemPasswordChar = true;

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

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {

            if (clsValidate.IsNumber(txtConfirmPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Invalid input type Password Must Containes Letters and Numbers.");
                System.Media.SystemSounds.Exclamation.Play();
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            }
        }
    }
}
