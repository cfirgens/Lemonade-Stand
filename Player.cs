using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Player
    {
        double money;

        public double Money
        {
            get => money;

            set
            {
                if(value <= 0)
                {
                    money = 0;
                    Console.WriteLine("You can't go below 0 dollars");
                }
                else
                {
                    money = value;
                }
            }
        }


        public void PurchaseInventory()
        { }

    }
}
