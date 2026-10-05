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
    public partial class frmManageTestTypes : Form
    {
        public frmManageTestTypes()
        {
            InitializeComponent();
        }

        private void GetTestTypes()
        {
            dgvTestTypes.DataSource = clsTestTypesB.GetTestTypes();
            lblTotalCount.Text = dgvTestTypes.Rows.Count.ToString();

            if (dgvTestTypes.Columns.Count > 0)
            {
                dgvTestTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            dgvTestTypes.Columns["TestTypeID"].FillWeight = 15;
            dgvTestTypes.Columns["TestTypeTitle"].FillWeight = 33;
            dgvTestTypes.Columns["TestTypeTitle"].FillWeight = 27;
            dgvTestTypes.Columns["TestTypeFees"].FillWeight = 25;

        }
        private void frmManageTestTypes_Load(object sender, EventArgs e)
        {
            GetTestTypes();
        }

        private void updateTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TypeID = int.Parse(dgvTestTypes.CurrentRow.Cells["TestTypeID"].Value.ToString());
            frmUpdateTestType frm = new frmUpdateTestType(TypeID);
            frm.ShowDialog();
            GetTestTypes();
        }
    }
}
