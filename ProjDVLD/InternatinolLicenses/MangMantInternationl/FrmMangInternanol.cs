using DataBussnsLayer;
using ProjDVLD.Users;
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
    public partial class FrmMangInternanol : Form
    {

        DataTable DataTableInternationalLicense =  ClsInternationalLicense.GetAllInternationalLicenses();
        public FrmMangInternanol()
        {
            InitializeComponent();
        }


        void _LoadDataGridViw()
        {
            if (DataTableInternationalLicense != null) { 
            
            
            dataGridViewIntern.DataSource = DataTableInternationalLicense;
            
            }


        }
        private void FrmMangInternanol_Load(object sender, EventArgs e)
        {
            _LoadDataGridViw();
            dataGridViewIntern.ContextMenuStrip = contextMenuStrip1;
        }

        private void showInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {




            if (dataGridViewIntern.CurrentRow != null)
            {
                int interId = (int)dataGridViewIntern.CurrentRow.Cells[0].Value;
                FrmShowInteratinlcs showInteratinl = new FrmShowInteratinlcs(interId);
                showInteratinl.Show();

            }





        }
    }
}
