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
    public partial class FrmTakTest : Form
    {

        private int _TestAppontomintId = 0;
        private int _LoaclApplicatonId = 0;
        private int _CreatUserId=0;
        clsTestAppointment _clsTestAppointment;
        private ClsLocalDrivingLicenseApplications _ClsLocalDrivingLicenseApplications;
        private ClsTakTest _ClsTakTest  = new ClsTakTest();


        public FrmTakTest(int TestAppontomintId,  int CreatUserId)
        {
            InitializeComponent();

            _TestAppontomintId = TestAppontomintId;
            _CreatUserId = CreatUserId;
            _clsTestAppointment = clsTestAppointment.FindTestAppointmentbyid(TestAppontomintId);

            if (_clsTestAppointment != null)
            {
                _LoaclApplicatonId = _clsTestAppointment.localId;
                _ClsLocalDrivingLicenseApplications = ClsLocalDrivingLicenseApplications.FindLocalDrivingLicenseApplications_ViewById(_LoaclApplicatonId);
                if (_ClsLocalDrivingLicenseApplications != null)
                {
                    _LoadData();

                }

            }
            return;


        }
        void _LoadData()
        {
            laAppId.Text= _LoaclApplicatonId.ToString();
            laFees.Text=_ClsLocalDrivingLicenseApplications.PaidFees.ToString();
            labenameClass.Text = _ClsLocalDrivingLicenseApplications.LicenseClassName;
            labName.Text = _ClsLocalDrivingLicenseApplications.clsPepoleinfo.getFullName();

        }
        bool _Save()
        {
           if (radioPassed.Checked == true)
            {
                _ClsTakTest.TestResult = 1;

            }
            else
            {
                _ClsTakTest.TestResult = 0;

            }
            _ClsTakTest.Notes = textNotes.Text;
            _ClsTakTest.TestAppointmentID = _TestAppontomintId;
            _ClsTakTest.CreatedByUserID = _CreatUserId;
           if (_ClsTakTest.save())
            {
                clsTestAppointment.LocadTestAppontmintById(_TestAppontomintId);
                return true;
            }
            return false;


        }
     
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labInf_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FrmTakTest_Load(object sender, EventArgs e)
        {

        }

        private void buSve_Click(object sender, EventArgs e)
        {
           if(_Save())
            {
                MessageBox.Show("Tak Test Saved()");
                buSve.Enabled = false;

            }
            else
            {
                MessageBox.Show("Tak Test Fild()");
                buSve.Enabled = false;
            }
        }
    }
}
