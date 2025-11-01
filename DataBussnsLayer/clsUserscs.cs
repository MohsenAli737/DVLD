using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using DataAcsses;
using SettingConc;
namespace DataBussnsLayer
{
    public class clsUserscs
    {
       enum enmode {Add,Uptade};
        enmode _mode;

        public int UserID { set; get; }
        public int FkPersonId { set; get; }
        public string UserName { set; get; }
        public string Password { set; get; }
        public bool IsActive { set; get; }

        public clsUserscs (){
            UserID=-1;
            FkPersonId = -1;
            UserName="";
            Password="";
            IsActive=false;
            _mode=enmode.Add;


    }

        private clsUserscs(int UserID, int FkPersonId, string UserName, string Password, bool IsActive)
        {
            this.UserID = UserID;
            this.FkPersonId = FkPersonId;
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;

            _mode = enmode.Uptade;


        }
        public static DataTable GetAllUsers()
        {
           return UsereDataAcess.GetAllUsers();
        }
        public static bool IsIdpersonIsExsit(int personId)
        {
            return UsereDataAcess.IsIdpersonIsExsit(personId);
        }
        private bool _AddnewUser()
        {

            UserID = UsereDataAcess.AddnewUser(FkPersonId, UserName, Password, IsActive);
            return UserID>0?true:false;
        }
        private bool _UptateUser()
        {
            if (UsereDataAcess.UptadeUser(UserID, UserName, Password, IsActive))
            {

                return true;
            }
            return false;


        }
        public bool Save()
        {
            switch (_mode)
            {
                case enmode.Add:
                    {


                        if (_AddnewUser())
                        {
                            _mode = enmode.Uptade;
                            return true;
                        }

                        break;
                    }
                case enmode.Uptade:
                    {


                        if (_UptateUser())
                        {



                            return true;

                        }
                        break;



                    }




                  
            }
            return false;
        }

       static public  bool  DeleteUserByUserId(int UserId)
        {

            return UsereDataAcess.DeleteUserByUserId(UserId);

        }



        public static clsUserscs GetUserByUserid(int UserID)
        {
           
            int FkPersonId = -1;
            string Password = "", Username="";
            bool IsActive = true;
            if (UsereDataAcess.GetUserByUseId( UserID, ref FkPersonId, ref Username , ref Password, ref IsActive))
            {
                return new clsUserscs(UserID, FkPersonId, Username, Password, IsActive);
            }
            return null;


        }


        public static bool IsUserNameAndPasswordExsit(string Username,string password)
        {

            return UsereDataAcess.IsUserNameAndPasswordExsit(Username,password);

        }
         public static clsUserscs GetUserByUserNmae(string Username)
        {
            int UserID = -1;
              int FkPersonId = -1;
               string Password = "";
               bool IsActive=true;
           if ( UsereDataAcess.GetUserByUserNmae(ref UserID, ref FkPersonId,Username, ref Password, ref IsActive))
            {
                return new clsUserscs(UserID, FkPersonId,Username,Password, IsActive);
            }
            return null;


    }

        public static bool IsUserNameExsit(string username)
        {
            return UsereDataAcess.IsUserNameExsit(username);    
        }
    }


    }

