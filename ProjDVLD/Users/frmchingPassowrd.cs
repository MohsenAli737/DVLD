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

namespace ProjDVLD
{
    public partial class frmchingPassowrd : Form
    {
        clsUserscs _user;
        public frmchingPassowrd()
        {
            InitializeComponent();
        }
       
        public void loadDataByUserId(int Userid)
        {
            _user = clsUserscs.GetUserByUserid(Userid);
        }
        public void GetClsUser(ref clsUserscs clsUserscs)
        {
            _user = clsUserscs;
        }







        private bool _ChackPassword()
        {
            if (_user.Password == textBoxPassword.Text)
            {
                return true;

            }
            MessageBox.Show("Password Is Error");

            return false;





        }
        private void _Save()
        {
           _user.Password = textBoxNewPassword.Text;
            if (_user.Save())
            {
                MessageBox.Show("Chang PassWord Seccded");

            }
            else
            {
                MessageBox.Show("Chang PassWord Filde");
            }

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void uscShowPerson1_Load(object sender, EventArgs e)
        {

        }

        private void frmchingPassowrd_Load(object sender, EventArgs e)
        {
            uscshowUser1.GetUserId(_user.UserID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_ChackPassword())
            {
                _Save();



            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uscshowUser1_Load(object sender, EventArgs e)
        {

        }
    }
}