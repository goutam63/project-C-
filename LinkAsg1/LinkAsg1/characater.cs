using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkAsg1
{
    public class characater
    {
        public void singlecharacter()
        {
            // soruce data 
            List<string> character = new List<string>() { "carrots", "cabbage", "broccoli", "beans", "barley" };

            // writeing the query
            var single = from i in character 
                        select i;

            // Execute the query
            foreach (var Char in single)
            {
                
                if (Char.StartsWith("c"))
                {
                   Console.WriteLine(Char);
                }
            }
            Console.ReadLine();
        }

    }
}
