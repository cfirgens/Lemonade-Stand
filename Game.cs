﻿using System;
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

            weather.GetPredictedWeather();
            Console.WriteLine("Today's predicted weather is: " + weather.GetPredictedWeather());
            weather.GetActualWeather();
            Console.WriteLine("Today's actual weather is: " + weather.GetActualWeather());

            Recipe recipe = new Recipe();

            Console.ReadLine();

            //recipe.GetRecipe();

            GetCustomers();
            Store store = new Store();

            store.SellLemons();


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
    }
}
