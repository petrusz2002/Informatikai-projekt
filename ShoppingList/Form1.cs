
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShoppingList
{
    public partial class ShoppingListForm : Form
    {
        private string constring = "SERVER=localhost;DATABASE=shop_database;UID=root;PASSWORD=;";
        private MySqlConnection connection;
        public ShoppingListForm()
        {
            InitializeComponent();
            this.connection = new MySqlConnection(constring);
        }

        private void bttn_Save_Click(object sender, EventArgs e)
        {

        }

        private void bttn_ShowCurrentData_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM main_table", connection);
                DataTable data = new DataTable();
                adapter.Fill(data);
                dtGrdVw.DataSource = data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        private void bttn_AddRow_Click(object sender, EventArgs e)
        {
            
        }

        private void bttn_DeleteRow_Click(object sender, EventArgs e)
        {

        }

        private void bttn_Find_Click(object sender, EventArgs e)
        {

        }

        private void bttn_DeleteSelectedData_Click(object sender, EventArgs e)
        {

        }

        private void bttn_ImportFile_Click(object sender, EventArgs e)
        {

        }

        private void bttn_ExportData_Click(object sender, EventArgs e)
        {

        }

        private void bttn_ShowResult_Click(object sender, EventArgs e)
        {

        }



        private void bttn_Close_Click(object sender, EventArgs e)
        {

        }
    }
}
