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
    public partial class FrmShowInteratinlcs : Form
    {
        int _InterNatnolId=-1;
        public FrmShowInteratinlcs(int InterNatnolId)
        {
            InitializeComponent();
            _InterNatnolId= InterNatnolId;  
        }

        private void FrmShowInteratinlcs_Load(object sender, EventArgs e)
        {
            uscShowInternetLicenses1.SetIntainonalId(_InterNatnolId);
        }

        private void uscShowInternetLicenses1_Load(object sender, EventArgs e)
        {

        }
    }
}
