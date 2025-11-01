using DataBussnsLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ProjDVLD
{
    public partial class uscshowUser : UserControl
    {

        clsUserscs _user;
        public uscshowUser()
        {
            InitializeComponent();
        }
        private void _FillData()
        {
            uscShowPerson1.LoadDataByPersonId(_user.FkPersonId);
            labelUserId.Text = _user.UserID.ToString();
            labelUserName.Text = _user.UserName.ToString();
            labelPersonid.Text=_user.FkPersonId.ToString(); 
            labelIsActiv.Text=_user.IsActive ? "TREUE" : "FALSE";




        }
        public void GetUserId(int userId)
        {
           _user= clsUserscs.GetUserByUserid(userId);
            if (_user != null) {

                _FillData();





            }

        }

        private void uscshowUser_Load(object sender, EventArgs e)
        {

        }
    }
}
