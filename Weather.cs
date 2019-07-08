using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Weather
    {

        //Has

        //Constructor

        //Can do

        public string GetWeather()
        {
            List<string> weather = new List<string>() { "Clear and Sunny", "Rainy", "Overcast", "Hazy"};
            int weatherNumber = new Random().Next(0, 3);
            string weatherToday = (weather[weatherNumber]);
            return weatherToday;
        }
        
        public int GetTemperature()
        {
            int temperature = new Random().Next(65, 110);
            return temperature;
        }

        public void CombinedWeather()
        {
            string CombinedWeather = (GetTemperature() + " and " + GetWeather());
            Console.WriteLine("Today's weather is " + CombinedWeather);

        }
    }
}
