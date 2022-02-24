using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cahracteraccessprojec
{
    public class Program
    {
        static void Main(string[] args)
        {
            studentinfoaccess std = new studentinfoaccess();
            /*var details = (from max in std.query()
                           select max.mark).Max();
            Console.WriteLine(details);
            Console.ReadLine();*/

            /*string username = Console.ReadLine();

            var name = from i in std.query()
                       where i.Name == username
                       select i.mark;
            
            foreach (var item in name)
                {
                    Console.WriteLine(item);
                }
                Console.ReadLine();*/

            studentinfoaccess std = new studentinfoaccess();
            var details_count = (from max in std.query()
                           select max.Name).Count();
            Console.WriteLine(details_count);
            Console.ReadLine();

            string stateName = Console.ReadLine();

            var name = from i in std.query()
                       where i.state == stateName
                       select new { i.Name, i.ID, i.mark, i.state, i.subject };
            // new employee() 

            foreach (var item in name)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
