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
    public partial class frmDrivers : Form
    {
        public frmDrivers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDrivers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void _RefreshAllDrivers()
        {
            dgvDrivers.DataSource = clsDriversB.GetAllDrivers();
            lblTotalCount.Text = dgvDrivers.Rows.Count.ToString();

            if (dgvDrivers.Columns.Count > 0)
            {
                dgvDrivers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            /*dgvDrivers.Columns["IsActive"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDrivers.Columns["UserID"].FillWeight = 10;
            dgvDrivers.Columns["PersonID"].FillWeight = 10;
            dgvDrivers.Columns["FullName"].FillWeight = 40;
            dgvDrivers.Columns["UserName"].FillWeight = 15;
            dgvDrivers.Columns["IsActive"].FillWeight = 25;*/

        }
        

        private void frmDrivers_Load(object sender, EventArgs e)
        {
            _RefreshAllDrivers();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.SelectedIndex != -1 && cbFilterBy.Text != "None")
            {
                txtFiltering.Visible = true;
                txtFiltering.Text = "";
                txtFiltering.Focus();
            }
            else
            {
                txtFiltering.Visible = false;
                txtFiltering.Text = "";
            }
        }

        private void txtFiltering_TextChanged(object sender, EventArgs e)
        {
            DataTable dtDrivers = (DataTable)dgvDrivers.DataSource;

            if (dtDrivers == null || string.IsNullOrWhiteSpace(txtFiltering.Text) || cbFilterBy.Text == "None")
            {
                if (dtDrivers != null)
                    dtDrivers.DefaultView.RowFilter = "";
                return;
            }

            string filterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "DriverID":
                    filterColumn = "DriverID";
                    break;

                case "NationalNo":
                    filterColumn = "NationalNo";
                    break;

                case "FullName":
                    filterColumn = "FullName";
                    break;

                default:
                    filterColumn = "None";
                    break;
            }

            if (filterColumn == "None")
            {
                dtDrivers.DefaultView.RowFilter = "";
                return;
            }

            if (filterColumn == "DriverID")
            {
                if (int.TryParse(txtFiltering.Text.Trim(), out int value))
                {
                    dtDrivers.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, value);
                }
                else
                {
                    dtDrivers.DefaultView.RowFilter = string.Format("[{0}] = -1", filterColumn);
                }
            }
            else
            {
                dtDrivers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterColumn, txtFiltering.Text.Trim().Replace("'", "''"));
            }
        }

    }
}
