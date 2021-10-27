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
    public partial class UpdateInventory : Form
    {
        int count = 0;
        MySqlConnection connection = new MySqlConnection("datasource = localhost;port = 3306; username = root; password=;database = biznessbuddy;");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;
        public UpdateInventory()
        {
            InitializeComponent();
        }
        public void search(string valueToSearch1)
        {
            string query = "SELECT * FROM inventory WHERE CONCAT(`InventoryName`,`InventoryID`,`InventoryAmount`,`InventoryQuantity`,`InventoryType`,`InventoryDate`) like '%" + valueToSearch1 + "%'";
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        public void updateformdb()
        {
            string ConnectString = "datasource = localhost; port = 3306; username = root; password=; database = biznessbuddy;";

            string update = "UPDATE inventory SET `InventoryName`='" + this.titletextbox.Text + "', `InventoryID`='" + this.idtextbox.Text + "',`InventoryAmount`='" + this.amounttextbox.Text + "', `InventoryQuantity`='" + this.quantitytextbox.Text + "', `InventoryType`='" + this.typecombobox.Text + "', `InventoryDate`='" + this.dateTimePicker.Text + "' WHERE `InventoryId`= '" + this.productidtextbox.Text + "';";
            MySqlConnection databaseConnection = new MySqlConnection(ConnectString);
            MySqlCommand commandDatabase = new MySqlCommand(update, databaseConnection);
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
                string query1 = "UPDATE asset SET `AssetName`='" + this.titletextbox.Text + "', `AssetAmount`='" + this.amounttextbox.Text + "',`AssetID`='" + this.idtextbox.Text + "' WHERE `AssetId`= '" + this.productidtextbox.Text + "';";
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
                string query1 = "UPDATE liability SET `LiabilityName`='" + this.titletextbox.Text + "', `LiabilityAmount`='" + this.amounttextbox.Text + "',`LiabilityID`='" + this.idtextbox.Text + "' WHERE `LiabilityId`= '" + this.productidtextbox.Text + "';";
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
                string query1 = "UPDATE capital SET `CapitalName`='" + this.titletextbox.Text + "', `CapitalAmount`='" + this.amounttextbox.Text + "',`CapitalID`='" + this.idtextbox.Text + "' WHERE `CapitalId`= '" + this.productidtextbox.Text + "';";
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
                string query1 = "UPDATE revenue SET `RevenueName`='" + this.titletextbox.Text + "', `RevenueAmount`='" + this.amounttextbox.Text + "',`RevenueID`='" + this.idtextbox.Text + "' WHERE `RevenueId`= '" + this.productidtextbox.Text + "';";
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
                string query1 = "UPDATE expenses SET `ExpenseName`='" + this.titletextbox.Text + "', `ExpenseAmount`='" + this.amounttextbox.Text + "',`ExpenseID`='" + this.idtextbox.Text + "' WHERE `ExpenseId`= '" + this.productidtextbox.Text + "';";
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
        private void Clearbutton1_Click(object sender, EventArgs e)
        {
            productidtextbox.Clear();
            search("");
        }

        private void ExitButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void paneldeletebody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UpdateInventory_Load(object sender, EventArgs e)
        {
            search("");
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (titletextbox.Text != "" && productidtextbox.Text != "" && quantitytextbox.Text != "" && amounttextbox.Text != "")
            {

                DialogResult Confirmation = MessageBox.Show("Are you sure you want to update the employee info?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (Confirmation == DialogResult.Yes)
                {
                    updateformdb();
                    MessageBox.Show("Employee information is successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    titletextbox.Clear();
                    if (count == 1)
                    {
                        MessageBox.Show("Data is aslo updated in the Asset Table!", "Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (count == 2)
                    {
                        MessageBox.Show("Data is aslo updated in the Liablity Table!", "Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (count == 3)
                    {
                        MessageBox.Show("Data is aslo updated in the Capital Table!", "Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (count == 4)
                    {
                        MessageBox.Show("Data is aslo updated in the Revenue Table!", "Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (count == 5)
                    {
                        MessageBox.Show("Data is aslo updated in the Expenses Table!", "Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Please provide proper information for update!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SearchButton1_Click(object sender, EventArgs e)
        {
            string valueToSearch1 = productidtextbox.Text;
            search(valueToSearch1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            titletextbox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            idtextbox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            productidtextbox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            amounttextbox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            quantitytextbox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            typecombobox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            dateTimePicker.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }
    }
}
