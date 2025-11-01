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
    public partial class FrmLostOrDamagedLicnsesDrivers : Form
    {

        int _LicensesID = -1;
        clsApplicationsTypes ApplicationsTypesLostDrivers = clsApplicationsTypes.GetApplicationTypeByid(3);
        clsApplicationsTypes ApplicationsTypesDamagetDrivers = clsApplicationsTypes.GetApplicationTypeByid(4);
        int _CrateByUserId = 1;
        ClsIssueDriversLicenses _IssueDriversLicenses;


        void _LoadDataForm()
        {
            if (radioDamaget.Checked)
            {

                laTitle.Text = "Damaget Licnses Driver ";
                laFees.Text = ApplicationsTypesDamagetDrivers.ApplicationFees.ToString();

            }
            else
            {
                laFees.Text = ApplicationsTypesLostDrivers.ApplicationFees.ToString();
                laTitle.Text = "Lost Licnses Driver ";

            }


        }
        private void LostOrDamagedLicnsesDrivers()
        {

            ClsIssueDriversLicenses NewLicenses = new ClsIssueDriversLicenses();

            if (_LicensesID > -1)
            {
                _IssueDriversLicenses = ClsIssueDriversLicenses.FindLicenceById(_LicensesID);



                if (_IssueDriversLicenses != null)
                {

                    if (_IssueDriversLicenses.IsActive ==true)
                    {
                        return;
                        if (radioDamaget.Checked)
                        {







                            if (_IssueDriversLicenses.Damaged_LocalDriversLicensesApplicatons(_CrateByUserId))
                            {
                                NewLicenses.ApplicationID = _IssueDriversLicenses.ApplicationID;

                                NewLicenses.Notes = string.Empty;
                                NewLicenses.IsActive = true;
                                NewLicenses.IssueDate = DateTime.Now;
                                NewLicenses.DriverID = _IssueDriversLicenses.DriverID;
                                NewLicenses.PaidFees = _IssueDriversLicenses.ApplicatonsinfoCls.PaidFees;
                                NewLicenses.IssueReason = 4;

                                NewLicenses.LicenseClass = _IssueDriversLicenses.LicenseClass;
                                NewLicenses.CreatedByUserID = _CrateByUserId;
                                NewLicenses.A_pplicantPersonID = _IssueDriversLicenses.A_pplicantPersonID;
                                NewLicenses.ExpirationDate = _IssueDriversLicenses.ExpirationDate;


                                if (NewLicenses.save())
                                {

                                    laLicensesId.Text = NewLicenses.LicenseID.ToString();
                                    MessageBox.Show("Damaged LicesesDriver Sucesseded()");
                                    buttIsusse.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Damaged Fild()");
                                    buttIsusse.Enabled = false;
                                }


                            }









                        }
                        else if (radioLostDriver.Checked)
                        {








                            if (_IssueDriversLicenses.Lost_LocalDriversLicensesApplicatons(_CrateByUserId))
                            {
                                NewLicenses.ApplicationID = _IssueDriversLicenses.ApplicationID;

                                NewLicenses.Notes = string.Empty;
                                NewLicenses.IsActive = true;
                                NewLicenses.IssueDate = DateTime.Now;
                                NewLicenses.DriverID = _IssueDriversLicenses.DriverID;
                                NewLicenses.PaidFees = _IssueDriversLicenses.ApplicatonsinfoCls.PaidFees;
                                NewLicenses.IssueReason = 4;

                                NewLicenses.LicenseClass = _IssueDriversLicenses.LicenseClass;
                                NewLicenses.CreatedByUserID = _CrateByUserId;
                                NewLicenses.A_pplicantPersonID = _IssueDriversLicenses.A_pplicantPersonID;
                                NewLicenses.ExpirationDate = _IssueDriversLicenses.ExpirationDate;


                                if (NewLicenses.save())
                                {

                                    laLicensesId.Text = NewLicenses.LicenseID.ToString();
                                    MessageBox.Show("Lost LicesesDriver Sucesseded()");
                                    buttIsusse.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Lost Fild()");
                                    buttIsusse.Enabled = false;
                                }


                            }









                        }
                    }
                    else
                    {

                        MessageBox.Show("LicensesId     ( " + _LicensesID + " )  Is Not Active");
                    }

                }


            }






        }




    
        
        public void  SetLIcensesIdBYDalaget(int LicensesID)
        {

            _LicensesID=LicensesID;
        }


        public FrmLostOrDamagedLicnsesDrivers( int CrateByUserId)
        {
            InitializeComponent();
            uscFlterLicences1.setLicencesIDDelegat = SetLIcensesIdBYDalaget;
            _CrateByUserId = CrateByUserId;
        }


        private void FrmLostOrDamagedLicnsesDrivers_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            _LoadDataForm();
        }

        private void radioDamaget_CheckedChanged(object sender, EventArgs e)
        {
            _LoadDataForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LostOrDamagedLicnsesDrivers();
        }
    }
}
