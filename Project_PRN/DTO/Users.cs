using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PRN
{
    class Users
    {

        string userID;
        string password;
        string fullname;
        string address;
        string phone;
        Roles role;


        public string UserID { get => userID; set => userID = value; }
        public string Password { get => password; set => password = value; }
        public string Fullname { get => fullname; set => fullname = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
        internal Roles Role { get => role; set => role = value; }

        public Users(string userID)
        {
            this.userID = userID;
        }

        public Users(string userID, string password, string fullname, string address, string phone, Roles role)
        {
            UserID = userID;
            Password = password;
            Fullname = fullname;
            Address = address;
            Phone = phone;
            Role = role;
        }
        public Users()
        {
        }

        public Users(string userID, string password, Roles role)
        {
            this.userID = userID;
            this.password = password;
            this.role = role;
        }

        public override string ToString()
        {
            return "ID - " + userID;
        }
    }
}
