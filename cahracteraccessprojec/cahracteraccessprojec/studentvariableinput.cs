using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cahracteraccessprojec
{
    public class  studentvariableinput:IEnumerable
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int mark { get; set; }

        public string subject { get; set; }

        public string state { get; set; }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
