using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DataAcsses;
namespace DataBussnsLayer
{
    public class ClsLocalDrivingLicenseApplications : ClsApplicatons
    {

        public int LocalDrivingID { set; get; }

        public string LicenseClassName { set; get; }



        public static DataTable GetAllClClassName()
        {
            return LocalDrivingLicenseApplications.GetAllLiconseClass();
        }
        public static DataTable GetAllLocalDrivingLicenseApplicationsView()
        {
            return LocalDrivingLicenseApplications.GetAllDrivingLicenseApplicationsViwe();
        }
        public ClsLocalDrivingLicenseApplications()
        {
            LocalDrivingID = -1;

            LicenseClassName = "";
            EnApplicitonType = enApplicitonType.New_Local_DrivingLicenseService;
            SetApplicitonsType();

        }
        public static int GetPersonIdByLocalAppliactonId(int LocalApplicatnId)
        {
            int personId = LocalDrivingLicenseApplications.GetPersonIdByLocalApplicatonId(LocalApplicatnId);

            return personId;

        }

        public static int GetApplicatonIdByLocalAppliactonId(int LocalApplicatnId)
        {
            int ApplicatonId = LocalDrivingLicenseApplications.GetAplicatonidByLocalApplicatonId(LocalApplicatnId);

            return ApplicatonId;

        }

        public ClsLocalDrivingLicenseApplications(int LocalDrivingID, int ApplicantId, int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID, int ApplicationStatus, DateTime LastStatusDate, int PaidFees, string LicenseClassName, int CreatedByUserID) : base(ApplicantId, ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID)
        {

            this.LocalDrivingID = LocalDrivingID;
            this.LicenseClassName = LicenseClassName;


            EnApplicitonType = enApplicitonType.New_Local_DrivingLicenseService;
            SetApplicitonsType();





        }



        public static ClsLocalDrivingLicenseApplications FindLocalDrivingLicenseApplications_ViewById(int LoaclApplicatonId)

        {
            string LicenseClassName = " ";


            int ApplicantId = 0;
            int ApplicantPersonID = 0;
            DateTime ApplicationDate = DateTime.Now; int ApplicationTypeID = 0; int ApplicationStatus = 0; DateTime LastStatusDate = DateTime.Now; int PaidFees = 0; int CreatedByUserID = 0;


            if (LocalDrivingLicenseApplications.GetLicenseApplicationsByLocalApplicatonId(LoaclApplicatonId, ref LicenseClassName, ref ApplicantId, ref ApplicantPersonID, ref ApplicationDate, ref ApplicationTypeID, ref ApplicationStatus, ref LastStatusDate, ref PaidFees, ref CreatedByUserID))
            {
                return new ClsLocalDrivingLicenseApplications(LoaclApplicatonId, ApplicantId, ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, LicenseClassName, CreatedByUserID);

            }

            return null;



        }


        private bool _AddnewLocalDrivingLicenseApplications()
        {

            LocalDrivingID = LocalDrivingLicenseApplications.AddNewLocalDrivingLicenseApplications(base.ApplicantID, LicenseClassName);
            return LocalDrivingID > 0 ? true : false;







        }

        public bool SaveLocalDrivingLicenseApplications()
        {
            if (base.Save())
            {
                if (_AddnewLocalDrivingLicenseApplications())
                {
                    return true;
                }





            }
            return false;


        }

        public static int GetPassedCount(int LocalApplicaonId)
        {
            int PassedCont = 0;
            if (LocalDrivingLicenseApplications.GetpessedTestCountLoaclDrivingLicenseApplicatoinsByid(LocalApplicaonId, ref PassedCont))

            {
                return PassedCont;
            }
            return 0;




        }

        public static int GetLicenseClassidByLicenseClassName(string LicenseClassName) {


            return LocalDrivingLicenseApplications.GetClassNameIdByclassName(LicenseClassName);
        }
    }
}
