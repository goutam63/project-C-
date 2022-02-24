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
        public void InseertUser(string name,string city)
        {
            objDAL.InsertData(name, city);

        }
        public object SelectUser()
        {
            return objDAL.SelectData();
        }

        }
    }
