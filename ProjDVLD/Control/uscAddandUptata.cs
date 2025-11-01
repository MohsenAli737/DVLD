using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBussnsLayer;
using static System.Net.Mime.MediaTypeNames;
namespace ProjDVLD
{
    public partial class uscAddandUptata : UserControl
    {
        private Label lblFirstNameError;
        private Label lblNationalNoError;
        private Label lblEmailError; // تأكد من تعريف هذا المتغير
        private Label lblPhoneError;
        private Label lblAddressError ;
        private Label lblSecondNameError;  // إضافة هذه السطور لبقية الحقول
        private Label lblLastNameError;
        private Label lblThirdNameError;
        private Label lblCountryNameError;
        private Label lblGenderError;
        public delegate void CloseFormDelegate();
        public event CloseFormDelegate CloseFormRequst;
        enum imegMode { M,F,MF};
        imegMode _imegMod;

        clsPepole person;
        enum enmode { Add, uptade };
        enmode _mode;
        private string targetFolder = @"E:\مشروع رخصه القياده\ProjDVLD\Image-person";
        private string destinationPath = "";
        private string PathfileImage;
       public    delegate void SelectPersonidRequest(int personid);
      public  event SelectPersonidRequest evenSelectPersonidRequest;
       
        private void lodaDataForm()
        {
            lodaComboBoxContryNmae();
          

            switch (_mode)
            {

                case enmode.Add:
                    {
                        _ResetDefualtValues();






                        break;
                    }


                case enmode.uptade:
                    {

                        
                        _LodaDataFromclsPerson();









                        break;
                    }







            }




        }


        // دالة للتحقق من صحة البريد الإلكتروني
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        // دالة للتحقق من صحة رقم الهاتف
        private bool IsPhoneNumberValid(string phone)
        {
            return phone.All(char.IsDigit); // التأكد من أن جميع الأحرف أرقام
        }


        private bool Save()
        {
            bool isValid = true;

            // إعادة تعيين إشارات الخطأ
            lblFirstNameError.Visible = false;
            lblNationalNoError.Visible = false;
            lblEmailError.Visible = false;
            lblPhoneError.Visible = false;
            lblAddressError.Visible = false;
            lblSecondNameError.Visible = false;  // إضافة هذه السطور لبقية الحقول
            lblLastNameError.Visible = false;
            lblThirdNameError.Visible = false;
            lblCountryNameError.Visible = false;
            lblGenderError.Visible = false;

            // التحقق من صحة المدخلات
            if (string.IsNullOrWhiteSpace(TexFirst.Text))
            {
                lblFirstNameError.Visible = true;
                TexFirst.BackColor = Color.Pink;
                isValid = false;
            }
            else
            {
                TexFirst.BackColor = Color.White;
            }

            if (string.IsNullOrWhiteSpace(texNat.Text))
            {
                lblNationalNoError.Visible = true;
                texNat.BackColor = Color.Pink;
                isValid = false;
            }
            else 
            {
                if (clsPepole.IsNationalNoExsist(texNat.Text) && _mode==enmode.Add || clsPepole.IsNationalNoExsist(texNat.Text)&& texNat.Text != person.NationalNo )
                {
                    lblNationalNoError.Visible = true;
                    texNat.BackColor = Color.Pink;
                    isValid = false;
                    MessageBox.Show("NationalNoExsist  ");
                }
                else
                {
                    texNat.BackColor = Color.White;
                }
            }



            if (!IsValidEmail(texEmali.Text))
            {
                lblEmailError.Visible = true;
                texEmali.BackColor = Color.Pink;
                isValid = false;
            }
            else
            {
                texEmali.BackColor = Color.White;
            }

            if (!IsPhoneNumberValid(texPhon.Text))
            {
                lblPhoneError.Visible = true;
                texPhon.BackColor = Color.Pink;
                isValid = false;
            }
            else
            {
                texPhon.BackColor = Color.White;
            }

            if (string.IsNullOrWhiteSpace(texAddres.Text))
            {
                lblAddressError.Visible = true;
                texAddres.BackColor = Color.Pink;
                isValid = false;
            }
            else
            {
                texAddres.BackColor = Color.White;
            }

            if (string.IsNullOrWhiteSpace(texSconde.Text))  // التحقق من صحة SecondName
            {
                lblSecondNameError.Visible = true;
                texSconde.BackColor = Color.Pink;
                isValid = false;
            }
            else
            {
                texSconde.BackColor = Color.White;
            }

            if (string.IsNullOrWhiteSpace(texList.Text))  // التحقق من صحة LastName
            {
                lblLastNameError.Visible = true;
                texList.BackColor = Color.Pink;
                isValid = false;
            }
            else
            {
                texList.BackColor = Color.White;
            }

            if (string.IsNullOrWhiteSpace(texThird.Text))  // التحقق من صحة ThirdName
            {
                lblThirdNameError.Visible = true;
                texThird.BackColor = Color.Pink;
                isValid = false;
            }
            else
            {
                texThird.BackColor = Color.White;
            }

            if (string.IsNullOrWhiteSpace(combContry.Text))  // التحقق من صحة CountryName
            {
                lblCountryNameError.Visible = true;
                combContry.BackColor = Color.Pink;
                isValid = false;
            }
            else
            {
                combContry.BackColor = Color.White;
            }

            if (!radiFemale.Checked && !radioMale.Checked)  // التحقق من صحة Gender
            {
                lblGenderError.Visible = true;
                isValid = false;
            }

            // إذا كانت المدخلات غير صحيحة، لا تتابع الحفظ
            if (!isValid)
            {
                return false;
            }

            // جمع المعلومات من واجهة المستخدم
            person.FirstName = TexFirst.Text;
            person.SecondName = texSconde.Text;
            person.LastName = texList.Text;
            person.ThirdName = texThird.Text;
            person.Gendor = radiFemale.Checked ? 1 : 0;
            
                
            
           
            person.NationalNo = texNat.Text;
            person.Email = texEmali.Text;
            person.Address = texAddres.Text;
            person.Phone = texPhon.Text;
            person.CountryName = combContry.Text;


            // تعيين مسار الصورة

            if (!string.IsNullOrEmpty(destinationPath) && person.ImagePath != destinationPath)
            {
                
                person.ImagePath = destinationPath;
                File.Copy(PathfileImage, destinationPath, true);
            }
            else
            {
                person.ImagePath = person.ImagePath;
            }
           
            person.DateOfBirth = dateTimePicker1.Value;

            // محاولة حفظ الشخص
            if (person.Save())
            {
                _mode = enmode.uptade;
                MessageBox.Show("Save Sucssed().");
                lodaDataForm();
                if (evenSelectPersonidRequest != null)
                {
                    evenSelectPersonidRequest.Invoke(person.PersonID);
                }
                return true;
            }
            else
            {
                MessageBox.Show("Faldi Save");
                return false;
            }
        }

