using DVLD.People;
using DVLD.Properties;
using DVLD_Business;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ctrlPersonCard : UserControl
    {
        public clsPeopleB _Person;
        private int _PersonID = -1;

        public int PersonID { get { return _PersonID; } }

        public ctrlPersonCard()
        {
            InitializeComponent();
        }

        public  clsPeopleB LoadPersonInfo(int PersonID)
        {
            _Person = clsPeopleB.Find(PersonID);

            if (_Person == null)
            {
                MessageBox.Show("Error the person Does not exit wil load it into the card " + PersonID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return _Person;
            }

            FillPersonInfo();
            return _Person;
        }

        public clsPeopleB LoadPersonInfo(string NationalNo)
        {
            _Person = clsPeopleB.Find(NationalNo);

            if (_Person == null)
            {
                MessageBox.Show("Error the person Does not exit wil load it into the card " + NationalNo, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return _Person;
            }

            FillPersonInfo();
            return _Person;
        }
        public void FillPersonInfo()
        {
            llEditPersonInfo.Enabled = true;
            _PersonID = _Person.PersonID;
            lPersonID.Text = _Person.PersonID.ToString();
            lName.Text = _Person.FirstName + " " + _Person.LastName;
            lNationalNo.Text = _Person.NationalID;

            if (_Person.Gendor == 0)
                lGendor.Text = "Male";
            else
                lGendor.Text = "Female";

            lDateOfBirth.Text = _Person.DateOfBirth.ToShortDateString();
            lEmail.Text = _Person.Email;
            lPhone.Text = _Person.Phone;
            lCountry.Text = clsCountriesB.FindCountry(_Person.NationalityCountryID).CountryName;
            lAddress.Text = _Person.Address;

            _LoadPersonImage();
        }

        private void _LoadPersonImage()
        {
            if (_Person.Gendor == 0)
                pbPersonImage.Image = Resources.unkownPerson;
            else
                pbPersonImage.Image = Resources.unknownWoman;

            string ImagePath = _Person.ImagePath;
            if (ImagePath != "")
            {
                if (File.Exists(ImagePath))
                    pbPersonImage.ImageLocation = ImagePath;
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DefaultControlsValues()
        {
            lName.Text = "???";
            lPersonID.Text = "???";
            lCountry.Text = "???";
            lNationalNo.Text = "???";
            lGendor.Text = "???";
            lDateOfBirth.Text = "???";
            lAddress.Text = "???";
            lPhone.Text = "???";
            lEmail.Text = "???";

            pbPersonImage.Image = Resources.unkownPerson;
        }
        private void llEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddNewPeople frm = new frmAddNewPeople(_Person.PersonID);
            frm.ShowDialog();

            LoadPersonInfo(_Person.PersonID);
        }

        private void label4_Click(object sender, EventArgs e) { }
        private void label12_Click(object sender, EventArgs e) { }
        private void ctrlPersonCard_Load(object sender, EventArgs e)
        {
            
        }

        private void lName_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void pbPersonImage_Click(object sender, EventArgs e)
        {

        }
    }
}