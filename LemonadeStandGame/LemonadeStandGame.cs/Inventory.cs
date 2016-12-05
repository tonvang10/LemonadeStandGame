using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame.cs
{
    class Inventory : Recipe
    {
        public decimal balanceOfMoney;
        public decimal remainingBalanceOfMoney;
        decimal lemonsBought;
        decimal money = 20.00M;

        public Inventory()
        {

        }
        public void DisplayLemons()
        {
            Console.WriteLine("\nYou have {0} lemons. How many do you want to use?", lemonsBought);
            Console.ReadLine();
        }
        public decimal GetMoney()
        {
            return money;
        }
    }
}
