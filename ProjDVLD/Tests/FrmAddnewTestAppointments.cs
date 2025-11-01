using DataBussnsLayer;
using ProjDVLD.Properties;
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
    public partial class FrmAddnewTestAppointments : Form
    {

        private enum enTypeTest { visonTest = 1, WritingTest = 2, Street = 3 };
        int _TypeTest = 0;
        private enTypeTest _enTypeTest;
        int _localApplicatonId = 0;
        clsTestAppointment NewTestAppointment = new clsTestAppointment();
        ClsTestType _clsTestType;
        clsUserscs _CretByUsre;
        public FrmAddnewTestAppointments( )
        {
            InitializeComponent();


        }



        void _LoadDataForm(int  TypeTest)

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















            switch (_enTypeTest)
                {

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
            labFees.Text=_clsTestType.Fees.ToString();

            }

        bool _Save()
        {



            if (_localApplicatonId > 0)
            {
                NewTestAppointment.CreatedByUserID = _CretByUsre.UserID;
                NewTestAppointment.PiedFees = _clsTestType.Fees;
                NewTestAppointment.localId = _localApplicatonId;
                NewTestAppointment.isLocked = 0;
                NewTestAppointment.TestId = _TypeTest;

                NewTestAppointment.AppointmenDate = dateTime.Value;
           if (NewTestAppointment.Save())
                {
                    return true;
                }
             
            }
            return false;
           
    








        }
            public void SetLoaclIdAndTypeTest(int localApplicatonId, int TypeTest, clsUserscs CretByUsre)
        
        {

            _localApplicatonId=localApplicatonId;
            _TypeTest=TypeTest;
            _clsTestType = ClsTestType.Find(TypeTest);



            _LoadDataForm(TypeTest);

            _CretByUsre = CretByUsre;

        }

        private void FrmAddnewTestAppointments_Load(object sender, EventArgs e)
        {

        }



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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buClos_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FrmShowApplicatons ShowApplicatons = new FrmShowApplicatons();
            ShowApplicatons.LoadaApplicainsId(_localApplicatonId);
            ShowApplicatons.Show();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buSve_Click(object sender, EventArgs e)
        {
            if (_Save())
            {
                MessageBox.Show("TestAppointment Is Save(Ok)");
            }
            else
            {
                MessageBox.Show("TestAppointment Is  not Save(Fild)");

            }
        }

        private void pictourTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
