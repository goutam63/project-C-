using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkAsg1
{
    public class infoaccess
    {
          public void info()
          {

                studentinfo std = new studentinfo();
                //specipy the data source
                var information = std.query();

                //define the query expression 
                var data = from student in information
                           where student.mark>60
                           select student.Name;
                //Execute the query 
                foreach (var item in data)
                {
                    Console.WriteLine(item);
                }
                Console.ReadKey();

          }
    }
 }
