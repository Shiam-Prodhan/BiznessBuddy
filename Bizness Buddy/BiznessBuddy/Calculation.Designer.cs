namespace BiznessBuddy
{
    partial class Calculation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculation));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ExitButton1 = new System.Windows.Forms.Button();
            this.taxlabel = new System.Windows.Forms.Label();
            this.acidlabel = new System.Windows.Forms.Label();
            this.Solvencylabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CalculateButton);
            this.panel1.Controls.Add(this.ExitButton1);
            this.panel1.Controls.Add(this.taxlabel);
            this.panel1.Controls.Add(this.acidlabel);
            this.panel1.Controls.Add(this.Solvencylabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 642);
            this.panel1.TabIndex = 0;
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(25)))));
            this.CalculateButton.FlatAppearance.BorderSize = 0;
            this.CalculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalculateButton.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.ForeColor = System.Drawing.Color.White;
            this.CalculateButton.Location = new System.Drawing.Point(343, 420);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(162, 37);
            this.CalculateButton.TabIndex = 32;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ExitButton1
            // 
            this.ExitButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitButton1.BackgroundImage")));
            this.ExitButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitButton1.FlatAppearance.BorderSize = 0;
            this.ExitButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton1.Location = new System.Drawing.Point(790, 15);
            this.ExitButton1.Name = "ExitButton1";
            this.ExitButton1.Size = new System.Drawing.Size(50, 41);
            this.ExitButton1.TabIndex = 28;
            this.ExitButton1.UseVisualStyleBackColor = true;
            this.ExitButton1.Click += new System.EventHandler(this.ExitButton1_Click);
            // 
            // taxlabel
            // 
            this.taxlabel.AutoSize = true;
            this.taxlabel.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxlabel.Location = new System.Drawing.Point(369, 275);
            this.taxlabel.Name = "taxlabel";
            this.taxlabel.Size = new System.Drawing.Size(0, 22);
            this.taxlabel.TabIndex = 0;
            this.taxlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // acidlabel
            // 
            this.acidlabel.AutoSize = true;
            this.acidlabel.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acidlabel.Location = new System.Drawing.Point(369, 223);
            this.acidlabel.Name = "acidlabel";
            this.acidlabel.Size = new System.Drawing.Size(0, 22);
            this.acidlabel.TabIndex = 0;
            this.acidlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Solvencylabel
            // 
            this.Solvencylabel.AutoSize = true;
            this.Solvencylabel.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Solvencylabel.Location = new System.Drawing.Point(369, 173);
            this.Solvencylabel.Name = "Solvencylabel";
            this.Solvencylabel.Size = new System.Drawing.Size(0, 22);
            this.Solvencylabel.TabIndex = 0;
            this.Solvencylabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(175, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Income Tax (10%):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Acid test Ratio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(339, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ratio Calculations";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Solvency:";
            // 
            // Calculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(71)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(874, 642);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculation";
            this.Text = "Calculation";
            this.Load += new System.EventHandler(this.Calculation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Solvencylabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitButton1;
        private System.Windows.Forms.Label taxlabel;
        private System.Windows.Forms.Label acidlabel;
        private System.Windows.Forms.Button CalculateButton;
    }
}