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
    public partial class FrmLicenceShowInfo : Form
    {
        int _ApplicatonId=-1;
        int _LicenceId=-1;
        void _LoadDataForm()
        {
            if (_LicenceId != -1)
            {
                uscShowLicens.GetLicencesId(_LicenceId);
            }
            else
            {
                uscShowLicens.GetAppplicatinID(_ApplicatonId);
            }


        }
        public FrmLicenceShowInfo(int ApplicatonId)
        {
            InitializeComponent();
            _ApplicatonId=ApplicatonId;
            _LoadDataForm();
        }
        public FrmLicenceShowInfo()
        {
            InitializeComponent();
        }


        

        public void GetLicencesId(int Licencesid) {

            _LicenceId = Licencesid;


            _LoadDataForm();



        }

        private void FrmLicenceShowInfo_Load(object sender, EventArgs e)
        {

        }

        private void uscShowLicens_Load(object sender, EventArgs e)
        {

        }
    }
}
