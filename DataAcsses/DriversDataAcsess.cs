using SettingConc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsses
{
    public class DriversDataAcsess
    {



        public static DataTable GetAllDrivers()
        {



            DataTable data = new DataTable();
            SqlConnection conn = new SqlConnection(clsSettingConc.ConnectionString);
            conn.Open();
            string Qurey = "SELECT* FROM Drivers ";
            
            SqlCommand comd = new SqlCommand(Qurey, conn);
            try
            {

                SqlDataReader Reader = comd.ExecuteReader();
                if (Reader.HasRows)
                {

                    data.Load(Reader);
                    return data;

                }

            }
            catch { }



            return null;




        }

        public static int AddNewDrivers(int PersonID,int CreatedByUserID , DateTime CreatedDate) 
        {

            int DriverId = -1;
            string query = "INSERT INTO  Drivers   VALUES (@PersonID,@CreatedByUserID,@CreatedDate);;" +
                           "SELECT SCOPE_IDENTITY();";

            using (SqlConnection conn = new SqlConnection(clsSettingConc.ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PersonID", PersonID);
                    cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                    cmd.Parameters.AddWithValue("@CreatedDate", CreatedDate);


                    try
                    {
                        object opj = cmd.ExecuteScalar();
                        if (opj != null)
                        {
                            DriverId = Convert.ToInt32(opj);
                        }
                    }
                    catch (Exception)
                    {
                        // قم بتسجيل الخطأ أو طباعته
                    }
                    finally { conn.Close(); }
                }
            }

            return DriverId;


        }
        public static bool IsPersonIDOrderedTwice(int PersonID)
        {
            bool isFound = false;



            string Qurye = "select    top 1 fount=1 from Drivers where PersonID =@PersonID";

            SqlConnection conn = new SqlConnection(clsSettingConc.ConnectionString);
            conn.Open();
            SqlCommand comd = new SqlCommand(Qurye, conn);
            comd.Parameters.AddWithValue("@PersonID", PersonID);


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
        public static bool FindBypersonId(   int PersonID,  ref int DirversId, ref  int CreatedByUserID,  ref DateTime CreatedDate)
        {




            string Qury = "select * from Drivers where PersonID = @PersonID";
            DataTable Drivers = new DataTable();
            SqlConnection conn = new SqlConnection(SettingConc.clsSettingConc.ConnectionString);
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand(Qury, conn);
            sqlCommand.Parameters.AddWithValue("@PersonID", PersonID);




            try
            {
                SqlDataReader reader = sqlCommand.ExecuteReader();
                Drivers.Load(reader);


                reader.Close();


            }
            catch (Exception) { }
            finally
            {
                conn.Close();
            }

            if (Drivers.Rows.Count > 0)
            {

                DataRow RowDrivers = Drivers.Rows[0];


                DirversId = int.Parse(RowDrivers[0].ToString());

                PersonID = int.Parse(RowDrivers[1].ToString());

                CreatedByUserID = int.Parse(RowDrivers[2].ToString());
                CreatedDate  = Convert.ToDateTime(RowDrivers[3]);



                /////////////////////

                return true;

            }
            return false;

















        }

        public static bool FindByDriversId( int DriverID, ref int PersonID, ref int CreatedByUserID, ref DateTime CreatedDate)
        {




            string Qury = "select * from Drivers where DriverID = @DriverID";
            DataTable Drivers = new DataTable();
            SqlConnection conn = new SqlConnection(SettingConc.clsSettingConc.ConnectionString);
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand(Qury, conn);
            sqlCommand.Parameters.AddWithValue("@DriverID", DriverID);




            try
            {
                SqlDataReader reader = sqlCommand.ExecuteReader();
                Drivers.Load(reader);


                reader.Close();


            }
            catch (Exception) { }
            finally
            {
                conn.Close();
            }

            if (Drivers.Rows.Count > 0)
            {

                DataRow RowDrivers = Drivers.Rows[0];



                PersonID = int.Parse(RowDrivers[1].ToString());

                CreatedByUserID = int.Parse(RowDrivers[2].ToString());
                CreatedDate = Convert.ToDateTime(RowDrivers[3]);



                /////////////////////

                return true;

            }
            return false;

















        }


    }


}
