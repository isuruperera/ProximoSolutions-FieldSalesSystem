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
        EmployeeProfile profile;

        public Controller()
        { objectFactory = new ObjectFactory();
            securityManager = new SecurityManager();
            openingDialogBox = new SignIn(this);
            profile = new EmployeeProfile();
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
                    adminHW.TopLevel = false;
                    adminHW.nameLabel.Text = u.getFirstName() + " " + u.getLastName();
                    adminHW.photoLabel.Image = u.Dp.getPicture();
                    adminHW.ShowDialog();
                    
                }
                else if (u is Agent)
                {
                    agentHW = new AgentHomeWindow();
                    agentHW.nameLabel.Text = u.getFirstName() + " " + u.getLastName();
                    agentHW.photoLabel.Image = u.Dp.getPicture();
                    agentHW.ShowDialog();

                }
                else if (u is Representative)
                {
                    repHW = new RepHomeWindow(this);
                    repHW.nameLabel.Text = u.getFirstName() + " " + u.getLastName();
                    repHW.photoLabel.Image = u.Dp.getPicture();
                    openingDialogBox.Hide();
                    repHW.ShowDialog();
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

        public void setMyHome_Representative() {
            profile.TopLevel = false;
            repHW.TopLevel = true;
            profile.AutoScroll = true;
            
            profile.addressLabel.Text = currentUSer.ContactDetails.AddressLine_1;
            profile.cityLabel.Text = currentUSer.ContactDetails.AddressLine_2;
            profile.stateLabel.Text = currentUSer.ContactDetails.AddressLine_3;
            profile.mobileLabel.Text = currentUSer.ContactDetails.MobileNo.ToString();
            profile.homeTelLabel.Text = currentUSer.ContactDetails.LandNo.ToString();
            profile.nameLabel.Text = currentUSer.getFirstName() + currentUSer.getLastName();
            profile.regionLabel.Text = "---";
            profile.jobTitleLabel.Text = currentUSer.UserRoles[0].getRoleName();
            repHW.repMainPannel.Controls.Add(profile);
            profile.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            profile.Show();
        }
    }
}
