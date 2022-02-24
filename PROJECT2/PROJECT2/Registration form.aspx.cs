using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using BLL;

namespace PROJECT2
{

    public partial class Registration_form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnregister_Click(object sender, EventArgs e)
        {
            CLSBusLayer layer = new CLSBusLayer();
            layer.InsertUser(txtname.Text,txtfather.Text,txtmother.Text,txtmono.Text,txtadd.Text,txtemail.Text,txtpassw.Text);
            GridView1.DataSource = layer.SelectUser();
            GridView1.DataBind();

        }
    }
}