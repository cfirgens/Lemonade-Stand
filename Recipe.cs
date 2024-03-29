﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Recipe
    {
        static public double price = .50;
        static public int howManyLemons = 4;
        static public int howMuchSugar = 4;
        static public int howMuchIce = 4;
        static public string taste;

        public int HowManyLemons { get; set; }
        public int HowMuchIce { get; set; }
        public int HowMuchSugar { get; set; }
        public string Taste { get; set; }
        public double Price { get; set; }


        public Recipe()
        {
            GetRecipe();
        }

        public double GetPrice()
        {
            Console.WriteLine("\nHow much would you like to charge? Default price is $0.50");
            try
            {
                return price = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please enter a valid number");
                return GetPrice();
            }
            
        }
        public int GetLemons()
        {
            Console.WriteLine("How many lemons would you like to add? The default value is 4");
            try
            {
                return howManyLemons = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please enter a valid number");
                return GetLemons();
            }
        }
        public int GetSugar()
        {
            Console.WriteLine("How many cups of sugar would you like to add? The default value is 4");
            try
            {
                return howMuchSugar = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please enter a valid number");
                return GetSugar();
            }
        }

        public int GetIce()
        {
            Console.WriteLine("How much ice would you like to add? The default value is 4");
            try
            {
               return howMuchIce = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please enter a valid number");
                return GetIce();
            }
        }

        public string GetTaste()
        {
            if (howManyLemons > howMuchSugar)
            {
                return taste = "Sour";
            }
            else if (howMuchSugar > howManyLemons)
            {
                return taste = "Sweet";
            }
            else
            {
                return taste = "normal";
            }
        }
        public void GetRecipe()
        {
            GetPrice();
            GetIce();
            GetLemons();
            GetSugar();
            GetTaste();
        }
    }
}
