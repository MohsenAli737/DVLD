using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBussnsLayer;
namespace ProjDVLD
{
    public partial class frmTest_Manage : Form
    {


        private   DataTable _DataListTestType;
        public frmTest_Manage()
        {
            InitializeComponent();
        }

        private void frmTest_Manage_Load(object sender, EventArgs e)
        {

            _DataListTestType = ClsTestType.GetListTestType();
            if (_DataListTestType != null)
            {
                dataGridViewTestList.DataSource = _DataListTestType;
                dataGridViewTestList.ContextMenuStrip = contextMenuStrip1;
            }




        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
         








            if (dataGridViewTestList.CurrentRow != null)
            {
                int Id = (int)dataGridViewTestList.CurrentRow.Cells[0].Value;
                FrmTestTypeUptata frmTestTypeUptata = new FrmTestTypeUptata(Id);

                frmTestTypeUptata.ShowDialog();
            }
        }

        private void dataGridViewTestList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
