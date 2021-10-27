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
    public partial class UpdateManager : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource = localhost;port = 3306; username = root; password=;database = biznessbuddy;");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;
        public UpdateManager()
        {
            InitializeComponent();
        }

        private void UpdateManager_Load(object sender, EventArgs e)
        {
            search("");
        }

        public void search(string valueToSearch1)
        {
            string query = "SELECT * FROM login WHERE CONCAT(`Name`, `Id`, `Phone`, `Password`, `UserType`) like '%" + valueToSearch1 + "%'";
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        public void updateformdb()
        {
            string ConnectString = "datasource = localhost; port = 3306; username = root; password=; database = biznessbuddy;";

            string update = "UPDATE login SET `Name`='" + this.nametextbox.Text + "', `Id`='" + this.idtextboxupdate.Text + "',`Phone`='" + this.phonetextbox.Text + "', `Password`='" + this.passwordtextbox.Text + "', `UserType`='" + this.typecombobox.Text + "' WHERE `Id`= '" + this.productidtextbox.Text + "';";
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

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (nametextbox.Text != "" && productidtextbox.Text != "" && phonetextbox.Text != "" && passwordtextbox.Text != "")
            {

                DialogResult Confirmation =MessageBox.Show("Are you sure you want to update the employee info?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (Confirmation == DialogResult.Yes)
                {
                    updateformdb();
                    MessageBox.Show("Employee information is successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nametextbox.Clear();

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

        private void dataGridViewdelete_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nametextbox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            idtextboxupdate.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            productidtextbox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            phonetextbox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            passwordtextbox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            typecombobox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            
        }

        private void Clearbutton1_Click(object sender, EventArgs e)
        {
            search("");
            nametextbox.Clear();
            idtextboxupdate.Clear();
            productidtextbox.Clear();
            phonetextbox.Clear();
            passwordtextbox.Clear();
            typecombobox.Text = "";
        }

        private void ExitButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
