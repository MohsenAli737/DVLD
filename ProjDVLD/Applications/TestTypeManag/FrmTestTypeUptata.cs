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
namespace ProjDVLD
{
    public partial class FrmTestTypeUptata : Form
    {


      private int _TestTypeId;
        private ClsTestType _ClsTestType;
        private  void _LoadData()
        {
            _ClsTestType= ClsTestType.Find(_TestTypeId);
            if (_ClsTestType != null)
            {
                TextBoxTatle.Text = _ClsTestType.Title;
                textBoxFees.Text = _ClsTestType.Fees.ToString();
                laId.Text= _ClsTestType.id.ToString();

            }
           
        }
        private void _Save()
        {
            bool Valdi = false;
            if (string.IsNullOrWhiteSpace(TextBoxTatle.Text))
            {

                errorProvider1.SetError(TextBoxTatle, "?");
                Valdi = true;
            }
            else
            {
                errorProvider1.SetError(TextBoxTatle, "");
                _ClsTestType.Title = TextBoxTatle.Text;
                Valdi = false;
            }

            if (int.TryParse(textBoxFees.Text, out int parsedValue))
            {
                errorProvider1.SetError(textBoxFees, "");
                _ClsTestType.Fees = parsedValue; // استخدام القيمة المحولة
                Valdi = false;
            }
            else
            {
                // إذا كانت القيمة غير صالحة
                errorProvider1.SetError(textBoxFees, "??"); // عرض رسالة خطأ
                Valdi = true;
            }

            if (!Valdi)
            {
                if (_ClsTestType.Save())
                {
                    MessageBox.Show("Save Succeeded");
                }
                else
                {
                    MessageBox.Show("Fild");

                }
            }






        }
        public FrmTestTypeUptata(int TestTypeId)
        {
            InitializeComponent();
            _TestTypeId = TestTypeId;
        }

        private void FrmTestTypeUptata_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            _Save();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
