
using Microsoft.VisualBasic.FileIO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShoppingList
{
    public partial class ShoppingListForm : Form
    {
        private string constring = "SERVER=localhost;DATABASE=shop_database;UID=root;PASSWORD=;ALLOWUSERVARIABLES=True;";
        private MySqlConnection connection;
        private DataTable data = new DataTable();
        private MySqlDataAdapter adapter;
        public ShoppingListForm()
        {
            InitializeComponent();
            this.connection = new MySqlConnection(constring);
            try
            {
                connection.Open();
                adapter = new MySqlDataAdapter("SELECT List_Items,List_Items_DB,Shop_Items" +
                    ",Shop_Items_DB,Succeeded_buy,How_much FROM main_table;", connection);
                adapter.Fill(data);
                dtGrdVw.DataSource = data;
                dtGrdVw.Columns[4].ReadOnly = true;
                dtGrdVw.Columns[5].ReadOnly = true;
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
                data = new DataTable();
                adapter = new MySqlDataAdapter("INSERT INTO main_table (`List_Items`,`List_Items_DB`,`Shop_Items`,`Shop_Items_DB`,`Succeeded_buy`,`How_much`) "
                    + "VALUES ('','','','','','')", connection);
                adapter.Fill(data);
                adapter = new MySqlDataAdapter("SELECT List_Items,List_Items_DB,Shop_Items" +
                    ",Shop_Items_DB,Succeeded_buy,How_much FROM main_table;", connection);
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
            data = new DataTable();
            try
            {
                DataGridViewRow myrow = null;
                foreach (DataGridViewRow row in dtGrdVw.SelectedRows)
                {
                    i = row.Index;
                }
                if (i == -1)
                {
                    MessageBox.Show("Please select the full row!", "Wrong usage!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    connection.Open();
                    myrow = dtGrdVw.Rows[i];
                    adapter = new MySqlDataAdapter("DELETE FROM main_table " +
                        "WHERE List_Items = '"+myrow.Cells[0].Value+ "' AND List_Items_DB ='" + myrow.Cells[1].Value + "' AND " +
                        "Shop_Items = '" + myrow.Cells[2].Value + "' AND Shop_Items_DB ='" + myrow.Cells[3].Value + "' LIMIT 1;", connection);
                    adapter.Fill(data);
                    adapter = new MySqlDataAdapter("SELECT List_Items,List_Items_DB,Shop_Items" +
                      ",Shop_Items_DB,Succeeded_buy,How_much FROM main_table;", connection);
                    adapter.Fill(data);
                    dtGrdVw.DataSource = data;
                    dtGrdVw.Columns[4].ReadOnly = true;
                    dtGrdVw.Columns[5].ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                connection.Close();
            }
        }

        private void bttn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtGrdVw_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell cell = dtGrdVw.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (!cell.ReadOnly)
                {
                    string newValue = dtGrdVw.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    adapter = new MySqlDataAdapter("SELECT * FROM main_table;", connection);
                    adapter.Fill(data);
                    string query = "UPDATE main_table SET " + data.Columns[e.ColumnIndex + 1].ColumnName + "= '" + newValue + "' " +
                         "WHERE main_table.Rows = '" + data.Rows[e.RowIndex].ItemArray[0] + "' ;";
                    using (MySqlConnection connection = new MySqlConnection(constring))
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }
        }
        private void txtBx_Search_TextChanged(object sender, EventArgs e)
        {
            data = new DataTable();
            connection.Open();
            adapter = new MySqlDataAdapter("SELECT List_Items,List_Items_DB,Shop_Items" +
                      ",Shop_Items_DB,Succeeded_buy,How_much FROM main_table WHERE List_Items_DB LIKE '%" + txtBx_Search.Text + "%' "
                    + "OR List_Items LIKE '%" + txtBx_Search.Text + "%' "
                    + "OR Shop_Items LIKE '%" + txtBx_Search.Text + "%' "
                    + "OR Shop_Items_DB LIKE '%" + txtBx_Search.Text + "%' ;", connection);
            adapter.Fill(data);
            connection.Close();
            dtGrdVw.DataSource = data;
        }

        private void bttn_ShowResult_Click(object sender, EventArgs e)
        {

        }

        private void bttn_ImportFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files (*.csv)|*.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = openFileDialog.FileName;
                    string[] lines = File.ReadAllLines(path);
                    connection.Open();
                    foreach (string line in lines)
                    {
                        string[] values = line.Split(';');
                        string query = "INSERT INTO main_table (List_Items,List_Items_DB,Shop_Items,Shop_Items_DB) VALUES (@val1, @val2, @val3, @val4)";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@val1", values[0]);
                        command.Parameters.AddWithValue("@val2", values[1]);
                        command.Parameters.AddWithValue("@val3", values[2]);
                        command.Parameters.AddWithValue("@val4", values[3]);
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                    data = new DataTable();
                    adapter = new MySqlDataAdapter("SELECT List_Items,List_Items_DB,Shop_Items,Shop_Items_DB FROM main_table", constring);
                    adapter.Fill(data);
                    dtGrdVw.DataSource = data;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void bttn_ExportData_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV Files (*.csv)|*.csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = saveFileDialog.FileName;
                    connection.Open();
                    data = new DataTable();
                    adapter = new MySqlDataAdapter("SELECT List_Items,List_Items_DB,Shop_Items,Shop_Items_DB FROM main_table", connection);
                    adapter.Fill(data);
                    connection.Close();
                    StringBuilder sb = new StringBuilder();
                    IEnumerable<string> columnNames = data.Columns.Cast<DataColumn>().Select(column => column.ColumnName);
                    sb.AppendLine(string.Join(";", columnNames));
                    foreach (DataRow row in data.Rows)
                    {
                        IEnumerable<string> fields = row.ItemArray.Select(field => string.Concat("\"", field.ToString().Replace("\"", "\"\""), "\""));
                        sb.AppendLine(string.Join(";", fields));
                    }
                    File.WriteAllText(path, sb.ToString());

                    MessageBox.Show("Data exported successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
