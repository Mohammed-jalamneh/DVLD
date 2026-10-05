using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Applications.Manage_Applications.Tests
{
    public partial class frmTestTypeAppointments : Form
    {
        public int LDLID { get; }
        public int TestTypeID { get; }
        public int ApplicantPersonID { get; set; }
        private int _PassedTest;
        public frmTestTypeAppointments(int LDLID , int TestTypeID , int PassedTest)
        {
            this.LDLID = LDLID;
            this.TestTypeID = TestTypeID;
            this._PassedTest = PassedTest;
            InitializeComponent();
        }

        public void SmthinNotImp()
        {
            dgvAppointments.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dgvAppointments.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

            dgvAppointments.RowTemplate.Height = 35;

            dgvAppointments.BackgroundColor = Color.FromArgb(34, 36, 49);
            dgvAppointments.BorderStyle = BorderStyle.None;

            dgvAppointments.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAppointments.GridColor = Color.FromArgb(50, 50, 65);
          // dgvAppointments.Columns["IsLocked"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
           // dgvAppointments.Columns["IsLocked"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAppointments.EnableHeadersVisualStyles = false;
        }
        public void LoadAppointmentsInfoIntoDGV(int TestTypeID)
        {

            dgvAppointments.DataSource = clsTestAppointmentsB.GetAppointmentsInfoByLDLIDandTestTypeID(LDLID, TestTypeID);

            if (dgvAppointments.Columns.Count > 0)
            {
                dgvAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            lblTotalAppointments.Text = dgvAppointments.Rows.Count.ToString();
            SmthinNotImp();
        }

        private void CheckWhichTestTypeToApply()
        {
            if (TestTypeID == 1)
            {
                lblHeadLine.Text = "Vision Test Appointments";
                pbHeadLine.Image = Properties.Resources.Eye;
            }
            else if (TestTypeID == 2)
            {
                lblHeadLine.Text = "Written Test Appointments";
                pbHeadLine.Image = Properties.Resources.WrittenTest;
            }
            else if (TestTypeID == 3)
            {
                lblHeadLine.Text = "Street Test Appointments";
                pbHeadLine.Image = Properties.Resources.SteetTest;
            }
            else
            {
                lblHeadLine.Text = "None!";
                pbHeadLine.Enabled = false; ;
            }
        }
        private void frmVisionTestAppointments_Load(object sender, EventArgs e)
        {
            
            ctrlLocalLicenseAndBaseApplication1.LoadApplicationData(LDLID , _PassedTest);
            LoadAppointmentsInfoIntoDGV(TestTypeID);
            CheckWhichTestTypeToApply();
            
            
        }

        private void ctrlLocalLicense_OnDataBack(object sender , int ApplicantPersonID)
        {
            this.ApplicantPersonID = ApplicantPersonID; //did not user ,  useless
        }

        private void btnAddNewAppointment_Click(object sender, EventArgs e)
        {
           
            frmAddEditTestType frm = new frmAddEditTestType(LDLID , TestTypeID, -1);
            frm.ShowDialog();
            LoadAppointmentsInfoIntoDGV(TestTypeID);
            
        }

        private void updateAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int Appointment = (int)dgvAppointments.CurrentRow.Cells[0].Value;
            frmAddEditTestType frm = new frmAddEditTestType(LDLID, TestTypeID , Appointment );
            frm.ShowDialog();
            LoadAppointmentsInfoIntoDGV(TestTypeID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int Appointment = (int)dgvAppointments.CurrentRow.Cells[0].Value;
            frmTakeTest frm = new frmTakeTest(Appointment , TestTypeID);
            frm.ShowDialog();
            LoadAppointmentsInfoIntoDGV(TestTypeID);
        }
    }
}
