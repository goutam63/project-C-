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
    public partial class home : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=project2;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                BindGrid();
            }
        }

        protected void btnregister_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=project2;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[PRO2]
           ([Name]
           ,[FatherName]
           ,[MobileNo]
           ,[MotherName]
           ,[Address]
           ,[Email]
           ,[password])
     VALUES
           ('" + txtname.Text + "','" + txtfname.Text + "','" + txtmono.Text + "','" + txtmname.Text + "','" + txtaddress.Text + "','" + txtemail.Text + "','" + txtpassword.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("<script>alert('User Register Successfully')</script>");
        }

        void BindGrid()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from PRO2", conn);
            SqlDataAdapter sqlda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        
    }
}