using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using DAL;
using BLL;

namespace project4
{

    public partial class display : System.Web.UI.Page
    {
        Userbll ba = new Userbll();
        Userdal da = new Userdal();
        DataTable dt = new DataTable();
        SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=project2;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from PRO2", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}