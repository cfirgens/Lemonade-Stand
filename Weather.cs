﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Weather
    {

        //Has
        public int temperature;
        public string weather;
        List<string> weatherList = new List<string>() { "Super Sunny", "Clear and Sunny", "Rainy", "Overcast", "Hazy", "Foggy"};
        int weatherNumber;


        //Constructor

        //Can do


        public string GetPredictedWeather()
        {
            weatherNumber = new Random().Next(1, 4);
            weather = (weatherList[weatherNumber]);           
            temperature = new Random().Next(50, 90);
            return ( weather + " " + temperature);
        }
        
        public string GetActualWeather()
        {
            List<int> tempAdjustList = new List<int>() { -10, -9, -8, -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int randomAdjust = new Random().Next(0, 21);
            int tempAdjust = (tempAdjustList[randomAdjust]);

            int weatherNumberAdjust = new Random().Next(-1, 1);
            int weatherAdjustNumber = (weatherNumber + weatherNumberAdjust);
            weather = (weatherList[weatherAdjustNumber]);

            return weather + " " + (temperature + tempAdjust);
        }

    }
}
