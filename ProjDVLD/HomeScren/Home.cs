using DataBussnsLayer;
using ProjDVLD.Applications.ApplicatonMange;
using ProjDVLD.DetainedLicense.Mang_Datained;
using ProjDVLD.GloblCls;
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
    public partial class Home : Form
    {
       public ClsGlobla clsGlobla =new ClsGlobla ();
        public LoginScren frmloginScren ;
        public Home(LoginScren frmloginScren)
        {

            InitializeComponent();
            this.frmloginScren = frmloginScren;


        }


        private void pepoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PepoleMen pepoleMen = new PepoleMen();
            pepoleMen.ShowDialog    ();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserMenagement userMenagement = new UserMenagement();
            userMenagement.ShowDialog ();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void singOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobla.Memember)
            {

                frmloginScren.MemberUserNameAndPassword();
                frmloginScren.Show();
                this.Close();
                return;
            }

            frmloginScren.Show();
            this.Close();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmchingPassowrd frmchingPassowrd = new frmchingPassowrd();
            frmchingPassowrd.GetClsUser(ref clsGlobla.UserGlobl);
            frmchingPassowrd.ShowDialog();  
        }

        private void accountSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowUser ShowUser = new frmShowUser();
            ShowUser.GetUserId(clsGlobla.UserGlobl.UserID);
            ShowUser.ShowDialog();
          

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmApplicationsMangaType ApplicationsMangaType = new frmApplicationsMangaType();
            ApplicationsMangaType.ShowDialog();
        }

        private void managTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTest_Manage Test_Manage = new frmTest_Manage();
            Test_Manage.ShowDialog();
        }

        private void newDrivingLicenseServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newLocalDrivingLicenseServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLocalApplicatonLisonccs LocalApplicatonLisonccs = new FrmLocalApplicatonLisonccs(clsGlobla.UserGlobl.UserName);
            LocalApplicatonLisonccs.ShowDialog();
        }

        private void locailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmApplicationLocailDrivingMange ApplicationLocailDrivingMange = new FrmApplicationLocailDrivingMange();
            ApplicationLocailDrivingMange.setCretByUsre(clsGlobla.UserGlobl);
             
            ApplicationLocailDrivingMange.ShowDialog();

        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowDrivers frmShowDrivers = new FrmShowDrivers();
            frmShowDrivers.Show();

        }

        private void newInterNatinolLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           FrmMangInternanol MangInternanol= new FrmMangInternanol();
            MangInternanol.Show();
        }

        private void expiredToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExpirationDataLicenses ExpirationDataLicenses =new FrmExpirationDataLicenses();
            ExpirationDataLicenses.Show();
        }

        private void renewDrivingLicenseServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRenewLocal_DriversLicensesApplicatons RenewLocal_DriversLicensesApplicatons=new FrmRenewLocal_DriversLicensesApplicatons(clsGlobla.UserGlobl.UserID);
            RenewLocal_DriversLicensesApplicatons.Show();
        }

        private void replacementForADamagedDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLostOrDamagedLicnsesDrivers LostOrDamagedLicnsesDrivers = new FrmLostOrDamagedLicnsesDrivers(clsGlobla.UserGlobl.UserID);
            LostOrDamagedLicnsesDrivers.Show();

        }

        private void dateinLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dateinLicensesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmcDetainedLicense DetainedLicense = new FrmcDetainedLicense(clsGlobla.UserGlobl.UserID);
            DetainedLicense.Show();
        }

        private void mangeDateinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMangDatein MangeDetainedLicense = new FrmMangDatein(clsGlobla.UserGlobl.UserID);
            MangeDetainedLicense.Show();    
        }
    }
}
