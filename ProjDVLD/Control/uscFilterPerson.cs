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
    public partial class uscFilterPerson : UserControl
    {

        
        public delegate void setPersonid(int personid);
        public event setPersonid setPersonideven;
        public delegate void setPersonidToForm(int personid);
        public event setPersonid setPersonidevenToFrmShowFilter;

        public delegate void setNationalNo(string NationalNo);
        public event setNationalNo setNationalNoeven;
        public uscFilterPerson()
        {
            InitializeComponent();
        }

        private void SelectPersonidRequest(int personid)
        {
            setPersonideven.Invoke(personid);

        }
        private void _ApplyFilter()
        {
            
            string filter = string.Empty;
            filter = textBoxFiletr.Text;
            if (comboBoxFilter.SelectedIndex == 0)
            {
                if (!string.IsNullOrEmpty(filter))
                {
                    if (clsPepole.IsNationalNoExsist(filter))
                    {
                        clsPepole pepole = clsPepole.FindpersonByNationalNo(filter);

                        setNationalNoeven.Invoke(filter);
                        setPersonidevenToFrmShowFilter.Invoke(pepole.PersonID);


                        return;
                    }



                }






            } else if (int.TryParse(filter, out int  Personid)&& comboBoxFilter.SelectedIndex == 1)
            {

                if (clsPepole.IsPersonIdExsist(Personid))
                {

                    setPersonideven.Invoke(Personid);
                    setPersonidevenToFrmShowFilter.Invoke(Personid);
                }


            }
        }
        private void _ComboBoxLoda()
        {
            comboBoxFilter.Items.Add("NationalNo");
            comboBoxFilter.Items.Add("PersonID");
            comboBoxFilter.SelectedIndex = 0;
        




        }

        private void uscFilterPerson_Load(object sender, EventArgs e)
        {
            _ComboBoxLoda();
        }

        private void textBoxFiletr_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void butserch_Click(object sender, EventArgs e)
        {
            _ApplyFilter();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonAddnew_Click(object sender, EventArgs e)
        {

            AddEdit NewPerson = new AddEdit();
            NewPerson.UserControlAddandUptata.evenSelectPersonidRequest += SelectPersonidRequest;
            NewPerson.Show();

        }
    }
}
