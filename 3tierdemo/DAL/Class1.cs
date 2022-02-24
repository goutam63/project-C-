using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class Class1
    {

    }
    public class CLSDataLayer
    {
        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=3tire;Integrated Security=True");
        public void InsertData(string name, string city)
        {
            SqlDataAdapter adp = new SqlDataAdapter("Insert into UserMst values('" + name + "','" + city + "')", con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
        }
        public object SelectData()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from UserMst",con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
    }
}
