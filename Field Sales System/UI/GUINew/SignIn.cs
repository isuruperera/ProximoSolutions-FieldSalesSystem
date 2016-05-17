﻿using Field_Sales_System.ControlLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUINew
{
    public partial class SignIn : Form
    {
        
        private Controller controller;

        public SignIn(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            controller.ForgotPassword.ShowDialog();
        }

       

        private void signInButton_Click(object sender, EventArgs e)
        {
            //controller.logIn(Int32.Parse(usernameText.Text), passwordText.Text);
        }

        private void signInButton_Click_1(object sender, EventArgs e)
        {
            controller.logIn(Int32.Parse(usernameText.Text), passwordText.Text);
        }
    }
}
