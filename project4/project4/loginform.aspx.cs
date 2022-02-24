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
    public partial class loginform : System.Web.UI.Page
    {
        Userbll ba = new Userbll();
        Userdal da = new Userdal();
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            da.UserName = txtusername.Text;
            da.Password = txtpassword.Text;
            dt = ba.loginuser(da);
            if(dt.Rows.Count > 0)
            {
                Response.Redirect("display.aspx");
            }
            else
            {
                Response.Write("<script>alert('invalid username or password')</script>");
            }
        }
        public string display()
        {
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=project2;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM PRO2 WHERE Email = '" + txtusername.Text + "', Password = '" + txtpassword.Text + "'");
            cmd.ExecuteNonQuery();
            con.Close();

        }
    }
}