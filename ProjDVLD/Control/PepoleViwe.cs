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
    public partial class PepoleViwe : UserControl
    {
        DataTable DataPepole=new DataTable();
        public delegate void CloseFormDelegate();
        public event CloseFormDelegate CloseFormRequst;
        private void _LoadData()
        {
            dataGridViewScren.ContextMenuStrip = contextMenuStrip1;
            
            DataPepole = clsPepole.GetAllPepoles();
            if (DataPepole == null)
            {
                MessageBox.Show("Erorr 1");
            }
            else
            {
                dataGridViewScren.DataSource = DataPepole;
                dataGridViewScren.Refresh();
            }



           


     
            



        }
        private void _ComboBoxLoda()
        {
            comboBoxFilter.Items.Add("Non");
            comboBoxFilter.Items.Add("PersonID");
            comboBoxFilter.Items.Add("NationalNo");
            comboBoxFilter.Items.Add("FirstName");
            comboBoxFilter.Items.Add("Phone");
            comboBoxFilter.Items.Add("Email");
            comboBoxFilter.Items.Add("ThirdName");
            comboBoxFilter.SelectedIndex=0;
            textFilter.Visible = false;
     



        }
        private void _ApllyFilter()
        {

            string filter = string.Empty;



            if (comboBoxFilter.SelectedItem != null)
            {
                if (comboBoxFilter.SelectedItem.ToString() == "Non")
                {
                    textFilter.Visible = false; 
                }
                else
                {
                    textFilter.Visible = true; 

                    if (!string.IsNullOrEmpty(textFilter.Text))
                    {
                        // استخدام النص المدخل في الفلتر
                        filter = $"{comboBoxFilter.SelectedItem}='{textFilter.Text}'";
                        DataView dataPeopleView = new DataView(DataPepole);
                        if (comboBoxFilter.SelectedItem.ToString() == "PersonID" &&int.TryParse(textFilter.Text, out int Val))
                        {

                            dataPeopleView.RowFilter = filter;
                            dataGridViewScren.DataSource = dataPeopleView;


                        }
                        else if (comboBoxFilter.SelectedItem.ToString() != "PersonID")
                        {
                            dataPeopleView.RowFilter = filter;
                            dataGridViewScren.DataSource = dataPeopleView;
                        }
                       // تطبيق الفلتر
                       // تعيين مصدر البيانات
                    }
                  
                }
            }

        }
        public PepoleViwe()
        {



            InitializeComponent();


       
         


        }

     

        private void PepoleViwe_Load(object sender, EventArgs e)
        {
            _LoadData();
            _ComboBoxLoda();




        }

        
     
        private void buRefrsh_Click(object sender, EventArgs e)
        {
            _LoadData();
                
                }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ApllyFilter();
        }

        private void buSarch_Click(object sender, EventArgs e)
        {
            _ApllyFilter();
        }

        private void textFilter_TextChanged(object sender, EventArgs e)
        {
            _ApllyFilter();
        }

        private void buAddNew_Click(object sender, EventArgs e)
        {
            AddEdit addEdit = new AddEdit();
            addEdit.ShowDialog();
        }

        public void buClose_Click(object sender, EventArgs e)
        {
            CloseFormRequst.Invoke();


        }

       

        private void toolStripShowDetil_Click(object sender, EventArgs e)
        {
            if (dataGridViewScren.CurrentRow != null)
            {
                int idpersin = (int)dataGridViewScren.CurrentRow.Cells[0].Value;
               ShowpersonInf showperson = new ShowpersonInf(idpersin);
                showperson.ShowDialog();
            }
        }

        private void uptadePersonToolStripUptate_Click(object sender, EventArgs e)
        {
            if (dataGridViewScren.CurrentRow != null)
            {
                int idpersin = (int)dataGridViewScren.CurrentRow.Cells[0].Value;
                AddEdit p = new AddEdit(idpersin);
                p.ShowDialog();
            }
        }

        private void deletePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dataGridViewScren.CurrentRow != null)
            {
                int idpersin = (int)dataGridViewScren.CurrentRow.Cells[0].Value;
               if (clsPepole.DeletePersonByID(idpersin))
                {
                    MessageBox.Show("Delete Succssde");
                }
                else
                {
                    MessageBox.Show("Delete Filde");
                }
            }
        }

        private void toolStripMenuItemAddNew_Click(object sender, EventArgs e)
        {
            
                AddEdit p = new AddEdit();
                p.ShowDialog();
            
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void dataGridViewScren_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
