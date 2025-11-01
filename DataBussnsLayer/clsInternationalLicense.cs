using DataAcsses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
namespace DataBussnsLayer
{
    public class ClsInternationalLicense
    {




        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int InternationalLicenseID { set; get; }
        public int DriverID { set; get; }
        public int IssuedUsingLocalLicenseID { set; get; }
        public DateTime IssueDate { set; get; }
        public DateTime ExpirationDate { set; get; }
        public bool IsActive { set; get; }
        public int CreatUserId { set; get; }
        public int ApplicatonId { set; get; }
        public ClsDirvers clsDirversinfo { set; get; }
        public clsUserscs clsUseres { set; get; }
        public ClsIssueDriversLicenses clslicensesinfo { set; get; }   
        public ClsInternationalLicense()
        {

            InternationalLicenseID = -1;
            DriverID = -1;
            IssuedUsingLocalLicenseID = -1;
         IssueDate = DateTime.Now;
            ExpirationDate = DateTime.Now;
            IsActive = false;
            CreatUserId = -1;
            ApplicatonId = -1;
             clsDirversinfo = null; 
             clslicensesinfo = null;
            clsUseres = null;
        }

        private ClsInternationalLicense(int InternationalLicenseID, int ApplicatonId, int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatUserId)
        {
            this.DriverID = DriverID;
            this.InternationalLicenseID = InternationalLicenseID;
            this.IssuedUsingLocalLicenseID = IssuedUsingLocalLicenseID;
            this.CreatUserId = CreatUserId;
            this.ApplicatonId = ApplicatonId;
            this.IsActive = IsActive;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            Mode = enMode.AddNew;
            clsDirversinfo =ClsDirvers.FindByDirversBYid(this.DriverID);
            clslicensesinfo = ClsIssueDriversLicenses.FindLicenceById(this.IssuedUsingLocalLicenseID);
            clsUseres =clsUserscs.GetUserByUserid(this.CreatUserId);
        }


        private bool _AddNewInternationalLicense()
        {

            InternationalLicenseID = clsInternationalLicenseData.AddNewInternationalLicense( ApplicatonId, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatUserId);
            return (InternationalLicenseID != -1);

        }


        public static ClsInternationalLicense Find(int InternationalLicenseID)



        {



            int DriverID = 0;
            int IssuedUsingLocalLicenseID = 0;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpirationDate = DateTime.Now;
            bool IsActive = true;
            int CreatUserId = 1;
            int ApplicatonId = 1;


            if (clsInternationalLicenseData.GetInternationalLicenseInfoByID(InternationalLicenseID, ref ApplicatonId, ref DriverID, ref IssuedUsingLocalLicenseID, ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatUserId))
            {


                return new ClsInternationalLicense(InternationalLicenseID, ApplicatonId, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatUserId);
            }




            return null;











        }

        public static DataTable GetAllInternationalLicenses()
        {
            return clsInternationalLicenseData.GetAllInternationalLicenses();

        }

        public bool Save()
        {

            //Because of inheritance first we call the save method in the base class,
            //it will take care of adding all information to the application table.


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewInternationalLicense())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }


            }

            return false;
        }

        public static int GetActiveInternationalLicenseIDByDriverID(int DriverID)
        {

            return clsInternationalLicenseData.GetActiveInternationalLicenseIDByDriverID(DriverID);

        }

        public static DataTable GetDriverInternationalLicenses(int DriverID)
        {
            return clsInternationalLicenseData.GetDriverInternationalLicenses(DriverID);
        }
    }





}

