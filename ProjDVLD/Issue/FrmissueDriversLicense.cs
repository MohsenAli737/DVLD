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
    public partial class FrmissueDriversLicense : Form
    {

        ClsLocalDrivingLicenseApplications _ClsLocalDrivingLicenseApplications;
        int _creatByUserid;
        ClsIssueDriversLicenses _ClsIssueDriversLicenses = new ClsIssueDriversLicenses();
        ClsDirvers _Dirver = new ClsDirvers();


        public FrmissueDriversLicense(int LocalApplicaonId, int creatByUserid)
        {
            InitializeComponent();
            _ClsLocalDrivingLicenseApplications = ClsLocalDrivingLicenseApplications.FindLocalDrivingLicenseApplications_ViewById(LocalApplicaonId);
            _creatByUserid = creatByUserid;
            uscVisionTestAppoimint1.GetDateaByLocalApplicatonId(LocalApplicaonId);



        }
        bool _save()
        {

            if (_ClsLocalDrivingLicenseApplications != null) {

                _ClsIssueDriversLicenses.IsActive = true;
                _ClsIssueDriversLicenses.A_pplicantPersonID = _ClsLocalDrivingLicenseApplications.ApplicantPersonID;

                _ClsIssueDriversLicenses.ApplicationID = _ClsLocalDrivingLicenseApplications.ApplicantID;
                _ClsIssueDriversLicenses.CreatedByUserID = _creatByUserid;
                _ClsIssueDriversLicenses.IssueDate = DateTime.Now;

                _ClsIssueDriversLicenses.PaidFees = _ClsLocalDrivingLicenseApplications.PaidFees;

                _ClsIssueDriversLicenses.LicenseClass = ClsLocalDrivingLicenseApplications.GetLicenseClassidByLicenseClassName(_ClsLocalDrivingLicenseApplications.LicenseClassName.ToString());
                _ClsIssueDriversLicenses.Notes = textboxNotes.Text;
                int expirationDate = clsLicenseClass.GetExpiryDate(_ClsIssueDriversLicenses.LicenseClass);
                _ClsIssueDriversLicenses.ExpirationDate = DateTime.Now.AddYears(expirationDate);
               
                if (ClsDirvers.DriversIsFindPersonID(_ClsIssueDriversLicenses.A_pplicantPersonID))
                {

                    if (ClsDirvers.DriversIsFindPersonID(_ClsIssueDriversLicenses.A_pplicantPersonID))
                    {
                        _Dirver = ClsDirvers.FindByPersonID(_ClsIssueDriversLicenses.A_pplicantPersonID);
                        if (_Dirver != null)
                        {

                            _ClsIssueDriversLicenses.DriverID = _Dirver.DirversId;



                            if (_ClsIssueDriversLicenses.save())
                            {
                                ClsApplicatons.CompliteStatus(_ClsIssueDriversLicenses.ApplicationID);
                            }
                        }
                    }

                }
                else
                {
                    _Dirver.PersonID = _ClsLocalDrivingLicenseApplications.clsPepoleinfo.PersonID;
                    _Dirver.CreatedByUserID = _creatByUserid;
                    _Dirver.CreatedDate = DateTime.Now;
                    if (_Dirver.Save())
                    {

                        _ClsIssueDriversLicenses.DriverID = _Dirver.DirversId;



                        if (_ClsIssueDriversLicenses.save())
                        {
                            ClsApplicatons.CompliteStatus(_ClsIssueDriversLicenses.ApplicationID);
                        }
                    }
                }



                return true;
            }
          



            return false;
             
            }




            private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butIsusse_Click(object sender, EventArgs e)
        {

            if (ClsIssueDriversLicenses.IsApplicationLicensesOrderedTwice(_ClsIssueDriversLicenses.ApplicationID))
            {
                MessageBox.Show("ApplicationLicensesOrderedTwice");
            }
             else
            {
                if (_save())
                {
                    MessageBox.Show("Save is ok()");
                }
                    else
                    {
                        MessageBox.Show("Falid");
                        butIsusse.Enabled = false;
                    }
                    butIsusse.Enabled = false;
            }
         
        }





        private void FrmissueDriversLicense_Load(object sender, EventArgs e)
        {

        }

        private void uscVisionTestAppoimint1_Load(object sender, EventArgs e)
        {

        }
    }
}
