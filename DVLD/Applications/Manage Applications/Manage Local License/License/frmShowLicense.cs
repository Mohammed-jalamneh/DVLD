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
using System.IO; 

namespace DVLD.Applications.Manage_Applications.Manage_Local_License.License
{
    public partial class frmShowLicense : Form
    {
        private int _LicenseID;
        public frmShowLicense(int LicenseID)
        {
            _LicenseID = LicenseID;
            InitializeComponent();
        }

        private void guna2ShadowPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmShowLicense_Load(object sender, EventArgs e)
        {
            ctrlDriverLicense1.LoadInfo(_LicenseID);
        }

       
    }
}