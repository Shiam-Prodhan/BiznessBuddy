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
    public partial class BalanceSheet : Form
    {
        int capital;
        int liability;
        int totalasset;
        int totalliability;
        string liabilities;
        public BalanceSheet()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("datasource = localhost;port = 3306; username = root; password=;database = biznessbuddy;");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;
        MySqlDataReader reader;
        public void search1(string valueToSearch1)
        {
            string query = "SELECT * FROM asset WHERE CONCAT(`AssetID`,`AssetName`,`AssetAmount`) like '%" + valueToSearch1 + "%'";

            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridViewasset.DataSource = table;
        }
        public void search2(string valueToSearch1)
        {
            string query = "SELECT * FROM liability WHERE CONCAT(`LiabilityID`,`LiabilityName`,`LiabilityAmount`) like '%" + valueToSearch1 + "%'";
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridViewliability.DataSource = table;
        }
        public void insert2db()
        {
            string ConnectString = "datasource = localhost; port = 3306; username = root; password=; database = biznessbuddy;";
            string query = "UPDATE totalcalculation SET `Amount`='" + liabilities + "'  WHERE `Title`='" + "Total Liability" + "'";
            string query1 = "UPDATE totalcalculation SET `Amount`='" + this.assestlabel.Text + "'  WHERE `Title`='" + "Total Asset" + "'";
            MySqlConnection databaseConnection = new MySqlConnection(ConnectString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            MySqlCommand commandDatabase1 = new MySqlCommand(query1, databaseConnection);
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

            try
            {

                databaseConnection.Open();
                reader = commandDatabase1.ExecuteReader();
                while (reader.Read())
                {


                }

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DialogResult Confirmation = MessageBox.Show("Data is stored in the table!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ExitButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BalanceSheet_Load(object sender, EventArgs e)
        {
            search1("");
            search2("");

            capital = 0;
            liability = 0;
            totalasset = 0;
            totalliability = 0;
            for (int i = 0; i < dataGridViewasset.Rows.Count; i++)
            {
                totalasset += Convert.ToInt32(dataGridViewasset.Rows[i].Cells[1].Value);
            }
            for (int i = 0; i < dataGridViewliability.Rows.Count; i++)
            {
                liability += Convert.ToInt32(dataGridViewliability.Rows[i].Cells[1].Value);
            }
            
            connection.Open();
            string query = "SELECT * FROM totalcalculation WHERE Title='" + "Owners Equity" + "'";
            command = new MySqlCommand(query, connection);
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                equitylabel.Text = (reader["Amount"].ToString());

            }
            assestlabel.Text = totalasset.ToString();
            capital = Convert.ToInt32(equitylabel.Text);
            totalliability = liability + capital;
            liabilities = liability.ToString();
            liabilitylabel.Text = totalliability.ToString();
            
            if(totalliability == totalasset)
            {
                ResultLabel.Text = "The Balance Sheet is BALANCED!";
            }
            else
            {
                ResultLabel.Text = "The Balance Sheet is not BALANCED!";
            }
            connection.Close();
            insert2db();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
