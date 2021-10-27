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
    public partial class EquityStatement : Form
    {
        int capital;
        int netincome;
        int equity;
        public EquityStatement()
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
            string query = "SELECT * FROM totalcalculation WHERE CONCAT(`Title`,`Amount`) like '%" + valueToSearch1 + "%'";
            
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridViewtotal.DataSource = table;
        }
        public void search2(string valueToSearch1)
        {
            string query = "SELECT * FROM capital WHERE CONCAT(`CapitalName`,`CapitalAmount`,`CapitalID`) like '%" + valueToSearch1 + "%'";
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridViewcapital.DataSource = table;
        }

        public void insert2db()
        {
            string ConnectString = "datasource = localhost; port = 3306; username = root; password=; database = biznessbuddy;";
            string query = "UPDATE totalcalculation SET `Amount`='" + this.closinglabel.Text + "'  WHERE `Title`='" + "Owners Equity" + "'";
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
            DialogResult Confirmation = MessageBox.Show("Data is stored in the table!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ExitButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EquityButton_Click(object sender, EventArgs e)
        {
            capital = 0;
            netincome = 0;
            equity = 0;
            for (int i = 0; i < dataGridViewcapital.Rows.Count; i++)
            {
                capital += Convert.ToInt32(dataGridViewcapital.Rows[i].Cells[1].Value);
            }
            connection.Open();
            string query = "SELECT * FROM totalcalculation WHERE Title='" + "Net Income" + "'";
            command = new MySqlCommand(query, connection);
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                incomelabel.Text = (reader["Amount"].ToString());

            }
            capitallabel.Text = capital.ToString();
            netincome = Convert.ToInt32(incomelabel.Text);
            
            equity = capital + netincome;
            closinglabel.Text = equity.ToString();
            insert2db();
            connection.Close();
        }

        private void EquityStatement_Load(object sender, EventArgs e)
        {
            search1("");
            search2("");
        }
    }
}
