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
    public partial class DeleteInventory : Form
    {
        int Flag = 0;
        int count = 0;
        MySqlConnection connection = new MySqlConnection("datasource = localhost;port = 3306; username = root; password=;database = biznessbuddy;");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;
        public DeleteInventory()
        {
            InitializeComponent();
        }

        private void DeleteInventory_Load(object sender, EventArgs e)
        {
            search("", "");
        }
        string ConnectString = "datasource = localhost; port = 3306; username = root; password=; database = biznessbuddy;";
        public void Check()
        {
            string search = "SELECT * FROM inventory WHERE InventoryName='" + Titletextbox.Text + "' AND InventoryId='" + productidtextbox.Text + "' AND InventoryType='"+typecombobox.Text+"'";
            MySqlConnection databaseConnect = new MySqlConnection(ConnectString);
            MySqlCommand commandDatabase = new MySqlCommand(search, databaseConnect);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader myreader;
            databaseConnect.Open();
            myreader = commandDatabase.ExecuteReader();

            if (myreader.Read())
            {
                Flag++;
            }


        }
        public void deletefromdb()
        {

            string query = "DELETE FROM inventory WHERE InventoryName='" + Titletextbox.Text + "' AND InventoryId='" + productidtextbox.Text + "'";
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
             if (typecombobox.Text == "Asset")
            {
                string query1 = "DELETE FROM asset WHERE AssetName='" + Titletextbox.Text + "' AND AssetId='" + productidtextbox.Text + "'";
                commandDatabase = new MySqlCommand(query1, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader1;

                try
                {

                    databaseConnection.Open();
                    reader1 = commandDatabase.ExecuteReader();
                    while (reader1.Read())
                    {


                    }
                    count = 1;
                    databaseConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            else if (typecombobox.Text == "Liability")
            {
                string query1 = "DELETE FROM liability WHERE LiabilityName='" + Titletextbox.Text + "' AND LiabilityId='" + productidtextbox.Text + "'";
                commandDatabase = new MySqlCommand(query1, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader1;

                try
                {

                    databaseConnection.Open();
                    reader1 = commandDatabase.ExecuteReader();
                    while (reader1.Read())
                    {


                    }
                    count = 2;
                    databaseConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            else if (typecombobox.Text == "Capital")
            {
                string query1 = "DELETE FROM Capital WHERE AssetName='" + Titletextbox.Text + "' AND AssetId='" + productidtextbox.Text + "'";
                commandDatabase = new MySqlCommand(query1, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader1;

                try
                {

                    databaseConnection.Open();
                    reader1 = commandDatabase.ExecuteReader();
                    while (reader1.Read())
                    {


                    }
                    count = 3;
                    databaseConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            else if (typecombobox.Text == "Revenue")
            {
                string query1 = "DELETE FROM revenue WHERE RevenueName='" + Titletextbox.Text + "' AND RevenueId='" + productidtextbox.Text + "'";
                commandDatabase = new MySqlCommand(query1, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader1;

                try
                {

                    databaseConnection.Open();
                    reader1 = commandDatabase.ExecuteReader();
                    while (reader1.Read())
                    {


                    }
                    count = 4;
                    databaseConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            else if (typecombobox.Text == "Expenses")
            {
                string query1 = "DELETE FROM expenses WHERE ExpenseName='" + Titletextbox.Text + "' AND ExpenseId='" + productidtextbox.Text + "'";
                commandDatabase = new MySqlCommand(query1, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader1;

                try
                {

                    databaseConnection.Open();
                    reader1 = commandDatabase.ExecuteReader();
                    while (reader1.Read())
                    {


                    }
                    count = 5;
                    databaseConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }
        public void search(string valueToSearch1, string valueToSearch2)
        {
            string query = "SELECT * FROM inventory WHERE CONCAT(`InventoryName`,`InventoryID`,`InventoryAmount`,`InventoryQuantity`,`InventoryType`,`InventoryDate`) like '%" + valueToSearch1 + valueToSearch2 + "%'";
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void Clearbutton_Click_1(object sender, EventArgs e)
        {
            Titletextbox.Clear();
            productidtextbox.Clear();
            search("", "");
            
        }

        private void ExitButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void paneldeletebody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e) //deletebutton
        {
            Check();

            if (Titletextbox.Text != "" && productidtextbox.Text != "")
            {

                if (Flag == 1)
                {
                    DialogResult Confirmation = MessageBox.Show("Are you sure you want to remove the book?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (Confirmation == DialogResult.Yes)
                    {
                        deletefromdb();
                        MessageBox.Show("Data is removed to the database!", "Successfull",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        Flag = 0;

                        if (count == 1)
                        {
                            MessageBox.Show("Data is aslo deleted from the Asset Table!", "Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (count == 2)
                        {
                            MessageBox.Show("Data is aslo deleted from the Liablity Table!", "Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (count == 3)
                        {
                            MessageBox.Show("Data is aslo deleted from the Capital Table!", "Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (count == 4)
                        {
                            MessageBox.Show("Data is aslo deleted from the Revenue Table!", "Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (count == 5)
                        {
                            MessageBox.Show("Data is aslo deleted from the Expenses Table!", "Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("There is no data with this name and id!\nTry Again", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Titletextbox.Text = "";
                    productidtextbox.Text = "";

                }

            }
            else
            {
                MessageBox.Show("Please provide valid information to continue", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click_1(object sender, EventArgs e) // search button
        {
            string valueToSearch2 = Titletextbox.Text;
            string valueToSearch1 = productidtextbox.Text;
            search(valueToSearch2, valueToSearch1);
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Titletextbox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            productidtextbox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            typecombobox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}
