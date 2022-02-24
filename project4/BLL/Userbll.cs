using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DAL;


namespace BLL
{
    public class Userbll
    {
        SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=project2;Integrated Security=True");

        public DataTable loginuser(Userdal da)
        {
            DataTable dt = new DataTable();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select Email,password from PRO2 where Email='"+da.UserName+"' and Password='"+da.Password+"'",conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt;
        }
    }
}
