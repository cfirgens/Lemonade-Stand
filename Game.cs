using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Game
    {
        List<Customer> Customers = new List<Customer>();
        //Random rng;

        public void RunGame()
        {

            Weather weather = new Weather();
            Player player = new Player();

            weather.GetPredictedWeather();
            Console.WriteLine("Today's predicted weather is: " + weather.GetPredictedWeather());
            string actualWeather = weather.GetActualWeather();
            Console.WriteLine("Today's actual weather is: " + weather.GetActualWeather());

            Day day = new Day(actualWeather);

            Recipe recipe = new Recipe();

            Console.ReadLine();
            Customer customer = new Customer(rng);
            GetCustomers();
            Store store = new Store();
            store.GoShopping(player);
            // recipe.GetRecipe();

            //PurchaseLemonade(recipe.taste, weather.temperature, weather.weather, recipe.price, recipe.howMuchIce, customer.tastePreference, customer.weatherPreference, customer.pricePreference);

            Console.WriteLine("$" + player.Money);
            Console.WriteLine("ice " +  Inventory.iceCubes+ ", lemons " +  Inventory.lemons + ", sugar " + Inventory.sugar + ", cups " + Inventory.cups);
            Console.ReadLine();
        }


        public void GetCustomers()
        {
            Random rng = new Random();
            int numberOfCustomers;
            numberOfCustomers = rng.Next(75,110);

            for ( int i=0; i < numberOfCustomers; i++)
            {
                Customer customer = new Customer(rng);
                Customers.Add(customer);
            }

        }


        public void CustomerPurchase(int numberOfCustomers)
        {
            for (int i = 0; i < numberOfCustomers - 1; i++)
            {
                

            }         
                
                   

        }
    }
}
