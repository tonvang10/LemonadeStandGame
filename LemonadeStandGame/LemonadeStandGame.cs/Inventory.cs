using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame.cs
{
    class Inventory 
    {
        decimal money = 20.00M;
        public decimal lemonStock;
        public decimal sugarCubeStock;
        public decimal iceCubeStock;
        public decimal gallonOfWaterStock;
        public decimal cupStock;
        public decimal balanceOfMoney;
        public decimal remainingBalanceOfMoney;
  
        public Inventory()
        {
        }
        public decimal GetLemonStock()
        { 
            return lemonStock;
        }
        public void DisplaySupplies()
        {
            Console.WriteLine("You have {0} lemons.", lemonStock);
            Console.WriteLine("You have {0} sugar cubes.", sugarCubeStock);
            Console.WriteLine("You Have {0} ice cubes.", iceCubeStock);
            Console.WriteLine("You have {0} gallons of water.", gallonOfWaterStock);
            Console.WriteLine("You have {0} cups.", cupStock);
        }
        public decimal GetMoney()
        {
            return money;
        }
    }
}
