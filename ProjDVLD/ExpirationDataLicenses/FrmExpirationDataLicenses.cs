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
    public partial class FrmExpirationDataLicenses : Form
    {
        DataTable _ExiprationData;
        public FrmExpirationDataLicenses()
        {
            InitializeComponent();

        }

        private void FrmExpirationDataLicenses_Load(object sender, EventArgs e)
        {
            _ExiprationData = ClsIssueDriversLicenses.GetAllExpirationDataLicenses();

            if (_ExiprationData != null) {
                dataGridViewExpData.DataSource = _ExiprationData;




            }
        }
    }
}
