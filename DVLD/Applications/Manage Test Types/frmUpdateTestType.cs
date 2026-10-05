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
    public partial class frmUpdateTestType : Form
    {
        private clsTestTypesB Test;

        public frmUpdateTestType(int TestID)
        {
            InitializeComponent();

            Test = clsTestTypesB.FindTestType(TestID);
        }

        private void frmUpdateTestType_Load(object sender, EventArgs e)
        {
            txtTitle.Text = Test._TestTypeTitle;
            txtDescription.Text = Test._TestTypeDescription;
            txtFees.Text = Test._TestTyepsFees.ToString();
        }

        private void AssignNewValueOfTestType()
        {
            Test._TestTypeTitle = txtTitle.Text;
            Test._TestTypeDescription = txtDescription.Text;
            Test._TestTyepsFees = Convert.ToSingle(txtFees.Text);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AssignNewValueOfTestType();
            if (Test.Save())
            {
                MessageBox.Show("Updated Succeffully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Update Falied.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
