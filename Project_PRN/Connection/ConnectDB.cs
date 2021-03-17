using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PRN.Connection
{
    class ConnectDB
    {
       public static SqlConnection connectDB()
       {
            String connetionString;
            SqlConnection con;
            connetionString = @"Data Source=TBLONG;Initial Catalog=Clothes;User ID=sa;Password=123456";
            con = new SqlConnection(connetionString);
            con.Open();
            return con;
        }
    }
}
