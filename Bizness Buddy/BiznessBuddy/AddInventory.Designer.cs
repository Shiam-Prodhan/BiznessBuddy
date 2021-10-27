namespace BiznessBuddy
{
    partial class AddInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddInventory));
            this.ExitButton = new System.Windows.Forms.Button();
            this.labelAddinventory = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.titletextbox = new System.Windows.Forms.TextBox();
            this.labelamount = new System.Windows.Forms.Label();
            this.amounttextbox = new System.Windows.Forms.TextBox();
            this.quantitytextbox = new System.Windows.Forms.TextBox();
            this.labelquantity = new System.Windows.Forms.Label();
            this.labeltype = new System.Windows.Forms.Label();
            this.typecombobox = new System.Windows.Forms.ComboBox();
            this.labeldatetime = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clearbutton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.labelproductid = new System.Windows.Forms.Label();
            this.productidtextbox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitButton.BackgroundImage")));
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(794, 24);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(50, 41);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // labelAddinventory
            // 
            this.labelAddinventory.AutoSize = true;
            this.labelAddinventory.Font = new System.Drawing.Font("Ethnocentric Rg", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddinventory.Location = new System.Drawing.Point(344, 28);
            this.labelAddinventory.Name = "labelAddinventory";
            this.labelAddinventory.Size = new System.Drawing.Size(193, 25);
            this.labelAddinventory.TabIndex = 2;
            this.labelAddinventory.Text = "Data Entry";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTitle.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(236, 168);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(65, 23);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Title: ";
            // 
            // titletextbox
            // 
            this.titletextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(175)))), ((int)(((byte)(204)))));
            this.titletextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titletextbox.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titletextbox.Location = new System.Drawing.Point(311, 168);
            this.titletextbox.Name = "titletextbox";
            this.titletextbox.Size = new System.Drawing.Size(251, 30);
            this.titletextbox.TabIndex = 4;
            // 
            // labelamount
            // 
            this.labelamount.AutoSize = true;
            this.labelamount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelamount.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelamount.Location = new System.Drawing.Point(197, 260);
            this.labelamount.Name = "labelamount";
            this.labelamount.Size = new System.Drawing.Size(98, 23);
            this.labelamount.TabIndex = 3;
            this.labelamount.Text = "Amount:";
            // 
            // amounttextbox
            // 
            this.amounttextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(175)))), ((int)(((byte)(204)))));
            this.amounttextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amounttextbox.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amounttextbox.Location = new System.Drawing.Point(311, 259);
            this.amounttextbox.Name = "amounttextbox";
            this.amounttextbox.Size = new System.Drawing.Size(251, 30);
            this.amounttextbox.TabIndex = 5;
            this.amounttextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amounttextbox_KeyPress);
            // 
            // quantitytextbox
            // 
            this.quantitytextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(175)))), ((int)(((byte)(204)))));
            this.quantitytextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quantitytextbox.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitytextbox.Location = new System.Drawing.Point(311, 307);
            this.quantitytextbox.Name = "quantitytextbox";
            this.quantitytextbox.Size = new System.Drawing.Size(251, 30);
            this.quantitytextbox.TabIndex = 6;
            // 
            // labelquantity
            // 
            this.labelquantity.AutoSize = true;
            this.labelquantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelquantity.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelquantity.Location = new System.Drawing.Point(194, 309);
            this.labelquantity.Name = "labelquantity";
            this.labelquantity.Size = new System.Drawing.Size(102, 23);
            this.labelquantity.TabIndex = 3;
            this.labelquantity.Text = "Quantity:";
            // 
            // labeltype
            // 
            this.labeltype.AutoSize = true;
            this.labeltype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labeltype.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltype.Location = new System.Drawing.Point(231, 356);
            this.labeltype.Name = "labeltype";
            this.labeltype.Size = new System.Drawing.Size(64, 23);
            this.labeltype.TabIndex = 3;
            this.labeltype.Text = "Type:";
            this.labeltype.Click += new System.EventHandler(this.labeltype_Click);
            // 
            // typecombobox
            // 
            this.typecombobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(175)))), ((int)(((byte)(204)))));
            this.typecombobox.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typecombobox.FormattingEnabled = true;
            this.typecombobox.Items.AddRange(new object[] {
            "Asset",
            "Liability",
            "Capital",
            "Revenue",
            "Expenses"});
            this.typecombobox.Location = new System.Drawing.Point(311, 354);
            this.typecombobox.Name = "typecombobox";
            this.typecombobox.Size = new System.Drawing.Size(251, 30);
            this.typecombobox.TabIndex = 7;
            this.typecombobox.SelectedIndexChanged += new System.EventHandler(this.typecombobox_SelectedIndexChanged);
            // 
            // labeldatetime
            // 
            this.labeldatetime.AutoSize = true;
            this.labeldatetime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labeldatetime.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldatetime.Location = new System.Drawing.Point(231, 404);
            this.labeldatetime.Name = "labeldatetime";
            this.labeldatetime.Size = new System.Drawing.Size(62, 23);
            this.labeldatetime.TabIndex = 3;
            this.labeldatetime.Text = "Date:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(175)))), ((int)(((byte)(204)))));
            this.dateTimePicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(175)))), ((int)(((byte)(204)))));
            this.dateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(311, 406);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(251, 20);
            this.dateTimePicker.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.clearbutton);
            this.panel1.Location = new System.Drawing.Point(276, 467);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 37);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // clearbutton
            // 
            this.clearbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.clearbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearbutton.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbutton.Location = new System.Drawing.Point(52, 3);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(75, 31);
            this.clearbutton.TabIndex = 0;
            this.clearbutton.Text = "Clear";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.ConfirmButton);
            this.panel2.Location = new System.Drawing.Point(412, 467);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 37);
            this.panel2.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(14, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ConfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmButton.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmButton.Location = new System.Drawing.Point(52, 3);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(98, 31);
            this.ConfirmButton.TabIndex = 0;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // labelproductid
            // 
            this.labelproductid.AutoSize = true;
            this.labelproductid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelproductid.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelproductid.Location = new System.Drawing.Point(193, 215);
            this.labelproductid.Name = "labelproductid";
            this.labelproductid.Size = new System.Drawing.Size(100, 23);
            this.labelproductid.TabIndex = 3;
            this.labelproductid.Text = "Entry ID:";
            // 
            // productidtextbox
            // 
            this.productidtextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(175)))), ((int)(((byte)(204)))));
            this.productidtextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productidtextbox.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productidtextbox.Location = new System.Drawing.Point(311, 214);
            this.productidtextbox.Name = "productidtextbox";
            this.productidtextbox.Size = new System.Drawing.Size(251, 30);
            this.productidtextbox.TabIndex = 10;
            // 
            // AddInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(71)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(874, 642);
            this.Controls.Add(this.productidtextbox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.typecombobox);
            this.Controls.Add(this.quantitytextbox);
            this.Controls.Add(this.amounttextbox);
            this.Controls.Add(this.titletextbox);
            this.Controls.Add(this.labeldatetime);
            this.Controls.Add(this.labeltype);
            this.Controls.Add(this.labelquantity);
            this.Controls.Add(this.labelamount);
            this.Controls.Add(this.labelproductid);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelAddinventory);
            this.Controls.Add(this.ExitButton);
            this.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddInventory";
            this.Text = "Add Inventory";
            this.Load += new System.EventHandler(this.AddInventory_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label labelAddinventory;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox titletextbox;
        private System.Windows.Forms.Label labelamount;
        private System.Windows.Forms.TextBox amounttextbox;
        private System.Windows.Forms.TextBox quantitytextbox;
        private System.Windows.Forms.Label labelquantity;
        private System.Windows.Forms.Label labeltype;
        private System.Windows.Forms.ComboBox typecombobox;
        private System.Windows.Forms.Label labeldatetime;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Label labelproductid;
        private System.Windows.Forms.TextBox productidtextbox;
    }
}