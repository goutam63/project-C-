using gridform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gridform
{
    public partial class Defauld : System.Web.UI.Page
    {
        List<Employee> employees = new List<Employee>();
        protected void Page_Load(object sender, EventArgs e)
        {
            employees.Add(new Employee { Id=  1,Email  = "abc@gamil.com",Name = "Goutam",Gender = "Male"});
            employees.Add(new Employee { Id = 2, Email = "ac@gamil.com", Name = "Rathod", Gender = "Male" });
            employees.Add(new Employee { Id = 3, Email = "ad@gamil.com", Name = "abc", Gender = "Male" });
            employees.Add(new Employee { Id = 4, Email = "abc@gamil.com", Name = "xyz", Gender = "Male" });
            employees.Add(new Employee { Id = 5, Email = "abc@gamil.com", Name = "aaa", Gender = "Male" });

            gvemployee.DataSource = employees;
            gvemployee.DataBind();
        }
    }
}