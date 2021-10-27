using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace BiznessBuddy
{
    public partial class Login : Form
    {
        int flag = 0;
        int temp = 0;
        public Login()
        {
            InitializeComponent();
        }

        public string getvalue;
        private void LoginButton_Click(object sender, EventArgs e)
        {
            
            try
            {

                MySqlConnection connection = new MySqlConnection("datasource = localhost; port = 3306; username = root; password=; database = biznessbuddy;");
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM login WHERE Id='" + UserID.Text + "' AND Password='" + userPassword.Text + "'", connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable Table = new DataTable();
                adapter.Fill(Table);
                if (UserID.Text == "" || userPassword.Text == "")
                {
                    MessageBox.Show("Please provide proper information for log in!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UserID.Clear();
                    userPassword.Clear();
                    temp = 1;
                }
                if (temp == 0)
                {
                    try
                    {
                        getvalue = comboboxusertype.SelectedItem.ToString();
                        flag = 1;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Please insert user type and try again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                    if (Table.Rows.Count > 0)
                    {
                        if (flag == 1)
                        {

                            for (int i = 0; i < Table.Rows.Count; i++)
                            {

                                if (Table.Rows[i]["UserType"].ToString() == getvalue)
                                {
                                    MessageBox.Show("Congratulations! You have Logged in as " + Table.Rows[i][4], "Access Granted!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    if (comboboxusertype.SelectedIndex == 0)
                                    {
                                        DashboardAdmin access = new DashboardAdmin();
                                        access.Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        Dashboard access = new Dashboard();
                                        access.Show();
                                        this.Hide();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("There is no " + getvalue + " with this id and password", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }

                        }

                    }
                    else
                    {
                        MessageBox.Show("Please insert correct user id and password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                temp = 0;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            

        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }

        /*private void UserID_Validating(object sender, CancelEventArgs e)
        {
           
                if (string.IsNullOrEmpty(UserID.Text))
                {
                    e.Cancel = true;
                    UserID.Focus();
                    errorProvider1.SetError(UserID, "Please enter your user name or id!");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(UserID, null);
                }
        }

        private void userPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(userPassword.Text))
            {
                e.Cancel = true;
                userPassword.Focus();
                errorProvider2.SetError(userPassword, "Please enter your password!");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(userPassword, null);
            }
        }*/

    }
}
