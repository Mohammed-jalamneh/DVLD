using DVLD.Properties;
using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.MemoryMappedFiles;


namespace DVLD.People
{
    public partial class frmAddNewPeople : Form
    {


        public delegate void deleSelectedPersonID(int PersonID);
        public event deleSelectedPersonID DataBack;


        enum enMode { AddNew, Update };
        enMode _Mode;

        int _PersonID = -1;

        clsPeopleB _Person;

        public frmAddNewPeople(int PersonID)
        {
            InitializeComponent();

            _PersonID = PersonID;
            _Mode = enMode.Update;
          
        }

        public frmAddNewPeople()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
        }

        private void FillCountriesInComboBox()
        {
            DataTable dt = clsCountriesB.GetListOfCountries();

            foreach (DataRow row in dt.Rows)
            {
                cbCountries.Items.Add(row["CountryName"]);
            }
        }

        private int _GetNationalCountryID()
        {
            clsCountriesB Country = clsCountriesB.FindCountry(cbCountries.Text);
            if (Country != null)
                return Country.CountryID;

            return -1;
        }

        private void GetPersonINfo()
        {
            _Person.NationalID = txtNationalID.Text.Trim();
            _Person.FirstName = txtFirstName.Text.Trim();
            _Person.SecondName = txtSecondName.Text.Trim();
            _Person.ThirdName = txtThirdName.Text.Trim();
            _Person.LastName = txtLastName.Text.Trim();
            _Person.DateOfBirth = dateTimePicker1.Value;
            if (cbGender.Text == "Male") _Person.Gendor = 0;
            else _Person.Gendor = 1;
            _Person.Address = txtAddress.Text.Trim();
            _Person.Phone = txtPhone.Text.Trim();
            _Person.Email = txtEmail.Text.Trim();
            _Person.NationalityCountryID = _GetNationalCountryID();

            if (pictureBox1.ImageLocation != null)
                _Person.ImagePath = pictureBox1.ImageLocation;
            else
                _Person.ImagePath = "";
        }


