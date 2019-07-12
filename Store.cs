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
        double iceCubePrice;
        double cupPrice;
        int lemonQuantity;
        int sugarQuantity;
        int iceQuantity;
        int cupQuantity;
        double cost;
        double lemonCost;
        double sugarCost;
        double iceCost;
        double cupCost;

        public Store()
        {
            lemonPrice = 1.00;
            sugarPrice = 1.00;
            cupPrice = 1.00;
            iceCubePrice = 1.00;
            lemonCost = 0;
            sugarCost = 0;
            iceCost = 0;
            cupCost = 0;
        }

        public int SellSugarQuantity()
        {
            Console.WriteLine("How many bags of sugar would you like to buy? Every bag contains 12 cups of sugar and costs $1.00");
            try
            {
                int sugarInput = int.Parse(Console.ReadLine());
                //double sugarCost = sugarInput * sugarPrice;
                sugarQuantity = sugarInput * 12;
                return sugarQuantity;

                
            }
            catch
            {
                Console.WriteLine("Please enter a valid number");
                return SellSugarQuantity();
            }
        }

        public int SellLemonsQuantity()
        {
            Console.WriteLine("How many bags of lemons would you like to buy? Every bag contains 10 lemons and costs $1.00");
            try
            {
                int lemonInput = int.Parse(Console.ReadLine());
                //double lemonCost = lemonInput * lemonPrice;
                lemonQuantity = lemonInput * 10;
                return lemonQuantity;
            }
            catch
            {
                Console.WriteLine("Please enter a valid number");
                return SellLemonsQuantity();
            }
        }
        public int SellIceQuantity()
        {
            Console.WriteLine("How many bags of ice would you like to buy? Every bag contains 100 ice cubes and costs $1.00");
            try
            {
                int iceInput = int.Parse(Console.ReadLine());
                //double iceCost = iceInput * icePrice;
                iceQuantity = iceInput * 100;
                return iceQuantity;

            }
            catch
            {
                Console.WriteLine("Please enter a valid number");
                return SellIceQuantity();
            }
        }

        public int SellCupsQuantity()
        {
            Console.WriteLine("How many boxes of cups would you like to buy? Every box contains 25 cups and costs $1.00");
            try
            {
                int cupsInput = int.Parse(Console.ReadLine());
                //double cupCost = cupsInput * cupPrice;
                cupQuantity = cupsInput * 25;
                return cupQuantity;


            }
            catch
            {
                Console.WriteLine("Please enter a valid number");
                return SellCupsQuantity();
            }
        }


        public void GoShopping(double playerMoney)
        {
            bool loop;
            loop = false;
            Console.WriteLine("Welcome to the shop!");

            while (loop == false)
            {
                Console.WriteLine("Which item would you like to purchase? Enter : Lemons, Sugar, Ice or Cups.Or type quit to exit");     
                
                string itemSelecter = Console.ReadLine();

                if (itemSelecter == "lemons" || itemSelecter == "Lemons")
                {
                    double lemonQuantity = SellLemonsQuantity();
                    lemonCost = (lemonQuantity / 10) * lemonPrice;

                }
                else if (itemSelecter == "sugar" || itemSelecter == "Sugar")
                {
                    double sugarQunatity = SellSugarQuantity();
                    sugarCost = (sugarQunatity / 12) * sugarPrice;
                }
                else if (itemSelecter == "ice" || itemSelecter == "Ice")
                {
                    double iceQuantity = SellIceQuantity();
                    iceCost = (iceQuantity / 100) * iceCubePrice;
                }
                else if (itemSelecter == "cups" || itemSelecter == "Cups")
                {
                    double cupQuantity = SellCupsQuantity();
                    cupCost = (cupQuantity / 25) * cupPrice;
                }
                else if (itemSelecter == "quit" || itemSelecter == "Quit")
                {
                    loop = !loop;
                }
                else
                {
                    Console.WriteLine("Did not recognize that input");
                    GoShopping(playerMoney);
                }
            }
        

        }


        public double  AddCost()
        {
            cost = cupCost + iceCost + lemonCost + sugarCost;
            return cost;
        }


    }
}
