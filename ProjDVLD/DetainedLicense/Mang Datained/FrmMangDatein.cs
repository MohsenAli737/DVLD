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

namespace ProjDVLD.DetainedLicense.Mang_Datained
{
    public partial class FrmMangDatein : Form
    {
        DataTable _DataTablDetainedLicenses;
        int _CretaByUserId=1;
        public FrmMangDatein(int CretaByUserId)
        {
            InitializeComponent();
        }

        private void FrmMangDatein_Load(object sender, EventArgs e)
        {
             _DataTablDetainedLicenses = clsDetainedLicense.GetAllDetainedLicenses();
            if (_DataTablDetainedLicenses != null)
            {
                dataGridViewDateins.DataSource = _DataTablDetainedLicenses;
            }
           
        }

        private void buttAddNew_Click(object sender, EventArgs e)
        {
            FrmcDetainedLicense DetainedLicense=new FrmcDetainedLicense(_CretaByUserId);
            DetainedLicense.Show();
        }
    }
}
