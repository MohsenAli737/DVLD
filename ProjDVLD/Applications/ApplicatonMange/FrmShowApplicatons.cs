using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjDVLD.Users
{
    public partial class FrmShowApplicatons : Form
    {
        public FrmShowApplicatons()
        {
            InitializeComponent();
        }
        public void LoadaApplicainsId(int LocalApplicainsId)
        {
            uscVisionTestAppoimint.GetDateaByLocalApplicatonId(LocalApplicainsId);


        }


        private void FrmShowApplicatons_Load(object sender, EventArgs e)
        {

        }
    

        private void uscShowApplicatonsInfo1_Load(object sender, EventArgs e)
        {

        }

        private void uscVisionTestAppoimint_Load(object sender, EventArgs e)
        {

        }
    }
}
