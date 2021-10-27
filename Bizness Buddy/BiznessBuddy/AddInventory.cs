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
    public partial class AddInventory : Form
    {
        public AddInventory()
        {
            InitializeComponent();
        }
        int count = 0;
        private void ExitButton_Click(object sender, EventArgs e)
        {
            /* Dashboard access = new Dashboard();
             access.Show();
             this.Hide();*/

            this.Close();
        }

        public void insert2db()
        {
            string ConnectString = "datasource = localhost; port = 3306; username = root; password=; database = biznessbuddy;";
            string query = "INSERT INTO inventory (InventoryName,InventoryID,InventoryAmount,InventoryQuantity,InventoryType,InventoryDate) VALUES ('" + this.titletextbox.Text + "','" + this.productidtextbox.Text + "','" + this.amounttextbox.Text + "','" + this.quantitytextbox.Text + "','" + this.typecombobox.Text + "', '" + this.dateTimePicker.Text + "');";
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

            if(typecombobox.Text=="Asset")
            {
                string query1 = "INSERT INTO asset (AssetName,AssetAmount,AssetID) VALUES ('" + this.titletextbox.Text + "','" + this.amounttextbox.Text + "','" +this.productidtextbox.Text + "');";
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
                string query1 = "INSERT INTO liability (LiabilityName,LiabilityAmount,LiabilityID) VALUES ('" + this.titletextbox.Text + "','" + this.amounttextbox.Text + "','" + this.productidtextbox.Text + "');";
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
                string query1 = "INSERT INTO capital (CapitalName,CapitalAmount,CapitalID) VALUES ('" + this.titletextbox.Text + "','" + this.amounttextbox.Text + "','" + this.productidtextbox.Text + "');";
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
                string query1 = "INSERT INTO revenue (RevenueName,RevenueAmount,RevenueId) VALUES ('" + this.titletextbox.Text + "','" + this.amounttextbox.Text + "','" + this.productidtextbox.Text + "');";
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
                string query1 = "INSERT INTO expenses (ExpenseName,ExpenseAmount,ExpenseID) VALUES ('" + this.titletextbox.Text + "','" + this.amounttextbox.Text + "','" + this.productidtextbox.Text + "');";
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
        private void clearbutton_Click(object sender, EventArgs e)
        {
            titletextbox.Clear();
            productidtextbox.Clear();
            amounttextbox.Clear();
            quantitytextbox.Clear();
            typecombobox.Text = "";
            dateTimePicker.Text = "";
        }

        private void amounttextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please insert only interger value!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void typecombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labeltype_Click(object sender, EventArgs e)
        {

        }

        private void AddInventory_Load(object sender, EventArgs e)
        {

        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (titletextbox.Text != "" && productidtextbox.Text != "" && typecombobox.Text != "")
            {
                DialogResult Confirmation = MessageBox.Show("Are you sure you want to add a new data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (Confirmation == DialogResult.Yes)
                {
                    insert2db();
                    MessageBox.Show("Congratulations! Data is added to the database!", "Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    titletextbox.Clear();
                    productidtextbox.Clear();
                    amounttextbox.Clear();
                    quantitytextbox.Clear();
                    typecombobox.Text = "";
                    dateTimePicker.Text = ""; 

                    if(count==1)
                    {
                        MessageBox.Show("Data is aslo added to the Asset Table!", "Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (count == 2)
                    {
                        MessageBox.Show("Data is aslo added to the Liablity Table!", "Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (count == 3)
                    {
                        MessageBox.Show("Data is aslo added to the Capital Table!", "Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (count == 4)
                    {
                        MessageBox.Show("Data is aslo added to the Revenue Table!", "Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (count == 5)
                    {
                        MessageBox.Show("Data is aslo added to the Expenses Table!", "Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

               this.Close();

            }
            else
            {
                MessageBox.Show("Provide proper information to continue!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
