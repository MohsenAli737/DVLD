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
    public partial class UscVisionTestAppoimint : UserControl
    {
        private ClsLocalDrivingLicenseApplications _clsLocalDrivingLicenseApplications;
        private ClsApplicatons 
            _clApplicaton;
        private int _PersonId=0;
        public UscVisionTestAppoimint()
        {
            InitializeComponent();
        }

        private  void _LoadData(int ApplicatonLocalId)
        {

            _clsLocalDrivingLicenseApplications=   ClsLocalDrivingLicenseApplications.FindLocalDrivingLicenseApplications_ViewById(ApplicatonLocalId);
            if (_clsLocalDrivingLicenseApplications != null)
                
            {
                laiDApplicatonLic.Text = ApplicatonLocalId.ToString();
                laApplForLicencse.Text = _clsLocalDrivingLicenseApplications.LicenseClassName;
                labCratUser.Text = _clsLocalDrivingLicenseApplications.clsUserscsInfo.UserName;

                laApplicaonId.Text= _clsLocalDrivingLicenseApplications.ApplicantID.ToString();
                laType.Text = _clsLocalDrivingLicenseApplications.EnApplicitonType.ToString();
                laApplicatonsNam.Text = _clsLocalDrivingLicenseApplications.clsPepoleinfo.getFullName();
               _PersonId= _clsLocalDrivingLicenseApplications.ApplicantPersonID;
                laFees.Text=_clsLocalDrivingLicenseApplications.PaidFees.ToString();
                labStutas.Text= _clsLocalDrivingLicenseApplications.ApplicationStatus.ToString();
                laLiastData.Text= _clsLocalDrivingLicenseApplications.LastStatusDate.ToString();
                labData.Text = _clsLocalDrivingLicenseApplications.ApplicationDate.ToString();
             labPessdtest.Text  = ClsLocalDrivingLicenseApplications.GetPassedCount(ApplicatonLocalId).ToString();

            }








        }






        private void UscVisionTestAppoimint_Load(object sender, EventArgs e)
        {



        }
        public void GetDateaByLocalApplicatonId(int ApplicatonLocalId)
        {
            _LoadData(ApplicatonLocalId);
        }
        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void labViwePersonInfo_Click(object sender, EventArgs e)
        {
            ShowpersonInf personifo = new ShowpersonInf(_PersonId);
            personifo.Show();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void laApplicatons_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
