using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cahracteraccessprojec
{
    public class studentinfoaccess
    {
        public List<studentvariableinput> query()
        {
            List<studentvariableinput> e = new List<studentvariableinput>()
            {
                new studentvariableinput { ID = 1, Name = "goutam", mark = 65, subject = "i", state = "karanataka",},
                new studentvariableinput { ID = 2, Name = "rathod", mark = 70, subject = "x", state = "maharastra" },
                new studentvariableinput { ID = 3, Name = "ravi", mark = 78, subject = "y", state = "andrapradesh" },
                new studentvariableinput { ID = 4, Name = "rahul", mark = 63, subject = "z", state = "uttarpradesh" },
                new studentvariableinput { ID = 5, Name = "abhishek", mark = 65, subject = "w", state = "keral" },
                new studentvariableinput { ID = 6, Name = "priyanka", mark = 68, subject = "h", state = "tamilnadu" },
                new studentvariableinput { ID = 7, Name = "priyanka.N", mark = 90, subject = "j", state = "goa" },
            };
            return e;
        }
    }
}
