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
        int temperature;
        string weather;

        //Constructor

        //Can do

        public string GetPredictedWeather()
        {
            List<string> weatherList = new List<string>() { "Clear and Sunny", "Rainy", "Overcast", "Hazy"};
            int weatherNumber = new Random().Next(0, 3);
            weather = (weatherList[weatherNumber]);           
            temperature = new Random().Next(65, 110);
            return ( weather + " " + temperature);
        }
        
        public string GetActualWeather()
        {
            List<int> tempAdjustList = new List<int>() { -10, -9, -8, -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int randomAdjust = new Random().Next(0, 21);
            int tempAdjust = (tempAdjustList[randomAdjust]);
            return weather + " " + (temperature + tempAdjust);
        }
    }
}
