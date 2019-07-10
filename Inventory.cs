using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Inventory
    {
        int lemons;
        int iceCubes;
        double money;
        int sugar;

        public Inventory()
        {
            lemons = 0;
            iceCubes = 0;
            money = 20.00;
            sugar = 0;
        }

        public void EndDayInventoryLoss()
        {
            iceCubes = 0;
            int roll = new Random().Next(0, 4);
            int inventoryLoss = new Random().Next(1, 5);
            if (roll == 0)
            {
                lemons = -inventoryLoss;
                sugar -= inventoryLoss;
            }
        }


        public void GetInventory(int boughtLemons, int boughtIceCubes, int boughtSugar, double spentMoney)
        {
            lemons += boughtLemons;
            iceCubes += boughtIceCubes;
            sugar += boughtSugar;
            money -= spentMoney;
        }
    }
}
