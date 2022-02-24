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
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=project2;Integrated Security=True");
        public void InsertData(string name,string fathername,string mothername,string mobileno,string Address,string Email,string password)
        {
            SqlDataAdapter adp = new SqlDataAdapter("insert into project2 values('" + name + "','" + fathername + "','" + mothername + "','" + mobileno + "','" + Address + "','" + Email + "','" + password + "')", conn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
        }
        public object SelectData()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from project2", conn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
    }
}
