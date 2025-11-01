using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DataAcsses;
namespace DataBussnsLayer
{
    public class ClsApplicatons
    {

        enum enMode { Add, Updata };
        enMode _mode;
        public enum  enApplicitonType { New_Local_DrivingLicenseService = 1, RenewDrivingLicenseService = 2, ReplacementforaLostDrivingLicense = 3, ReplacementforaDamagedDrivingLicense = 4, ReleaseDetainedDrivingLicsense = 5, NewInternationalLicense = 6, RetakeTest = 7 };
        public int ApplicantID { set; get; }

        public int ApplicantPersonID { set; get; }
        public DateTime ApplicationDate { set; get; }
        public enApplicitonType EnApplicitonType { set; get; }
        public int ApplicationTypeID { set; get; }
        public clsApplicationsTypes ApplicationsTypescls { set; get; }
        public int ApplicationStatus { set; get; }
        public void SetApplicitonsType()
        {
            switch(EnApplicitonType)
            {

                case enApplicitonType.New_Local_DrivingLicenseService:
                    {

                        ApplicationTypeID = 1;
                        ApplicationsTypescls = clsApplicationsTypes.GetApplicationTypeByid(ApplicationTypeID);
                        break;
                    }
                case enApplicitonType.RenewDrivingLicenseService:
                    {

                        ApplicationTypeID = 2;
                        ApplicationsTypescls = clsApplicationsTypes.GetApplicationTypeByid(ApplicationTypeID);

                        break;
                    }
                case enApplicitonType.ReplacementforaLostDrivingLicense:
                    {

                        ApplicationTypeID = 3;

                        ApplicationsTypescls = clsApplicationsTypes.GetApplicationTypeByid(ApplicationTypeID);

                        break;
                    }
                case enApplicitonType.ReplacementforaDamagedDrivingLicense:
                    {

                        ApplicationTypeID = 4;
                        ApplicationsTypescls = clsApplicationsTypes.GetApplicationTypeByid(ApplicationTypeID);

                        break;
                    }
                case enApplicitonType.ReleaseDetainedDrivingLicsense:
                    {

                        ApplicationTypeID = 5;
                        ApplicationsTypescls = clsApplicationsTypes.GetApplicationTypeByid(ApplicationTypeID);

                        break;
                    }
                case enApplicitonType.NewInternationalLicense:
                    {

                        ApplicationTypeID = 6;
                        ApplicationsTypescls = clsApplicationsTypes.GetApplicationTypeByid(ApplicationTypeID);

                        break;
                    }
                case enApplicitonType.RetakeTest:
                    {

                        ApplicationTypeID = 7;
                        ApplicationsTypescls = clsApplicationsTypes.GetApplicationTypeByid(ApplicationTypeID);

                        break;
                    }


            }
        }
        public DateTime LastStatusDate { set; get; }
        public int CreatedByUserID { set; get; }
        public clsPepole clsPepoleinfo {  get; }
        public clsUserscs clsUserscsInfo {  get; }  
        public int PaidFees { set; get; }

        public static ClsApplicatons FindApplicatonsById(int ApplId)
        {
            int ApplicantPersonID = 0, ApplicatonTypeId = 0, ApplicatonStatus = 0, CreateByUserId = 0, PaidFees=0;
            DateTime LastStatusDate = DateTime.MinValue, ApplicationDate= DateTime.MinValue;
            if (ApplicatonsDateAcess.GetApplicatonById(ApplId,  ref ApplicantPersonID,  ref ApplicationDate, ref ApplicatonTypeId, ref  ApplicatonStatus, ref  LastStatusDate, ref PaidFees, ref CreateByUserId))
            {
                return  new ClsApplicatons(ApplId, ApplicantPersonID, ApplicationDate, ApplicatonTypeId, ApplicatonStatus, LastStatusDate, PaidFees, CreateByUserId);
            }
               return null;





        }

        public static bool CancleStatus(int ApplicatonId)
        {
            return ApplicatonsDateAcess.UptataStatus(ApplicatonId,2);

        }
        public static bool IsAgaAllwod(int Age,string ClassName)
        {
            return LicenseClasses.IsAgeAllowed(Age, ClassName);
        }


        public ClsApplicatons (int ApplicantId, int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID, int ApplicationStatus, DateTime LastStatusDate, int PaidFees, int CreatedByUserID)
        {
            this.ApplicantID = ApplicantId;
            this.ApplicantPersonID = ApplicantPersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.clsPepoleinfo = clsPepole.FindpersonById(ApplicantPersonID);
            this.clsUserscsInfo = clsUserscs.GetUserByUserid(CreatedByUserID);
           this.ApplicationsTypescls =clsApplicationsTypes.GetApplicationTypeByid(ApplicationTypeID);

        }
       private bool _ChackidInput()
        {
            if (clsPepole.IsPersonIdExsist(ApplicantPersonID) && clsApplicationsTypes.IsExsit(ApplicationTypeID))
            {
                return true;
            }
            return false;   

        }

        bool _AddNewApplicitons()
        {

            ApplicantID= ApplicatonsDateAcess.AddNewApplicatons(ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees,CreatedByUserID);
            return ApplicantID > 0 ? true : false;


        }

        public static bool IsRequstFind(int personID, string ClassName)
        {
            return ApplicatonsDateAcess.IsApplicatonsRequest(personID, ClassName);
        }
       public ClsApplicatons()
        {

            ApplicantID = -1;
            ApplicantPersonID = -1;
            ApplicationDate= DateTime.Now;
            ApplicationTypeID = -1;
            ApplicationStatus = 1;
            LastStatusDate = DateTime.Now;
            PaidFees = -1;


            CreatedByUserID = -1;
            clsPepoleinfo = new clsPepole();
            clsUserscsInfo = new clsUserscs();
            _mode = enMode.Add;



        }

      
        public bool Save()
        {
            switch (_mode) {
            case enMode.Add:
                    {

                       if (_ChackidInput())
                        {
                           return _AddNewApplicitons();
                        }

                        break;
                    }


                case enMode.Updata:
                    {

                        break;
                    }
            
            }
            return false;


        }

        public static bool CompliteStatus(int ApplicatonId)
        {
            return ApplicatonsDateAcess.UptataStatus(ApplicatonId, 3);

        }












    }
}
