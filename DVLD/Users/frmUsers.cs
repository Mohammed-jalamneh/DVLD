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
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        private void dgvPeople_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void _RefreshAllUsers()
        {
            dgvUsers.DataSource = clsUsersB.GetListOfUsers();
            lblTotalCount.Text = dgvUsers.Rows.Count.ToString();

            if (dgvUsers.Columns.Count > 0)
            {
                dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            dgvUsers.Columns["IsActive"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUsers.Columns["UserID"].FillWeight = 10;   
            dgvUsers.Columns["PersonID"].FillWeight = 10; 
            dgvUsers.Columns["FullName"].FillWeight = 40; 
            dgvUsers.Columns["UserName"].FillWeight = 15; 
            dgvUsers.Columns["IsActive"].FillWeight = 25;

        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            txtFiltering.Visible = false;
            _RefreshAllUsers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFilterBy.SelectedIndex != -1 && cbFilterBy.Text != "None")
            {
                txtFiltering.Visible =true;
            }
            else
            { txtFiltering.Visible =false; }
        }

        private void txtFiltering_TextChanged(object sender, EventArgs e)
        {
            DataTable dtUsers = (DataTable)dgvUsers.DataSource;

            if (string.IsNullOrWhiteSpace(txtFiltering.Text) || cbFilterBy.Text == "None")
            {
                dtUsers.DefaultView.RowFilter = "";
                return;
            }

            string filterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "Person ID":
                    filterColumn = "PersonID";
                    break;
                case "User ID":
                    filterColumn = "UserID";
                    break;
                case "User Name":
                    filterColumn = "UserName";
                    break;

                default:
                    filterColumn = "None";
                    break;
            }

            if (filterColumn == "None")
            {
                dtUsers.DefaultView.RowFilter = "";
                return;
            }

            if (filterColumn == "PersonID" || filterColumn =="UserID")
            {
                if (int.TryParse(txtFiltering.Text.Trim(), out int value))
                {
                    dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, value);
                }
                else
                {
                    dtUsers.DefaultView.RowFilter = "";
                }
            }
            else
            {
                dtUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterColumn, txtFiltering.Text.Trim());
            }

        }

        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow != null && dgvUsers.CurrentRow.Index >= 0)
            {
                if(Convert.ToInt16(dgvUsers.CurrentRow.Cells["IsActive"].Value) == 1)
                {
                    lblIsActive.Text = "YES";
                }
                else
                {
                    lblIsActive.Text = "NO";
                }
                lblUserName.Text = dgvUsers.CurrentRow.Cells["UserName"].Value.ToString();
                lblFullName.Text = dgvUsers.CurrentRow.Cells["FullName"].Value.ToString();

            }
        }

        private void llMoreDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int PersonID = int.Parse(dgvUsers.CurrentRow.Cells["PersonID"].Value.ToString());
            frmUserInfo frm = new frmUserInfo(PersonID);
            frm.ShowDialog();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddEditUser frm = new AddEditUser();
            frm.ShowDialog();
            _RefreshAllUsers();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = int.Parse(dgvUsers.CurrentRow.Cells["UserID"].Value.ToString());
            bool Value = (bool)dgvUsers.CurrentRow.Cells["IsActive"].Value;

            if (MessageBox.Show("Are you sure you want to delete User with ID = " + UserID, "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (!Value)
                {
                    if (!clsUsersB.DeleteUser(UserID))
                    {
                        MessageBox.Show("This user has something reltaed in the system.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    MessageBox.Show("Deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _RefreshAllUsers();

                }
                else
                {
                    MessageBox.Show("Can't Delete This User (Active).", "Permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

                
        }

        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = int.Parse(dgvUsers.CurrentRow.Cells["PersonID"].Value.ToString());
            AddEditUser user = new AddEditUser(PersonID);
            user.ShowDialog();
            _RefreshAllUsers();
            
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = int.Parse(dgvUsers.CurrentRow.Cells["PersonID"].Value.ToString());
            ChangePassword frm = new ChangePassword(PersonID);
            frm.ShowDialog();
            _RefreshAllUsers();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditUser frm = new AddEditUser();
            frm.ShowDialog();
            _RefreshAllUsers();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = int.Parse(dgvUsers.CurrentRow.Cells["PersonID"].Value.ToString());
            frmUserInfo frm = new frmUserInfo(PersonID);
            frm.ShowDialog();
        }

        private void dgvUsers_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
