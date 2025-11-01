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
    public partial class FrmIssueHistory : Form
    {
        ClsIssueDriversLicenses IssueDriverss;
        DataTable _DataDriversLicenses;
        DataTable _InternationalLicensesDataTable;
        private void _LoadDateLicenses(int personId)
        {
            _DataDriversLicenses = ClsIssueDriversLicenses.GetDriversLicensesByDriverId(personId);
            if (_DataDriversLicenses != null)
            {
                datalisunssDrevers.DataSource = _DataDriversLicenses;
            }



        }



        public FrmIssueHistory(int personId)
        {
            InitializeComponent();
            _LoadDateLicenses(personId);
            uscShowPerson1.LoadDataByPersonId(personId);

        }
        public FrmIssueHistory()
        {
            InitializeComponent();
          

        }


        void _LoadInternanolViw()
        {

            if (IssueDriverss != null)
            {
                _InternationalLicensesDataTable = ClsInternationalLicense.GetDriverInternationalLicenses(IssueDriverss.DriverID);

                if (_InternationalLicensesDataTable != null)
                {


                    dataGridViewIntrenanol.DataSource = _InternationalLicensesDataTable;
                }

            }
        }
        public void  SetLicensesId(int LicensesId)
        {

            IssueDriverss =  ClsIssueDriversLicenses.FindLicenceById(LicensesId);
            if (IssueDriverss != null) {
                _LoadDateLicenses(IssueDriverss.A_pplicantPersonID);
                _LoadInternanolViw();
                uscShowPerson1.LoadDataByPersonId(IssueDriverss.A_pplicantPersonID);

            }
            
         


        }


        private void FrmIssueHistory_Load(object sender, EventArgs e)
        {
       
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void useShowFilter1_Load(object sender, EventArgs e)
        {

        }

        private void uscShowPerson1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
