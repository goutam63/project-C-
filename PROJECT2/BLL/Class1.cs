using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Class1
    {
    }
    public class CLSBusLayer
    {
        CLSDataLayer objDAL = new CLSDataLayer();
        public void InsertUser(string name, string fathername, string mothername, string mobileno, string Address, string Email, string password)
        {
            objDAL.InsertData(name, fathername,mothername,mobileno,Address,Email,password);

        }
        public object SelectUser()
        {
            return objDAL.SelectData();
        }

    }
}
