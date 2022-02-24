using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkAsg1
{
    public class maxnumber
    {
        public void GetgreaterthanZero()
        {



            //Specify the data source
            List<int> numbers = new List<int>() { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };



            //Define the query expression



            var greaterthanzero =
            from zero in numbers
            where zero > 3
            select zero;



            // Execute the query



            foreach (var number in greaterthanzero)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();



        }

    }
}
