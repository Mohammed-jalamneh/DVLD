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
    public partial class frmUserInfo : Form
    {
        int _PersonID = -1;
        clsUsersB _User;
        public frmUserInfo()
        {
            InitializeComponent();
        }

        public frmUserInfo(int PersonID)
        {
            InitializeComponent();

            _PersonID = PersonID;
            ctrlPersonCard1.LoadPersonInfo(_PersonID);
        }

        public frmUserInfo(string UserName)
        {
            InitializeComponent();

            _User = clsUsersB.Find(UserName);
            _PersonID = _User._PersonID;
            ctrlPersonCard1.LoadPersonInfo(_PersonID);
        }

        private void LoadData()
        {
            _User = clsUsersB.Find(_PersonID);
            lblUserID.Text = _User._UserID.ToString();
            lblUserName.Text = _User._UserName.ToString();
            if (_User._IsActive == 1) lblIsActive.Text = "Yes";
            else lblIsActive.Text = "No";
        }

        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
