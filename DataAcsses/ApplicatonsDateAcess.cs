using SettingConc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsses
{
    public class ApplicatonsDateAcess
    {


        private static int GetClassNameIdByclassName(string ClassName)
        {

            int clsNameId = -1;
            SqlConnection conn = new SqlConnection(clsSettingConc.ConnectionString);
            conn.Open();
            string Qurey = "select  LicenseClassID ClassName from LicenseClasses where ClassName=@ClassName";

            SqlCommand comd = new SqlCommand(Qurey, conn);
            comd.Parameters.AddWithValue("@ClassName", ClassName);
            try
            {
                object Opj = comd.ExecuteScalar();
                if (Opj != null)
                {
                    string s = Opj.ToString();
                    clsNameId = int.Parse(s);
                }



            }
            catch { }



            return clsNameId;



        }
        public static string GetClassNameById(int LicenseClassID)
        {

            string classname  = "null";
            SqlConnection conn = new SqlConnection(clsSettingConc.ConnectionString);
            conn.Open();
            string Qurey = " select   ClassName from LicenseClasses where LicenseClassID=@LicenseClassID";

            SqlCommand comd = new SqlCommand(Qurey, conn);
            comd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            try
            {
                object Opj = comd.ExecuteScalar();
                if (Opj != null)
                {
                    string s = Opj.ToString();
                    classname = s;
                }



            }
            catch { }



            return classname;



        }

        public static int AddNewApplicatons(int ApplicantPersonID, DateTime ApplicationDate,int  ApplicationTypeID,int  ApplicationStatus,DateTime LastStatusDate, int PaidFees, int  CreatedByUserID)
        {


            int ApplicantnID = -1;
            string query = @"
INSERT INTO Applications 
(ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID)
VALUES 
(@ApplicantPersonID, @ApplicationDate, @ApplicationTypeID, @ApplicationStatus, @LastStatusDate, @PaidFees, @CreatedByUserID); 
SELECT SCOPE_IDENTITY();";


            using (SqlConnection conn = new SqlConnection(clsSettingConc.ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
                    cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

                    cmd.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
                    cmd.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
                    cmd.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
                    cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
                    cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


                    try
                    {
                        object opj = cmd.ExecuteScalar();
                        if (opj != null)
                        {
                            ApplicantnID = Convert.ToInt32(opj);
                        }
                    }
                    catch (Exception)
                    {
                        // قم بتسجيل الخطأ أو طباعته
                    }
                    finally { conn.Close(); }
                }
            }

            return ApplicantnID;

        }
        public static bool IsApplicatonsRequest(int personID, string className)
        {
            object result=null;
            int classNameId=GetClassNameIdByclassName(className);
            string query = @"SELECT 1 
                     FROM Applications  
                     INNER JOIN LocalDrivingLicenseApplications     
                     ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID  
                     WHERE ApplicantPersonID = @personID     
                     AND Applications.ApplicationStatus = 1     
                     AND LocalDrivingLicenseApplications.LicenseClassID = @classNameId";
                  
            using (SqlConnection conn = new SqlConnection(clsSettingConc.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@personID", personID);
                    cmd.Parameters.AddWithValue("@classNameId", classNameId);
                   
                    try
                    {
                        conn.Open();
                         result = cmd.ExecuteScalar();

                        return result != null;
                    }
                    catch (Exception)
                    {
                        
                    }
                }
            }

            return (result !=null) ?true:false;
        }

        public static bool UptataStatus(int ApplicantId ,short Status)
        {

            string qurey = "Update Applications set ApplicationStatus =@Status where ApplicationID=@ApplicantId and  ApplicationStatus !=3";
            SqlConnection Conn = new SqlConnection(clsSettingConc.ConnectionString);
            Conn.Open();
            SqlCommand comd= new SqlCommand(qurey,Conn);
            comd.Parameters.AddWithValue("@Status", Status);
            comd.Parameters.AddWithValue("@ApplicantId", ApplicantId);

            int RowAffict = 0;
            try
            {
                RowAffict = comd.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                Conn.Close();


            }

            return RowAffict > 0 ? true : false; 





        }


        public static bool GetApplicatonById(int ApplicantId, ref int ApplicantPersonID, ref DateTime ApplicationDate, ref int ApplicationTypeID, ref int ApplicationStatus, ref DateTime LastStatusDate, ref int PaidFees, ref int CreatedByUserID)
        {
            DataTable data = new DataTable();


            SqlConnection conn = new SqlConnection(clsSettingConc.ConnectionString);
            conn.Open();
            string Qurey = "select * from Applications where ApplicationID=@ApplicantId";

            SqlCommand comd = new SqlCommand(Qurey, conn);
            comd.Parameters.AddWithValue("@ApplicantId", ApplicantId);

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
                ApplicantId = int.Parse(Rowperson[1].ToString());
                ApplicationDate = Convert.ToDateTime(Rowperson[2]) ;
                ApplicationTypeID = int.Parse(Rowperson[3].ToString());
                ApplicationStatus = int.Parse(Rowperson[4].ToString());
                LastStatusDate = Convert.ToDateTime(Rowperson[5]);
                float fPaidFees = float.Parse(Rowperson[6].ToString());
                CreatedByUserID = int.Parse(Rowperson[7].ToString());

                PaidFees = (int)fPaidFees;
            





                return true;

            }
            return false;



        }

    }
}
