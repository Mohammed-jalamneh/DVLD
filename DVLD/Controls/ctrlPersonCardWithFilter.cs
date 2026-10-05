using DVLD.People;
using DVLD_Business;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ctrlPersonCardWithFilter : System.Windows.Forms.UserControl
    {

        public bool FilterEnabled
        {
            get
            {
                return gbFilter.Enabled; 
            }
            set
            {
                cbFilteringType.Enabled = value;
                txtPersonInfoToSearch.Enabled = value;
                btnSearch.Enabled = value;
                btnAdd.Enabled = value;
            }
        }

        public event Action<int> OnPersonSelected;

        protected virtual void PersonSelected(int PersonID)
        {
            Action<int> handler = OnPersonSelected;
            if (handler != null)
            {
                handler(PersonID);
            }
        }

        public int PersonID
        {
            get { return ctrlPersonCard1.PersonID; }
        }

        public clsPeopleB LoadPersonInfo
        {
            get
            {
                return ctrlPersonCard1._Person;
            }
        }

        public ctrlPersonCardWithFilter()
        {
            InitializeComponent();
        }

        public  void LoadPersonDefInfo(int PersonID)
        {
            cbFilteringType.SelectedIndex = 0; 
            txtPersonInfoToSearch.Text = PersonID.ToString();
            FindBy();

        }

        private void FindBy()
        {
            switch (cbFilteringType.Text)
            {
                case "Person ID":
                    ctrlPersonCard1.LoadPersonInfo(int.Parse(txtPersonInfoToSearch.Text));
                    break;
                case "National No":
                    ctrlPersonCard1.LoadPersonInfo(txtPersonInfoToSearch.Text);
                    break;
            }

            if (OnPersonSelected != null && ctrlPersonCard1.PersonID != -1)
            {
                PersonSelected(ctrlPersonCard1.PersonID);
            }
        }

        private void _MakePictureBoxCircular(PictureBox pb)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();

            int diameter = Math.Min(pb.Width, pb.Height);

            int x = (pb.Width - diameter) / 2;
            int y = (pb.Height - diameter) / 2;

            path.AddEllipse(x, y, diameter, diameter);

            pb.Region = new Region(path);
        }
        private void ctrlPersonCardWithFilter_Load(object sender, EventArgs e)
        {
            cbFilteringType.SelectedIndex = 0;
            txtPersonInfoToSearch.Focus();
            _MakePictureBoxCircular(pictureBox1);
            _MakePictureBoxCircular(pictureBox2);
        }

        private void txtPersonInfoToSearch_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPersonInfoToSearch.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPersonInfoToSearch, "Not Allowed To Be Null");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPersonInfoToSearch, null);
            }
        }

        private void txtPersonInfoToSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnSearch.PerformClick();
            }

            if (cbFilteringType.Text == "Person ID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddNewPeople frm = new frmAddNewPeople();
            frm.DataBack += DataBackValue;
            frm.ShowDialog();
            
        }

        private void DataBackValue(int PersonID)
        {
            cbFilteringType.SelectedIndex = 0;
            txtPersonInfoToSearch.Text = PersonID.ToString();
            ctrlPersonCard1.LoadPersonInfo(PersonID);

            if (OnPersonSelected != null)
            {
                PersonSelected(PersonID);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtPersonInfoToSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid! Hover over the red icon to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtPersonInfoToSearch.Text))
            {
                MessageBox.Show("Please Enter Search Text.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FindBy();
        }

        private void ctrlPersonCard1_Load(object sender, EventArgs e)
        {

        }
    }
}