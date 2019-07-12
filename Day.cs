using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Day
    {
   
        int todayCustomer;

        public Day(string weather)
        {            
            Console.WriteLine("Today's weather is " + weather + " predicted number of customers are: " + todayCustomer);
        }
    }
}
