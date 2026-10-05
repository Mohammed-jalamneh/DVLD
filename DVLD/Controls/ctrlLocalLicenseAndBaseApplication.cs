using DVLD.Applications.Manage_Applications.Manage_Local_License.License;
using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD.Controls
{
    public partial class ctrlLocalLicenseAndBaseApplication : UserControl
    {
        
        private int _LDLID = -1;
        public clsLocalDrivingLicenseApplicationB LocalLicense { get; set; }
        

        public int LDLID
        {
            get { return _LDLID; }
        }

        public ctrlLocalLicenseAndBaseApplication()
        {
            InitializeComponent();
        }

        public delegate void DataBackEventHandler(object sender, int PersonID);
        public event DataBackEventHandler OnDataBack;
        public void LoadApplicationData(int LDLID , int PassedTest)
        {
            _LDLID = LDLID;
            LocalLicense = clsLocalDrivingLicenseApplicationB.FindApplicationUsingLDLID(_LDLID);

            if (LocalLicense == null)
            {
                MessageBox.Show("No Application found with this ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblLDLApplicationID.Text = LocalLicense.LocalDrivingLicenseApplicationID.ToString();

            clsLicenseClassesB LicenseClass = clsLicenseClassesB.Find(LocalLicense.LicenseClassID);
            lblAppliedForLicense.Text = (LicenseClass != null) ? LicenseClass.ClassName : "Unknown";
            lblPassedTest.Text = PassedTest.ToString();

            lblAppID.Text = LocalLicense.ApplicationID.ToString();
            lblFees.Text = LocalLicense.PaidFees.ToString();

            lblAppDate.Text = LocalLicense.ApplicationDate.ToString("dd/MMM/yyyy");
            lblLastStatusDate.Text = LocalLicense.LastStatusDate.ToString("dd/MMM/yyyy");

            switch (LocalLicense.ApplicationStatus)
            {
                case 1:
                    lblAppStatus.Text = "New";
                    break;
                case 2:
                    lblAppStatus.Text = "Cancelled";
                    break;
                case 3:
                    lblAppStatus.Text = "Completed";
                    break;
                default:
                    lblAppStatus.Text = "Unknown";
                    break;
            }

            clsApplicationTypesB AppType = clsApplicationTypesB.FindApplicationType(LocalLicense.ApplicationTypeID);
            lblAppType.Text = (AppType != null) ? AppType._ApplicationTypeTitle : "Unknown";

            clsPeopleB Person = clsPeopleB.Find(LocalLicense.ApplicantPersonID);
            lblApplicantName.Text = (Person != null) ? Person.FullName : "Unknown";


            lblCreatedBy.Text = clsLoggedUser.CurrentUser._UserName;
        }

        private void ctrlLocalLicenseAndBaseApplication_Load(object sender, EventArgs e)
        {
            OnDataBack?.Invoke(this, LocalLicense.ApplicantPersonID);
        }

        private void btnLicenseINfo_Click(object sender, EventArgs e)
        {
            int LicenseID = clsLicensesB.GetLicenseIDbyApplicationID(LocalLicense.ApplicationID);
            
            if(LicenseID != -1)
            {
                frmShowLicense frm = new frmShowLicense(LicenseID);
                frm.ShowDialog();
            }
            
        }

        private void btnPersonInfo_Click(object sender, EventArgs e)
        {
            frmPersonCard frm = new frmPersonCard(LocalLicense.ApplicantPersonID);
            frm.ShowDialog();
        }
    }
}