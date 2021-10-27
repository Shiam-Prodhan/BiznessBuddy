namespace BiznessBuddy
{
    partial class DashboardAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardAdmin));
            this.Panelbody = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelbar = new System.Windows.Forms.Panel();
            this.AdministrationButton = new System.Windows.Forms.Button();
            this.panelMainmenu = new System.Windows.Forms.Panel();
            this.Deleteinventory = new System.Windows.Forms.Button();
            this.Upadateinventory = new System.Windows.Forms.Button();
            this.AddInventory = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deletemanagerbutton = new System.Windows.Forms.Button();
            this.updatemanagerbutton = new System.Windows.Forms.Button();
            this.AddManagerButton = new System.Windows.Forms.Button();
            this.Mainmenubutton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.equitystatementbutton = new System.Windows.Forms.Button();
            this.incomestatementbutton = new System.Windows.Forms.Button();
            this.Balancesheet = new System.Windows.Forms.Button();
            this.OperationButton = new System.Windows.Forms.Button();
            this.Logoutbutton = new System.Windows.Forms.Button();
            this.calculationbutton = new System.Windows.Forms.Button();
            this.Panelbody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelbar.SuspendLayout();
            this.panelMainmenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panelbody
            // 
            this.Panelbody.Controls.Add(this.pictureBox1);
            this.Panelbody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panelbody.Location = new System.Drawing.Point(168, 0);
            this.Panelbody.Name = "Panelbody";
            this.Panelbody.Size = new System.Drawing.Size(896, 681);
            this.Panelbody.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(265, 176);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 278);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelbar
            // 
            this.panelbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.panelbar.Controls.Add(this.calculationbutton);
            this.panelbar.Controls.Add(this.Logoutbutton);
            this.panelbar.Controls.Add(this.panel2);
            this.panelbar.Controls.Add(this.AdministrationButton);
            this.panelbar.Controls.Add(this.OperationButton);
            this.panelbar.Controls.Add(this.panelMainmenu);
            this.panelbar.Controls.Add(this.panel1);
            this.panelbar.Controls.Add(this.Mainmenubutton);
            this.panelbar.Controls.Add(this.pictureBox2);
            this.panelbar.Controls.Add(this.panel3);
            this.panelbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelbar.Location = new System.Drawing.Point(0, 0);
            this.panelbar.Name = "panelbar";
            this.panelbar.Size = new System.Drawing.Size(168, 681);
            this.panelbar.TabIndex = 6;
            // 
            // AdministrationButton
            // 
            this.AdministrationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.AdministrationButton.Enabled = false;
            this.AdministrationButton.FlatAppearance.BorderSize = 0;
            this.AdministrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdministrationButton.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdministrationButton.ForeColor = System.Drawing.Color.Lavender;
            this.AdministrationButton.Location = new System.Drawing.Point(-3, 281);
            this.AdministrationButton.Name = "AdministrationButton";
            this.AdministrationButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.AdministrationButton.Size = new System.Drawing.Size(174, 37);
            this.AdministrationButton.TabIndex = 1;
            this.AdministrationButton.Text = "Administration";
            this.AdministrationButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdministrationButton.UseVisualStyleBackColor = false;
            this.AdministrationButton.Click += new System.EventHandler(this.Administrationbutton_Click);
            // 
            // panelMainmenu
            // 
            this.panelMainmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.panelMainmenu.Controls.Add(this.Deleteinventory);
            this.panelMainmenu.Controls.Add(this.Upadateinventory);
            this.panelMainmenu.Controls.Add(this.AddInventory);
            this.panelMainmenu.Location = new System.Drawing.Point(2, 175);
            this.panelMainmenu.Name = "panelMainmenu";
            this.panelMainmenu.Size = new System.Drawing.Size(172, 100);
            this.panelMainmenu.TabIndex = 5;
            // 
            // Deleteinventory
            // 
            this.Deleteinventory.FlatAppearance.BorderSize = 0;
            this.Deleteinventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deleteinventory.ForeColor = System.Drawing.SystemColors.Control;
            this.Deleteinventory.Location = new System.Drawing.Point(-1, 67);
            this.Deleteinventory.Name = "Deleteinventory";
            this.Deleteinventory.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.Deleteinventory.Size = new System.Drawing.Size(174, 33);
            this.Deleteinventory.TabIndex = 0;
            this.Deleteinventory.Text = "Delete Inventory";
            this.Deleteinventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Deleteinventory.UseVisualStyleBackColor = true;
            this.Deleteinventory.Click += new System.EventHandler(this.Deleteinventory_Click);
            // 
            // Upadateinventory
            // 
            this.Upadateinventory.FlatAppearance.BorderSize = 0;
            this.Upadateinventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Upadateinventory.ForeColor = System.Drawing.SystemColors.Control;
            this.Upadateinventory.Location = new System.Drawing.Point(-2, 35);
            this.Upadateinventory.Name = "Upadateinventory";
            this.Upadateinventory.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.Upadateinventory.Size = new System.Drawing.Size(174, 33);
            this.Upadateinventory.TabIndex = 0;
            this.Upadateinventory.Text = "Update Inventory";
            this.Upadateinventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Upadateinventory.UseVisualStyleBackColor = true;
            this.Upadateinventory.Click += new System.EventHandler(this.Upadateinventory_Click);
            // 
            // AddInventory
            // 
            this.AddInventory.FlatAppearance.BorderSize = 0;
            this.AddInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddInventory.ForeColor = System.Drawing.SystemColors.Control;
            this.AddInventory.Location = new System.Drawing.Point(-2, 3);
            this.AddInventory.Name = "AddInventory";
            this.AddInventory.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.AddInventory.Size = new System.Drawing.Size(174, 33);
            this.AddInventory.TabIndex = 0;
            this.AddInventory.Text = "Add Inventory";
            this.AddInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddInventory.UseVisualStyleBackColor = true;
            this.AddInventory.Click += new System.EventHandler(this.AddInventory_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.deletemanagerbutton);
            this.panel1.Controls.Add(this.updatemanagerbutton);
            this.panel1.Controls.Add(this.AddManagerButton);
            this.panel1.Location = new System.Drawing.Point(-2, 318);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 106);
            this.panel1.TabIndex = 6;
            // 
            // deletemanagerbutton
            // 
            this.deletemanagerbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.deletemanagerbutton.FlatAppearance.BorderSize = 0;
            this.deletemanagerbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletemanagerbutton.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletemanagerbutton.ForeColor = System.Drawing.Color.Lavender;
            this.deletemanagerbutton.Location = new System.Drawing.Point(-1, 65);
            this.deletemanagerbutton.Name = "deletemanagerbutton";
            this.deletemanagerbutton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.deletemanagerbutton.Size = new System.Drawing.Size(174, 37);
            this.deletemanagerbutton.TabIndex = 1;
            this.deletemanagerbutton.Text = "Delete Employee";
            this.deletemanagerbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deletemanagerbutton.UseVisualStyleBackColor = false;
            this.deletemanagerbutton.Click += new System.EventHandler(this.DeleteManagerButton_Click);
            // 
            // updatemanagerbutton
            // 
            this.updatemanagerbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.updatemanagerbutton.FlatAppearance.BorderSize = 0;
            this.updatemanagerbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatemanagerbutton.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatemanagerbutton.ForeColor = System.Drawing.Color.Lavender;
            this.updatemanagerbutton.Location = new System.Drawing.Point(-1, 35);
            this.updatemanagerbutton.Name = "updatemanagerbutton";
            this.updatemanagerbutton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.updatemanagerbutton.Size = new System.Drawing.Size(174, 37);
            this.updatemanagerbutton.TabIndex = 1;
            this.updatemanagerbutton.Text = "Update Employee";
            this.updatemanagerbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updatemanagerbutton.UseVisualStyleBackColor = false;
            this.updatemanagerbutton.Click += new System.EventHandler(this.UpdateManagerButton_Click);
            // 
            // AddManagerButton
            // 
            this.AddManagerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.AddManagerButton.FlatAppearance.BorderSize = 0;
            this.AddManagerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddManagerButton.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddManagerButton.ForeColor = System.Drawing.Color.Lavender;
            this.AddManagerButton.Location = new System.Drawing.Point(0, 0);
            this.AddManagerButton.Name = "AddManagerButton";
            this.AddManagerButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.AddManagerButton.Size = new System.Drawing.Size(174, 37);
            this.AddManagerButton.TabIndex = 1;
            this.AddManagerButton.Text = "Add Employee";
            this.AddManagerButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddManagerButton.UseVisualStyleBackColor = false;
            this.AddManagerButton.Click += new System.EventHandler(this.AddManagerButton_Click);
            // 
            // Mainmenubutton
            // 
            this.Mainmenubutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.Mainmenubutton.Enabled = false;
            this.Mainmenubutton.FlatAppearance.BorderSize = 0;
            this.Mainmenubutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mainmenubutton.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mainmenubutton.ForeColor = System.Drawing.Color.Lavender;
            this.Mainmenubutton.Location = new System.Drawing.Point(0, 137);
            this.Mainmenubutton.Name = "Mainmenubutton";
            this.Mainmenubutton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Mainmenubutton.Size = new System.Drawing.Size(174, 37);
            this.Mainmenubutton.TabIndex = 1;
            this.Mainmenubutton.Text = "Main Menu";
            this.Mainmenubutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Mainmenubutton.UseVisualStyleBackColor = false;
            this.Mainmenubutton.Click += new System.EventHandler(this.Mainmenubutton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(148, 82);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(168, 128);
            this.panel3.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.panel2.Controls.Add(this.equitystatementbutton);
            this.panel2.Controls.Add(this.incomestatementbutton);
            this.panel2.Controls.Add(this.Balancesheet);
            this.panel2.Location = new System.Drawing.Point(1, 460);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(172, 100);
            this.panel2.TabIndex = 7;
            // 
            // equitystatementbutton
            // 
            this.equitystatementbutton.FlatAppearance.BorderSize = 0;
            this.equitystatementbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equitystatementbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.equitystatementbutton.Location = new System.Drawing.Point(-5, 32);
            this.equitystatementbutton.Name = "equitystatementbutton";
            this.equitystatementbutton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.equitystatementbutton.Size = new System.Drawing.Size(174, 33);
            this.equitystatementbutton.TabIndex = 0;
            this.equitystatementbutton.Text = "Equity Statement";
            this.equitystatementbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.equitystatementbutton.UseVisualStyleBackColor = true;
            this.equitystatementbutton.Click += new System.EventHandler(this.equitystatementbutton_Click);
            // 
            // incomestatementbutton
            // 
            this.incomestatementbutton.FlatAppearance.BorderSize = 0;
            this.incomestatementbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incomestatementbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.incomestatementbutton.Location = new System.Drawing.Point(-5, 0);
            this.incomestatementbutton.Name = "incomestatementbutton";
            this.incomestatementbutton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.incomestatementbutton.Size = new System.Drawing.Size(174, 33);
            this.incomestatementbutton.TabIndex = 0;
            this.incomestatementbutton.Text = "Income Statement";
            this.incomestatementbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.incomestatementbutton.UseVisualStyleBackColor = true;
            this.incomestatementbutton.Click += new System.EventHandler(this.incomestatementbutton_Click);
            // 
            // Balancesheet
            // 
            this.Balancesheet.FlatAppearance.BorderSize = 0;
            this.Balancesheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Balancesheet.ForeColor = System.Drawing.SystemColors.Control;
            this.Balancesheet.Location = new System.Drawing.Point(-4, 67);
            this.Balancesheet.Name = "Balancesheet";
            this.Balancesheet.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.Balancesheet.Size = new System.Drawing.Size(174, 33);
            this.Balancesheet.TabIndex = 0;
            this.Balancesheet.Text = "BalanceSheet";
            this.Balancesheet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Balancesheet.UseVisualStyleBackColor = true;
            this.Balancesheet.Click += new System.EventHandler(this.Balancesheet_Click);
            // 
            // OperationButton
            // 
            this.OperationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.OperationButton.Enabled = false;
            this.OperationButton.FlatAppearance.BorderSize = 0;
            this.OperationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OperationButton.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperationButton.ForeColor = System.Drawing.Color.Lavender;
            this.OperationButton.Location = new System.Drawing.Point(1, 424);
            this.OperationButton.Name = "OperationButton";
            this.OperationButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.OperationButton.Size = new System.Drawing.Size(174, 37);
            this.OperationButton.TabIndex = 6;
            this.OperationButton.Text = "Operations";
            this.OperationButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OperationButton.UseVisualStyleBackColor = false;
            // 
            // Logoutbutton
            // 
            this.Logoutbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.Logoutbutton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Logoutbutton.FlatAppearance.BorderSize = 0;
            this.Logoutbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logoutbutton.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logoutbutton.ForeColor = System.Drawing.Color.Black;
            this.Logoutbutton.Location = new System.Drawing.Point(0, 644);
            this.Logoutbutton.Name = "Logoutbutton";
            this.Logoutbutton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Logoutbutton.Size = new System.Drawing.Size(168, 37);
            this.Logoutbutton.TabIndex = 8;
            this.Logoutbutton.Text = "Logout";
            this.Logoutbutton.UseVisualStyleBackColor = false;
            this.Logoutbutton.Click += new System.EventHandler(this.Logoutbutton_Click);
            // 
            // calculationbutton
            // 
            this.calculationbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.calculationbutton.FlatAppearance.BorderSize = 0;
            this.calculationbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculationbutton.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculationbutton.ForeColor = System.Drawing.Color.Lavender;
            this.calculationbutton.Location = new System.Drawing.Point(-6, 566);
            this.calculationbutton.Name = "calculationbutton";
            this.calculationbutton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.calculationbutton.Size = new System.Drawing.Size(174, 37);
            this.calculationbutton.TabIndex = 9;
            this.calculationbutton.Text = "Calculations";
            this.calculationbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.calculationbutton.UseVisualStyleBackColor = false;
            this.calculationbutton.Click += new System.EventHandler(this.calculationbutton_Click);
            // 
            // DashboardAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(71)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.Panelbody);
            this.Controls.Add(this.panelbar);
            this.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DashboardAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DashboardAdmin_FormClosing);
            this.Load += new System.EventHandler(this.DashboardAdmin_Load);
            this.Panelbody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelbar.ResumeLayout(false);
            this.panelMainmenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panelbody;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelbar;
        private System.Windows.Forms.Panel panelMainmenu;
        private System.Windows.Forms.Button Deleteinventory;
        private System.Windows.Forms.Button Upadateinventory;
        private System.Windows.Forms.Button AddInventory;
        private System.Windows.Forms.Button AddManagerButton;
        private System.Windows.Forms.Button Mainmenubutton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deletemanagerbutton;
        private System.Windows.Forms.Button updatemanagerbutton;
        private System.Windows.Forms.Button AdministrationButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button equitystatementbutton;
        private System.Windows.Forms.Button incomestatementbutton;
        private System.Windows.Forms.Button Balancesheet;
        private System.Windows.Forms.Button OperationButton;
        private System.Windows.Forms.Button Logoutbutton;
        private System.Windows.Forms.Button calculationbutton;
    }
}