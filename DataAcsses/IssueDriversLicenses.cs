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
    public class IssueDriversLicenses
    {


        public static bool GetLicenseInfoByID(int LicenseID, ref int ApplicationID, ref int DriverID, ref int LicenseClass,
            ref DateTime IssueDate, ref DateTime ExpirationDate, ref string Notes,
            ref float PaidFees, ref bool IsActive, ref int IssueReason, ref int createdByUserID, ref int personId)
        {
            bool isFound = false;

            string query = "SELECT * FROM Licenses_Viwe WHERE LicenseID  = @LicenseID";

            using (SqlConnection connection = new SqlConnection(clsSettingConc.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@LicenseID", LicenseID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;

                            ApplicationID = reader["ApplicationID"] != DBNull.Value ? Convert.ToInt32(reader["ApplicationID"]) : 0;
                            DriverID = reader["DriverID"] != DBNull.Value ? Convert.ToInt32(reader["DriverID"]) : 0;
                            LicenseClass = reader["LicenseClass"] != DBNull.Value ? Convert.ToInt32(reader["LicenseClass"]) : 0;
                            IssueDate = reader["IssueDate"] != DBNull.Value ? Convert.ToDateTime(reader["IssueDate"]) : DateTime.MinValue;
                            ExpirationDate = reader["ExpirationDate"] != DBNull.Value ? Convert.ToDateTime(reader["ExpirationDate"]) : DateTime.MinValue;
                            Notes = reader["Notes"] != DBNull.Value ? reader["Notes"].ToString() : "";
                            PaidFees = reader["PaidFees"] != DBNull.Value ? Convert.ToSingle(reader["PaidFees"]) : 0f;
                            IsActive = reader["IsActive"] != DBNull.Value ? Convert.ToBoolean(reader["IsActive"]) : false;
                            IssueReason = reader["IssueReason"] != DBNull.Value ? Convert.ToInt32(reader["IssueReason"]) : 0;
                            createdByUserID = reader["CreatedByUserID"] != DBNull.Value ? Convert.ToInt32(reader["CreatedByUserID"]) : 0;
                            personId = reader["personId"] != DBNull.Value ? Convert.ToInt32(reader["personId"]) : 0;
                        }
                    }
                }
                catch (Exception)
                {
                    isFound = false;
                }
            }

            return isFound;
        }








        public static DataTable GetAllExpirationDateLicenses()
        {



            DataTable data = new DataTable();
            SqlConnection conn = new SqlConnection(clsSettingConc.ConnectionString);
            conn.Open();
            string Qurey = "SELECT   Licenses.LicenseID,   InternationalLicenses.InternationalLicenseID, InternationalLicenses.DriverID, Licenses.ExpirationDate, Licenses.IsActive  FROM        InternationalLicenses full join             Licenses ON InternationalLicenses.IssuedUsingLocalLicenseID = Licenses.LicenseID                   where  getdate()>=Licenses.ExpirationDate ";

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



        public static bool IsApplicationLicensesOrderedTwice(int ApplicationID)
        {
            bool isFound = false;



            string Qurye = "select    top 1 fount=1 from Licenses where ApplicationID =@ApplicationID";

            SqlConnection conn = new SqlConnection(clsSettingConc.ConnectionString);
            conn.Open();
            SqlCommand comd = new SqlCommand(Qurye, conn);
            comd.Parameters.AddWithValue("@ApplicationID", ApplicationID);


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

        public static int GetLicenseIdByApplicatonId(int ApplicationID)
        {




            SqlConnection conn = new SqlConnection(clsSettingConc.ConnectionString);
            conn.Open();
            string Qurey = "select LicenseID  from Licenses where ApplicationID =@ApplicationID ";
            int LicenseId = -1;


            SqlCommand comd = new SqlCommand(Qurey, conn);
            comd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            try
            {
                object result = comd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    LicenseId = Convert.ToInt32(result);
                }







            }
            catch { }



            return LicenseId;









        }




        public static int IssueDriversLicense(
      int applicationID,
      int driverID,
      int licenseClass,
      DateTime issueDate,
      DateTime expirationDate,
      string notes,
      float paidFees,
      bool isActive,
      int issueReason,
      int createdByUserID)
        {
            int licenseID = -1;

            string query = @"
INSERT INTO Licenses 
(ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID)
VALUES 
(@ApplicationID, @DriverID, @LicenseClass, @IssueDate, @ExpirationDate, @Notes, @PaidFees, @IsActive, @IssueReason, @CreatedByUserID); 
SELECT SCOPE_IDENTITY();";

            using (SqlConnection conn = new SqlConnection(clsSettingConc.ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ApplicationID", applicationID);
                    cmd.Parameters.AddWithValue("@DriverID", driverID);
                    cmd.Parameters.AddWithValue("@LicenseClass", licenseClass);
                    cmd.Parameters.AddWithValue("@IssueDate", issueDate);
                    cmd.Parameters.AddWithValue("@ExpirationDate", expirationDate);
                    cmd.Parameters.AddWithValue("@Notes", notes ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PaidFees", paidFees);
                    cmd.Parameters.AddWithValue("@IsActive", isActive);
                    cmd.Parameters.AddWithValue("@IssueReason", issueReason);
                    cmd.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);

                    try
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            licenseID = Convert.ToInt32(result);
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
            }

            return licenseID;
        }

        public static DataTable LoadAllLicensesThisDrivers(int PersonID)
        {
            DataTable dataLicensesId = new DataTable();


            SqlConnection conn = new SqlConnection(clsSettingConc.ConnectionString);
            conn.Open();
            string Qurey = "SELECT       Licenses.*FROM            Applications INNER JOIN                         Licenses ON Applications.ApplicationID = Licenses.ApplicationID INNER JOIN                       Drivers ON Licenses.DriverID = Drivers.DriverID  where PersonID=@PersonID ";

            SqlCommand comd = new SqlCommand(Qurey, conn);
            comd.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                SqlDataReader reader = comd.ExecuteReader();
                dataLicensesId.Load(reader);


                reader.Close();


            }
            catch (Exception) { }
            finally
            {
                conn.Close();
            }
            if (dataLicensesId.Rows.Count > 0)
            {
                return dataLicensesId;

            }
            return null;






        }




    





       
     public static bool Stop_DriversLicenses(int LicensesID)
        {

            string qurey = "UPDATE Licenses   SET IsActive =0   WHERE LicenseID =@LicensesID";


            SqlConnection Conn = new SqlConnection(clsSettingConc.ConnectionString);
            Conn.Open();
            SqlCommand comd = new SqlCommand(qurey, Conn);
            comd.Parameters.AddWithValue("@LicensesID", LicensesID);

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

     

    }
}

