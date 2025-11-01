using DataBussnsLayer;
using ProjDVLD.Control;
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

namespace ProjDVLD.Applications.ApplicatonMange
{
    public partial class FrmApplicationLocailDrivingMange : Form
    {

        private DataTable _DataLocalDrivingLicenseApplicationsView;
        private clsUserscs _CretByUsre;
        public FrmApplicationLocailDrivingMange()
        {
            InitializeComponent();
        }
        private void _LoadDataLocalDriving()
        {
            dataGridViewLocailApplicatonMange.ContextMenuStrip = contextMenuStrip;
            _DataLocalDrivingLicenseApplicationsView = ClsLocalDrivingLicenseApplications.GetAllLocalDrivingLicenseApplicationsView();
           dataGridViewLocailApplicatonMange.DataSource= _DataLocalDrivingLicenseApplicationsView;  
        }
        public void setCretByUsre(clsUserscs CretByUsre)
        {
            _CretByUsre= CretByUsre;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void FrmApplicationMange_Load(object sender, EventArgs e)
        {
            _LoadDataLocalDriving();
        }

        private void buttonAddnewLoacil_Click(object sender, EventArgs e)
        {
            FrmLocalApplicatonLisonccs ApLocalApplicatonLisonccs  = new FrmLocalApplicatonLisonccs(_CretByUsre.UserName);
            ApLocalApplicatonLisonccs.ShowDialog();
            _LoadDataLocalDriving();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void showInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {








            if (dataGridViewLocailApplicatonMange.CurrentRow != null)
            {
                int LocalApplicatonsId = (int)dataGridViewLocailApplicatonMange.CurrentRow.Cells[0].Value;
                FrmShowApplicatons ShowApplicatonsInfo = new FrmShowApplicatons();
                ShowApplicatonsInfo.LoadaApplicainsId(LocalApplicatonsId);   
                ShowApplicatonsInfo.ShowDialog();   

            }

         
        }

        private void cancelAppliciatonsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if(dataGridViewLocailApplicatonMange.CurrentRow != null)
            {
                int LocalApplicatonsId = (int)dataGridViewLocailApplicatonMange.CurrentRow.Cells[0].Value;

               if(ClsApplicatons.CancleStatus(ClsLocalDrivingLicenseApplications.GetApplicatonIdByLocalAppliactonId(LocalApplicatonsId)))
                {

                    MessageBox.Show("Cancle Ok");
                }
                else
                {
                    MessageBox.Show("Fild");
                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

            if (dataGridViewLocailApplicatonMange.CurrentRow != null)
            {
                string ApplicationStatus = dataGridViewLocailApplicatonMange.CurrentRow.Cells[6].Value.ToString();
                int PesstCont = (int)dataGridViewLocailApplicatonMange.CurrentRow.Cells[5].Value;


                 if (ApplicationStatus == "New" && PesstCont == 3)
                {


                    TestlStripMenuItem.Enabled = false;
                    cancelAppliciatonsToolStripMenuItem.Enabled = false;
                    delteteToolStripMenuItem.Enabled = false;
                    LicenseHistoryToolStripMenuItem.Enabled = false;
                    showLicenseToolStripMenuItem.Enabled = false;
                    issueDriversLicensesToolStripMenuItem.Enabled = true;


                }else if (ApplicationStatus == "Completed"  )
                {
                    TestlStripMenuItem.Enabled = false;
                    cancelAppliciatonsToolStripMenuItem.Enabled = false;
                    delteteToolStripMenuItem.Enabled = false;
                    issueDriversLicensesToolStripMenuItem.Enabled = false;
                    LicenseHistoryToolStripMenuItem.Enabled = true;
                    showLicenseToolStripMenuItem.Enabled = true;
                }
                else if (ApplicationStatus == "New")
                {
                    TestlStripMenuItem.Enabled = true;
                    cancelAppliciatonsToolStripMenuItem.Enabled = true;
                    delteteToolStripMenuItem.Enabled = true;
                    issueDriversLicensesToolStripMenuItem.Enabled = false;
                    LicenseHistoryToolStripMenuItem.Enabled = false;
                    showLicenseToolStripMenuItem.Enabled = false;
                }
                else if (ApplicationStatus == "Cancelled")
                {
                    TestlStripMenuItem.Enabled = false;
                    cancelAppliciatonsToolStripMenuItem.Enabled = false;
                    delteteToolStripMenuItem.Enabled = false;
                    issueDriversLicensesToolStripMenuItem.Enabled = false;
                    LicenseHistoryToolStripMenuItem.Enabled = false;
                    showLicenseToolStripMenuItem.Enabled = false;

                }
                else
                {
                    TestlStripMenuItem.Enabled = true;
                    cancelAppliciatonsToolStripMenuItem.Enabled = true;
                    delteteToolStripMenuItem.Enabled = true;
                    LicenseHistoryToolStripMenuItem.Enabled = false;
                    showLicenseToolStripMenuItem.Enabled = false;
                    issueDriversLicensesToolStripMenuItem.Enabled = false;

                }
            }
        }

        private void visionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewLocailApplicatonMange.CurrentRow != null)
            {
                int LocalApplicatonsId = (int)dataGridViewLocailApplicatonMange.CurrentRow.Cells[0].Value;
                FormTestAppoint TestAppomint = new FormTestAppoint(_CretByUsre);
                TestAppomint.SetenTypeTest(1);
                TestAppomint.GetIdAppLocail(LocalApplicatonsId);
                TestAppomint.ShowDialog();


            }
            _LoadDataLocalDriving();

        }

        private void writingTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewLocailApplicatonMange.CurrentRow != null)
            {
                int LocalApplicatonsId = (int)dataGridViewLocailApplicatonMange.CurrentRow.Cells[0].Value;
                FormTestAppoint TestAppomint = new FormTestAppoint(_CretByUsre);
                TestAppomint.SetenTypeTest(2);
                TestAppomint.GetIdAppLocail(LocalApplicatonsId);
                TestAppomint.ShowDialog();


            }
            _LoadDataLocalDriving();
        }



