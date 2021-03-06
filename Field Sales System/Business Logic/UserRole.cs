﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic

{
    [Serializable]
    public class UserRole
    {

        private List<Permission> permissions;
        private string roleName;

        public List<Permission> Permissions
        {
            get
            {
                return permissions;
            }

            set
            {
                permissions = value;
            }
        }

        public void setRoleName(string name) {
            this.roleName = name;
        }
        public string getRoleName() {
            return this.roleName;
        }
        public void addPermission(Permission p) {
            this.Permissions.Add(p);
        }
        public void dropPermission(Permission p) {
            this.Permissions.Remove(p);
        }
        


    }
}
