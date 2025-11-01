using DataBussnsLayer;
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
    public partial class FrmLocalApplicatonLisonccs : Form
    {
        

        clsUserscs _User;
        clsPepole _Person;
        int _Fees = 0;
        ClsLocalDrivingLicenseApplications _LocalDrivingLicenseApplications = new ClsLocalDrivingLicenseApplications();
        public FrmLocalApplicatonLisonccs(string CrtByUserName)
        {
            InitializeComponent();
            _User= clsUserscs.GetUserByUserNmae(CrtByUserName);

        }

        private void _LodaFeesFromApplType()
        {
            clsApplicationsTypes ApplicationsTypes  =clsApplicationsTypes.GetApplicationTypeByid(_LocalDrivingLicenseApplications.ApplicationTypeID);

            _Fees= ApplicationsTypes.ApplicationFees ;

        }
        private void _lodaComboBoxClassName()
        {

            DataTable ClassName = ClsLocalDrivingLicenseApplications.GetAllClClassName();
            if (ClassName != null)
            {
                foreach (DataRow row in ClassName.Rows)
                {
                    comboBoxClassName.Items.Add(row[0]);






                }
                comboBoxClassName.SelectedIndex = 0;


            }
            else
            {
                comboBoxClassName.Items.Add("Class 1 - Small Motorcycle");
            }




        }
        private  void _SetPersonIdFromShowFliter(int personId)
        {
            _Person = clsPepole.FindpersonById(personId);
            buttonSave.Enabled = true;

           
        }
        private void _loadDate()
        {
           
            labelFees.Text=_Fees.ToString();    
            labelAppDate.Text=_LocalDrivingLicenseApplications.ApplicationDate.ToString();   
            labelCuser.Text= _User.UserName.ToString();



        }

       
        private void _Save()
        {
              ///vild//
            if (ClsApplicatons.IsRequstFind(_Person.PersonID, comboBoxClassName.SelectedItem.ToString()))
            {
                MessageBox.Show("  Requst  ( " + _Person.PersonID.ToString()+ ")   Is Find");
                return;
            }
            if (ClsApplicatons.IsAgaAllwod(_Person.GetAge(), comboBoxClassName.SelectedItem.ToString()))
            {
                MessageBox.Show(" Error Age  ( " + _Person.PersonID.ToString() + " ) Is Not Allowd ");
                return;
            }

            _LocalDrivingLicenseApplications.ApplicantPersonID= _Person.PersonID;
            _LocalDrivingLicenseApplications.ApplicationStatus = 1;
            _LocalDrivingLicenseApplications.LicenseClassName = comboBoxClassName.SelectedItem.ToString();
            _LocalDrivingLicenseApplications.PaidFees = _Fees;
            _LocalDrivingLicenseApplications.CreatedByUserID=_User.UserID;  
            if (_LocalDrivingLicenseApplications.SaveLocalDrivingLicenseApplications())
            {
              labelApplicatonsID.Text=  _LocalDrivingLicenseApplications.LocalDrivingID.ToString();
                MessageBox.Show(" Save Applicitons Succseful ") ;


            }
            else
            {
                MessageBox.Show("( Save Applicitons Fild!!) ");

            }


        }


        private void FrmLocalApplicatonLisonccs_Load(object sender, EventArgs e)
        {
            useShowFilter1.setPersonidevenFrmShowFilter += _SetPersonIdFromShowFliter;
            _LodaFeesFromApplType();
            _lodaComboBoxClassName();
            _loadDate();
   
            
        }

        private void useShowFilter1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
_Save();


        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
        }
    }
}
