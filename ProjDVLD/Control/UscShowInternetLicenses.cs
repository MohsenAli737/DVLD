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
    public partial class UscShowInternetLicenses : UserControl
    {

        int _InternationID=-1;

        ClsInternationalLicense _ClsInternationalLicense;
        public UscShowInternetLicenses()
        {
            InitializeComponent();
        }
        void _LoadDataForm()
        {

            if (_InternationID > -1)
            {
                _ClsInternationalLicense = ClsInternationalLicense.Find(_InternationID);

                if (_ClsInternationalLicense != null) {


                    laIsActiv.Text = _ClsInternationalLicense.IsActive.ToString();
                    laExpritonData.Text = _ClsInternationalLicense.ExpirationDate.ToString();
                    laIssueData.Text = _ClsInternationalLicense.IssueDate.ToString();
                    laFullName.Text = _ClsInternationalLicense.clsDirversinfo.ClspersonInfo.getFullName();
                    laInternanoal.Text = _ClsInternationalLicense.InternationalLicenseID.ToString();
                    laLicensesId.Text = _ClsInternationalLicense.IssuedUsingLocalLicenseID.ToString();
                    laCreatByUser.Text = _ClsInternationalLicense.clsUseres.UserName;



                }





            }


        }
        public void SetIntainonalId ( int InternationID)
        {

            _InternationID = InternationID;
            _LoadDataForm();



        }
        private void UscShowInternetLicenses_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
