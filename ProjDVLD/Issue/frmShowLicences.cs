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
    public partial class frmShowLicences : Form
    {
        public frmShowLicences(int ApplicatonID)
        {
            InitializeComponent();

            uscShowLicens1.GetAppplicatinID(ApplicatonID);

        }

        
        private void frmShowLicences_Load(object sender, EventArgs e)
        {

        }

        private void uscShowLicens1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
