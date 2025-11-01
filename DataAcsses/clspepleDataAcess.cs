using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SettingConc;
using System.Data;
using System.Runtime.Remoting.Messaging;
using Microsoft.SqlServer.Server;
using System.Security.AccessControl;
using System.Collections;
using System.Runtime.InteropServices.ComTypes;
namespace DataAcsses
{
    public class pepoleDataAcsess
    {
        static public DataTable LoadAllPepole()
        {
            DataTable dataPepole = new DataTable();


            SqlConnection conn = new SqlConnection(clsSettingConc.ConnectionString);
            conn.Open();
            string Qurey = "SELECT     People.PersonID,   People.NationalNo, People.FirstName, People.SecondName, People.ThirdName, People.LastName, People.DateOfBirth, People.Gendor, People.Address, People.Phone, People.Email, Countries.CountryName                      FROM            People INNER JOIN                    Countries ON People.NationalityCountryID = Countries.CountryID";
            SqlCommand comd = new SqlCommand(Qurey, conn);
            try
            {
                SqlDataReader reader = comd.ExecuteReader();
                dataPepole.Load(reader);


                reader.Close();


            }
            catch (Exception) { }
            finally
            {
                conn.Close();
            }
            if (dataPepole.Rows.Count > 0)
            {
                return dataPepole;

            }
            return null;






        }



        static private int _GetContryIdByName(string NameContry)
        {
            int Contryid = 1;
            SqlConnection conn = new SqlConnection(clsSettingConc.ConnectionString);
            conn.Open();
            string Qurey = "SELECT  CountryID   from Countries where CountryName=@Name ";

            SqlCommand comd = new SqlCommand(Qurey, conn);
            comd.Parameters.AddWithValue("@Name", NameContry);
            try
            {
                object Opj = comd.ExecuteScalar();
                if (Opj != null)
                {
                    string s = Opj.ToString();
                    Contryid = int.Parse(s);
                }
               
                

            }
            catch { }



            return Contryid;



        }
        static public int AddNewPerson(string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, int Gendor, string Address, string Phone, string Email, string CountryName, string ImagePath)
        {
            int idperson = -1;
            int ContryId = _GetContryIdByName(CountryName);
            string query = "INSERT INTO People (NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath) " +
                           "VALUES (@NationalNo, @FirstName, @SecondName, @ThirdName, @LastName, @DateOfBirth, @Gendor, @Address, @Phone, @Email, @CountryName, @ImagePath); " +
                           "SELECT SCOPE_IDENTITY();";

            using (SqlConnection conn = new SqlConnection(clsSettingConc.ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NationalNo", NationalNo);
                    cmd.Parameters.AddWithValue("@FirstName", FirstName);
                    cmd.Parameters.AddWithValue("@SecondName", SecondName);
                    cmd.Parameters.AddWithValue("@ThirdName", ThirdName);
                    cmd.Parameters.AddWithValue("@LastName", LastName);
                    cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    cmd.Parameters.AddWithValue("@Gendor", Gendor);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.Parameters.AddWithValue("@Phone", Phone);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@CountryName", ContryId);
                    cmd.Parameters.AddWithValue("@ImagePath", string.IsNullOrEmpty(ImagePath) ? (object)DBNull.Value : ImagePath);

                    try
                    {
                        object opj = cmd.ExecuteScalar();
                        if (opj != null)
                        {
                            idperson = Convert.ToInt32(opj);
                        }
                    }
                    catch (Exception )
                    {
                        // قم بتسجيل الخطأ أو طباعته
                    }
                    finally { conn.Close(); }
                }
            }

            return idperson;
        }
        static public DataTable LodaContrNamy()
        {
            DataTable data = new DataTable();
             SqlConnection conn = new SqlConnection(clsSettingConc.ConnectionString);
            conn.Open();
            string Qurey = "SELECT  CountryName   from Countries  ";

            SqlCommand comd = new SqlCommand(Qurey, conn);
            try
            {

                SqlDataReader Reader= comd.ExecuteReader();
                if (Reader.HasRows) {
                
                data.Load(Reader);
                    return data;
                
                }

            }
            catch { }



            return null;







        }
        static public bool UptadePerson(int PersonID, string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, int Gendor, string Address, string Phone, string Email, string CountryName, string ImagePath)
        {
            string Qurye = "UPDATE People   SET NationalNo = @NationalNo     ,FirstName = @FirstName      ,SecondName = @SecondName     ,ThirdName =@ThirdName     ,LastName = @LastName     ,DateOfBirth = @DateOfBirth     ,Gendor =@Gendor      ,Address = @Address     ,Phone = @Phone     ,Email = @Email     ,NationalityCountryID = @CountryName     ,ImagePath = @ImagePath  WHERE PersonID=@PersonID ";


            int RowAffct = 0;
            int ContryId = _GetContryIdByName(CountryName);

            SqlConnection conn = new SqlConnection(clsSettingConc.ConnectionString);
            conn.Open();

            SqlCommand comd = new SqlCommand(Qurye, conn);
            comd.Parameters.AddWithValue("@NationalNo", NationalNo);
            comd.Parameters.AddWithValue("@FirstName", FirstName);
            comd.Parameters.AddWithValue("@SecondName", SecondName);
            comd.Parameters.AddWithValue("@ThirdName", ThirdName);
            comd.Parameters.AddWithValue("@LastName", LastName);
            comd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);

