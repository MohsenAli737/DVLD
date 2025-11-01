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
using static System.Net.Mime.MediaTypeNames;

namespace ProjDVLD
{
    public partial class FrmRenewLocal_DriversLicensesApplicatons : Form
    {

        ClsIssueDriversLicenses _IssueDriversLicenses;
        ClsIssueDriversLicenses _RenwtLicenses;
        clsApplicationsTypes _clsApplicationsTypes = clsApplicationsTypes.GetApplicationTypeByid(2);
        int _CreatByUserID=1;
        int _LicensesId=-1;
        void _LodaDataForm()
        {
            if (_clsApplicationsTypes != null)
            {

              labelFees.Text=  _clsApplicationsTypes.ApplicationFees.ToString();
            }


        }
        void _GetLicensesIdByDalget(int LicensesId)
        {


            _LicensesId= LicensesId;
        }
        void _Renw_Licenses_Drevers()
        {
            
            if (_LicensesId > -1)
            {
                _IssueDriversLicenses = ClsIssueDriversLicenses.FindLicenceById(_LicensesId);
               if (_IssueDriversLicenses.IsExpirationDate())
                {




                    _RenwtLicenses = new ClsIssueDriversLicenses();
                    if (_IssueDriversLicenses.Renew_LocalDriversLicensesApplicatons(_CreatByUserID))
                    {
                        _RenwtLicenses.ApplicationID = _IssueDriversLicenses.ApplicationID;

                        _RenwtLicenses.Notes = string.Empty;
                        _RenwtLicenses.IsActive = true;
                        _RenwtLicenses.IssueDate = DateTime.Now;
                        _RenwtLicenses.DriverID = _IssueDriversLicenses.DriverID;
                        _RenwtLicenses.PaidFees = _IssueDriversLicenses.ApplicatonsinfoCls.PaidFees;
                        _RenwtLicenses.IssueReason = 2;

                        _RenwtLicenses.LicenseClass = _IssueDriversLicenses.LicenseClass;
                        _RenwtLicenses.CreatedByUserID = _CreatByUserID;
                        _RenwtLicenses.A_pplicantPersonID = _IssueDriversLicenses.A_pplicantPersonID;
                        _RenwtLicenses.ExpirationDate = DateTime.Now.AddYears(clsLicenseClass.GetExpiryDate(_IssueDriversLicenses.LicenseClass));


                        if (_RenwtLicenses.save())
                        {
                            _IssueDriversLicenses.Stop_DriversLicenses();

                            labelLicensesId.Text = _RenwtLicenses.LicenseID.ToString();
                            MessageBox.Show("RenwtLicenses Sucesseded()");
                        }
                        else
                        {
                            MessageBox.Show("RenwtLicenses Fild()");

                        }

                    }






                }
                else
                {
                    MessageBox.Show("Licenses is not ExpirationDate");
                }


            }
           

            
        }
        public FrmRenewLocal_DriversLicensesApplicatons(int CreatByUserID)
        {
            InitializeComponent();
          _CreatByUserID = CreatByUserID;
        }
        

        private void FrmRenewLocal_DriversLicensesApplicatons_Load(object sender, EventArgs e)
        {
            uscFlterLicences1.setLicencesIDDelegat = _GetLicensesIdByDalget;
            _LodaDataForm();
        }

        private void buttRenew_Click(object sender, EventArgs e)
        {
            _Renw_Licenses_Drevers();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