        void _Controlling_The_Hiding_Test(int PassedCount)
        {







            switch (PassedCount)
            {


                case 0:
                    {
                        visionTestToolStripMenuItem.Enabled = true;
                        writingTestToolStripMenuItem.Enabled = false;
                        streetTestToolStripMenuItem.Enabled = false;

                        return;
                    }
                case 1:
                    {
                        visionTestToolStripMenuItem.Enabled = false;
                        writingTestToolStripMenuItem.Enabled = true;
                        streetTestToolStripMenuItem.Enabled = false;

                        return;

                    }
                case 2:
                    {

                        visionTestToolStripMenuItem.Enabled = false;
                        writingTestToolStripMenuItem.Enabled = false;
                        streetTestToolStripMenuItem.Enabled = true;

                        return;

                    }
                case 3:
                    {

                        visionTestToolStripMenuItem.Enabled = false;
                        writingTestToolStripMenuItem.Enabled = false;
                        streetTestToolStripMenuItem.Enabled = false;

                        return;

                    }

            }
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dataGridViewLocailApplicatonMange.CurrentRow != null)
            {
               int  PassedCount= (int)dataGridViewLocailApplicatonMange.CurrentRow.Cells[5].Value;

                _Controlling_The_Hiding_Test(PassedCount);

                return;

                }






            

        }

        private void streetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalApplicatonsId = 0;
            if (dataGridViewLocailApplicatonMange.CurrentRow != null)
            {
                LocalApplicatonsId = (int)dataGridViewLocailApplicatonMange.CurrentRow.Cells[0].Value;
                FormTestAppoint TestAppomint = new FormTestAppoint(_CretByUsre);
                TestAppomint.SetenTypeTest(3);
                TestAppomint.GetIdAppLocail(LocalApplicatonsId);
                TestAppomint.ShowDialog();


            }
            _LoadDataLocalDriving();
        }

        private void issueDriversLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {


            int LocalApplicatonsId = 0;
            if (dataGridViewLocailApplicatonMange.CurrentRow != null)
            {
                LocalApplicatonsId = (int)dataGridViewLocailApplicatonMange.CurrentRow.Cells[0].Value;
                FrmissueDriversLicense issueDriversLicense = new FrmissueDriversLicense(LocalApplicatonsId,_CretByUsre.UserID);
                issueDriversLicense.Show();

            }
       
        }

        private void LicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalApplicatonsId = 0;

            if (dataGridViewLocailApplicatonMange.CurrentRow != null)
            {
                LocalApplicatonsId = (int)dataGridViewLocailApplicatonMange.CurrentRow.Cells[0].Value;
              int PersonId=  ClsLocalDrivingLicenseApplications.GetPersonIdByLocalAppliactonId(LocalApplicatonsId);

                if (PersonId > 0)
                {

FrmIssueHistory FIssueHistory =new FrmIssueHistory(PersonId);

                    FIssueHistory.Show();



                }
            }

        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int LocalApplicatonsId = 0;

            if (dataGridViewLocailApplicatonMange.CurrentRow != null)
            {
                LocalApplicatonsId = (int)dataGridViewLocailApplicatonMange.CurrentRow.Cells[0].Value;
                int ApplicatonId = ClsLocalDrivingLicenseApplications.GetApplicatonIdByLocalAppliactonId(LocalApplicatonsId);
                FrmLicenceShowInfo ShowLicences = new FrmLicenceShowInfo(ApplicatonId);
                ShowLicences.Show();


                }
            }

        }
    }
    

