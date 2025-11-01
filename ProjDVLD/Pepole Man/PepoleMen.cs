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
    public partial class PepoleMen : Form
    {
        public PepoleMen()
        {
            InitializeComponent();
        }
  private void CloseRequst()
        {
            this.Close();
        }

        private void PepoleMen_Load(object sender, EventArgs e)
        {
         ;
            PepoleViwe  p= new PepoleViwe();  
            this.Controls.Add(p);
            p.CloseFormRequst += CloseRequst;

        }

        
    }
}
