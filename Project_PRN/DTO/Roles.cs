using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PRN
{
    class Roles
    {
        int roleId;
        string roleName;

        public Roles(int roleId, string roleName)
        {
            RoleId = roleId;
            RoleName = roleName;
        }
        public Roles(int roleId)
        {
            RoleId = roleId;
        }

        public Roles(string roleName)
        {
            RoleName = roleName;
        }

        public Roles()
        {
        }

        public int RoleId { get => roleId; set => roleId = value; }
        public string RoleName { get => roleName; set => roleName = value; }
    }
}
