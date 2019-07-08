using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Game
    {

        public void RunGame()
        {
            Weather weather = new Weather();

            weather.CombinedWeather();

            Console.ReadLine();
            weather.CombinedWeather();

            Console.ReadLine();
            weather.CombinedWeather();

            Console.ReadLine();
            weather.CombinedWeather();
            weather.CombinedWeather();

            Console.ReadLine();
        }
    }
}
