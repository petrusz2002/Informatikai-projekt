
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
        private string constring = "SERVER=localhost;DATABASE=shop_database;UID=root;PASSWORD=;ALLOWUSERVARIABLES=True;";
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
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT List_Items,List_Items_DB,Shop_Items" +
                    ",Shop_Items_DB,Succeeded_buy,How_much FROM main_table;", connection);
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
            try
            {
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter("INSERT INTO main_table (`List_Items`,`List_Items_DB`,`Shop_Items`,`Shop_Items_DB`,`Succeeded_buy`,`How_much`) "
                    + "VALUES ('','','','','','')", connection);
                DataTable data = new DataTable();
                adapter.Fill(data);
                adapter = new MySqlDataAdapter("SELECT * FROM main_table", connection);
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

        private void bttn_DeleteRow_Click(object sender, EventArgs e)
        {
            int i = -1;
            try
            {
                
                foreach (DataGridViewRow row in dtGrdVw.SelectedRows)
                {
                    i = row.Index;
                    dtGrdVw.Rows.RemoveAt(row.Index);
                }
                if (i == -1)
                {
                    MessageBox.Show("Please select the full row!", "Wrong usage!",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    connection.Open();
                    MySqlDataAdapter adapter;
                    DataTable data = new DataTable();
                   
                    string sql = "SET @row_number := 0; SELECT (@row_number:= @row_number + 1) AS `row_number`,t.* FROM `main_table` t;";
                    /*MySqlDataAdapter adapter = new MySqlDataAdapter("DELETE FROM main_table " +
                        "WHERE main_table.Rows = '"+(i+1)+"';",connection);*/
                   
                   
                    adapter = new MySqlDataAdapter(sql, connection);
                    adapter.Fill(data);
                    // adapter = new MySqlDataAdapter("ALTER TABLE maintable AUTO_INCREMENT="+(i+1)+";", connection);
                    /* adapter = new MySqlDataAdapter("SELECT List_Items,List_Items_DB,Shop_Items" +
                     ",Shop_Items_DB,Succeeded_buy,How_much FROM main_table;", connection);
                     adapter.Fill(data);*/
                    dtGrdVw.DataSource = data;
                }
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
