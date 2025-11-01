using DataBussnsLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjDVLD
{
    public partial class FrmInternenonlSet : Form
    {

        ClsApplicatons _Applicatons;
        ClsIssueDriversLicenses _Licenses;
        int _LicensesId = -1;
        int _CrateByUserId;
        clsApplicationsTypes _ApplicationsTypes = clsApplicationsTypes.GetApplicationTypeByid(6);
        ClsInternationalLicense InternationalLicense = new  ClsInternationalLicense ();
        bool FillngDataInternationalLicense=false;
        public FrmInternenonlSet(int UserId)
        {
            InitializeComponent();
            _CrateByUserId = UserId;
        }
        void _LoadDate()
        {
            labelFees.Text = _ApplicationsTypes.ApplicationFees.ToString();
        }

        void GetLicncesIdByDelegat(int LicencesId)
        {

            _LicensesId = LicencesId;
            _Licenses = ClsIssueDriversLicenses.FindLicenceById(LicencesId);
            if (_Licenses != null)
            {
                InternationalLicense.IssuedUsingLocalLicenseID = _Licenses.LicenseID;
                InternationalLicense.ApplicatonId = _Licenses.ApplicationID;
                InternationalLicense.ExpirationDate= _Licenses.ExpirationDate;
                InternationalLicense.IssueDate= _Licenses.IssueDate;
                InternationalLicense.CreatUserId = _CrateByUserId;
                InternationalLicense.DriverID = _Licenses.DriverID;
                InternationalLicense.IsActive= true;
                FillngDataInternationalLicense = true;

            }
            else
            {
                MessageBox.Show("Not Find");


            }
            





        }

        void _Save()
        {
         if (FillngDataInternationalLicense)
            {

                if (InternationalLicense.Save())
                {
                    MessageBox.Show("(InternationalLicense Saved");
                    labeInterId.Text= InternationalLicense.InternationalLicenseID.ToString();
                    uscFlterLicences1.HideFliterLicences();
                    buttonIssuse.Enabled= false;
                }
                else
                {
                    MessageBox.Show("(InternationalLicense Fild");

                }

            }
            else
            {


                MessageBox.Show("No Data");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmInternenonlSet_Load(object sender, EventArgs e)
        {
            _LoadDate();
            uscFlterLicences1.setLicencesIDDelegat += GetLicncesIdByDelegat;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _Save();
        }

        private void uscFlterLicences1_Load(object sender, EventArgs e)
        {
            FrmIssueHistory IssueHistory =new FrmIssueHistory();
            IssueHistory.SetLicensesId(_LicensesId);

        }
    }
}
