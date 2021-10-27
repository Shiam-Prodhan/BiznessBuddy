using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BiznessBuddy
{
    public partial class DeleteManager : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource = localhost;port = 3306; username = root; password=;database = biznessbuddy;");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;
        int count = 0;
        public DeleteManager()
        {
            InitializeComponent();
        }

        private void DeleteManager_Load(object sender, EventArgs e)
        {
            searchData("","");
        }
        public void searchData(string valueToSearch, string valueToSearch1)
        {
            string query = "SELECT * FROM login WHERE CONCAT(`Name`, `Id`, `Phone`, `Password`, `UserType`) like '%" + valueToSearch + valueToSearch1 + "%'";
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            //dataGridView1.DataSource = table;
        }

        string ConnectString = "datasource = localhost; port = 3306; username = root; password=; database = biznessbuddy;";
        public void search()
        {
            string search = "SELECT * FROM login WHERE Name='" + nametextbox.Text + "' AND Id='" + productidtextbox.Text + "'";
            MySqlConnection databaseConnect = new MySqlConnection(ConnectString);
            MySqlCommand commandDatabase = new MySqlCommand(search, databaseConnect);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader myreader;
            databaseConnect.Open();
            myreader = commandDatabase.ExecuteReader();

            if (myreader.Read())
            {
                count++;
            }


        }
        public void deletefromdb()
        {

            string query = "DELETE FROM login WHERE Name='" + nametextbox.Text + "' AND Id='" + productidtextbox.Text + "'";
            MySqlConnection databaseConnection = new MySqlConnection(ConnectString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                while (reader.Read())
                {


                }

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e) //delete manager
        {
            search();

            if (nametextbox.Text != "" && productidtextbox.Text != "")
            {

                if (count == 1)
                {
                    DialogResult Confirmation = MessageBox.Show("Are you sure you want to remove the employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (Confirmation == DialogResult.Yes)
                    {
                        deletefromdb();
                        MessageBox.Show("Employee is removed from the database!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        count = 0;
                        nametextbox.Clear();
                        productidtextbox.Clear();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("There is no employee with this name and id!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nametextbox.Clear();
                    productidtextbox.Clear();

                }

            }
            else
            {
                MessageBox.Show("Provide proper information to continue!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e) // search button
        {
            string valueToSearch = productidtextbox.Text;
            string valueToSearch1 = nametextbox.Text;
            searchData(valueToSearch,valueToSearch1);
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            productidtextbox.Clear();
            nametextbox.Clear();
            searchData("","");
        }

        private void ExitButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
