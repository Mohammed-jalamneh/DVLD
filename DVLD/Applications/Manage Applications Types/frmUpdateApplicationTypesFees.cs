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
    public partial class frmUpdateApplicationTypesFees : Form
    {

       private clsApplicationTypesB _SingleType;
        public frmUpdateApplicationTypesFees()
        {
            InitializeComponent();
        }

        public frmUpdateApplicationTypesFees(int TypeID)
        {
            InitializeComponent();

            _SingleType = clsApplicationTypesB.FindApplicationType(TypeID);

        }

        private void frmUpdateApplicationTypesFees_Load(object sender, EventArgs e)
        {
            txtTitle.Text = _SingleType._ApplicationTypeTitle;
            txtFees.Text = _SingleType._ApplicationTyepsFees.ToString();

        }

        private void AssignNewValueOfApplicationType()
        {
            _SingleType._ApplicationTypeTitle = txtTitle.Text;
            _SingleType._ApplicationTyepsFees =Convert.ToSingle(txtFees.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AssignNewValueOfApplicationType();
           if (_SingleType.Save())
            {
                MessageBox.Show("Updated Succeffully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                MessageBox.Show("Update Falied.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
