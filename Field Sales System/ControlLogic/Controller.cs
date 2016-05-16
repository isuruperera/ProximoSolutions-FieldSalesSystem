﻿using Field_Sales_System.Business_Logic;
using Field_Sales_System.Utility_Classes;
using GUINew;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Field_Sales_System.ControlLogic
{
    public class Controller
    {
        ObjectFactory objectFactory;
        SecurityManager securityManager;
        SignIn openingDialogBox;
        AdminHomeWindow adminHW;
        AgentHomeWindow agentHW;
        RepHomeWindow repHW;
        WMHomeWindow wmHW;
        User currentUSer;
        AddEmployee newEmployee;
        ViewEmployee viewEmployee;

        public Controller()
        { objectFactory = new ObjectFactory();
            securityManager = new SecurityManager();
            openingDialogBox = new SignIn(this);
        }
        public void initilizer()
        {
            openingDialogBox.ShowDialog();
        }
        public void logIn(int empId, string password)
        {
            string check = securityManager.login(empId, password);
            if (check.Equals("Successfully logged in!"))
            {
                MessageBox.Show(check);
                User u = objectFactory.getUser(empId);
                currentUSer = u;
                if (u is CompanyAdmin)
                {
                    adminHW = new AdminHomeWindow();
                    adminHW.ShowDialog();
                    adminHW.nameLabel.Text = u.getFirstName() + " " + u.getLastName();
                    adminHW.photoLabel.Image = u.Dp.getPicture();
                }
                else if (u is Agent)
                {
                    agentHW = new AgentHomeWindow();
                    agentHW.Show();
                    agentHW.nameLabel.Text = u.getFirstName() + " " + u.getLastName();
                    agentHW.photoLabel.Image = u.Dp.getPicture();
                }
                else if (u is Representative)
                {
                    repHW = new RepHomeWindow();
                    repHW.Show();
                    repHW.nameLabel.Text = u.getFirstName() + " " + u.getLastName();
                    repHW.photoLabel.Image = u.Dp.getPicture();
                }
                else if (u is WarehouseManager)
                {
                    wmHW = new WMHomeWindow();
                    wmHW.Show();
                    wmHW.nameLabel.Text = u.getFirstName() + " " + u.getLastName();
                    wmHW.photoLabel.Image = u.Dp.getPicture();
                }
            }
            else
            {
                MessageBox.Show(check);
                openingDialogBox.usernameText.Text = "";
                openingDialogBox.passwordText.Text = "";
            }

        }
        public void adminAddemployer()
        {
            newEmployee.ShowDialog();
        }
        public void adminViewEmployer()
        {
            viewEmployee.ShowDialog();
        }
        public void adminSearchEmploee(int empId=0, string empFirstName="", string empLastName="")
        {
            
            
            viewEmployee.ShowDialog();
            viewEmployee.setData(objectFactory.searchUser(empId, empFirstName, empLastName));
        }
    }
}