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
    public partial class FrmShowDrivers : Form
    {
        private DataTable _Drivers;
        public FrmShowDrivers()
        {
            InitializeComponent();
        }

        private void FrmShowDrivers_Load(object sender, EventArgs e)
        {
            





                  _Drivers = ClsDirvers.GetAllDrivers();

            if (_Drivers != null)
            {
                dataGridViewDreivers.DataSource = _Drivers;
            }

        }
    }
}
