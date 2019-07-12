using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Store
    {
        double lemonPrice;
        double sugarPrice;
        double icePrice;
        double cupPrice;
        double lemonQuantity;
        double sugarQuantity;
        double iceQuantity;
        double cupQuantity;
        double lemonPackage;
        double icePackage;
        double cupPackage;
        double sugarPackage;

        public Store()
        {
            lemonPrice = 1.00;
            sugarPrice = 1.00;
            cupPrice = 1.00;
            icePrice = 1.00;
            lemonPackage = 10;
            icePackage = 100;
            cupPackage = 25;
            sugarPackage = 12;
        }
                
        public double SellSugarQuantity()
        {
            Console.WriteLine("How many bags of sugar would you like to buy? Every bag contains 12 cups of sugar and costs $1.00");
            try
            {
                double sugarInput = double.Parse(Console.ReadLine());
                sugarQuantity = sugarInput * sugarPackage;
                Inventory.sugar = sugarQuantity;
                return sugarQuantity;                
            }
            catch
            {
                Console.WriteLine("Please enter a valid number");
                return SellSugarQuantity();
            }
        }

        public double SellLemonsQuantity()
        {
            Console.WriteLine("How many bags of lemons would you like to buy? Every bag contains 10 lemons and costs $1.00");
            try
            {
                double lemonInput = double.Parse(Console.ReadLine());
                lemonQuantity = lemonInput * lemonPackage;
                Inventory.lemons = lemonQuantity;
                return lemonQuantity;
            }
            catch
            {
                Console.WriteLine("Please enter a valid number");
                return SellLemonsQuantity();
            }
        }
        public double SellIceQuantity()
        {
            Console.WriteLine("How many bags of ice would you like to buy? Every bag contains 100 ice cubes and costs $1.00");
            try
            {
                double iceInput = double.Parse(Console.ReadLine());
                iceQuantity = iceInput * icePackage;
                Inventory.iceCubes = iceQuantity;
                return iceQuantity;
            }
            catch
            {
                Console.WriteLine("Please enter a valid number");
                return SellIceQuantity();
            }
        }

        public double SellCupsQuantity()
        {
            Console.WriteLine("How many boxes of cups would you like to buy? Every box contains 25 cups and costs $1.00");
            try
            {
                double cupsInput = double.Parse(Console.ReadLine());
                cupQuantity = cupsInput * cupPackage;
                Inventory.cups = cupQuantity;
                return cupQuantity;
            }
            catch
            {
                Console.WriteLine("Please enter a valid number");
                return SellCupsQuantity();
            }
        }

        public double SellIngrediant(Func<double> ingrediantQuantity, double package, double price)
        {
            double quantity = ingrediantQuantity();
            double resultCost = (quantity / package) * price;
            return resultCost;
        }
        public void GoShopping(Player player)
        {
            bool loop;
            loop = false;
            Console.WriteLine("Welcome to the shop!");

            while (loop == false)
            {
                Console.WriteLine("Which item would you like to purchase? Enter : Lemons, Sugar, Ice or Cups. Or type quit to exit");     
                
                string itemSelecter = Console.ReadLine();

                if (itemSelecter == "lemons" || itemSelecter == "Lemons")
                {
                    player.Money -= SellIngrediant(SellLemonsQuantity, lemonPackage, lemonPrice);
                    Console.WriteLine("You have " + player.Money + " dollars left.\n");

                }
                else if (itemSelecter == "sugar" || itemSelecter == "Sugar")
                {
                    player.Money -= SellIngrediant(SellSugarQuantity, sugarPackage, sugarPrice);
                    Console.WriteLine("You have " + player.Money + " dollars left.\n");
                }
                else if (itemSelecter == "ice" || itemSelecter == "Ice")
                {
                    player.Money -= SellIngrediant(SellIceQuantity, icePackage, icePrice);
                    Console.WriteLine("You have " + player.Money + " dollars left.\n");
                }
                else if (itemSelecter == "cups" || itemSelecter == "Cups")
                {
                    player.Money -= SellIngrediant(SellCupsQuantity, cupPackage, cupPrice);
                    Console.WriteLine("You have " + player.Money + " dollars left.\n");
                }
                else if (itemSelecter == "quit" || itemSelecter == "Quit")
                {
                    loop = !loop;
                }
                else
                {
                    Console.WriteLine("Did not recognize that input \n");
                    GoShopping(player);
                }
            }      

        }
               
    }
}
