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

namespace DVLD.Applications.Driving_Licenses_Services
{
    public partial class frmAddUpdateLocalDrivingLicenseApplication : Form
    {
        private int _PersonID = -1;
        private bool _AllowToPass = false;

        private clsApplicationTypesB _ApplicationType;
        private clsLocalDrivingLicenseApplicationB _LocalLicense = new clsLocalDrivingLicenseApplicationB();
        private clsApplicationsB _Application;
        private clsLicenseClassesB _LicenseClass;

        public enum enMode { AddNew = 0, Update };
        private enMode _Mode = enMode.AddNew;

        enum enStatus { New = 1, Cancelled, Completed };
        enStatus _enStatus;

        public frmAddUpdateLocalDrivingLicenseApplication()
        {
            InitializeComponent();
            ctrlPersonCardWithFilter1.OnPersonSelected += GetPersonIDFromCtrl;
            _Mode = enMode.AddNew;
        }

        public frmAddUpdateLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();
            ctrlPersonCardWithFilter1.OnPersonSelected += GetPersonIDFromCtrl;

            _Mode = enMode.Update;

            _LocalLicense = clsLocalDrivingLicenseApplicationB.FindApplicationUsingLDLID(LocalDrivingLicenseApplicationID);
        }

        private void GetApplicationFeesFromApplicationTestTable()
        {
            _ApplicationType = clsApplicationTypesB.FindApplicationType(1); 
            {
                lblApplicationFees.Text = _ApplicationType._ApplicationTyepsFees.ToString() + " JD";
            }
        }

        private void _FillLicenseClassesInComboBox()
        {
            DataTable dtClasses = clsLicenseClassesB.GetAllLicenseClasses();
            cbLicenseClasses.DataSource = dtClasses;
            cbLicenseClasses.DisplayMember = "ClassName";
            cbLicenseClasses.ValueMember = "LicenseClassID";

            if (cbLicenseClasses.Items.Count > 0)
            {
                cbLicenseClasses.SelectedIndex = 2; 
            }
        }

        private void _DefaultSetting()
        {
            GetApplicationFeesFromApplicationTestTable();

            if (_Mode == enMode.AddNew)
            {
                lblProcessState.Text = "Add New Local Driving License Application";
                btnNext.Enabled = false;
                lblApplicationDate.Text = DateTime.Now.ToString("d");

                if (cbLicenseClasses.Items.Count > 2)
                    cbLicenseClasses.SelectedIndex = 2;

                lblCreatedBy.Text = clsLoggedUser.CurrentUser._UserName;
            }
            else
            {
                lblProcessState.Text = "Update Local Driving License Application";
                btnNext.Enabled = true;
            }
        }

        private void _LoadDataForUpdateProcess()
        {
            ctrlPersonCardWithFilter1.FilterEnabled = false;

            if (_LocalLicense != null)
            {
                
                ctrlPersonCardWithFilter1.LoadPersonDefInfo(_LocalLicense.ApplicantPersonID);
                _PersonID = _LocalLicense.ApplicantPersonID; 

                lblApplicationDate.Text = _LocalLicense.ApplicationDate.ToString("d");

                _LicenseClass = clsLicenseClassesB.Find(_LocalLicense.LicenseClassID);
                if (_LicenseClass != null)
                {
                    cbLicenseClasses.SelectedIndex = cbLicenseClasses.FindString(_LicenseClass.ClassName);
                }

                lblApplicationFees.Text = _LocalLicense.PaidFees.ToString();
                lblCreatedBy.Text = clsLoggedUser.CurrentUser._UserName;
                lblApplicationID.Text = _LocalLicense.LocalDrivingLicenseApplicationID.ToString();
            }
        }

        private void frmNewLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            _FillLicenseClassesInComboBox();
            _DefaultSetting();

            
            if (_Mode == enMode.Update)
            {
                _LoadDataForUpdateProcess();
            }
        }

        private void GetPersonIDFromCtrl(int PerosonID)
        {
            _PersonID = PerosonID;
            btnNext.Enabled = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _AllowToPass = true;
            guna2TabControl1.SelectedTab = TabApplicationInfo;
            _AllowToPass = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _AllowToPass = true;
            guna2TabControl1.SelectedTab = TabPersonInfo;
            _AllowToPass = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guna2TabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (_AllowToPass == false)
                e.Cancel = true;
        }

        private void FillApplicationInfoToDB()
        {
            _LocalLicense.ApplicantPersonID = _PersonID;

            DateTime resultDate;
            if (DateTime.TryParse(lblApplicationDate.Text, out resultDate))
            {
                _LocalLicense.ApplicationDate = resultDate;
            }
            else
            {
                _LocalLicense.ApplicationDate = DateTime.Now;
            }

            _LocalLicense.ApplicationTypeID = _ApplicationType._ApplicationTypeID;

            _LocalLicense.ApplicationStatus = (byte)enStatus.New;
            _LocalLicense.LastStatusDate = DateTime.Now;

            _LocalLicense.PaidFees = _ApplicationType._ApplicationTyepsFees;
            _LocalLicense.CreatedByUserID = clsLoggedUser.CurrentUser._UserID;

            _LocalLicense.LicenseClassID = Convert.ToInt32(cbLicenseClasses.SelectedValue);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int LicenseClassID = (int)cbLicenseClasses.SelectedValue;
            if (clsLicensesB.IsLicenseExistByPersonIDAndLicenseClassID(_PersonID , LicenseClassID))
            {
                MessageBox.Show("Person already have a license with the same applied driving class , Choose another driving class."
                    ,"Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (clsApplicationsB.IsPersonHasActiveApplication(_PersonID, LicenseClassID))
            {
                MessageBox.Show("Person already has an active application for this license class!",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FillApplicationInfoToDB();

            if (_LocalLicense.Save())
            {
                lblApplicationID.Text = _LocalLicense.LocalDrivingLicenseApplicationID.ToString();

                _Mode = enMode.Update;
                lblProcessState.Text = "Update Local Driving License Application";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error: Data was not saved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}