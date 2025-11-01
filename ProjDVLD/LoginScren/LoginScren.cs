using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBussnsLayer;
using ProjDVLD.GloblCls;
namespace ProjDVLD
{
    public partial class LoginScren : Form
    {

        private Home _Homescren;
        public LoginScren()
        {
            InitializeComponent();
        }
      
      
        private void _ChackedUserNameAndPassword()
        {
            if (!string.IsNullOrEmpty(textBoxPassord.Text)&& !string.IsNullOrEmpty(textBoxUserName.Text)){


             if ( clsUserscs.IsUserNameAndPasswordExsit(textBoxUserName.Text, textBoxPassord.Text)){

                     _Homescren = new Home(this);
                   
                    _Homescren.clsGlobla.UserGlobl =   clsUserscs.GetUserByUserNmae(textBoxUserName.Text);
                    if (!_Homescren.clsGlobla.UserGlobl.IsActive)
                    {
                        MessageBox.Show("Is not Active","Erorr",MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if(checMemember.Checked == true)
                    {
                        _Homescren.clsGlobla.MemberUserNameAndPassowrd();
                    }
                    else
                    {
                        _Homescren.clsGlobla.NotMemberUserNameAndPassowrd();
                    }
                    MessageBox.Show("Welecom " + textBoxUserName.Text, "Login", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    _Homescren.Show();
                    textBoxUserName.Text = "";
                    textBoxPassord.Text = "";
                    this.Hide();




                }
                else
                {
                    MessageBox.Show("Username Or Passord Is Fild Login");


                }



            }
            else
            {
                MessageBox.Show("Username Or Passord Is is Empty");


            }




        }
        public  void  MemberUserNameAndPassword()
        {

            textBoxPassord.Text = _Homescren.clsGlobla.SelectPassowrd();
            textBoxUserName.Text = _Homescren.clsGlobla.SelectUserName();

        }
        private void butLogin_Click(object sender, EventArgs e)
        {

            _ChackedUserNameAndPassword();

        }

        private void LoginScren_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureLogin1_Click(object sender, EventArgs e)
        {

        }
    }
}
