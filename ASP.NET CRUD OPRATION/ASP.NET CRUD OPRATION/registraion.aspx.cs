using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace ASP.NET_CRUD_OPRATION
{
    public partial class registraion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=UserRegister;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("strlogin", conn);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("username", txtusername.Text);
            SqlParameter p2 = new SqlParameter("password", txtpassword.Text);
            SqlParameter p3 = new SqlParameter("email", txtemail.Text);
            sqlCommand.Parameters.Add(p1);
            sqlCommand.Parameters.Add(p2);
            sqlCommand.Parameters.Add(p3);
            conn.Open();
            SqlDataReader rd = sqlCommand.ExecuteReader();
        }
    }
}