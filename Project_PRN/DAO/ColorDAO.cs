using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PRN
{
    class ColorDAO
    {
        public List<Colors> getAllColor()
        {
            List<Colors> list = new List<Colors>();
            try
            {
                SqlConnection conn = Connection.ConnectDB.connectDB();
                string statement = "select * from Colors";
                SqlDataAdapter dap = new SqlDataAdapter(statement, conn);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                conn.Close();
                foreach (DataRow row in dt.Rows)
                {
                    int ColorId = int.Parse(row["colorId"].ToString());
                    string ColorsName = row["colorName"].ToString();
                    Colors color = new Colors(ColorId, ColorsName);
                    list.Add(color);
                }
                return list;
            }
            catch (System.Exception)
            {
            }
            return null;
        }

        public Colors searchColorById(int id)
        {
            Colors Color = new Colors();
            try
            {
                SqlConnection conn = Connection.ConnectDB.connectDB();
                string statement = "select * from Colors where colorId = " + id + "";
                SqlCommand cmd = new SqlCommand(statement, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int colorId = int.Parse(dr["colorId"].ToString());
                    string colorName = dr["colorName"].ToString();
                    Color = new Colors(colorId, colorName);
                }
                return Color;
            }
            catch (Exception)
            {
            }
            return null;
        }

        public bool updateColor(Colors color)
        {
            try
            {
                SqlConnection conn = Connection.ConnectDB.connectDB();
                string statement = "update Colors set colorName = '" + color.ColorName + "' where colorId = " + color.ColorId;
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

        public bool addColor(Colors Color)
        {
            try
            {
                SqlConnection conn = Connection.ConnectDB.connectDB();
                string statement = "insert into Colors values('" + Color.ColorName + "')";
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

        public bool deleteColorById(int id)
        {
            try
            {
                SqlConnection conn = Connection.ConnectDB.connectDB();
                string statement = "delete from colors where colorId = " + id;
                SqlCommand cmd = new SqlCommand(statement, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (System.Exception)
            {
            }
            return false;
        }
    }
}


