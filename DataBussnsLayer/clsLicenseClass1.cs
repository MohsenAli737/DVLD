using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcsses;
namespace DataBussnsLayer
{
    public class clsLicenseClass
    {




        public  static bool IsAgeAllwd(int  age,string ClassName)
        {

            return LicenseClasses.IsAgeAllowed(age, ClassName); 


        }

        public static int GetExpiryDate(int LicenseClassId) { 
        
    return   LicenseClasses.GetDefaultValidityLength(LicenseClassId);
        
        
        
        
        }



    }
}
