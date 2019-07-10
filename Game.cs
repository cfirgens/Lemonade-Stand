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
        public void RunGame()
        {
            Weather weather = new Weather();

            weather.CombinedWeather();

            Recipe recipe = new Recipe();

            //recipe.GetRecipe();

            GetCustomers();            

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
    }
}
