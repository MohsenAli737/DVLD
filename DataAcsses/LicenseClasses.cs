using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SettingConc;
using static System.Net.Mime.MediaTypeNames;
namespace DataAcsses
{
    public class LicenseClasses
    {


      public  static  bool IsAgeAllowed(int Age,string ClassName)
        {

            int age = -1;
            string Quyre = "select  MinimumAllowedAge from LicenseClasses  where ClassName=@ClassName";

            SqlConnection conn = new SqlConnection(clsSettingConc.ConnectionString);
            conn.Open();    
            SqlCommand cmd =  new SqlCommand (Quyre,conn);


            try
            {
                object opjAge =cmd.ExecuteScalar();

                if (opjAge != null) {

                    age = (int)opjAge;
                
                }


            }
            catch (Exception ) { }
            finally { conn.Close(); }
            return age > 0 ?true :false;



        }

        public static int GetDefaultValidityLength(int LicenseClassID)
        {
            int DefaultValidityLength = 0;
            SqlConnection conn = new SqlConnection(clsSettingConc.ConnectionString);
            conn.Open();
            string Qurey = " select   DefaultValidityLength from LicenseClasses where LicenseClassID=@LicenseClassID";

            SqlCommand comd = new SqlCommand(Qurey, conn);
            comd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            try
            {
                object Opj = comd.ExecuteScalar();
                if (Opj != null)
                {
                    DefaultValidityLength = int.Parse(Opj.ToString());
                }



            }
            catch { }



            return DefaultValidityLength;

        }
    }
}
