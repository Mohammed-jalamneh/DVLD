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

namespace DVLD.Applications.Manage_Applications
{
    public partial class frmApplicationDetails : Form
    {
        public int LDLID { get; }
        private int _PassedTest;

        public frmApplicationDetails(int LDLID , int PassedTest)
        {
            this.LDLID = LDLID;
            _PassedTest = PassedTest;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guna2PictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void lblIsActive_Click(object sender, EventArgs e)
        {

        }


        private void frmApplicationDetails_Load(object sender, EventArgs e)
        {
            ctrlLocalLicenseAndBaseApplication1.LoadApplicationData(LDLID , _PassedTest);   
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ShadowPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
