using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiznessBuddy
{
    public partial class DashboardAdmin : Form
    {
        public DashboardAdmin()
        {
            InitializeComponent();
        }
        private void customize()
        {
            panelMainmenu.Visible = false;
        }

        private void hidesubmenu()
        {
            if (panelMainmenu.Visible == true)
            {
                panelMainmenu.Visible = false;
            }
            if (panel1.Visible == true)
            {
                panel1.Visible = false;
            }
        }

        private void showsubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hidesubmenu();
                submenu.Visible = true;
            }

            else
            {
                submenu.Visible = false;
            }
        }
        private void DashboardAdmin_Load(object sender, EventArgs e)
        {

        }

        private void Mainmenubutton_Click(object sender, EventArgs e)
        {
            showsubmenu(panelMainmenu);
        }


        private Form activeForm = null;

        private void openSubForm(Form SubForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = SubForm;
            SubForm.TopLevel = false;
            SubForm.FormBorderStyle = FormBorderStyle.None;
            SubForm.Dock = DockStyle.Fill;
            Panelbody.Controls.Add(SubForm);
            Panelbody.Tag = SubForm;
            SubForm.BringToFront();
            SubForm.Show();

        }
        private void DashboardAdmin_FormClosing(object sender, FormClosingEventArgs e)
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

        private void AddInventory_Click(object sender, EventArgs e)
        {
            openSubForm(new AddInventory());
            
        }

        private void Upadateinventory_Click(object sender, EventArgs e)
        {
            openSubForm(new UpdateInventory());
            
        }


        private void Deleteinventory_Click(object sender, EventArgs e)
        {
            openSubForm(new DeleteInventory());
            
        }

        private void AddManagerButton_Click(object sender, EventArgs e)
        {
            openSubForm(new AddManager());
            
        }

        private void UpdateManagerButton_Click(object sender, EventArgs e)
        {
            openSubForm(new UpdateManager());
        }

        private void DeleteManagerButton_Click(object sender, EventArgs e)
        {
            openSubForm(new DeleteManager());
        }

        private void Administrationbutton_Click(object sender, EventArgs e)
        {
            showsubmenu(panel1);
        }

        private void Logoutbutton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to LogOut?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Login access = new Login();
                access.Show();
                this.Hide();
            }
        }

        private void incomestatementbutton_Click(object sender, EventArgs e)
        {
            openSubForm(new IncomeStatement());
        }

        private void equitystatementbutton_Click(object sender, EventArgs e)
        {
            openSubForm(new EquityStatement());
        }

        private void Balancesheet_Click(object sender, EventArgs e)
        {
            openSubForm(new BalanceSheet());
        }

        private void calculationbutton_Click(object sender, EventArgs e)
        {
            openSubForm(new Calculation());
        }
    }
}
