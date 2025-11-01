using SettingConc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsses
{
    public class TakTest
    {

         static public int AddNewTakTest(string Notes, int TestAppointmentID, int TestResult, int CreatedByUserID)
        {


            int TakTestId = -1;
            string query = "INSERT INTO  Tests   VALUES (@TestAppointmentID,@TestResult,@Notes,@CreatedByUserID);;" +
                           "SELECT SCOPE_IDENTITY();";

            using (SqlConnection conn = new SqlConnection(clsSettingConc.ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
                    cmd.Parameters.AddWithValue("@Notes", Notes);
                    cmd.Parameters.AddWithValue("@TestResult", TestResult);
                    cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                    try
                    {
                        object opj = cmd.ExecuteScalar();
                        if (opj != null)
                        {
                            TakTestId = Convert.ToInt32(opj);
                        }
                    }
                    catch (Exception)
                    {
                        // قم بتسجيل الخطأ أو طباعته
                    }
                    finally { conn.Close(); }
                }
            }

            return TakTestId;


        }


    }

}
