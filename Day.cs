using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Day
    {
        List<Customer> Customers = new List<Customer>();        

        public Day(Player player)
        {

            Weather weather = new Weather();
            weather.GetPredictedWeather();
            Console.WriteLine("\nToday's predicted weather is: " + weather.GetPredictedWeather());
            string actualWeather = weather.GetActualWeather();  

           
            Store store = new Store();
            store.GoShopping();
            Inventory.DisplayInventory();

            Console.WriteLine("\nToday's actual weather is: " + weather.GetActualWeather());
            Recipe recipe = new Recipe();
            
            GetCustomers();

            foreach (Customer item in Customers)
                item.PurchaseLemonade(weather.temperature, weather.weather);

            Inventory.DisplayInventory();
            Console.WriteLine(Player.money);


            EndDayInventoryLoss();

            EndOfDayStats();
                       
        }

        // Singularity responsibility - Generating customers and adding them into a list.
        public void GetCustomers()
        {
            Random rng = new Random();
            int numberOfCustomers;
            numberOfCustomers = rng.Next(75, 110);

            for (int i = 0; i < numberOfCustomers; i++)
            {
                Customer customer = new Customer(rng);
                Customers.Add(customer);
            }
        }

        public void EndDayInventoryLoss()
        {
            Inventory.iceCubes = 0;
            double roll = new Random().Next(0, 4);
            double inventoryLoss = new Random().Next(1, 3);
            if (roll == 0)
            {
                Inventory.lemons =- inventoryLoss;
                Inventory.sugar =- inventoryLoss;
            }
        }


        public void EndOfDayStats()
        {
            double endOfDay;          
            endOfDay = Player.startingMoney - Player.startingTwenty;
            Console.WriteLine("You made $" + Player.startingMoney + " today. and have made a total of $" + endOfDay);
        }
    }
}
