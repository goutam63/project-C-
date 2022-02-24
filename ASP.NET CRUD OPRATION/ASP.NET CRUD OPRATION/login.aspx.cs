using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET_CRUD_OPRATION
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=UserRegister;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("CUser", conn);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("username", txtuser.Text);
            SqlParameter p2 = new SqlParameter("password", txtpassword.Text);
            sqlCommand.Parameters.Add(p1);
            sqlCommand.Parameters.Add(p2);
            conn.Open();
            SqlDataReader rd = sqlCommand.ExecuteReader();
        }
    }
}