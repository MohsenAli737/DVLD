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
    public partial class frmShowUser : Form
    {
        public frmShowUser()
        {
            InitializeComponent();
        }
        public void GetUserId(int userid)
        {

            uscshowUser1.GetUserId(userid);
        }
        private void frmShowUser_Load(object sender, EventArgs e)
        {

        }

        private void uscshowUser1_Load(object sender, EventArgs e)
        {

        }
    }
}