        private void initialLablEror()
        {
            // إنشاء الإشارات الحمراء بجانب الـ TextBoxes
            lblFirstNameError = new Label();
            lblFirstNameError.ForeColor = Color.Red;
            lblFirstNameError.Text = "!";
            lblFirstNameError.Visible = false;
            this.Controls.Add(lblFirstNameError);

            lblNationalNoError = new Label();
            lblNationalNoError.ForeColor = Color.Red;
            lblNationalNoError.Text = "!";
            lblNationalNoError.Visible = false;
            this.Controls.Add(lblNationalNoError);

            lblEmailError = new Label();
            lblEmailError.ForeColor = Color.Red;
            lblEmailError.Text = "!";
            lblEmailError.Visible = false;
            this.Controls.Add(lblEmailError);

            lblPhoneError = new Label();
            lblPhoneError.ForeColor = Color.Red;
            lblPhoneError.Text = "!";
            lblPhoneError.Visible = false;
            this.Controls.Add(lblPhoneError);

            lblAddressError = new Label();
            lblAddressError.ForeColor = Color.Red;
            lblAddressError.Text = "!";
            lblAddressError.Visible = false;
            this.Controls.Add(lblAddressError);

            lblSecondNameError = new Label();  // إضافة Error Label لـ SecondName
            lblSecondNameError.ForeColor = Color.Red;
            lblSecondNameError.Text = "!";
            lblSecondNameError.Visible = false;
            this.Controls.Add(lblSecondNameError);

            lblLastNameError = new Label();  // إضافة Error Label لـ LastName
            lblLastNameError.ForeColor = Color.Red;
            lblLastNameError.Text = "!";
            lblLastNameError.Visible = false;
            this.Controls.Add(lblLastNameError);

            lblThirdNameError = new Label();  // إضافة Error Label لـ ThirdName
            lblThirdNameError.ForeColor = Color.Red;
            lblThirdNameError.Text = "!";
            lblThirdNameError.Visible = false;
            this.Controls.Add(lblThirdNameError);

            lblCountryNameError = new Label();  // إضافة Error Label لـ CountryName
            lblCountryNameError.ForeColor = Color.Red;
            lblCountryNameError.Text = "!";
            lblCountryNameError.Visible = false;
            this.Controls.Add(lblCountryNameError);

            lblGenderError = new Label();  // إضافة Error Label لـ Gender
            lblGenderError.ForeColor = Color.Red;
            lblGenderError.Text = "!";
            lblGenderError.Visible = false;
            this.Controls.Add(lblGenderError);

            // إعداد المواقع لجميع الإشارات الحمراء
            lblFirstNameError.Location = new Point(TexFirst.Location.X + TexFirst.Width + 5, TexFirst.Location.Y);
            lblNationalNoError.Location = new Point(texNat.Location.X + texNat.Width + 5, texNat.Location.Y);
            lblEmailError.Location = new Point(texEmali.Location.X + texEmali.Width + 5, texEmali.Location.Y);
            lblPhoneError.Location = new Point(texPhon.Location.X + texPhon.Width + 5, texPhon.Location.Y);
            lblAddressError.Location = new Point(texAddres.Location.X + texAddres.Width + 5, texAddres.Location.Y);
            lblSecondNameError.Location = new Point(texSconde.Location.X + texSconde.Width + 5, texSconde.Location.Y); // SecondName
            lblLastNameError.Location = new Point(texList.Location.X + texList.Width + 5, texList.Location.Y); // LastName
            lblThirdNameError.Location = new Point(texThird.Location.X + texThird.Width + 5, texThird.Location.Y); // ThirdName
            lblCountryNameError.Location = new Point(combContry.Location.X + combContry.Width + 5, combContry.Location.Y); // CountryName
            lblGenderError.Location = new Point(radiFemale.Location.X + radiFemale.Width + 5, radiFemale.Location.Y); // Gender
        }

