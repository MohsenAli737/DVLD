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
    public class TestTypeDataAcess
    {
          public static DataTable GetlistTestType()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsSettingConc.ConnectionString);
            connection.Open();
            string Qurey = "select * from TestTypes";
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
            public  static bool Uptate(int TestTypeID,  string TestTypeTitle,  string TestTypeDescription,  int TestTypeFees)
        {





            SqlConnection connection = new SqlConnection(clsSettingConc.ConnectionString);
            connection.Open();
            string Qurey = "UPDATE TestTypes  SET TestTypeTitle = @TestTypeTitle     ,TestTypeDescription = @TestTypeDescription     ,TestTypeFees = @TestTypeFees WHERE  TestTypeID= @TestTypeID";
            SqlCommand command = new SqlCommand(Qurey, connection);
            command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
            command.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);
            command.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
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
        public static bool GetRecordTestTypeById(int TestTypeID, ref string TestTypeTitle, ref string TestTypeDescription, ref int TestTypeFees)
        {






            DataTable data = new DataTable();


            SqlConnection conn = new SqlConnection(clsSettingConc.ConnectionString);
            conn.Open();
            string Qurey = "select * from TestTypes  where TestTypeID=@TestTypeID";

            SqlCommand comd = new SqlCommand(Qurey, conn);
            comd.Parameters.AddWithValue("@TestTypeID", TestTypeID);

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
                TestTypeTitle = Rowperson[1].ToString();
                TestTypeDescription = Rowperson[2].ToString();
                TestTypeFees = Convert.ToInt32(Rowperson[3]);





                return true;
            }

            return false;






        }

    }
}
