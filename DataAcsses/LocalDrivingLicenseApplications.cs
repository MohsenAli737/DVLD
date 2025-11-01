using Microsoft.SqlServer.Server;
using SettingConc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DataAcsses
{
    public class LocalDrivingLicenseApplications 
    {

      static  public DataTable GetAllLiconseClass()
        {


            DataTable LiconseClass = new DataTable();

            SqlConnection conn = new SqlConnection(clsSettingConc.ConnectionString);
            conn.Open();
            string Qurey = "select ClassName from LicenseClasses;  ";

            SqlCommand comd = new SqlCommand(Qurey, conn);
            try
            {

                SqlDataReader Reader = comd.ExecuteReader();
                if (Reader.HasRows)
                {

                    LiconseClass.Load(Reader);
                    return LiconseClass;

                }

            }
            catch { }



            return null;





        }
      public  static   bool GetpessedTestCountLoaclDrivingLicenseApplicatoinsByid(int LocalApplicatonId, ref int  pessedTestCount)
        {

            string Qury = "select * from LocalDrivingLicenseApplications_View where LocalDrivingLicenseApplicationID=@LocalApplicatonId";
            DataTable LiconseClass = new DataTable();
            SqlConnection conn = new SqlConnection(SettingConc.clsSettingConc.ConnectionString);
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand(Qury, conn);
            sqlCommand.Parameters.AddWithValue("@LocalApplicatonId", LocalApplicatonId);




            try
            {
                SqlDataReader reader = sqlCommand.ExecuteReader();
                LiconseClass.Load(reader);


                reader.Close();


            }
            catch (Exception) { }
            finally
            {
                conn.Close();
            }

            if (LiconseClass.Rows.Count > 0)
            {

                DataRow RowLiconseClass = LiconseClass.Rows[0];



                pessedTestCount = short.Parse(RowLiconseClass[5].ToString());
         


                /////////////////////

                return true;

            }
            return false;










        }
        public static DataTable GetAllDrivingLicenseApplicationsViwe() {





            DataTable LiconseClass = new DataTable();

            SqlConnection conn = new SqlConnection(clsSettingConc.ConnectionString);
            conn.Open();
            string Qurey = "select * from LocalDrivingLicenseApplications_View";

            SqlCommand comd = new SqlCommand(Qurey, conn);
            try
            {

                SqlDataReader Reader = comd.ExecuteReader();
                if (Reader.HasRows)
                {

                    LiconseClass.Load(Reader);
                    return LiconseClass;

                }

            }
            catch { }



            return null;



        }
        public static  bool GetLicenseApplicationsByLocalApplicatonId( int LocalApplicatonId,  ref string className ,   ref  int ApplicantId,  ref int ApplicantPersonID, ref DateTime ApplicationDate, ref int  ApplicationTypeID,ref  int ApplicationStatus, ref DateTime LastStatusDate, ref int PaidFees, ref  int CreatedByUserID)
        {
            string Qury = "select * from LocalDrivingLicenseFullApplications_View where LocalDrivingLicenseApplicationID =@LocalApplicatonId ";
            DataTable LiconseClass = new DataTable();
            SqlConnection conn = new SqlConnection(SettingConc.clsSettingConc.ConnectionString);
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand(Qury, conn);
            sqlCommand.Parameters.AddWithValue("@LocalApplicatonId", LocalApplicatonId);




            try
            {
                SqlDataReader reader = sqlCommand.ExecuteReader();
                LiconseClass.Load(reader);


                reader.Close();


            }
            catch (Exception) { }
            finally
            {
                conn.Close();
            }

            if (LiconseClass.Rows.Count > 0)
            {

                DataRow RowLiconseClass = LiconseClass.Rows[0];


                ApplicantId = int.Parse(RowLiconseClass[0].ToString());

                ApplicantPersonID= int.Parse(RowLiconseClass[1].ToString());

                ApplicationDate = Convert.ToDateTime(RowLiconseClass[2]);
                ApplicationTypeID = int.Parse(RowLiconseClass[3].ToString());
                ApplicationStatus= int.Parse(RowLiconseClass[4].ToString());
                LastStatusDate = Convert.ToDateTime(RowLiconseClass[5]);
                 float fPaidFees=  float.Parse(RowLiconseClass[6].ToString());
                PaidFees =( int)fPaidFees;
                CreatedByUserID = int.Parse(RowLiconseClass[7].ToString());
                className = ApplicatonsDateAcess.GetClassNameById(int.Parse(RowLiconseClass[9].ToString()));

                /////////////////////

                return true;

            }
            return false;







        }


        public static int GetPersonIdByLocalApplicatonId(int LocalApplicatonId)
        {
            string Qoury = "SELECT        Applications.ApplicantPersonID FROM            Applications INNER JOIN                        LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID  where LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID=@LocalApplicatonId";

            Object PersonId = 0;



            SqlConnection conn = new SqlConnection(clsSettingConc.ConnectionString);
            conn.Open();


            SqlCommand sqlCommand = new SqlCommand(Qoury, conn);
            sqlCommand.Parameters.AddWithValue("@LocalApplicatonId", LocalApplicatonId);
            try
            {

                PersonId= sqlCommand.ExecuteScalar();   


            }
            catch (Exception ) { } finally{

                conn.Close();
                    }
            if (Convert.ToInt32(PersonId) > 0)
            {
                return Convert.ToInt32(PersonId);
            }
            return 0;
           
        }


        public static int GetAplicatonidByLocalApplicatonId(int LocalApplicatonId)
        {
            string Qoury = "select  ApplicationID from LocalDrivingLicenseApplications where LocalDrivingLicenseApplicationID=@LocalApplicatonId";
            Object ApplicatonId = 0;



            SqlConnection conn = new SqlConnection(clsSettingConc.ConnectionString);
            conn.Open();


            SqlCommand sqlCommand = new SqlCommand(Qoury, conn);
            sqlCommand.Parameters.AddWithValue("@LocalApplicatonId", LocalApplicatonId);
            try
            {

                ApplicatonId = sqlCommand.ExecuteScalar();


            }
            catch ( Exception) { }
            finally
            {

                conn.Close();
            }
            if (Convert.ToInt32(ApplicatonId) > 0)
            {
                return Convert.ToInt32(ApplicatonId);
            }
            return 0;

        }
        public static int GetClassNameIdByclassName(string ClassName)
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

        static public int AddNewLocalDrivingLicenseApplications(int ApplicationID, string ClasName)
        {
            int LicenseClassID = GetClassNameIdByclassName(ClasName);
            int LocalDrivingLicenseApplicationID=-1;
            string query = "INSERT INTO LocalDrivingLicenseApplications (ApplicationID,LicenseClassID) " +
                           "VALUES (@ApplicationID,@LicenseClassID); " +
                           "SELECT SCOPE_IDENTITY();";

            using (SqlConnection conn = new SqlConnection(clsSettingConc.ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                    cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
                 


                    try
                    {
                        object opj = cmd.ExecuteScalar();
                        if (opj != null)
                        {
                            LocalDrivingLicenseApplicationID = Convert.ToInt32(opj);
                        }
                    }
                    catch (Exception)
                    {
                        // قم بتسجيل الخطأ أو طباعته
                    }
                    finally { conn.Close(); }
                }
            }


            return LocalDrivingLicenseApplicationID;





        }

  



    }
}
