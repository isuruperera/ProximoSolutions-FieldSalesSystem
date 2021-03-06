﻿namespace GUINew
{
    partial class AdminHomeWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHomeWindow));
            this.nameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.adminMainPanel1 = new System.Windows.Forms.Panel();
            this.viewReportsButton = new System.Windows.Forms.Button();
            this.searchEmployeeButton = new System.Windows.Forms.Button();
            this.empLastNameText = new System.Windows.Forms.TextBox();
            this.empFirstNameText = new System.Windows.Forms.TextBox();
            this.employeeIDText = new System.Windows.Forms.TextBox();
            this.logoutButton = new System.Windows.Forms.Button();
            this.photoLabel = new System.Windows.Forms.Label();
            this.addProductButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(72, 18);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(513, 50);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(31)))), ((int)(((byte)(1)))));
            this.label3.Location = new System.Drawing.Point(4, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1355, 7);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(31)))), ((int)(((byte)(1)))));
            this.label4.Location = new System.Drawing.Point(269, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(7, 639);
            this.label4.TabIndex = 3;
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(31)))), ((int)(((byte)(1)))));
            this.addEmployeeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployeeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.addEmployeeButton.FlatAppearance.BorderSize = 0;
            this.addEmployeeButton.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.addEmployeeButton.Location = new System.Drawing.Point(16, 152);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(236, 30);
            this.addEmployeeButton.TabIndex = 10;
            this.addEmployeeButton.Text = "Add Employee";
            this.addEmployeeButton.UseVisualStyleBackColor = false;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // adminMainPanel1
            // 
            this.adminMainPanel1.Location = new System.Drawing.Point(276, 112);
            this.adminMainPanel1.Name = "adminMainPanel1";
            this.adminMainPanel1.Size = new System.Drawing.Size(1080, 600);
            this.adminMainPanel1.TabIndex = 11;
            this.adminMainPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // viewReportsButton
            // 
            this.viewReportsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(31)))), ((int)(((byte)(1)))));
            this.viewReportsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewReportsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.viewReportsButton.FlatAppearance.BorderSize = 0;
            this.viewReportsButton.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewReportsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.viewReportsButton.Location = new System.Drawing.Point(16, 441);
            this.viewReportsButton.Name = "viewReportsButton";
            this.viewReportsButton.Size = new System.Drawing.Size(236, 30);
            this.viewReportsButton.TabIndex = 13;
            this.viewReportsButton.Text = "View Reports";
            this.viewReportsButton.UseVisualStyleBackColor = false;
            this.viewReportsButton.Click += new System.EventHandler(this.viewReportsButton_Click_1);
            // 
            // searchEmployeeButton
            // 
            this.searchEmployeeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(31)))), ((int)(((byte)(1)))));
            this.searchEmployeeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchEmployeeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.searchEmployeeButton.FlatAppearance.BorderSize = 0;
            this.searchEmployeeButton.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchEmployeeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.searchEmployeeButton.Location = new System.Drawing.Point(16, 342);
            this.searchEmployeeButton.Name = "searchEmployeeButton";
            this.searchEmployeeButton.Size = new System.Drawing.Size(236, 30);
            this.searchEmployeeButton.TabIndex = 15;
            this.searchEmployeeButton.Text = "Search Employee";
            this.searchEmployeeButton.UseVisualStyleBackColor = false;
            this.searchEmployeeButton.Click += new System.EventHandler(this.searchEmployeeButton_Click);
            // 
            // empLastNameText
            // 
            this.empLastNameText.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empLastNameText.Location = new System.Drawing.Point(16, 310);
            this.empLastNameText.Name = "empLastNameText";
            this.empLastNameText.Size = new System.Drawing.Size(236, 27);
            this.empLastNameText.TabIndex = 17;
            this.empLastNameText.Text = "Employee Last Name";
            this.empLastNameText.Click += new System.EventHandler(this.empLastNameText_Click);
            this.empLastNameText.TextChanged += new System.EventHandler(this.empLastNameText_TextChanged);
            this.empLastNameText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.empLastNameText_KeyPress);
            // 
            // empFirstNameText
            // 
            this.empFirstNameText.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empFirstNameText.Location = new System.Drawing.Point(16, 282);
            this.empFirstNameText.Name = "empFirstNameText";
            this.empFirstNameText.Size = new System.Drawing.Size(236, 27);
            this.empFirstNameText.TabIndex = 19;
            this.empFirstNameText.Text = "Employee First Name";
            this.empFirstNameText.Click += new System.EventHandler(this.empFirstNameText_Click);
            this.empFirstNameText.TextChanged += new System.EventHandler(this.empFirstNameText_TextChanged);
            this.empFirstNameText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.empFirstNameText_KeyPress);
            // 
            // employeeIDText
            // 
            this.employeeIDText.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIDText.Location = new System.Drawing.Point(16, 253);
            this.employeeIDText.Name = "employeeIDText";
            this.employeeIDText.Size = new System.Drawing.Size(236, 27);
            this.employeeIDText.TabIndex = 20;
            this.employeeIDText.Text = "Employee ID";
            this.employeeIDText.Click += new System.EventHandler(this.employeeIDText_Click);
            this.employeeIDText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.employeeIDText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.employeeIDText_KeyPress);
            // 
            // logoutButton
            // 
            this.logoutButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoutButton.BackgroundImage")));
            this.logoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Location = new System.Drawing.Point(1300, 18);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(50, 50);
            this.logoutButton.TabIndex = 18;
            this.logoutButton.UseVisualStyleBackColor = true;
            // 
            // photoLabel
            // 
            this.photoLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.photoLabel.Image = ((System.Drawing.Image)(resources.GetObject("photoLabel.Image")));
            this.photoLabel.Location = new System.Drawing.Point(16, 18);
            this.photoLabel.Name = "photoLabel";
            this.photoLabel.Size = new System.Drawing.Size(50, 50);
            this.photoLabel.TabIndex = 0;
            // 
            // addProductButton
            // 
            this.addProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(31)))), ((int)(((byte)(1)))));
            this.addProductButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addProductButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.addProductButton.FlatAppearance.BorderSize = 0;
            this.addProductButton.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.addProductButton.Location = new System.Drawing.Point(16, 547);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(236, 30);
            this.addProductButton.TabIndex = 21;
            this.addProductButton.Text = "Add Products";
            this.addProductButton.UseVisualStyleBackColor = false;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(1)))));
            this.label2.Location = new System.Drawing.Point(1104, 718);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 14);
            this.label2.TabIndex = 38;
            this.label2.Text = " UPALI FOODS AND BEVERAGES (PVT.) LTD.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AdminHomeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(236)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(1359, 733);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.employeeIDText);
            this.Controls.Add(this.empFirstNameText);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.empLastNameText);
            this.Controls.Add(this.searchEmployeeButton);
            this.Controls.Add(this.viewReportsButton);
            this.Controls.Add(this.adminMainPanel1);
            this.Controls.Add(this.addEmployeeButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.photoLabel);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminHomeWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public  System.Windows.Forms.Label photoLabel;
        public System.Windows.Forms.Label nameLabel;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button addEmployeeButton;
        public System.Windows.Forms.Panel adminMainPanel1;
        public System.Windows.Forms.Button viewReportsButton;
        public System.Windows.Forms.Button searchEmployeeButton;
        public System.Windows.Forms.TextBox empLastNameText;
        public System.Windows.Forms.Button logoutButton;
        public System.Windows.Forms.TextBox empFirstNameText;
        public System.Windows.Forms.TextBox employeeIDText;
        public System.Windows.Forms.Button addProductButton;
        public System.Windows.Forms.Label label2;
    }
}