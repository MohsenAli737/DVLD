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
using static System.Net.Mime.MediaTypeNames;

namespace ProjDVLD
{
    public partial class AddNewUser : Form
    {
        private int _personId = -1; 
        public AddNewUser()
        {
            InitializeComponent();
        }

        private void AddNewUser_Load(object sender, EventArgs e)
        {
            useShowFilter1.setPersonidevenFrmShowFilter += SetdPersonId;
            butNext.Enabled = true;
   




        }
        private bool _chackUsernameExsit(string username) {
        
        return clsUserscs.IsUserNameExsit(username);
        }
       
        private bool _ChackInpuVild()
        {
            if (!string.IsNullOrEmpty(textUserName.Text) && !string.IsNullOrEmpty(textoxPassordAgin.Text) && !string.IsNullOrEmpty(textPassord.Text))
            {

                if (_chackUsernameExsit(textUserName.Text))
                {
                    MessageBox.Show("the " + textUserName.Text + " is (Used)!");
                    return false;
                }
                if (textPassord.Text != textoxPassordAgin.Text)
                {
                    MessageBox.Show("the Password is Not Applied ");

                    return false;





                }
            }
            else
            {
                MessageBox.Show("the Password  or UsrerNmae is Empty ");

                return false;
            }
            return true;
        }
       
        private void _Save()
        {
            if (_ChackInpuVild())
            {
                clsUserscs newuser = new clsUserscs();

                newuser.IsActive=check_Is_Achin.Checked?true:false;
                newuser.UserName=textUserName.Text;
                newuser.Password=textPassord.Text;
                newuser.FkPersonId=_personId;
                if (newuser.Save())
                {
                    labUserId.Text=newuser.UserID.ToString();
                    MessageBox.Show("The Add User Succeeded()");

                }
            }
            



        }
        private void SetdPersonId(int personid)
        {
            _personId = personid;


        }

        private void uscShowPerson1_Load(object sender, EventArgs e)
        {
        
        }

        private void uscFilterPerson1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void butNext_Click(object sender, EventArgs e)
        {
            tabControlI.SelectedIndex++;
            if (_personId > 0)
            {
                if (!clsUserscs.IsIdpersonIsExsit(_personId))
                {
                    groupBoxLogin.Enabled = true;

                    butSave.Enabled = true;
                }
                else
               
                {
                    MessageBox.Show("Erorr","Persondid is Avalible");
                }


            }

        }

        private void butClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
          
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            _Save();
        }

        private void useShowFilter1_Load(object sender, EventArgs e)
        {

        }

        private void groupBoxLogin_Enter(object sender, EventArgs e)
        {

        }
    }
}
