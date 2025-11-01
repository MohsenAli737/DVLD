using DataAcsses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBussnsLayer
{
    public class ClsDirvers
    {
       public int DirversId { set; get; }
        public int PersonID { set; get; }

        public int CreatedByUserID { set; get; }
        public DateTime CreatedDate { set; get; }
        public clsPepole ClspersonInfo { set; get; }    
        public ClsDirvers()
        {
             DirversId =0;
            PersonID=0;

             CreatedByUserID=0;
             CreatedDate=DateTime.Now;
            ClspersonInfo = null;
        }


        private ClsDirvers(int DirversId,int PersonID,int CreatedByUserID, DateTime CreatedDate )
        {
            this.DirversId = DirversId;
            this.PersonID = PersonID;

            this.CreatedByUserID = CreatedByUserID;
            this.CreatedDate = CreatedDate;
            ClspersonInfo =clsPepole.FindpersonById(this.PersonID);
        }

        public static DataTable GetAllDrivers()
        {

            return DriversDataAcsess.GetAllDrivers();
        }

        public static bool DriversIsFindPersonID(int PersonID)
        {
  return DriversDataAcsess.IsPersonIDOrderedTwice(PersonID);
        }
        private bool  _AddnewDirvers()
        {
            DirversId = DriversDataAcsess.AddNewDrivers(PersonID, CreatedByUserID, CreatedDate);
            if (DirversId > 0)
            {
                return true;
            }
            return false;

        }

        public static ClsDirvers FindByPersonID(int PersonID) {

            int DirversId = 0;

            int CreatedByUserID = 0;
            DateTime CreatedDate = DateTime.Now;



            if (DriversDataAcsess.FindBypersonId(PersonID, ref DirversId, ref CreatedByUserID, ref CreatedDate)){ return new ClsDirvers(DirversId, PersonID, CreatedByUserID, CreatedDate); }

             
            
          return null;


    }

      public  static ClsDirvers FindByDirversBYid(int DriversId)
        {

            int persinid = 0;

            int CreatedByUserID = 0;
            DateTime CreatedDate = DateTime.Now;



            if (DriversDataAcsess.FindByDriversId(DriversId, ref persinid, ref CreatedByUserID, ref CreatedDate))
            {



                return new ClsDirvers(DriversId, persinid, CreatedByUserID, CreatedDate);
            }

            return null;



        }
        public bool Save()
        {
            return _AddnewDirvers();
        }

    }
}
