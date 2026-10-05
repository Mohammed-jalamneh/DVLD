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
    public partial class frmPersonCard : Form
    {
        public frmPersonCard(int PersonID)
        {

            InitializeComponent();
            
            ctrlPersonCard1.LoadPersonInfo(PersonID);
        }
        

        private void ctrlPersonCard1_Load(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void ctrlPersonCard1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
