using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcsses;
namespace DataBussnsLayer
{
    public class ClsTakTest
    {

      
     public   int TestId { set; get; }
      public string Notes { set; get; }
        public int TestAppointmentID { set; get; }
        public int TestResult { set; get; }
        public int CreatedByUserID { set; get; }

      public  ClsTakTest()
        {
            TestId = 0;
            Notes = string.Empty;
             TestAppointmentID= 0;
             TestResult = 0;
            CreatedByUserID = 0;    


        }
      private  bool _AddnewTakTest()
        {
            TestId=TakTest.AddNewTakTest(Notes, TestAppointmentID,  TestResult,CreatedByUserID);
            return TestId > 0?true:false;




        }
        public  bool  save()
        {
            return _AddnewTakTest();
        }
     



    }
}
