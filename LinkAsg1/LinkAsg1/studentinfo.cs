using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkAsg1
{
    public class studentinfo
    {

        public List<studentgetbydetails> query()
        {
            List<studentgetbydetails> e = new List<studentgetbydetails>();
            {
                new studentgetbydetails { ID = 1, Name = "goutam", mark = 65, subject = "i", state = "wt" };
                new studentgetbydetails { ID = 2, Name = "rathod", mark = 70, subject = "x", state = "xy" };
                new studentgetbydetails { ID = 3, Name = "ravi", mark = 78, subject = "y", state = "yz" };
                new studentgetbydetails { ID = 4, Name = "rahul", mark = 63, subject = "z", state = "za" };
                new studentgetbydetails { ID = 5, Name = "abhishek", mark = 65, subject = "w", state = "zb" };
                new studentgetbydetails { ID = 6, Name = "priyanka", mark = 68, subject = "h", state = "zc" };
                new studentgetbydetails { ID = 7, Name = "priyanka.N", mark = 90, subject = "j", state = "zd" };
            };
            return e;
        }


    }
}
