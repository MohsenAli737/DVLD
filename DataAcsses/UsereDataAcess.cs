using SettingConc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsses
{
    public class UsereDataAcess
    {

        public static DataTable GetAllUsers()
        {
            DataTable dtusers = new DataTable();


            SqlConnection conn = new SqlConnection(clsSettingConc.ConnectionString);
            conn.Open();
            string Qurey = "select * from Users_View";
            SqlCommand comd = new SqlCommand(Qurey, conn);
            try
            {
                SqlDataReader reader = comd.ExecuteReader();
                dtusers.Load(reader);


                reader.Close();


            }
            catch (Exception) { }
            finally
            {
                conn.Close();
            }
            if (dtusers.Rows.Count > 0)
            {
                return dtusers;

            }
            return null;







        }
        public static int AddnewUser(int FkPersonId, string UserName, string Password, bool IsActive)
        {
            int UserId = -1;
            string query = "INSERT INTO  Users   VALUES (@FkPersonId,@UserName,@Password,@IsActive);;" +
                           "SELECT SCOPE_IDENTITY();";

            using (SqlConnection conn = new SqlConnection(clsSettingConc.ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FkPersonId", FkPersonId);
                    cmd.Parameters.AddWithValue("@UserName", UserName);
                    cmd.Parameters.AddWithValue("@Password", Password);
                    cmd.Parameters.AddWithValue("@IsActive", IsActive);

                    try
                    {
                        object opj = cmd.ExecuteScalar();
                        if (opj != null)
                        {
                            UserId = Convert.ToInt32(opj);
                        }
                    }
                    catch (Exception)
                    {
                        // قم بتسجيل الخطأ أو طباعته
                    }
                    finally { conn.Close(); }
                }
            }

            return UserId;
        }

        public static bool IsUserNameAndPasswordExsit(string Username, string password)
        {

            bool isFound = false;



            string Qurye = "select  top 1 fount=1 from Users where  UserName=@Username and Password =@password";

            SqlConnection conn = new SqlConnection(clsSettingConc.ConnectionString);
            conn.Open();
            SqlCommand comd = new SqlCommand(Qurye, conn);
            comd.Parameters.AddWithValue("@Username", Username);
            comd.Parameters.AddWithValue("@password", password);

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
        public static bool IsUserNameExsit(string Username)
        {
            bool isFound = false;



            string Qurye = "select  top 1 fount=1 from Users where  UserName=@Username ";

            SqlConnection conn = new SqlConnection(clsSettingConc.ConnectionString);
            conn.Open();
            SqlCommand comd = new SqlCommand(Qurye, conn);
            comd.Parameters.AddWithValue("@Username", Username);


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
        public static bool GetUserByUserNmae(ref int UserID, ref int FkPersonId, string UserName, ref string Password, ref bool IsActive)
        {

            DataTable data = new DataTable();


            SqlConnection conn = new SqlConnection(clsSettingConc.ConnectionString);
            conn.Open();
            string Qurey = "select  * from Users where  UserName= @UserName";

            SqlCommand comd = new SqlCommand(Qurey, conn);
            comd.Parameters.AddWithValue("@UserName", UserName);

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
                UserID = int.Parse(Rowperson[0].ToString());
                FkPersonId = int.Parse(Rowperson[1].ToString());
                Password = Rowperson[3].ToString();
                IsActive = Convert.ToBoolean(Rowperson[4]);


                /////////////////////

                return true;

            }
            return false;






        }
        public static bool GetUserByUseId( int UserID, ref int FkPersonId, ref string UserName, ref string Password, ref bool IsActive)
        {

            DataTable data = new DataTable();


            SqlConnection conn = new SqlConnection(clsSettingConc.ConnectionString);
            conn.Open();
            string Qurey = "select  * from Users where  UserID= @UserID";

            SqlCommand comd = new SqlCommand(Qurey, conn);
            comd.Parameters.AddWithValue("@UserID", UserID);

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
                FkPersonId = int.Parse(Rowperson[1].ToString());
                UserName = Rowperson[2].ToString();
                Password = Rowperson[3].ToString();
                IsActive = Convert.ToBoolean(Rowperson[4]);


                /////////////////////

                return true;

            }
            return false;






        }
        static public bool DeleteUserByUserId(int UserID)
        {

            int RowAffct = 0;
            string Qurye = "DELETE  from Users where  UserID= @UserID";

            SqlConnection conn = new SqlConnection(clsSettingConc.ConnectionString);
            conn.Open();
            SqlCommand comd = new SqlCommand(Qurye, conn);
            comd.Parameters.AddWithValue("@UserID", UserID);





            try
            {

                RowAffct = comd.ExecuteNonQuery();

            }
            catch (Exception) { }
            finally { conn.Close(); }

            return RowAffct > 0 ? true : false;


        }


        static public bool UptadeUser( int UserID, string UserName,  string Password,  bool IsActive)
        {
            string Qurye = "UPDATE Users   SET        UserName = @UserName     ,Password =@Password     ,IsActive = @IsActive    where UserID=@UserID  ";


            int RowAffct = 0;

            SqlConnection conn = new SqlConnection(clsSettingConc.ConnectionString);
            conn.Open();

            SqlCommand comd = new SqlCommand(Qurye, conn);
            comd.Parameters.AddWithValue("@UserName", UserName);
            comd.Parameters.AddWithValue("@Password", Password);
            comd.Parameters.AddWithValue("@IsActive", IsActive);
            comd.Parameters.AddWithValue("@UserID", UserID);



            try
            {

                RowAffct = comd.ExecuteNonQuery();






            }
            catch (Exception)
            {

            }
            finally { conn.Close(); }


            return RowAffct > 0 ? true : false;


        }
        static public bool IsIdpersonIsExsit(int Personid)
        {

            bool isFound = false;



            string Qurye = "select  top 1 fount=1 from Users where   PersonID =@Personid";

            SqlConnection conn = new SqlConnection(clsSettingConc.ConnectionString);
            conn.Open();
            SqlCommand comd = new SqlCommand(Qurye, conn);
            comd.Parameters.AddWithValue("@Personid", Personid);
     

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
