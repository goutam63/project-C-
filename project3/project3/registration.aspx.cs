using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace project3
{
    public partial class registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnregister_Click(object sender, EventArgs e)
        {

            CLSBussLayer layer = new CLSBussLayer();
            layer.InseertUser(txtname.Text, txtfather.Text,txtmother.Text,txtmono.Text,txtadd.Text,txtemail.Text,txtpassw.Text);

            GridView1.DataSource = layer.SelectUser();
            GridView1.DataBind();
        }
    }
}