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
    class OrderDAO
    {
        public List<Orders> getAllOrder()
        {
            List<Orders> list = new List<Orders>();
            try
            {
                SqlConnection conn = Connection.ConnectDB.connectDB();
                string statement = "select * from orders";
                SqlDataAdapter dap = new SqlDataAdapter(statement, conn);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                conn.Close();
                foreach (DataRow row in dt.Rows)
                {
                    int orderId = int.Parse(row["orderId"].ToString());
                    string userid = row["userId"].ToString();
                    DateTime dateCreated = DateTime.Parse(row["dateCreated"].ToString());
                    bool status = false;
                    if (row["status"].ToString().Equals("1"))
                    {
                        status = true;
                    }
                    else
                    {
                        status = false;
                    }
                    float totalPrice = float.Parse(row["totalPrice"].ToString());

                    Orders order = new Orders(orderId, new Users(userid), dateCreated, status, totalPrice);
                    list.Add(order);
                }
                return list;
            }
            catch (System.Exception)
            {
            }
            return null;
        }
    }
}
