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

namespace DVLD.Applications
{
    public partial class frmManageApplicationTypes : Form
    {
        public frmManageApplicationTypes()
        {
            InitializeComponent();
        }

        private void GetApplicationTypes()
        {
            dgvApplicationTypes.DataSource = clsApplicationTypesB.GetListOfApplicationTypes();
            lblTotalCount.Text = dgvApplicationTypes.Rows.Count.ToString();

            if (dgvApplicationTypes.Columns.Count > 0)
            {
                dgvApplicationTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            dgvApplicationTypes.Columns["ApplicationTypeID"].FillWeight = 15;
            dgvApplicationTypes.Columns["ApplicationTypeTitle"].FillWeight = 55;
            dgvApplicationTypes.Columns["ApplicationFees"].FillWeight = 30;

        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmManageApplicationTypes_Load(object sender, EventArgs e)
        {
            GetApplicationTypes();
        }

       

        private void updateApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TypeID = int.Parse(dgvApplicationTypes.CurrentRow.Cells["ApplicationTypeID"].Value.ToString());
            frmUpdateApplicationTypesFees frm = new frmUpdateApplicationTypesFees(TypeID);
            frm.ShowDialog();
            GetApplicationTypes();

        }
    }
}
