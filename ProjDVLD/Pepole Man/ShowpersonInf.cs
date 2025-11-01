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
    public partial class ShowpersonInf : Form
    {


   
        public ShowpersonInf(int idperson)
        {
            InitializeComponent();
            uscShowPerson person = new uscShowPerson();
            person.LoadDataByPersonId(idperson);

            this.Controls.Add(person);
        }

        private void ShowpersonInf_Load(object sender, EventArgs e)
        {
           


        }
    }
}
