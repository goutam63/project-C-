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
    public class CLSBussLayer
    {
        CLSDataLayer objDAL = new CLSDataLayer();
        public void InseertUser(string name, string fathername, string mothername, string MobileNo, string address, string email, string password)
        {
            objDAL.InsertData(name, fathername,mothername,MobileNo,address,email,password);

        }
        public object SelectUser()
        {
            return objDAL.SelectData();
        }

    }
}
