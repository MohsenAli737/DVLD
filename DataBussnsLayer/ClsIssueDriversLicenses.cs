using DataAcsses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DataBussnsLayer
{

    
    public class ClsIssueDriversLicenses
    {


        public int LicenseID { set; get; }
        public int A_pplicantPersonID { set; get; }
        public int ApplicationID { set; get; }

        public int DriverID { set; get; }


        public int LicenseClass { set; get; }
        public DateTime IssueDate { set; get; }
        public DateTime ExpirationDate { set; get; }
        public string Notes { set; get; }
        public float PaidFees { set; get; }
        public bool IsActive { set; get; }
        public int IssueReason { set; get; }
        public int CreatedByUserID { set; get; }
        public  clsPepole personInf { set; get; }
        public ClsApplicatons ApplicatonsinfoCls {  set; get; } 
        public ClsIssueDriversLicenses()
        {
            LicenseID = 0;
            ApplicationID = 0;
            DriverID = 0;
            LicenseClass = 0;
            IssueDate = DateTime.Now;
            ExpirationDate = DateTime.Now.AddYears(1);
            Notes = string.Empty;
            PaidFees = 0;
            IsActive = true;
            IssueReason = 0;
            CreatedByUserID = 0;
            A_pplicantPersonID = 0;

            personInf = new clsPepole();
            ApplicatonsinfoCls= new ClsApplicatons();









        }



        public static DataTable GetAllExpirationDataLicenses()
        {
            return IssueDriversLicenses.GetAllExpirationDateLicenses();
        }
       public bool IsExpirationDate()
        {
            return this.ExpirationDate <= DateTime.Now;
        }

        private bool _AddIssueDrivers()
        {
            LicenseID= IssueDriversLicenses.IssueDriversLicense(ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate,Notes,PaidFees,IsActive,IssueReason,CreatedByUserID);

            if (LicenseID > 0)
            {
                return true; 
            }
            return false;















    }


    public static bool IsApplicationLicensesOrderedTwice(int applicationID)
        {

          return  IssueDriversLicenses.IsApplicationLicensesOrderedTwice(applicationID);


        }

        public  bool save()
        {
           return _AddIssueDrivers();
        }

















     

        private ClsIssueDriversLicenses(int licenseID, int applicationID, int driverID, int licenseClass, DateTime issueDate, DateTime expirationDate, string notes, float paidFees, bool isActive, int issueReason, int createdByUserID,int personid)
        {
            LicenseID = licenseID;
            ApplicationID = applicationID;
            DriverID = driverID;
            LicenseClass = licenseClass;
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            Notes = notes;
            PaidFees = paidFees;
            IsActive = isActive;
            IssueReason = issueReason;
            CreatedByUserID = createdByUserID;
            A_pplicantPersonID = personid;
            personInf = clsPepole.FindpersonById(personid);
            ApplicatonsinfoCls = ClsApplicatons.FindApplicatonsById(ApplicationID);


        }


        public static  ClsIssueDriversLicenses FindLicenceById(int licenseID)
        {

            int ApplicationID = 0;
            int DriverID = 0;
            int LicenseClass = 0;
            DateTime IssueDate = DateTime.Now;
                 DateTime ExpirationDate = DateTime.Now;
            string Notes = " ";
            float PaidFees = 0;
            bool IsActive = true;
            int IssueReason =0;
            int CreatedByUserID = 0;
            int personId = 0;
            if (IssueDriversLicenses.GetLicenseInfoByID(licenseID, ref ApplicationID, ref DriverID, ref LicenseClass, ref IssueDate,  ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID,ref personId)){

                return new ClsIssueDriversLicenses(licenseID, ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID, personId);
                


            }
            return null;








        }








        public bool Renew_LocalDriversLicensesApplicatons(int CreatedByUserID)
        {
            ClsApplicatons RenewApplicatons=new ClsApplicatons();
            RenewApplicatons.EnApplicitonType = ClsApplicatons.enApplicitonType.RenewDrivingLicenseService;
            RenewApplicatons.SetApplicitonsType();
            RenewApplicatons.ApplicantPersonID = personInf.PersonID;
            RenewApplicatons.ApplicationDate = DateTime.Now;
            RenewApplicatons.LastStatusDate= DateTime.Now;
            RenewApplicatons.PaidFees = RenewApplicatons.ApplicationsTypescls.ApplicationFees;
            RenewApplicatons.ApplicationStatus = 3;
            RenewApplicatons.CreatedByUserID = CreatedByUserID;
            if (RenewApplicatons.Save())
            {

               this.ApplicationID= RenewApplicatons.ApplicantID;
                return true;

            }
            return false;


        }

        public bool Damaged_LocalDriversLicensesApplicatons(int CreatedByUserID)
        {
            ClsApplicatons RenewApplicatons = new ClsApplicatons();
            RenewApplicatons.EnApplicitonType = ClsApplicatons.enApplicitonType.ReplacementforaDamagedDrivingLicense;
            RenewApplicatons.SetApplicitonsType();
            RenewApplicatons.ApplicantPersonID = personInf.PersonID;
            RenewApplicatons.ApplicationDate = DateTime.Now;
            RenewApplicatons.LastStatusDate = DateTime.Now;
            RenewApplicatons.PaidFees = RenewApplicatons.ApplicationsTypescls.ApplicationFees;
            RenewApplicatons.ApplicationStatus = 3;
            RenewApplicatons.CreatedByUserID = CreatedByUserID;
            if (RenewApplicatons.Save())
            {

                this.ApplicationID = RenewApplicatons.ApplicantID;
                return true;

            }
            return false;


        }
        public bool Lost_LocalDriversLicensesApplicatons(int CreatedByUserID)
        {
            ClsApplicatons RenewApplicatons = new ClsApplicatons();
            RenewApplicatons.EnApplicitonType = ClsApplicatons.enApplicitonType.ReplacementforaDamagedDrivingLicense;
            RenewApplicatons.SetApplicitonsType();
            RenewApplicatons.ApplicantPersonID = personInf.PersonID;
            RenewApplicatons.ApplicationDate = DateTime.Now;
            RenewApplicatons.LastStatusDate = DateTime.Now;
            RenewApplicatons.PaidFees = RenewApplicatons.ApplicationsTypescls.ApplicationFees;
            RenewApplicatons.ApplicationStatus = 3;
            RenewApplicatons.CreatedByUserID = CreatedByUserID;
            if (RenewApplicatons.Save())
            {

                this.ApplicationID = RenewApplicatons.ApplicantID;
                return true;

            }
            return false;


        }
        public  bool Stop_DriversLicenses()
        {
            return IssueDriversLicenses.Stop_DriversLicenses(this.LicenseID);
        }
        public static int FindLicensebYApplictonId(int ApplictonId)
        {


            return IssueDriversLicenses.GetLicenseIdByApplicatonId(ApplictonId);





        }


        public static DataTable GetDriversLicensesByDriverId(int PersonID)
        {
           return IssueDriversLicenses.LoadAllLicensesThisDrivers(PersonID);
        }


    }
}
