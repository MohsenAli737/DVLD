using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcsses;

namespace DataBussnsLayer
{
    public class clsTestAppointment
    {


        enum enTestAppointment { New=0,Uptade=1}
        enTestAppointment _enTestAppointment;
    public    int TestAppointmentId { get; set; }
        public int TestId {  get; set; }

        public int localId { get; set; }

        public DateTime AppointmenDate { get; set; }

        public double PiedFees { get; set; }
        public int isLocked { get; set; }
        public int CreatedByUserID { get; set; }

        public int RetackTestApplicaonId { get; set; }

        private clsTestAppointment(int TestId, int localId, DateTime AppointmenDate, double PiedFees, int CreatedByUserID, int isLocked,int RetackTestApplicaonId)
        {
            this.TestId = TestId;
            this.localId = localId;
            this.PiedFees = PiedFees;
            this.CreatedByUserID = CreatedByUserID;
            this.AppointmenDate = AppointmenDate;
            this.isLocked=isLocked; 
            this.RetackTestApplicaonId=RetackTestApplicaonId;
            _enTestAppointment = enTestAppointment.Uptade;


        }
        public clsTestAppointment()
        {
            this.TestAppointmentId = 0;
            this.TestId = -1;
            this.localId = -1;
            this.PiedFees = 0;
            this.CreatedByUserID = -1;
            this.AppointmenDate = DateTime.Now;
            this.isLocked = 0;
            this.RetackTestApplicaonId = 0;
            _enTestAppointment = enTestAppointment.New;
        }

        public static DataTable GetTestAppointmentByLocalId(int LocalId,int Testtypeid)
        {


           return TestAppointmentsDataAcess.GetTestAppointmentsBylocalIdAndTestType(LocalId, Testtypeid);

        }

          public static clsTestAppointment  GetTesttAppointmentByid(int TesttAppointmentByid)
        {


            int TestId = 0;

            int localId = 0;
            DateTime AppointmenDate =DateTime.Now;

            double PiedFees = 0;
            int isLocked = 0;
            int CreatedByUserID = 0;

            int RetackTestApplicaonId = 0;



            if (TestAppointmentsDataAcess.GetTestAppointmentByid(TesttAppointmentByid ,  ref TestId ,ref  localId, ref AppointmenDate , ref PiedFees, ref isLocked , ref CreatedByUserID, ref RetackTestApplicaonId))
            {
                return new clsTestAppointment(TesttAppointmentByid, TestId, AppointmenDate, PiedFees, isLocked, CreatedByUserID, RetackTestApplicaonId);
            }
            return null;

        }
        private bool _AddnewTestAppointment()
        {

    
                
                
             
            
            this.TestAppointmentId=  TestAppointmentsDataAcess.AddTestAppointment(this.TestId, this.localId, this.AppointmenDate, this.PiedFees, this.CreatedByUserID,this.isLocked , this.RetackTestApplicaonId);
            if (this.TestAppointmentId > 0)
            {
                return true;
            }
            return false;

        }
         public static   clsTestAppointment FindTestAppointmentbyid(int TestAppomintId)



        {


            int TestId = 0;

         int localId = 0;

            DateTime AppointmenDate = DateTime.Now;

            double PiedFees = 0;
            int isLocked = 0;
            int CreatedByUserID = 0;

         int RetackTestApplicaonId =0;

             if ( TestAppointmentsDataAcess.GetTestAppointmentByid(TestAppomintId, ref TestId, ref localId, ref AppointmenDate, ref PiedFees, ref CreatedByUserID, ref isLocked, ref RetackTestApplicaonId))
            {
                return new clsTestAppointment(TestId, localId, AppointmenDate, PiedFees, CreatedByUserID, isLocked, RetackTestApplicaonId);
            }
             return null;   

        }
      public  static bool IsTestAppointmentIsNotLocad(int LocalId)
        {
            return TestAppointmentsDataAcess.IsTestAppointmentIsActiv(LocalId);

        }
        public  static bool  LocadTestAppontmintById(int TestAppointmentId)
        {
            return TestAppointmentsDataAcess.LoacdTestAppointmen(TestAppointmentId);



        }
        public bool Save()
        {

            switch (_enTestAppointment)
            {
                case enTestAppointment.New:
                    {

                       if (_AddnewTestAppointment())
                        {

                            _enTestAppointment = enTestAppointment.Uptade;

                            return true;
                        }
                        break;

                    }
                case enTestAppointment.Uptade:
                    {

                        break;

                    }
            }

            return false;


        }

       








    }
}
