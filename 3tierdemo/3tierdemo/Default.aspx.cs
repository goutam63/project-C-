using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace _3tierdemo
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            CLSBussLayer layer = new CLSBussLayer();
            layer.InseertUser(txtname.Text, txtcity.Text);

            GridView1.DataSource = layer.SelectUser();
            GridView1.DataBind();

        }
    }
}