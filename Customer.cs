using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Customer
    {
        //Has a

        public string weatherPreference;
        public string tastePreference;
        public int icePreference;
        public int temperaturePreference;
        public double pricePreference;
        public string customerName;



        //Constructor
        public Customer(Random rng)
        {
            List<string> names = new List<string>() { "Henry", "Frank", "Gary", "Bobby", "Chris", "Will", "Joe", "A-aron" };
            int nameRandom = rng.Next(0, 7);
            customerName = names[nameRandom];

            List<string> taste = new List<string>() {"sweet", "tart", "normal"};
            int tasteRandom = rng.Next(0, 2);
            tastePreference = taste[tasteRandom];

            List<int> temperature = new List<int>() { 60, 70, 80, 90 };
            int temperatureRandom = rng.Next(0, 3);
            temperaturePreference = temperature[temperatureRandom];

            List<int> ice = new List<int>() { 3, 4, 5, 6, 7, 8 };
            int iceRandom = rng.Next(0, 5);
            icePreference = ice[iceRandom];

            List<string> weather = new List<string>() { "clear and sunny", "rainy", "overcast", "hazy" };
            int weatherRandom = rng.Next(0, 3);
            weatherPreference = weather[weatherRandom];

            List<double> price = new List<double>() { .50, .75, .85, 1, 1.25, 1.50 };
            int priceRandom = rng.Next(0, 5);
            pricePreference = price[priceRandom];
        }


        //Can do

       // public bool PurchaseLemonade(double price, string taste, int temperature, string weather, int iceCount);
       
    }
}