        private void _ResetDefualtValues()
        {
            laTatal.Text = "Add new pserson";
            radioMale.Checked = true;
            dateTimePicker1.MaxDate = DateTime.Now.AddYears(-18);
            dateTimePicker1.Value = dateTimePicker1.MaxDate;
          _imegMod = imegMode.M;


        }
        private void _LodaDataFromclsPerson()
        {

            laTatal.Text = "Uptade pesron";
            labIdperson.Text = person.PersonID.ToString();

            TexFirst.Text = person.FirstName;
            texSconde.Text = person.SecondName;
            texList.Text = person.LastName;
            texThird.Text = person.ThirdName;
            if (person.Gendor == 1)
            {
                radiFemale.Checked = true;
            }
            else
            { radioMale.Checked = true; }


            texNat.Text = person.NationalNo;
            texEmali.Text = person.Email;
            texAddres.Text = person.Address;
            texPhon.Text = person.Phone;
            combContry.Text = person.CountryName;
            if (File.Exists(person.ImagePath))
            {
                picturImageperson.Image = System.Drawing.Image.FromFile(person.ImagePath);
                _imegMod = imegMode.MF;
            }
           

                dateTimePicker1.Value = person.DateOfBirth;

        }
        public uscAddandUptata(int idperson)
        {
            InitializeComponent();
            initialLablEror();
            person = clsPepole.FindpersonById(idperson);
         
            if (person.PersonID  >0)
            {
                _mode = enmode.uptade;
            }
            else
            {
                _mode = enmode.Add;
            }
            lodaDataForm();


        }
        public uscAddandUptata()
        {
            InitializeComponent();

            initialLablEror();
            person = new clsPepole();
            lodaDataForm();
            _mode = enmode.Add;


        }
        public uscAddandUptata(string NationalNo)
        {
            InitializeComponent();
            initialLablEror();
            person = clsPepole.FindpersonByNationalNo(NationalNo);

            if (person.PersonID > 0)
            {
                _mode = enmode.uptade;
            }
            else
            {
                _mode = enmode.Add;
            }
            lodaDataForm();


        }


        private void lodaComboBoxContryNmae()
        {

            DataTable contryname = clsPepole.GetAllContryName();
            if (contryname != null)
            {
                foreach (DataRow row in contryname.Rows)
                {
                    combContry.Items.Add(row[0]);






                }
                combContry.SelectedIndex = 0;


            }
            else
            {
                combContry.Items.Add("Armenia");
            }




        }

 

        private void linkimagepath_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // عرض الصورة في PictureBox

                   
                    // نسخ الصورة إلى المجلد المحدد
                      string fileName = Path.GetFileName(openFileDialog.FileName);
                    picturImageperson.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
                    destinationPath = Path.Combine(targetFolder, fileName);
                    PathfileImage = openFileDialog.FileName;
                    if (!Directory.Exists(targetFolder))
                    {
                        Directory.CreateDirectory(targetFolder);
                    }

                    _imegMod = imegMode.MF;

                   
                }
            }
        }

        private void buSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void uscAddandUptata_Load(object sender, EventArgs e)
        {

        }

        private void radioMale_CheckedChanged(object sender, EventArgs e)
        {



            if (_imegMod == imegMode.F)
            {
                System.Drawing.Image img = Properties.Resources.Male_512;

                picturImageperson.Image = img;
                _imegMod = imegMode.M;
            }

        }

        private void picturImageperson_Click(object sender, EventArgs e)
        {

        }


        private void radiFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (_imegMod == imegMode.M)
            {
                System.Drawing.Image img = Properties.Resources.Female_512;
                picturImageperson.Image = img;
                _imegMod = imegMode.F;
            }
     

        }

        private void buClose_Click(object sender, EventArgs e)
        {
            CloseFormRequst.Invoke();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
