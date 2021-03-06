﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
{
    [Serializable]
    public abstract class Employee
    {
        private int empId;
        private int empNIC;
        private bool gender;
        private string firstName;
        private string lastName;
        private DateTime dOB;

        [NonSerialized()] private DisplayPicture dp;
        [NonSerialized()] private ContactDetails contactDetails;

        internal ContactDetails ContactDetails
        {
            get
            {
                return contactDetails;
            }

            set
            {
                contactDetails = value;
            }
        }

        public DisplayPicture Dp
        {
            get
            {
                return dp;
            }

            set
            {
                dp = value;
            }
        }

        public int EmpNIC
        {
            get
            {
                return empNIC;
            }

            set
            {
                empNIC = value;
            }
        }

        public Employee(int empId, int empNIC ,DateTime dOB, bool gender, string firstName, string lastName, int mobileNo, int landNo, string email, string addressLine_1,string addressLine_2,string addressLine_3,Image img) {
            this.ContactDetails = new ContactDetails(mobileNo, landNo, email, addressLine_1,addressLine_2,addressLine_3);
            this.Dp = new DisplayPicture(img);
            this.empId = empId;
            this.EmpNIC = empNIC;
            this.gender = gender;
            this.firstName = firstName;
            this.lastName = lastName;
            this.dOB = dOB;

        }
        public void setGender(bool gender) {
            this.gender = gender;
        }

        public void setFirstName(string firstName) {
            this.firstName = firstName;
        }

        public void setLastName(string lastName) {
            this.lastName = lastName;
        }
        public void setDOB(DateTime dOB)
        {
            this.dOB = dOB;
        }

        public int getEmpId() {
            return this.empId;
        }

        public int getEmpNIC() {
            return this.EmpNIC;
        }

        public bool getGender() {
            return this.gender;
        }

        public string getFirstName() {
            return this.firstName; ;
        }

        public string getLastName() {
            return this.lastName;
        }
        public DateTime getDOB()
        {
            return this.dOB;
        }


    }
}
