using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
namespace WebApplication3
{
    public partial class WebForm : System.Web.UI.Page
    {
        SqlConnection myConnection = new
            SqlConnection(ConfigurationManager.ConnectionStrings["UserRegisterConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            {
                SqlConnection con = new SqlConnection("Data Source = LAPTOP-TSJ1TKE4;Initial Catalog = 
                string query = "select * from userreg";

                SqlCommand insertCommond = new SqlCommand(@"INSERT INTO [dbo].[userreg]
           ([name]
           ,[address]
           ,[gender]
           ,[phone]
           ,[email]
           ,[username]
           ,[password])
     VALUES
           ("+txtname.Text+","+txtAddress.Text+","+gender+","+txtphone.Text+","+txtemail.Text+","+txtUser.Text+","+txtpassword+")");
                insertCommond.Parameters.AddWithValue("@Full name",);
            }
        }
    }
}