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
    public partial class frmApplicationsMangaType : Form
    {

        DataTable _dataListApplicationsMangaType = new DataTable();

        private void _LoadData()
        {

            _dataListApplicationsMangaType = clsApplicationsTypes.GetApplicationsTypes();
            dataGridView1.DataSource = _dataListApplicationsMangaType;
            dataGridView1.ContextMenuStrip = contextMenuStrip1;


        }
        public frmApplicationsMangaType()
        {
            InitializeComponent();
            _LoadData();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ApplicationsMangaType_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow != null)
            {
                int Id = (int)dataGridView1.CurrentRow.Cells[0].Value;
            frmEditApplicationManage EditApplicationManage=new frmEditApplicationManage(Id);
                EditApplicationManage.ShowDialog();
            }
        }
    }
}
