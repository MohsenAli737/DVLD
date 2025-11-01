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
    public partial class UseShowFilter : UserControl
    {
        int _personid;
        public delegate void setPersonid(int personid);
        public event setPersonid setPersonidevenFrmShowFilter;
        public UseShowFilter()
        {
            InitializeComponent();
        }
        private void _setPersonID(int personid)
        {
            _personid = personid;
            setPersonidevenFrmShowFilter.Invoke(personid);

        }
        public void SetDataByPersonId(int PersonID)
        {
            _personid = PersonID;
            setPersonidevenFrmShowFilter.Invoke(PersonID);
        }

        public  void EnbleFilterPerson()
        {
            uscFilterPerson1.Enabled = false;
        }

        private void uscShowPerson1_Load(object sender, EventArgs e)
        {

        }

        private void UseShowFilter_Load(object sender, EventArgs e)
        {
            uscFilterPerson1.setNationalNoeven += uscShowPerson1.LoadDataByNationalNo;
            uscFilterPerson1.setPersonideven += uscShowPerson1.LoadDataByPersonId;
            uscFilterPerson1.setPersonidevenToFrmShowFilter += _setPersonID;

        }
      

        private void uscFilterPerson1_Load(object sender, EventArgs e)
        {

        }
    }
}
