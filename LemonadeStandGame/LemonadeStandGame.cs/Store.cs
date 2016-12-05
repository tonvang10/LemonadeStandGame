using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame.cs
{
    class Store : Inventory
    {
        decimal lemons = .25M;
        decimal sugarCubes = .05M;
        decimal iceCubes = .01M;
        decimal gallonsOfWater = 1.00M;
        decimal cups = .05M;
        decimal lemonsBought;
        decimal sugarCubesBought;
        decimal iceCubesBought;
        decimal gallonsOfWaterBought;
        decimal cupsBought;

        public Store()
        {

        }
        public void BuyLemons()
        {
            Console.WriteLine("How many lemons would you like to purchase?");
            decimal lemonsBought = decimal.Parse(Console.ReadLine());
            balanceOfMoney = GetMoney() - (lemonsBought * lemons);
            if (balanceOfMoney < 0)
            {
                Console.WriteLine("Oops, you don't have enough money.\n");
                BuyLemons();
            }
            Console.WriteLine("You have {0} left to spend.\n", balanceOfMoney);
        }
        public void BuySugarCubes()
        {
            Console.WriteLine("How many sugar cubes would you like to purchase?");
            decimal sugarCubesBought = decimal.Parse(Console.ReadLine());
            balanceOfMoney = balanceOfMoney - (sugarCubesBought * sugarCubes);
            if (balanceOfMoney < 0)
            {
                Console.WriteLine("Oops, you don't have enough money.\n");
                BuySugarCubes();
            }
            Console.WriteLine("You have {0} left to spend.\n", balanceOfMoney);
        }
        public void BuyIceCubes()
        {
            Console.WriteLine("How many ice cubes would you like to purcahse?");
            decimal iceCubesBought = decimal.Parse(Console.ReadLine());
            balanceOfMoney = balanceOfMoney - (iceCubesBought * iceCubes);
            if (balanceOfMoney < 0)
            {
                Console.WriteLine("Oops, you don't have enough money.\n");
                BuyIceCubes();
            }
            Console.WriteLine("You have {0} left to spend\n.", balanceOfMoney);
        }
        public void BuyGallonsOfWater()
        {
            Console.WriteLine("How many gallons of water would you like to purchase?");
            decimal gallonsOfWaterBought = decimal.Parse(Console.ReadLine());
            balanceOfMoney = balanceOfMoney - (gallonsOfWaterBought * gallonsOfWater);
            if (balanceOfMoney < 0)
            {
                Console.WriteLine("Oops, you don't have enough money.\n");
                BuyGallonsOfWater();
            }
            Console.WriteLine("You have {0} left to spend.\n", balanceOfMoney);
        }
        public void BuyCups()
        {
            Console.WriteLine("How many cups would you like to purchase?");
            decimal cupsBought = decimal.Parse(Console.ReadLine());
            remainingBalanceOfMoney = balanceOfMoney - (cupsBought * cups);
            if (balanceOfMoney < 0)
            {
                Console.WriteLine("Oops, you don't have enough money.\n");
                BuyCups();
            }
            Console.WriteLine("You have {0} left. Let's go make lemonade!\n", remainingBalanceOfMoney);
        }
        public void BuyIngridients()
        {
            int i = 0;
            while (i < 1)
            {
                BuyLemons();
                BuySugarCubes();
                BuyIceCubes();
                BuyGallonsOfWater();
                BuyCups();
                ++i;
            }
        }
        public void GoToStore()
        {
            Console.WriteLine("Let's go to the store.\n");
        }
        public void ShowStorePrices()
        {
            Console.WriteLine("Lemons cost .25 each.");
            Console.WriteLine("Sugar cubes cost .05 each cube.");
            Console.WriteLine("Ice cubes cost .01 each cube.");
            Console.WriteLine("A gallon of water costs 1.00 each.");
            Console.WriteLine("Cups cost .05 each.\n");
        }    

    }
}
