using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DataAcsses;
using DataBussnsLayer;
namespace DataBussnsLayer
{
    public class clsPepole

    {
        enum enmode { New, update };
        enmode _mode;
        private DataTable DataTablePerson = new DataTable();
        public int PersonID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Gendor { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string CountryName { get; set; }
        public string ImagePath { get; set; }



        public clsPepole()
        {

            _mode = enmode.New;


            PersonID = -1;
            NationalNo = "";
            FirstName = "";
            LastName = "";
            SecondName = "";
            ThirdName = "";

            DateOfBirth = DateTime.Now;
            Gendor = 0;
            Address = "";
            Phone = "";
            Email = "";
            CountryName = "";
            ImagePath = "";
        }
        private clsPepole(int PersonID, string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, int Gendor, string Address, string Phone, string Email, string CountryName, string ImagePath)
        {

            this.PersonID = PersonID;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.Address = Address;
            this.Gendor = Gendor;
            this.DateOfBirth = DateOfBirth;
            this.Phone = Phone;
            this.Email = Email;
            this.CountryName = CountryName;
            this.ImagePath = ImagePath;
            _mode = enmode.update;



        }



      public  static clsPepole FindpersonById(int personID)
        {
            string NationalNo = "", FirstName = "", SecondName = "", ThirdName = "", LastName = "", Address = "", Phone = "", Email = "", CountryName = "", ImagePath = "";
            int Gendor = 1;
            DateTime DateOfBirth = new DateTime();
            if (pepoleDataAcsess.GetpersonByid(ref personID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref CountryName, ref ImagePath))
            {



                return new clsPepole (personID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, CountryName, ImagePath);
        
















               
            }
            return new  clsPepole();

        }


        public static clsPepole FindpersonByNationalNo(string NationalNo)
        {
            int personID = -1;
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "", Address = "", Phone = "", Email = "", CountryName = "", ImagePath = "";
            int Gendor = 1;
            DateTime DateOfBirth = new DateTime();
            if (pepoleDataAcsess.GetpersonByNationalNo(ref personID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref CountryName, ref ImagePath))
            {



                return new clsPepole(personID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, CountryName, ImagePath);


















            }
            return new clsPepole();

        }





        public static DataTable GetAllPepoles()
        {
            return pepoleDataAcsess.LoadAllPepole();

        }
        public static DataTable GetAllContryName()
        {


            return pepoleDataAcsess.LodaContrNamy();
        }
        public static bool DeletePersonByID(int idperson)
        {


            return pepoleDataAcsess.DeletepersonByid(idperson);

        }

        public string getFullName()
        {

            return FirstName +" " + LastName +" " +  ThirdName + " " + LastName;
        }
        public int GetAge()
        {
            int Age = DateTime.Now.Year - DateOfBirth.Year;

            return Age;

        }
        public bool Save()
        {
            switch (_mode)
            {

                case enmode.New:
                    {


                        PersonID = pepoleDataAcsess.AddNewPerson(NationalNo, FirstName, LastName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, CountryName, ImagePath);
                        if (PersonID != -1)
                        {
                            _mode = enmode.update;
                            return true;
                        }

                        break;

                    }
                case enmode.update:
                    {


                        if (pepoleDataAcsess.UptadePerson(PersonID, NationalNo, FirstName, LastName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, CountryName, ImagePath))
                        {

                          
                            return true;

                        }


                        break;

                    }



            }




            return false;
        }
        public static bool IsNationalNoExsist(string NationalNo)
        {
            return pepoleDataAcsess.IsNationalNoExsist(NationalNo);
        }
        public static bool IsPersonIdExsist(int personid)
        {

            return pepoleDataAcsess.IsPersonIExsist(personid);

        }

    }

}




























