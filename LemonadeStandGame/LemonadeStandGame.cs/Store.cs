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
        public List<Lemon> lemons = new List<Lemon>();
        public List<SugarCube> sugarCubes = new List<SugarCube>();
        public List<IceCube> iceCubes = new List<IceCube>();
        public List<GallonOfWater> gallonsOfWater = new List<GallonOfWater>();
        public List<Cup> cups = new List<Cup>();
        public decimal lemonPurchased;
        public decimal sugarCubePurchased;
        public decimal iceCubePurchased;
        public decimal gallonOfWaterPurchased;
        public decimal cupPurchased;
        decimal balanceOfMoney;
        decimal remainingBalanceOfMoney;
        decimal lemonCost = .25M;
        decimal sugarCubeCost = .05M;
        decimal iceCubeCost = .01M;
        decimal gallonOfWaterCost = 1.00M;
        decimal cupCost = .05M;
        decimal i;

        public Store()
        {
            money = new Money();
        }
        public decimal GetBalanceOfMoney()
        {
            return remainingBalanceOfMoney;
        }
        public bool BuyLemons()
        {
            try
            {
                Console.WriteLine("How many lemons would you like to purchase?");
                lemonPurchased = decimal.Parse(Console.ReadLine());
                for (i = 0; i < lemonPurchased; i++)
                {
                    lemons.Add(new Lemon());
                }
                balanceOfMoney = money.GetMoney() - (lemonPurchased * lemonCost);
                if (balanceOfMoney > 0)
                {
                    Console.WriteLine("You have {0} left to spend.\n", balanceOfMoney);
                }
                else
                {
                    Console.WriteLine("Oops, you don't have enough money.\n");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("PLEASE ENTER A NUMBER.");
                BuyLemons();
            }
            return true;
        }
        public bool BuySugarCubes()
        {
            try
            {
                Console.WriteLine("How many sugar cubes would you like to purchase?");
                sugarCubePurchased = decimal.Parse(Console.ReadLine());
                for (i = 0; i < sugarCubePurchased; i++)
                {
                    sugarCubes.Add(new SugarCube());
                }
                balanceOfMoney = balanceOfMoney - (sugarCubePurchased * sugarCubeCost);
                if (balanceOfMoney > 0)
                {
                    Console.WriteLine("You have {0} left to spend.\n", balanceOfMoney);
                }
                else
                {
                    Console.WriteLine("Oops, you don't have enough money.\n");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("PLEASE ENTER A NUMBER.");
                BuySugarCubes();
            }
            return true;
        }
        public bool BuyIceCubes()
        {
            try
            {
                Console.WriteLine("How many ice cubes would you like to purcahse?");
                iceCubePurchased = decimal.Parse(Console.ReadLine());
                for (i = 0; i < iceCubePurchased; i++)
                {
                    iceCubes.Add(new IceCube());
                }
                balanceOfMoney = balanceOfMoney - (iceCubePurchased * iceCubeCost);
                if (balanceOfMoney > 0)
                {
                    Console.WriteLine("You have {0} left to spend.\n", balanceOfMoney);
                }
                else
                {
                    Console.WriteLine("Oops, you don't have enough money.\n");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("PLEASE ENTER A NUMBER.");
                BuyIceCubes();
            }
            return true;
        }
        public bool BuyGallonsOfWater()
        {
            try
            {
                Console.WriteLine("How many gallons of water would you like to purchase?");
                gallonOfWaterPurchased = decimal.Parse(Console.ReadLine());
                for (i = 0; i < gallonOfWaterPurchased; i++)
                {
                    gallonsOfWater.Add(new GallonOfWater());
                }
                balanceOfMoney = balanceOfMoney - (gallonOfWaterPurchased * gallonOfWaterCost);
                if (balanceOfMoney > 0)
                {
                    Console.WriteLine("You have {0} left to spend.\n", balanceOfMoney);
                }
                else
                {
                    Console.WriteLine("Oops, you don't have enough money.\n");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("PLEASE ENTER A NUMBER.");
                BuyGallonsOfWater();
            }
            return true;
        }
        public bool BuyCups()
        {
            try
            {
                Console.WriteLine("How many cups would you like to purchase?");
                cupPurchased = decimal.Parse(Console.ReadLine());
                for (i = 0; i < cupPurchased; i++)
                {
                    cups.Add(new Cup());
                }
                remainingBalanceOfMoney = balanceOfMoney - (cupPurchased * cupCost);
                if (balanceOfMoney > 0)
                {
                    Console.WriteLine("You have {0} left to spend.\n", balanceOfMoney);
                }
                else
                {
                    Console.WriteLine("Oops, you don't have enough money.\n");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("PLEASE ENTER A NUMBER.");
                BuyCups();
            }
            return true;
        }
        public void GoToStore()
        {
            Console.WriteLine("Let's go to the store.\nPress **ENTER** to enter");
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
