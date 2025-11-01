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
    public partial class frmEditApplicationManage : Form
    {

        int _ApplcationId;
        clsApplicationsTypes _clsApplicationsTypes;
        private void _LoadData()
        {
            _clsApplicationsTypes = clsApplicationsTypes.GetApplicationTypeByid(_ApplcationId);
            if (_clsApplicationsTypes != null)
            {
                textTitl.Text = _clsApplicationsTypes.ApplicationTypeTitl.ToString();
                textFees.Text = _clsApplicationsTypes.ApplicationFees.ToString();
                laID.Text= _clsApplicationsTypes.ApplicationTypeID.ToString();
            }

        }
        private void _Save()
        {
            bool Valdi=false;
            if (string.IsNullOrWhiteSpace(textTitl.Text))
            {

                errorProvider1.SetError(textTitl,"?");
                Valdi = true;
            }
            else
            {
                errorProvider1.SetError(textTitl, "");
                _clsApplicationsTypes.ApplicationTypeTitl = textTitl.Text;
                Valdi = false;
            }

            if (int.TryParse(textFees.Text, out int parsedValue))
            {
                errorProvider1.SetError(textFees, "");
                _clsApplicationsTypes.ApplicationFees = parsedValue; // استخدام القيمة المحولة
                Valdi = false;
            }
            else
            {
                // إذا كانت القيمة غير صالحة
                errorProvider1.SetError(textFees, "??"); // عرض رسالة خطأ
                Valdi = true;
            }

            if (!Valdi)
            {
               if(_clsApplicationsTypes.Save())
                {
                    MessageBox.Show("Save Succeeded");
                }
                else
                {
                    MessageBox.Show("Fild");

                }
            }
         





        }
        public frmEditApplicationManage(int ApplcationId)
        {
            InitializeComponent();
            _ApplcationId = ApplcationId;
            _LoadData();
        }











        private void frmEditApplicationManage_Load(object sender, EventArgs e)
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
