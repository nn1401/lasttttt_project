using Project_PRN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PRN
{
    class UserDAO
    {
        public static List<Users> getAllUser()
        {
            List<Users> list = new List<Users>();
            try
            {
                SqlConnection conn = Connection.ConnectDB.connectDB();
                string statement = "select * from Users, roles where Users.roleId = roles.roleId";
                SqlDataAdapter dap = new SqlDataAdapter(statement, conn);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                conn.Close();
                foreach (DataRow row in dt.Rows)
                {
                    list.Add(new Users(row["userId"].ToString(), row["password"].ToString(), row["fullName"].ToString(), row["address"].ToString(), row["phone"].ToString(), new Roles(row["roleName"].ToString())));
                }
                return list;
            }
            catch (System.Exception)
            {
            }
            return null;
        }

        public static List<Users> getAllUserById(string id)
        {
            List<Users> list = new List<Users>();
            try
            {
                SqlConnection conn = Connection.ConnectDB.connectDB();
                string statement = "select * from Users, Roles where Users.roleId = roles.roleId and userid like '%" + id + "%'";
                SqlDataAdapter dap = new SqlDataAdapter(statement, conn);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                conn.Close();
                foreach (DataRow row in dt.Rows)
                {
                    list.Add(new Users(row["userId"].ToString(), row["password"].ToString(), row["fullName"].ToString(), row["address"].ToString(), row["phone"].ToString(), new Roles(row["roleName"].ToString())));
                }
                return list;
            }
            catch (System.Exception)
            {
            }
            return null;
        }




        public static Users getUserByIdAndPassword(string userName, string password)
        {
            Users user = new Users();
            try
            {
                SqlConnection conn = Connection.ConnectDB.connectDB();
                string statement = "select * from Users where userid = '" + userName + "' and [password] = '" + password + "'";
                SqlCommand cmd = new SqlCommand(statement, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string userId = dr["userId"].ToString();
                    string passwordd = dr["password"].ToString();
                    string fullName = dr["fullName"].ToString();
                    string address = dr["address"].ToString();
                    string phone = dr["phone"].ToString();
                    Roles roleId = new Roles(int.Parse(dr["roleId"].ToString()));
                    user = new Users(userId, passwordd, fullName, address, phone, roleId);
                }
                return user;
            }
            catch (Exception)
            {
            }
            return null;
        }

        public static bool register(Users user)
        {
            try
            {
                SqlConnection conn = Connection.ConnectDB.connectDB();
                string statement = "insert into Users values('" + user.UserID + "','" + user.Password + "','" + user.Fullname + "','" + user.Address + "','" + user.Phone + "'," + user.Role.RoleId + ")";
                SqlCommand cmd = new SqlCommand(statement, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception)
            {
            }
            return false;
        }


    }
}
