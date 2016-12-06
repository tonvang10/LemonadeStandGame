using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame.cs
{
    class Store
    {
        public Money money;
        decimal lemonCost = .25M;
        decimal sugarCubeCost = .05M;
        decimal iceCubeCost = .01M;
        decimal gallonOfWaterCost = 1.00M;
        decimal cupCost = .05M;
        public decimal lemonPurchased;
        public decimal sugarCubePurchased;
        public decimal iceCubePurchased;
        public decimal gallonOfWaterPurchased;
        public decimal cupPurchased;
        public decimal balanceOfMoney;
        public decimal remainingBalanceOfMoney;

        public Store()
        {
            money = new Money();
        }
        public decimal GetCups()
        {
            return cupPurchased;
        }
        public decimal GetGallonsOfWater()
        {
            return gallonOfWaterPurchased;
        }
        public decimal GetIceCubes()
        {
            return iceCubePurchased;
        }
        public decimal GetSugarCubes()
        {
            return sugarCubePurchased;
        }
        public decimal GetLemons()
        {
            return lemonPurchased;
        }
        public decimal GetBalanceOfMoney()
        {
            return remainingBalanceOfMoney;
        }
        public decimal BuyLemons()
        {
            Console.WriteLine("How many lemons would you like to purchase?");
            lemonPurchased = decimal.Parse(Console.ReadLine());
            balanceOfMoney = money.GetMoney() - (lemonPurchased * lemonCost);
            Console.WriteLine("You have {0} left to spend.\n", balanceOfMoney);
            if (balanceOfMoney < 0)
            {
                Console.WriteLine("Oops, you don't have enough money.\n");
                BuyLemons();
            }
            return lemonPurchased;
        }
        public decimal BuySugarCubes()
        {
            Console.WriteLine("How many sugar cubes would you like to purchase?");
            sugarCubePurchased = decimal.Parse(Console.ReadLine());
            balanceOfMoney = balanceOfMoney - (sugarCubePurchased * sugarCubeCost);
            if (balanceOfMoney < 0)
            {
                Console.WriteLine("Oops, you don't have enough money.\n");
                BuySugarCubes();
            }
            Console.WriteLine("You have {0} left to spend.\n", balanceOfMoney);
            return sugarCubePurchased;
        }
        public decimal BuyIceCubes()
        {
            Console.WriteLine("How many ice cubes would you like to purcahse?");
            iceCubePurchased = decimal.Parse(Console.ReadLine());
            balanceOfMoney = balanceOfMoney - (iceCubePurchased * iceCubeCost);
            if (balanceOfMoney < 0)
            {
                Console.WriteLine("Oops, you don't have enough money.\n");
                BuyIceCubes();
            }
            Console.WriteLine("You have {0} left to spend.\n", balanceOfMoney);
            return iceCubePurchased;
        }
        public decimal BuyGallonsOfWater()
        {
            Console.WriteLine("How many gallons of water would you like to purchase?");
            gallonOfWaterPurchased = decimal.Parse(Console.ReadLine());
            balanceOfMoney = balanceOfMoney - (gallonOfWaterPurchased * gallonOfWaterCost);
            if (balanceOfMoney < 0)
            {
                Console.WriteLine("Oops, you don't have enough money.\n");
                BuyGallonsOfWater();
            }
            Console.WriteLine("You have {0} left to spend.\n", balanceOfMoney);
            return gallonOfWaterPurchased;
        }
        public decimal BuyCups()
        {
            Console.WriteLine("How many cups would you like to purchase?");
            cupPurchased = decimal.Parse(Console.ReadLine());
            remainingBalanceOfMoney = balanceOfMoney - (cupPurchased * cupCost);
            if (balanceOfMoney < 0)
            {
                Console.WriteLine("Oops, you don't have enough money.\n");
                BuyCups();
            }
            Console.WriteLine("\nYou have {0} left. Let's go make lemonade!\n", remainingBalanceOfMoney);
            return cupPurchased;
        }
        public void GoToStore()
        {
            Console.WriteLine("Let's go to the store.");
            Console.ReadLine();
        }
        public void ShowStorePrices()
        {
            Console.WriteLine("LEMONS cost .25 each.");
            Console.WriteLine("SUGAR CUBES cost .05 each cube.");
            Console.WriteLine("ICE CUBES cost .01 each cube.");
            Console.WriteLine("A GALLON OF WATER costs 1.00 each.");
            Console.WriteLine("CUPS cost .05 each.\n");
        }    
    }
}
