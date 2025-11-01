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
    public partial class FrmcDetainedLicense : Form
    {
        int _LicenseID=-1;
        int _CreatByUserID = 1;
        clsDetainedLicense _DetainedLicense =new clsDetainedLicense();
        ClsIssueDriversLicenses _Licenses; 
        
        void DetainedLicense()
        {

            if (_Licenses != null) { 
            
            
            if (int.TryParse(textBoxFees.Text, out int Fees))
                {


                    laFees.Text= Fees.ToString();
                    _DetainedLicense.FineFees = Fees;
                    _DetainedLicense.ReleaseDate = DateTime.Now;
                    _DetainedLicense.LicenseID = _LicenseID;
                    _DetainedLicense.CreatedByUserID = _CreatByUserID;
                    if (_DetainedLicense.Save())
                    {
                       if (_Licenses.Stop_DriversLicenses())
                        {
                            MessageBox.Show("LicensesID hse (Detained) Number ID Detained Has: (" + _DetainedLicense.DetainID.ToString() + " ) ");
                            labeDataId.Text = _DetainedLicense.DetainID.ToString();
                            buDetained.Enabled = false;

                        }

                    }



                }
                else
                {
                    MessageBox.Show("Incoret input ??????");
                }
            
            
            
            
            
            }



        }
        public FrmcDetainedLicense(int CreatByUserID)
        {
            InitializeComponent();
            _CreatByUserID = CreatByUserID;
        }
        void GetLicensesIDByDalaet(int LicensesID)
        {
            _LicenseID = LicensesID;
            _Licenses = ClsIssueDriversLicenses.FindLicenceById(_LicenseID);
            if (_Licenses != null) { 
            groupBoxDetainedInfo.Enabled = true;
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmcDetainedLicense_Load(object sender, EventArgs e)
        {
            uscFlterLicences1.setLicencesIDDelegat = GetLicensesIDByDalaet;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buDetained_Click(object sender, EventArgs e)
        {
            DetainedLicense();
        }

        private void uscFlterLicences1_Load(object sender, EventArgs e)
        {

        }
    }
}
