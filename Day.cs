using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Day
    {
        string todayWeather;
        int todayCustomer;

        public Day(string weather, int temperature, int customers)
        {
            todayWeather = weather + temperature;
            todayCustomer = customers;


        }
    }
}
