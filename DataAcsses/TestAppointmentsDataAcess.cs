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
using static System.Net.Mime.MediaTypeNames;

namespace DataAcsses
{
    public class TestAppointmentsDataAcess
    {
        public static DataTable GetTestAppointmentsBylocalIdAndTestType(int localId,int TestTypeID)
        {


            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsSettingConc.ConnectionString);
            connection.Open();
            string Qurey = "select TestAppointmentID,AppointmentDate,PaidFees,IsLocked from TestAppointments where (LocalDrivingLicenseApplicationID =@localId) and (TestTypeID=@TestTypeID)";
            SqlCommand command = new SqlCommand(Qurey, connection);
            command.Parameters.AddWithValue("@localId", localId);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);



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
        public static int AddTestAppointment(int TestId, int localId, DateTime AppointmenDate, double PiedFees,int CreatedByUserID, int IsLocked, int RetackTestApplicaonId)
        {




            int TestAppointmentId = -1;
            string query = "INSERT INTO TestAppointments(TestTypeID,LocalDrivingLicenseApplicationID,AppointmentDate,PaidFees,CreatedByUserID,IsLocked,RetakeTestApplicationID) " +
                           "VALUES (@TestId,@localId,@AppointmenDate,@PiedFees,@CreatedByUserID,@IsLocked,@RetakeTestApplicationID); " +
                           "SELECT SCOPE_IDENTITY();";

            using (SqlConnection conn = new SqlConnection(clsSettingConc.ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TestId", TestId);
                    cmd.Parameters.AddWithValue("@localId", localId);

                    cmd.Parameters.AddWithValue("@AppointmenDate", AppointmenDate);
                    cmd.Parameters.AddWithValue("@PiedFees", PiedFees);
                    cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                    cmd.Parameters.AddWithValue("@IsLocked", IsLocked);
                    if (RetackTestApplicaonId > 0)
                    {
                        cmd.Parameters.AddWithValue("@RetakeTestApplicationID", RetackTestApplicaonId);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);
                    }

                    try
                    {
                        object opj = cmd.ExecuteScalar();
                        if (opj != null)
                        {
                            TestAppointmentId = Convert.ToInt32(opj);
                        }
                    }
                    catch (Exception)
                    {
                        // قم بتسجيل الخطأ أو طباعته
                    }
                    finally { conn.Close(); }
                }
            }


            return TestAppointmentId ;





        }

        public static bool UptateTestAppointment(int LocalDrivingLicenseApplicationID,  DateTime AppointmenDate)
        {

            SqlConnection connection = new SqlConnection(clsSettingConc.ConnectionString);
            connection.Open();
            string Qurey = "UPDATE TestAppointments  SET AppointmentDate = @AppointmenDate    WHERE  LocalDrivingLicenseApplicationID= @LocalDrivingLicenseApplicationID";
            SqlCommand command = new SqlCommand(Qurey, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeDescription", AppointmenDate);
       
            int RowAffAct = 0;
            try
            {
                RowAffAct = command.ExecuteNonQuery();
            }
            catch (Exception) { }
            finally
            {
                connection.Close();

            }

            return RowAffAct > 0 ? true : false;




        }

        public static bool IsTestAppointmentIsActiv(int LoaclId)
        {

                        bool isFound=false; 
            SqlConnection conn = new SqlConnection(clsSettingConc.ConnectionString);
            conn.Open();
            string Qurey = "select  top 1 fount=1 from TestAppointments where LocalDrivingLicenseApplicationID=@LoaclId and IsLocked=0;";
            SqlCommand comd = new SqlCommand(Qurey, conn);
            comd.Parameters.AddWithValue("@LoaclId", LoaclId);

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
        public static bool GetTestAppointmentByid(int TestAppontmentId,  ref int TestId, ref int localId, ref DateTime AppointmenDate, ref double PiedFees, ref int CreatedByUserID, ref int IsLocked, ref int RetackTestApplicaonId)
        {

            DataTable data = new DataTable();


            SqlConnection conn = new SqlConnection(clsSettingConc.ConnectionString);
            conn.Open();
            string Qurey = "select * from TestAppointments where TestAppointmentID=@TestAppontmentId";

            SqlCommand comd = new SqlCommand(Qurey, conn);
            comd.Parameters.AddWithValue("@TestAppontmentId", TestAppontmentId);

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

                int.TryParse(Rowperson[1]?.ToString(), out TestId);
                int.TryParse(Rowperson[2]?.ToString(), out localId);

                DateTime.TryParse(Rowperson[3]?.ToString(), out AppointmenDate);

                double.TryParse(Rowperson[4]?.ToString(), out PiedFees);
                int.TryParse(Rowperson[5]?.ToString(), out CreatedByUserID);
                int.TryParse(Rowperson[6]?.ToString(), out IsLocked);
                int.TryParse(Rowperson[7]?.ToString(), out RetackTestApplicaonId);

                return true;
            }


            return false;
        }
        public static bool Uptata (int TestAppontmentId,  int TestId,  int localId,  DateTime AppointmenDate,  int PiedFees,  int CreatedByUserID,  int IsLocked,  int RetackTestApplicaonId)
        {





            return false;
        }

        public static bool LoacdTestAppointmen(int TestAppointmentId)
        {


            SqlConnection connection = new SqlConnection(clsSettingConc.ConnectionString);
            connection.Open();
            string Qurey = "UPDATE TestAppointments  SET isLocked = 1    WHERE  TestAppointmentId= @TestAppointmentId";
            SqlCommand command = new SqlCommand(Qurey, connection);
            command.Parameters.AddWithValue("@TestAppointmentId", TestAppointmentId);
  
            int RowAffAct = 0;
            try
            {
                RowAffAct = command.ExecuteNonQuery();
            }
            catch (Exception) { }
            finally
            {
                connection.Close();

            }

            return RowAffAct > 0 ? true : false;


        }

    }
}
