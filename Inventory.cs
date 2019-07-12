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
        public double Lemons { get; set; }
        public double IceCubes { get; set; }
        public double Sugar { get; set; }
        public double Cups { get; set; }

        public Inventory()
        {
            lemons = 0;
            iceCubes = 0;
            sugar = 0;
        }


        public void EndDayInventoryLoss()
        {
            iceCubes = 0;
            double roll = new Random().Next(0, 4);
            double inventoryLoss = new Random().Next(1, 3);
            if (roll == 0)
            {
                lemons = -inventoryLoss;
                sugar -= inventoryLoss;
            }
        }
    }
}
