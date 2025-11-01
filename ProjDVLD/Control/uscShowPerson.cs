using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;

using System.Threading.Tasks;
using System.Windows.Forms;
using DataBussnsLayer;
using ProjDVLD.Properties;
namespace ProjDVLD
{
    public partial class uscShowPerson : UserControl
    {
       private int _personid = -1;


        public int selectPersonID()
        {
            return _personid;
        }
        public uscShowPerson()
        {



            InitializeComponent();



        }

        private void _FillPersonId()
        {
            _personid = -1;
            laPersonId.Text = "[????]";
            laAddres.Text = "[????]";
            laNam.Text = "[????]";
            laNat.Text = "[????]";
            laPhone.Text = "[????]";
            laEmail.Text = "[????]";
            laGen.Text = "[????]";
            laAddres.Text = "[????]";
            laContry.Text = "[????]";
            pictureBox1.Image = Resources.People_400;

        }
        private void _LodaDataFromClsPerson(clsPepole person)
        {
            _personid = person.PersonID;
            laPersonId.Text = person.PersonID.ToString();
            laAddres.Text = person.Address.ToString();
            laNam.Text = person.FirstName.ToString() + " " + person.LastName.ToString() + " " + person.SecondName.ToString() + " " + person.ThirdName.ToString();
            laNat.Text = person.NationalNo.ToString();
            laPhone.Text = person.Phone.ToString();
            laEmail.Text = person.Email.ToString();
            laGen.Text = person.Gendor == 0 ? "Male" : "Female";
            laAddres.Text = person.Address.ToString();
            laContry.Text = person.CountryName.ToString();
            laDataBa.Text = person.DateOfBirth.ToString();
            if (File.Exists(person.ImagePath))
            {
                pictureBox1.Image = System.Drawing.Image.FromFile(person.ImagePath);
            }
            else
            {
                if (person.Gendor == 0)
                {
                    pictureBox1.Image = Resources.Male_512;
                }
                else
                {
                    pictureBox1.Image = Resources.Female_512;
                }
            }



        }
        public void LoadDataByPersonId(int idperson)
        {
            clsPepole person = clsPepole.FindpersonById(idperson);
            if (person != null)
            {

                _LodaDataFromClsPerson(person);

                return;










            }
            _FillPersonId();

        }
        public void LoadDataByNationalNo(string NationalNo)
        {
            clsPepole person = clsPepole.FindpersonByNationalNo(NationalNo);
            if (person != null)
            {

                _LodaDataFromClsPerson(person);






                return;





            }
            _FillPersonId();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddEdit newperson = new AddEdit(_personid);
            newperson.ShowDialog();
        }

        private void uscShowPerson_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
