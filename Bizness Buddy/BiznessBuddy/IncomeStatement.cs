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
    public partial class IncomeStatement : Form
    {
        int revenuesum;
        int expensesum;
        int netincome;
        int count = 0;
        public IncomeStatement()
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
            string query = "SELECT * FROM revenue WHERE CONCAT(`RevenueName`,`RevenueAmount`,`RevenueID`) like '%" + valueToSearch1 + "%'";
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridViewrevenue.DataSource = table;
        }
        public void search2(string valueToSearch1)
        {
            string query = "SELECT * FROM expenses WHERE CONCAT(`ExpenseName`,`ExpenseAmount`,`ExpenseID`) like '%" + valueToSearch1 + "%'";
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridViewexpenses.DataSource = table;
        }
        public void insert2db()
        {
            string ConnectString = "datasource = localhost; port = 3306; username = root; password=; database = biznessbuddy;";
            string query = "UPDATE totalcalculation SET `Amount`='" + this.incomelabel.Text + "'  WHERE `Title`='"+ "Net Income" + "'";
            string query1 = "UPDATE totalcalculation SET `Amount`='" + this.revenuelabel.Text + "'  WHERE `Title`='" + "Total Revenue" + "'";
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

        private void button1_Click(object sender, EventArgs e) //generate income statementbutton
        {
            revenuesum = 0;
            expensesum = 0;
            netincome = 0;
            for(int i=0;i<dataGridViewrevenue.Rows.Count; i++)
            {
                revenuesum += Convert.ToInt32(dataGridViewrevenue.Rows[i].Cells[1].Value);
            }

            for (int i = 0; i < dataGridViewexpenses.Rows.Count; i++)
            {
                expensesum += Convert.ToInt32(dataGridViewexpenses.Rows[i].Cells[1].Value);
            }
            revenuelabel.Text = revenuesum.ToString();
            expenselabel.Text = expensesum.ToString();
            netincome = revenuesum - expensesum;
            incomelabel.Text = netincome.ToString();
            insert2db();

            


        }

        private void BalanceSheetButton_Load(object sender, EventArgs e)
        {
            search1("");
            search2("");
            
           
        }
    }
}
