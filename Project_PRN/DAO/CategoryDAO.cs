using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PRN
{
    class CategoryDAO
    {
        public List<Categories> getAllCategory()
        {
            List<Categories> list = new List<Categories>();
            try
            {
                SqlConnection conn = Connection.ConnectDB.connectDB();
                string statement = "select * from Categories";
                SqlDataAdapter dap = new SqlDataAdapter(statement, conn);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                conn.Close();
                foreach (DataRow row in dt.Rows)
                {
                    string categoryId = row["categoryId"].ToString();
                    string categoryName = row["categoryName"].ToString();
                    Categories categorys = new Categories(categoryId, categoryName);
                    list.Add(categorys);
                }
                return list;
            }
            catch (System.Exception)
            {
            }
            return null;
        }

        public Categories searchCategoryById(string id)
        {
            Categories Categories = new Categories();
            try
            {
                SqlConnection conn = Connection.ConnectDB.connectDB();
                string statement = "select * from Categories where categoryId = '" + id + "'";
                SqlCommand cmd = new SqlCommand(statement, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string categoryId = dr["categoryId"].ToString();
                    string categoryName = dr["categoryName"].ToString();
                    Categories = new Categories(categoryId, categoryName);
                }
                return Categories;
            }
            catch (Exception)
            {
            }
            return null;
        }

        public bool updateCategory(Categories cate)
        {
            try
            {
                SqlConnection conn = Connection.ConnectDB.connectDB();
                string statement = "update categories set categoryName = '" + cate.CategoryName + "' where categoryId = '" + cate.CategoryId + "'";
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

        public bool addCategory(Categories cate)
        {
            try
            {
                SqlConnection conn = Connection.ConnectDB.connectDB();
                string statement = "insert into categories values('" + cate.CategoryId + "','" + cate.CategoryName + "')";
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

        public bool deleteCategoryById(string id)
        {
            try
            {
                SqlConnection conn = Connection.ConnectDB.connectDB();
                string statement = "delete from categories where categoryId = '" + id + "'";
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
