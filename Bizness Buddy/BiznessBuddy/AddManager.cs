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
    public partial class AddManager : Form
    {
        public AddManager()
        {
            InitializeComponent();
        }

        public void insert2db()
        {
            string ConnectString = "datasource = localhost; port = 3306; username = root; password=; database = biznessbuddy;";
            string query = "INSERT INTO login (Name,Id,Phone,Password,UserType) VALUES ('" + this.nametextbox.Text + "','" + this.manageridtextbox.Text + "','" + this.phonetextbox.Text + "','" + this.passwordtextbox.Text + "','" + this.Designation.Text + "');";
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
        private void AddManager_Load(object sender, EventArgs e)
        {

        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            nametextbox.Clear();
            phonetextbox.Clear();
            passwordtextbox.Clear();
            manageridtextbox.Clear();
        }

        private void ExitButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void phonetextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please insert only interger value!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (nametextbox.Text != "" && passwordtextbox.Text != "" && manageridtextbox.Text != "" && phonetextbox.Text != "")
            {
                DialogResult Confirmation = MessageBox.Show("Are you sure you want to add a new employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (Confirmation == DialogResult.Yes)
                {
                    insert2db();
                    MessageBox.Show("Congratulations! Employee information is added to the database!", "Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nametextbox.Clear();
                    phonetextbox.Clear();
                    passwordtextbox.Clear();
                    manageridtextbox.Clear();
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
