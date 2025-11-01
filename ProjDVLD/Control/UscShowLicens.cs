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
    public partial class UscShowLicens : UserControl
    {
        int _ApplicatonID;
        int _LicensID;
        ClsIssueDriversLicenses _ClsIssueDriversLicenses;
        ClsApplicatons _ClsApplicatons;
        public UscShowLicens()
        {
            InitializeComponent();
        }



        void _LoadDateForm()
        {

                labeAsActav.Text = (_ClsIssueDriversLicenses.IsActive ? "Acatv" : "No Acatv");
                labeCreatByuserName.Text = _ClsIssueDriversLicenses.CreatedByUserID.ToString();
                labeIssuDate.Text = _ClsIssueDriversLicenses.IssueDate.ToString();
                labeExDate.Text = _ClsIssueDriversLicenses.ExpirationDate.ToString();
                labelClassName.Text = _ClsIssueDriversLicenses.LicenseClass.ToString();
                labelicenceId.Text = _ClsIssueDriversLicenses.LicenseID.ToString();



            




        }
        public void GetAppplicatinID(int ApplicatonID)
        {
            

           _LicensID= ClsIssueDriversLicenses.FindLicensebYApplictonId(ApplicatonID);


                _ApplicatonID = ApplicatonID;
                _ClsApplicatons =ClsApplicatons.FindApplicatonsById(_ApplicatonID);
            if (_ClsApplicatons != null) {

                _ClsIssueDriversLicenses = ClsIssueDriversLicenses.FindLicenceById(_LicensID);

                if (_LicensID > -1 && _ClsIssueDriversLicenses!=null)
                {
                    _LoadDateForm();
                }


              

            }


      


            

        }
        private void UscShowLicens_Load(object sender, EventArgs e)
        {

        }


        public bool GetLicencesId(int LicensID)
        {
            _LicensID = LicensID;
            _ClsIssueDriversLicenses = ClsIssueDriversLicenses.FindLicenceById(_LicensID);

            if (_ClsIssueDriversLicenses !=null)
            {
                if (_ClsIssueDriversLicenses.IsActive)
                {
                    _ApplicatonID = _ClsIssueDriversLicenses.ApplicationID;

                    _ClsApplicatons = ClsApplicatons.FindApplicatonsById(_ApplicatonID);

                    _LoadDateForm();
                    return true;
                }
                else
                {
                    MessageBox.Show("Drivers Licenses Is Not Active()");
                    return false;
                }

              
            }


            return false;


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void linkLPersonInf_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_ClsIssueDriversLicenses != null) {

                ShowpersonInf personInf = new ShowpersonInf(_ClsIssueDriversLicenses.personInf.PersonID);
                personInf.Show();








             }
        }
    }
}
