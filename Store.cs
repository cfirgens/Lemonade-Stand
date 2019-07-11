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
        double totalCost;
        double cupPrice;
        int lemonQuantity;
        int sugarQuantity;
        int iceQuantity;
        int cupQuantity;

        public Store()
        {
            lemonPrice = 1.00;
            sugarPrice = 1.00;
            cupPrice = 1.00;
            iceCubePrice = 1.00;            
        }

        public void SellSugar()
        {
            Console.WriteLine("How many cups of sugar would you like to buy? Every single purchase is 12 cups of sugar and costs $1.00");
            try
            {
                int sugarInput = int.Parse(Console.ReadLine());
                double sugarCost = sugarInput * sugarPrice;
                lemonQuantity = sugarInput * 12;
                Console.WriteLine(sugarQuantity);
                Console.WriteLine(sugarCost);
                
            }
            catch
            {
                Console.WriteLine("Please enter a valid number");
                SellSugar();
            }
        }

        public void SellLemons()
        {
            Console.WriteLine("How many lemons would you like to buy? Every single purchase is 10 lemons and costs $1.00");
            try
            {
                int lemonInput = int.Parse(Console.ReadLine());
                double lemonCost = lemonInput * lemonPrice;
                lemonQuantity = lemonInput * 10;
                Console.WriteLine(lemonQuantity);
                Console.WriteLine(lemonCost);

            }
            catch
            {
                Console.WriteLine("Please enter a valid number");
                SellLemons();
            }
        }
        public void SellIce()
        {
            Console.WriteLine("How much ice would you like to buy? Every single purchase is 100 ice cubes and costs $1.00");
            try
            {
                int iceInput = int.Parse(Console.ReadLine());
                double iceCost = iceInput * icePrice;
                iceQuantity = iceInput * 100;
                Console.WriteLine(iceQuantity);
                Console.WriteLine(iceCost);

            }
            catch
            {
                Console.WriteLine("Please enter a valid number");
                SellIce();
            }
        }

        public void SellCups()
        {
            Console.WriteLine("How many cups would you like to buy? Every single purchase is 25 cups and costs $1.00");
            try
            {
                int cupsInput = int.Parse(Console.ReadLine());
                double cupCost = cupsInput * cupPrice;
                cupQuantity = cupsInput * 25;
                Console.WriteLine(cupQuantity);
                Console.WriteLine(cupCost);

            }
            catch
            {
                Console.WriteLine("Please enter a valid number");
                SellCups();
            }
        }


        public void GoShopping(double playerMoney)
        {
            Console.WriteLine("Welcome to the shop! Which item would you like to purchase first? Enter: Lemons, Sugar, Ice or Cups.");
            string itemSelecter = Console.ReadLine();

            if(itemSelecter == "lemons" || itemSelecter == "Lemons")
            {
                SellLemons();
            }
            else if (itemSelecter == "sugar" || itemSelecter == "Sugar")
            {
                SellSugar();
            }
            else if (itemSelecter == "ice" || itemSelecter == "Ice")
            {
                SellIce();
            }
            else if (itemSelecter == "cups" || itemSelecter == "Cups")
            {
                SellCups();
            }

        }


    }
}
