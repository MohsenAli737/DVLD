using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using SettingConc;
namespace DataAcsses
{
    public class ApplicationsManageTypeDataAcess
    {



        public static bool  GetApplicationsTypesByid(int ApplicationTypeID, ref int ApplicationFees,  ref string ApplicationTypeTitl)
        {

          







            DataTable data = new DataTable();


            SqlConnection conn = new SqlConnection(clsSettingConc.ConnectionString);
            conn.Open();
            string Qurey = "select * from ApplicationTypes where ApplicationTypeID=@ApplicationTypeID";

            SqlCommand comd = new SqlCommand(Qurey, conn);
            comd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

            try
            {
                SqlDataReader reader = comd.ExecuteReader();
                data.Load(reader);


                reader.Close();


            }
            catch (Exception) { }
            finally
            {
                conn.Close();
            }
            if (data.Rows.Count > 0)
            {

                DataRow Rowperson = data.Rows[0];
                ApplicationTypeTitl = Rowperson[1].ToString();
                ApplicationFees = Convert.ToInt32(Rowperson[2]);

              



                return true;
            }
              
            return false;
            }
        public static DataTable GetApplicationsTypes()
        {


            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsSettingConc.ConnectionString);
            connection.Open();
            string Qurey = "select * from ApplicationTypes";
            SqlCommand command = new SqlCommand(Qurey, connection);



            try
            {

                SqlDataReader reader = command.ExecuteReader();

                dt.Load(reader);
                return dt;
            }
            catch (Exception) { }
            finally
            {
                connection.Close();
            }


            return null;


        }
       public static bool UptateAllApplicationsTypesById(int ApplicationTypeID, int ApplicationFees,string ApplicationTypeTitl)
        {


            SqlConnection connection = new SqlConnection(clsSettingConc.ConnectionString);
            connection.Open();
            string Qurey = "UPDATE ApplicationTypes   SET ApplicationTypeTitle =@ApplicationTypeTitl ,ApplicationFees =@ApplicationFees WHERE ApplicationTypeID=@ApplicationTypeID";
            SqlCommand command = new SqlCommand(Qurey, connection);
            command.Parameters.AddWithValue("@ApplicationTypeTitl", ApplicationTypeTitl);
            command.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            int RowAffAct=0;
            try
            {
                 RowAffAct = command.ExecuteNonQuery();
            }catch (Exception) { }
            finally
            {
                connection.Close();

            }

            return RowAffAct >0?true:false; 

        }
         public static bool IsApplicationsTypesExsist(int ApplicationTypeID)
        {
            bool isFound = false;



            string Qurye = "select  top 1 fount=1 from ApplicationTypes where ApplicationTypeID=@ApplicationTypeID";

            SqlConnection conn = new SqlConnection(clsSettingConc.ConnectionString);
            conn.Open();
            SqlCommand comd = new SqlCommand(Qurye, conn);
            comd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);


            try
            {

                object result = comd.ExecuteScalar();
                if (result != null && Convert.ToInt32(result) > 0)
                {
                    isFound = true; // سجل موجود
                }

            }
            catch (Exception) { }
            finally { conn.Close(); }

            return isFound;











        }


    }
}
