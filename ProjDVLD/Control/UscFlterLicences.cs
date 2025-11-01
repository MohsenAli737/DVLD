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
    public partial class UscFlterLicences : UserControl
    {
        public delegate void SetLicencesIDDelegat(int liecincesId);
        public SetLicencesIDDelegat setLicencesIDDelegat;

        int _LicencesID=-1;
        public UscFlterLicences()
        {
            InitializeComponent();
        }
        public void  HideFliterLicences()
        {
            groupBox1.Enabled= false;
        }
        


        private void uscShowLicens1_Load(object sender, EventArgs e)
        {

        }
        void _FindLicencsId()
        {

            if (textBoxFliter.Text != null && int.TryParse(textBoxFliter.Text, out int number))
            {
                _LicencesID = number;



                if (_LicencesID > 0)
                {

                    if (uscShowLicens1.GetLicencesId(_LicencesID))
                    {

                        linkLabelShowLicensesHistory.Enabled= true;
                        labShowLicnses.Enabled= true;
                        setLicencesIDDelegat.Invoke(_LicencesID);

                    }


                }
            }


        }


        public void GetLicencsID(int LicencsID) { 
        
        
        _LicencesID = LicencsID;
        
        
        
        
        
        
        
        
        
        }
        public int setLicencesID()
        {
            if (_LicencesID > 0) {



                return _LicencesID;
            }
            return -1;
        }
        private void UscFlterLicences_Load(object sender, EventArgs e)
        {

        }

        private void buttIsusse_Click(object sender, EventArgs e)
        {
            _FindLicencsId();
        }

        private void linkLabelShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmIssueHistory IssueHistory = new FrmIssueHistory();
            if (_LicencesID > 0) {
                IssueHistory.SetLicensesId(_LicencesID);    
                IssueHistory.Show();






            }
        }
    }
}