        private bool HandleImages()
        {
            if(_Person.ImagePath != pictureBox1.ImageLocation)
            {
                if(_Person.ImagePath != "")
                {
                    try
                    {
                        File.Delete(_Person.ImagePath);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }


            if(pictureBox1.ImageLocation != null)
            {
                string picSource = pictureBox1.ImageLocation.ToString();

                if (clsUtil.CopyImageToProjectImagesFolder(ref picSource))
                {
                    pictureBox1.ImageLocation = picSource;
                    _Person.ImagePath = picSource;
                    return true;
                }else
                {
                    MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return false;



        }

        private void LoadData()
        {
            FillCountriesInComboBox();
            cbCountries.SelectedIndex = 0;
            dateTimePicker1.MaxDate = DateTime.Now.AddYears(-18);

            
            if (_Mode == enMode.AddNew)
            {
                labelHeadLine.Text = "ADD NEW CONTACT";
                labelID.Text = "Auto Generated";
                _Person = new clsPeopleB();

                cbGender.SelectedIndex = 0;
                cbCountries.SelectedIndex = cbCountries.FindString("Jordan");
                llRemoveImage.Visible = false;
                return;
            }
            else // Update Mode
            {
                _Person = clsPeopleB.Find(_PersonID);

                if (_Person == null)
                {
                    MessageBox.Show("Contact Not Found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                labelHeadLine.Text = "EDIT CONTACT (ID: " + _Person.PersonID + ")";
                labelID.Text = _Person.PersonID.ToString();

                txtNationalID.Text = _Person.NationalID;
                txtFirstName.Text = _Person.FirstName;
                txtSecondName.Text = _Person.SecondName;
                txtThirdName.Text = _Person.ThirdName;
                txtLastName.Text = _Person.LastName;
                txtPhone.Text = _Person.Phone;
                txtAddress.Text = _Person.Address;
                txtEmail.Text = _Person.Email;
                if(_Person.Gendor == 0) cbGender.SelectedIndex = 0;
                else cbGender.SelectedIndex = 1;

                if (_Person.DateOfBirth <= dateTimePicker1.MaxDate && _Person.DateOfBirth >= dateTimePicker1.MinDate)
                {
                    dateTimePicker1.Value = _Person.DateOfBirth;
                }

                clsCountriesB Country = clsCountriesB.FindCountry(_Person.NationalityCountryID);
                if (Country != null)
                {
                    cbCountries.SelectedIndex = cbCountries.FindString(Country.CountryName);
                }

                if (!string.IsNullOrEmpty(_Person.ImagePath))
                {
                    pictureBox1.ImageLocation = _Person.ImagePath;
                }
                else
                {
                    pictureBox1.Image = Properties.Resources.unkownPerson;
                }

                llRemoveImage.Visible = !string.IsNullOrEmpty(_Person.ImagePath);
            }
        }

        private void frmAddNewPeople_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GetPersonINfo();

            if (_Person.Save())
            {
                MessageBox.Show("Person Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _Mode = enMode.Update;
                labelHeadLine.Text = "EDIT CONTACT (ID: " + _Person.PersonID + ")";
                labelID.Text = _Person.PersonID.ToString();
                DataBack?.Invoke(_Person.PersonID);
            }
            else
            {
                MessageBox.Show("Save Failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private  void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files |*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;
                pictureBox1.ImageLocation = selectedFilePath;
                llRemoveImage.Visible = true ;
            }

            if(!HandleImages())
            {
                MessageBox.Show("Error With Image Handling.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            File.Delete(_Person.ImagePath);
            _Person.ImagePath = "";
            llRemoveImage.Visible = false;
            pictureBox1.ImageLocation = null;
            if(cbGender.Text == "Male")
            {
                pictureBox1.Image = Properties.Resources.unkownPerson;
            }else
            {
                pictureBox1.Image = Properties.Resources.unknownWoman;

            }

        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGender.Text == "Male")
            {
                pictureBox1.Image = Properties.Resources.unkownPerson; 
                pictureBox1.ImageLocation = null; 
            }
            else
            {
                pictureBox1.Image = Properties.Resources.unknownWoman; 
                pictureBox1.ImageLocation = null;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text.Trim() == "")
                return;

            if (!clsValidate.ValidateEmail(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "Invalid Email Address Format!");
                System.Media.SystemSounds.Exclamation.Play();
            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
            }
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (clsValidate.IsNumber(txtFirstName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFirstName, "Invalid input type!");
                System.Media.SystemSounds.Exclamation.Play();
            }
            else
            {
                errorProvider1.SetError(txtFirstName, null);
            }

        }

        private void txtSecondName_Validating(object sender, CancelEventArgs e)
        {
            if (clsValidate.IsNumber(txtSecondName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtSecondName, "Invalid input type!");
                System.Media.SystemSounds.Exclamation.Play();
            }
            else
            {
                errorProvider1.SetError(txtSecondName, null);
            }
        }

        private void txtThirdName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtThirdName_Validating(object sender, CancelEventArgs e)
        {
            if (clsValidate.IsNumber(txtThirdName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtThirdName, "Invalid input type!");
                System.Media.SystemSounds.Exclamation.Play();
            }
            else
            {
                errorProvider1.SetError(txtThirdName, null);
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if(clsValidate.IsNumber(txtLastName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtLastName, "Invalid input type!");
                System.Media.SystemSounds.Exclamation.Play();
            }
            else
            {
                errorProvider1.SetError(txtLastName, null);
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (!clsValidate.IsNumber(txtPhone.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPhone, "Invalid input type!");
                System.Media.SystemSounds.Exclamation.Play();
            }
            else
            {
                errorProvider1.SetError(txtPhone, null);
            }

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}