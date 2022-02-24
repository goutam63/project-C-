using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace project1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=project1;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                gvbine();
            }
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            SqlCommand Cmd = new SqlCommand(@"INSERT INTO [dbo].[Coustomer]
           ([CoustomerName]
           ,[Address]
           ,[MobileNo]
           ,[Emailid])
     VALUES
           ('"+txtname.Text+"','"+txtAddress.Text+"','"+txtmobile.Text+"','"+txtemail.Text+"')", con);
            con.Open();
            Cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("<script>alert('Data has been Submitted Successfully')</script>");
            gvbine();
        }

        protected void btnreset_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            txtname.Text = "";
            txtAddress.Text = "";
            txtemail.Text = "";
            txtmobile.Text = "";
        }
        protected void gvbine()
        {
            con.Open();
            SqlCommand Cmd = new SqlCommand("select * from Coustomer",con);
            SqlDataReader dr = Cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                GridView1.DataSource = dr;
                GridView1.DataBind();
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            gvbine();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            string name = ((TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0]).Text;
            string add = ((TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).Text;
            string mobno = ((TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0]).Text;
            string email = ((TextBox)GridView1.Rows[e.RowIndex].Cells[4].Controls[0]).Text;
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=project1;Integrated Security=True");
            con.Open();
            SqlCommand sqlCmd = new SqlCommand("update Coustomer set CoustomerName='" + name + "',Address='" + add + "',MobileNo='" + mobno + "',Emailid='" + email + "' where Cid='" + id + "'", con);
            int t = sqlCmd.ExecuteNonQuery();
            if (t > 0)
            {
                Response.Write("<script>alert('Data Updated Successfully')</script>");
                GridView1.EditIndex = -1;
                gvbine();
            }

        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            gvbine();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=project1;Integrated Security=True");
            con.Open();
            SqlCommand sqlCmd = new SqlCommand("delete from Coustomer where Cid='"+id+"'", con);
            int t =sqlCmd.ExecuteNonQuery();
            if (t > 0)
            {
                Response.Write("<script>alert('Data Deleted Successfull')</script>");
                GridView1.EditIndex = -1;
                gvbine();
            }
        }
    }
}