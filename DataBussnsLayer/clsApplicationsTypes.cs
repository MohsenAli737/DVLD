using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcsses;
namespace DataBussnsLayer
{
    public class clsApplicationsTypes
    {
        enum enmode { Add, update };
        enmode _mode = enmode.Add;
       
        public int ApplicationTypeID { get; set; }
        public int ApplicationFees { get; set; }
        public string ApplicationTypeTitl { get; set; }
        public static clsApplicationsTypes GetApplicationTypeByid(int ApplicationTypeID)

        {
            int ApplicationFees = 0;
            string ApplicationTypeTitl = "";
            if (ApplicationsManageTypeDataAcess.GetApplicationsTypesByid(ApplicationTypeID, ref ApplicationFees, ref ApplicationTypeTitl))
            {
                return new clsApplicationsTypes(ApplicationTypeID, ApplicationFees, ApplicationTypeTitl);
            }
            return null;

        }


        private clsApplicationsTypes(int ApplicationTypeID, int ApplicationFees, string ApplicationTypeTitl)
        {

            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationFees = ApplicationFees;
            this.ApplicationTypeTitl = ApplicationTypeTitl;

            _mode = enmode.update;

        }

        public static DataTable GetApplicationsTypes()
        {
            return ApplicationsManageTypeDataAcess.GetApplicationsTypes();
        }

        public static bool UpdataApplicationTypesById(int ApplicationTypeID, int ApplicationFees, string ApplicationTypeTitl)
        {
            return ApplicationsManageTypeDataAcess.UptateAllApplicationsTypesById(ApplicationTypeID, ApplicationFees, ApplicationTypeTitl);

        }
        public static bool IsExsit(int ApplicationTypeID)
        {
            return ApplicationsManageTypeDataAcess.IsApplicationsTypesExsist(ApplicationTypeID);    
        }


        public bool Save()
        {


            switch (_mode)
            {
                case enmode.update:
                    {


                        if (ApplicationsManageTypeDataAcess.UptateAllApplicationsTypesById(ApplicationTypeID, ApplicationFees, ApplicationTypeTitl))
                        {
                            return true;
                        }
                    }
                    break;
            }

            return false;
        }
    }
}
