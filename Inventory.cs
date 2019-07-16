using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Inventory
    {
        static public double lemons;
        static public double iceCubes;
        static public double sugar;
        static public double cups;
        public double Lemons
        {
            get => lemons;

            set
            {
                if(value <= 0)
                {
                    lemons = 0;
                    Console.WriteLine("You've sold out of lemons!");
                }
                else { lemons = value; }
            }
        }
        public double IceCubes
        {
            get => iceCubes;

            set
            {
                if (value <= 0)
                {
                    iceCubes = 0;
                    Console.WriteLine("You've ran out of ice cubes!");
                }
                else { iceCubes = value; }
            }
        }
        public double Sugar
        {
            get => sugar;

            set
            {
                if (value <= 0)
                {
                    sugar = 0;
                    Console.WriteLine("You've sold out of sugar!");
                }
                else { sugar = value; }
            }
        }
        public double Cups
        {
            get => cups;

            set
            {
                if (value <= 0)
                {
                    cups = 0;
                    Console.WriteLine("You've ran out of cups!");
                }
                else { cups = value; }
            }
        }

        public Inventory()
        {
            lemons = 0;
            iceCubes = 0;
            sugar = 0;
        }

        public static void DisplayInventory()
        {

            Console.WriteLine("Your current inventory is as follows: Ice: " + Inventory.iceCubes + ", Lemons: " + Inventory.lemons + ", Sugar: " + Inventory.sugar + ", Cups: " + Inventory.cups);
        }
                      
    }
}
