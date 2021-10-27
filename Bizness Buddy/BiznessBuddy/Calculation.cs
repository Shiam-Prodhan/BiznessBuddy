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
    
    public partial class Calculation : Form
    {
        string netprofit;
        string totalliablities;
        string totalasset;
        int profit=0, liability=0, acid=0, tax=0, solvency=0,asset=0;

        public Calculation()
        {
            InitializeComponent();
        }

        private void ExitButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        MySqlConnection connection = new MySqlConnection("datasource = localhost;port = 3306; username = root; password=;database = biznessbuddy;");

        private void Calculation_Load(object sender, EventArgs e)
        {

        }

        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;
        MySqlDataReader reader;
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = "SELECT * FROM totalcalculation WHERE Title='" + "Net Income" + "'";
            command = new MySqlCommand(query, connection);
            reader = command.ExecuteReader();
            if (reader.Read())
            {
               netprofit  = (reader["Amount"].ToString());

            }
            connection.Close();
            connection.Open();
            string query1 = "SELECT * FROM totalcalculation WHERE Title='" + "Total Liability" + "'";
            command = new MySqlCommand(query1, connection);
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                totalliablities = (reader["Amount"].ToString());

            }connection.Close();
            connection.Open();
            string query2 = "SELECT * FROM totalcalculation WHERE Title='" + "Total Asset" + "'";
            command = new MySqlCommand(query2, connection);
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                totalasset = (reader["Amount"].ToString());

            }
            connection.Close();
            profit = Convert.ToInt32(netprofit);
            liability = int.Parse(totalliablities);
            asset = Convert.ToInt32(totalasset);
            acid = asset / liability;
            solvency = profit / liability;
            tax = (profit * 10) / 100;
            Solvencylabel.Text = solvency.ToString();
            acidlabel.Text = acid.ToString();
            taxlabel.Text = tax.ToString();
        }
    }
}
