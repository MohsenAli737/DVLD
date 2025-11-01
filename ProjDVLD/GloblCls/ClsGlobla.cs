using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBussnsLayer;
namespace ProjDVLD.GloblCls
{
    public class ClsGlobla 
    {
       public clsUserscs UserGlobl;
       public bool Memember = false;
        public  void  MemberUserNameAndPassowrd()
        {
            Memember = true;
            
         }
        public void NotMemberUserNameAndPassowrd()
        {
            Memember = false;

        }
        public string SelectPassowrd()
        {
            return (Memember == true)? UserGlobl.Password:"";
        }

        public string SelectUserName()
        {
            return (Memember == true) ? UserGlobl.UserName : "";
        }







    }
}
