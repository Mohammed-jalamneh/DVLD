using DVLD.People;
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

namespace DVLD
{
    public partial class frmPeople : Form
    {
        public frmPeople()
        {
            InitializeComponent();

        }

      

      
        private void _RefreshAllPeople()
        {
            dgvPeople.DataSource = clsPeopleB.GetListOfPeople();

            if (dgvPeople.Columns.Count > 0)
            {
                dgvPeople.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void frmPeople_Load(object sender, EventArgs e)
        {
            txtFiltering.Visible = false;
            _RefreshAllPeople();
            RefreshDashboard();
            dgvPeople.Columns["PersonID"].DefaultCellStyle.ForeColor = Color.FromArgb(128, 228, 255);
            dgvPeople.Columns["PersonID"].DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        }

        private void button1_Click(object sender, EventArgs e) // Add New Button
        {
            frmAddNewPeople frm = new frmAddNewPeople();
            frm.ShowDialog(this);
            _RefreshAllPeople();
            RefreshDashboard();
        }

        private void dgvPeople_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvPeople.CurrentRow != null)
            {
                int PersonID = (int)dgvPeople.CurrentRow.Cells[0].Value;

                frmAddNewPeople frm = new frmAddNewPeople(PersonID);
                frm.ShowDialog();

                _RefreshAllPeople();
            }
            else
            {
                MessageBox.Show("Please select a person to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dgvPeople.CurrentRow != null)
            {
                int PersonID = (int)dgvPeople.CurrentRow.Cells[0].Value;

                if (MessageBox.Show("Are you sure you want to delete Person with ID = " + PersonID, "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (clsPeopleB.DeletePerson(PersonID))
                    {
                        MessageBox.Show("Person Deleted Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed With Deletion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    _RefreshAllPeople();
                    RefreshDashboard();
                }
            }
            else
            {
                MessageBox.Show("Please select a person to Delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click_1(object sender, EventArgs e) // Close Button
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFiltering.Text = "";
            txtFiltering.Focus();

            if (cbFilterBy.Text == "None")
                txtFiltering.Visible = false;
            else
                txtFiltering.Visible = true;
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "PersonID" || cbFilterBy.Text == "Nationality" || cbFilterBy.Text == "Gendor")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtFiltering_TextChanged(object sender, EventArgs e)
        {
            DataTable dtPeople = (DataTable)dgvPeople.DataSource;

            if (string.IsNullOrWhiteSpace(txtFiltering.Text) || cbFilterBy.Text == "None")
            {
                dtPeople.DefaultView.RowFilter = "";
                return;
            }

            string filterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "Person ID":
                    filterColumn = "PersonID";
                    break;
                case "NationalNo":
                    filterColumn = "NationalNo";
                    break;
                case "FirstName":
                    filterColumn = "FirstName";
                    break;
                case "SecondName":
                    filterColumn = "SecondName";
                    break;
                case "ThirdName":
                    filterColumn = "ThirdName";
                    break;
                case "LastName":
                    filterColumn = "LastName";
                    break;
                case "Nationality":
                    filterColumn = "NationalityCountryID";
                    break;
                case "Gendor":
                    filterColumn = "Gendor";
                    break;
                case "Phone":
                    filterColumn = "Phone";
                    break;
                case "Email":
                    filterColumn = "Email";
                    break;
                default:
                    filterColumn = "None";
                    break;
            }

            if (filterColumn == "None")
            {
                dtPeople.DefaultView.RowFilter = "";
                return;
            }

            if (filterColumn == "PersonID" || filterColumn == "NationalityCountryID" || filterColumn == "Gendor")
            {
                if (int.TryParse(txtFiltering.Text.Trim(), out int value))
                {
                    dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, value);
                }
                else
                {
                    dtPeople.DefaultView.RowFilter = "";
                }
            }
            else
            {
                dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterColumn, txtFiltering.Text.Trim());
            }



        }

        private void dgvPeople_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPeople.CurrentRow != null && dgvPeople.CurrentRow.Index >= 0)
            {
                lblCardID.Text = dgvPeople.CurrentRow.Cells["PersonID"].Value.ToString();

                string firstName = dgvPeople.CurrentRow.Cells["FirstName"].Value.ToString();
                string secondName = dgvPeople.CurrentRow.Cells["SecondName"].Value.ToString();
                string thirdName = dgvPeople.CurrentRow.Cells["ThirdName"].Value.ToString();
                string lastName = dgvPeople.CurrentRow.Cells["LastName"].Value.ToString();

                string fullName = $"{firstName} {secondName} {thirdName} {lastName}".Replace("  ", " ").Trim();
                lblCardName.Text = fullName;

                lblCardPhone.Text = dgvPeople.CurrentRow.Cells["Phone"].Value.ToString();

                string imagePath = "";

                if (dgvPeople.CurrentRow.Cells["ImagePath"].Value != DBNull.Value && dgvPeople.CurrentRow.Cells["ImagePath"].Value != null)
                {
                    imagePath = dgvPeople.CurrentRow.Cells["ImagePath"].Value.ToString();
                }

                if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                {
                    pbCardImage.ImageLocation = imagePath;
                }
                else
                {
                    pbCardImage.Image = Properties.Resources.unkownPerson;
                }
            }
        }

        private void llMoreDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int SelectedPersonID = (int)dgvPeople.CurrentRow.Cells[0].Value;
            frmPersonCard frm = new frmPersonCard(SelectedPersonID);
            frm.ShowDialog();
            _RefreshAllPeople();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void RefreshDashboard()
        {
            lblTotalCount.Text = dgvPeople.Rows.Count.ToString();

            int maleCount = 0;
            int femaleCount = 0;

            foreach (DataGridViewRow row in dgvPeople.Rows)
            {
                if (row.Cells["Gendor"].Value != null)
                {
                    if (row.Cells["Gendor"].Value.ToString() == "0")
                    {
                        maleCount++;
                    }
                    else if (row.Cells["Gendor"].Value.ToString() == "1")
                    {
                        femaleCount++;
                    }
                }
            }

            lblMaleCount.Text = maleCount.ToString();
            lblFemaleCount.Text = femaleCount.ToString();
        }

        private void pnlContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}