            comd.Parameters.AddWithValue("@Gendor", Gendor);
            comd.Parameters.AddWithValue("@Address", Address);
            comd.Parameters.AddWithValue("@Phone", Phone);
            comd.Parameters.AddWithValue("@Email", Email);
            comd.Parameters.AddWithValue("@CountryName", ContryId);
            comd.Parameters.AddWithValue("@ImagePath", string.IsNullOrEmpty(ImagePath) ? (object)DBNull.Value : ImagePath);
            comd.Parameters.AddWithValue("@PersonID", PersonID);


            try
            {

                 RowAffct  = comd.ExecuteNonQuery();


                



            }
            catch (Exception)
            {

            }
            finally { conn.Close(); }


            return RowAffct > 0 ? true : false;


        }
        static public bool DeletepersonByid(int idperson)
        {

            int RowAffct = 0;
            string Qurye = "DELETE FROM People WHERE PersonID = @idperson";

            SqlConnection conn = new SqlConnection(clsSettingConc.ConnectionString);
            conn.Open();
            SqlCommand comd = new SqlCommand(Qurye, conn);
            comd.Parameters.AddWithValue("@idperson", idperson);





            try
            {

                RowAffct = comd.ExecuteNonQuery();

            }catch (Exception) { }
            finally { conn.Close(); }

            return RowAffct>0?true:false;


        }
        static public bool GetpersonByid( ref int idperson,  ref string NationalNo,ref string FirstName, ref string SecondName,ref  string ThirdName,ref string LastName, ref DateTime DateOfBirth,  ref int Gendor, ref string Address, ref string Phone,ref  string Email,ref string CountryName,ref string ImagePath)
        {
            DataTable data = new DataTable();


            SqlConnection conn = new SqlConnection(clsSettingConc.ConnectionString);
            conn.Open();
            string Qurey = "select * from Pepole_V where PersonID=@idperson";

            SqlCommand comd = new SqlCommand(Qurey, conn);
            comd.Parameters.AddWithValue("@idperson", idperson);

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

                DataRow Rowperson=data.Rows[0];
                NationalNo = Rowperson[1].ToString();
                FirstName = Rowperson[2].ToString();
                LastName = Rowperson[3].ToString();
                SecondName = Rowperson[4].ToString();
                ThirdName = Rowperson[5].ToString();
                DateOfBirth = Convert.ToDateTime(Rowperson[6]);
                Gendor = int.Parse(Rowperson[7].ToString());
                Address = Rowperson[8].ToString();
                Phone = Rowperson[9].ToString();
                Email = Rowperson[10].ToString();
                CountryName =  Rowperson[11].ToString();
                if (Rowperson[12] != null)
                {
                    ImagePath = Rowperson[12].ToString();
                }
                else
                {
                    ImagePath = string.Empty;
                }
                return true;

            }
            return false;














        }

        static public bool GetpersonByNationalNo( ref int idperson, ref string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref int Gendor, ref string Address, ref string Phone, ref string Email, ref string CountryName, ref string ImagePath)
        {
            DataTable data = new DataTable();


            SqlConnection conn = new SqlConnection(clsSettingConc.ConnectionString);
            conn.Open();
            string Qurey = "select * from pepole_view where NationalNo=@NationalNo";

            SqlCommand comd = new SqlCommand(Qurey, conn);
            comd.Parameters.AddWithValue("@NationalNo", @NationalNo);

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
                idperson = int.Parse(Rowperson[0].ToString());
                NationalNo = Rowperson[1].ToString();
                FirstName = Rowperson[2].ToString();
                LastName = Rowperson[3].ToString();
                SecondName = Rowperson[4].ToString();
                ThirdName = Rowperson[5].ToString();
                DateOfBirth = Convert.ToDateTime(Rowperson[6]);
                Gendor = int.Parse(Rowperson[7].ToString());
                Address = Rowperson[8].ToString();
                Phone = Rowperson[9].ToString();
                Email = Rowperson[10].ToString();
                CountryName = Rowperson[11].ToString();
                if (Rowperson[12] != null)
                {
                    ImagePath = Rowperson[12].ToString();
                }
                else
                {
                    ImagePath = string.Empty;
                }
                return true;

            }
            return false;














        }
        static public bool IsNationalNoExsist( string NationalNo)
        {

            bool isFound=false; 
            SqlConnection conn = new SqlConnection(clsSettingConc.ConnectionString);
            conn.Open();
            string Qurey = "select  top 1 fount=1 from pepole_view where NationalNo=@NationalNo";
            SqlCommand comd = new SqlCommand(Qurey, conn);
            comd.Parameters.AddWithValue("@NationalNo", @NationalNo);

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

        static public bool IsPersonIExsist(int PersonID)
        {
            bool isFound = false;



            string Qurye = "select  top 1 fount=1 from People where PersonID=@idperson";

            SqlConnection conn = new SqlConnection(clsSettingConc.ConnectionString);
            conn.Open();
            SqlCommand comd = new SqlCommand(Qurye, conn);
            comd.Parameters.AddWithValue("@idperson", PersonID);


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

