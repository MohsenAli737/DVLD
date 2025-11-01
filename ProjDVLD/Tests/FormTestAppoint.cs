using DataBussnsLayer;
using ProjDVLD.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjDVLD.GloblCls;
namespace ProjDVLD.Control
{
    public partial class FormTestAppoint : Form
    {

         private enum enTypeTest { visonTest=1,WritingTest=2,Street=3};
        int _TypeTest = 0;
        private enTypeTest _enTypeTest;
        int _LocailDrivingId = 0;
        DataTable  _DataTestApp;
        clsUserscs _CretByUsre;
        public void SetenTypeTest(short TypeTest)
        {

            switch (TypeTest)
            {

                case 1:
                    {
                        _enTypeTest = enTypeTest.visonTest;

                        break;
                    }


                case 2:
                    {
                        _enTypeTest = enTypeTest.WritingTest;

                        break;
                    }

                case 3:
                    {
                        _enTypeTest = enTypeTest.Street;


                        break;
                    }

            }

            _TypeTest = TypeTest;



        }
        private void _LoadDataGrad()
        {
            _DataTestApp = clsTestAppointment.GetTestAppointmentByLocalId(_LocailDrivingId, _TypeTest);
            if (_DataTestApp != null)
            {
                dataGridTestApp.DataSource = _DataTestApp;
            }


        }
        private void _LoadData()
        {
            switch (_enTypeTest) {
            
            case enTypeTest.visonTest:
                    {
                        pictourTitle.Image = Resources.Vision_Test_32;
                        labTitel.Text = "vison Test";


                        break;
                    }



                case enTypeTest.WritingTest:
                    {
                        pictourTitle.Image = Resources.Written_Test_32;

                        labTitel.Text = "Writing Test";
                        break;
                    }


                case enTypeTest.Street:
                    {
                        pictourTitle.Image = Resources.Street_Test_32;

                        labTitel.Text = "Street Test";
                        break;
                    }

            }
            _LoadDataGrad();






        }
        public FormTestAppoint(clsUserscs CretByUsre)
        {
            InitializeComponent();
             _CretByUsre = CretByUsre;




        }

        public void GetIdAppLocail(int IdAppLocail)
        {

           
            uscVisionTestAppoimint1.GetDateaByLocalApplicatonId(IdAppLocail);
             _LocailDrivingId = IdAppLocail;


            _LoadData();
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormTestAppoint_Load(object sender, EventArgs e)
        {
            dataGridTestApp.ContextMenuStrip = contextMenuStrip1;

        }

        private void uscVisionTestAppoimint1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (clsTestAppointment.IsTestAppointmentIsNotLocad(_LocailDrivingId))
            {
                MessageBox.Show("TestAppointmentIsActvie");



                return;
            }
            else
            {
FrmAddnewTestAppointments AddnewTestAppointments =new FrmAddnewTestAppointments();

                AddnewTestAppointments.SetLoaclIdAndTypeTest(_LocailDrivingId, _TypeTest, _CretByUsre);
                AddnewTestAppointments.Show();
                _LoadDataGrad();

            }
           
        }

        private void takTestToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dataGridTestApp.CurrentRow != null)
            {
                int TestAppId = (int)dataGridTestApp.CurrentRow.Cells[0].Value;
          
                
                FrmTakTest TakTest=new FrmTakTest(TestAppId,_CretByUsre.UserID);
             
                TakTest.Show();
                _LoadDataGrad();

            }







        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dataGridTestApp.CurrentRow != null && dataGridTestApp.CurrentRow.Cells[3].Value != DBNull.Value)
            {
                byte isLocad = Convert.ToByte(dataGridTestApp.CurrentRow.Cells[3].Value);

                if (isLocad == 1)
                {
                    MessageBox.Show("test is locked");
                    takTestToolStripMenuItem.Enabled = false;
                }
                else
                {
                    takTestToolStripMenuItem.Enabled = true;
                }
            }


        


        }

        private void button1_Click(object sender, EventArgs e)
        {
            _LoadDataGrad();

        }
    }
}
