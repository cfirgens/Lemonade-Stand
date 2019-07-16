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

            List<int> temperature = new List<int>() { 50, 60, 70, 80, 90 };
            int temperatureRandom = rng.Next(0, 4);
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

         
        public void PurchaseLemonade(int temperature, string weather)
        {
            int purchaseOdds = 0;

            if (Inventory.lemons == 0 || Inventory.cups == 0 || Inventory.sugar == 0 || Inventory.iceCubes == 0)
            {
                Console.WriteLine("You're out of materials for the day.");
            }
            else
            {
                if (temperature > 80 && Recipe.howMuchIce > 6)
                {
                    purchaseOdds = +1;
                }
                if (tastePreference == Recipe.taste)
                {
                    purchaseOdds = +1;
                }
                if (weather == weatherPreference)
                {
                    purchaseOdds = +1;
                }
                if (Recipe.price < pricePreference)
                {
                    purchaseOdds = +1;
                }

                if (purchaseOdds == 3 || purchaseOdds == 4)
                {
                    BuyLemonade();

                    Console.WriteLine("Lemonade sold");
                }
                else if (purchaseOdds == 2)
                {
                    int roll = new Random().Next(0, 1);
                    if (roll == 0)
                    {
                        BuyLemonade();
                        Console.WriteLine("Lemonade sold");
                    }

                }
                else if (purchaseOdds == 1)
                {
                    int roll = new Random().Next(0, 3);
                    if (roll == 0)
                    {
                        BuyLemonade();

                        Console.WriteLine("Lemonade sold");
                    }
                }
            }

        }


        public void BuyLemonade()
        {

            Inventory.cups = (Inventory.cups - 1);
            Inventory.lemons = (Inventory.lemons - Recipe.howManyLemons);
            Inventory.iceCubes = (Inventory.iceCubes - Recipe.howMuchIce);
            Inventory.sugar = (Inventory.sugar - Recipe.howMuchSugar);
            Player.startingMoney = (Player.startingMoney + Recipe.price);
            Player.money = (Player.money + Recipe.price);
        }
    }
}
