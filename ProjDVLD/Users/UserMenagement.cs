using DataBussnsLayer;
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
    public partial class UserMenagement : Form
    {
        DataTable DataUsers = new DataTable();

        private void _LoadUsers()
        {

            DataUsers=clsUserscs.GetAllUsers();
            if (DataUsers == null)
            {
                MessageBox.Show("Erorr 1");
            }
            else
            {
                dataGridView1.DataSource = DataUsers;
            
            }







        }
        private void _ComboBoxLoda()
        {
            comboBoxFilter.Items.Add("Non");
            comboBoxFilter.Items.Add("PersonID");
            comboBoxFilter.Items.Add("UserID");
            comboBoxFilter.Items.Add("FullName");
            comboBoxFilter.Items.Add("UserName");
            comboBoxFilter.SelectedIndex = 0;
            textBoxFilter.Visible = false;




        }
        private void _ApllyFilter()
        {

            string filter = string.Empty;



            if (comboBoxFilter.SelectedItem != null)
            {
                if (comboBoxFilter.SelectedItem.ToString() == "Non")
                {
                    textBoxFilter.Visible = false;
                }
                else
                {
                    textBoxFilter.Visible = true;

                    if (!string.IsNullOrEmpty(textBoxFilter.Text))
                    {
                        // استخدام النص المدخل في الفلتر
                        filter = $"{comboBoxFilter.SelectedItem}='{textBoxFilter.Text}'";
                        DataView DataUsersView = new DataView(DataUsers);
                        if (comboBoxFilter.SelectedItem.ToString() == "PersonID" || comboBoxFilter.SelectedItem.ToString() == "UserID")
                        {
                            if ( int.TryParse(textBoxFilter.Text, out int Val)) { 
                                DataUsersView.RowFilter = filter;
                                dataGridView1.DataSource = DataUsersView;
                            }
                         


                        }
                        else if (comboBoxFilter.SelectedItem.ToString() != "PersonID" && comboBoxFilter.SelectedItem.ToString() != "UserID")
                        {
                            DataUsersView.RowFilter = filter;
                            dataGridView1.DataSource = DataUsersView;
                        }
                        // تطبيق الفلتر
                        // تعيين مصدر البيانات
                    }

                }
            }

        }
        public UserMenagement()
        {
            InitializeComponent();
        }

        private void UserMenagement_Load(object sender, EventArgs e)
        {
            _LoadUsers();
            dataGridView1.ContextMenuStrip = contextMenuStrip1;

            _ComboBoxLoda();
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ApllyFilter();
        }

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            _ApllyFilter();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AddNewUser newUsers = new AddNewUser();
            newUsers.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void showUserToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (dataGridView1.CurrentRow != null)
            {
                int UserId = (int)dataGridView1.CurrentRow.Cells[0].Value;
                frmShowUser showUser = new frmShowUser();
                showUser.GetUserId(UserId);
                showUser.ShowDialog();

            }

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int UserId = (int)dataGridView1.CurrentRow.Cells[0].Value;
                if(clsUserscs.DeleteUserByUserId(UserId))
                {

                    MessageBox.Show("Delete Don","",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    MessageBox.Show("Filde Delete", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void chingPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmchingPassowrd chingPassowrdUser= new frmchingPassowrd();

            if (dataGridView1.CurrentRow != null)
            {
                int UserId = (int)dataGridView1.CurrentRow.Cells[0].Value;
                chingPassowrdUser.loadDataByUserId(UserId);
                chingPassowrdUser.ShowDialog();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
