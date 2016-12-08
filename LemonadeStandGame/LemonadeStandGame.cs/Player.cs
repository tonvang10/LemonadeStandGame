using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame.cs
{
    class Player
    {
        public Customer customer;
        public Recipe recipe;
        public Inventory inventory;
        public Money money;
        decimal lemonPurchased;
        decimal sugarCubePurchased;
        decimal iceCubePurchased;
        decimal gallonOfWaterPurchased;
        decimal cupPurchased;
        decimal balanceOfMoney;
        decimal remainingBalanceOfMoney;
        string name;

        public Player()
        {
            money = new Money();
            recipe = new Recipe();
            inventory = new Inventory();
            customer = new Customer();
        }
        public void SellLemonade()
        {
            Console.WriteLine("");
        }
                        //inventory.lemons.RemoveAt(Convert.ToInt32(lemonUsed));
                //inventory.cups.RemoveAt(Convert.ToInt32(cupUsed));
                //inventory.gallonsOfWater.RemoveAt(Convert.ToInt32(gallonOfWaterUsed));
                //inventory.iceCubes.RemoveAt(Convert.ToInt32(iceCubeUsed));
                //inventory.sugarCubes.RemoveAt(Convert.ToInt32(sugarCubeUsed));
        public void MakeLemonade()
        {
            recipe.UseLemons();
            recipe.UseSugarCubes();
            recipe.UseIceCubes();
            recipe.UseGallonOfWater();
            recipe.UseCup();
            Console.WriteLine("Good luck!\n");
        }
        public decimal GetBalanceOfMoney()
        {
            return remainingBalanceOfMoney;
        }
        public void BuyIngridients()
        {
            BuyLemons();
            BuySugarCubes();
            BuyIceCubes();
            BuyGallonsOfWater();
            BuyCups();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Great, let's make lemonade.\n");
            Console.ResetColor();
        }
        public bool BuyLemons()
        {
            try
            {
                Console.WriteLine("How many lemons would you like to purchase?");
                lemonPurchased = decimal.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("PLEASE ENTER A NUMBER.");
                BuyLemons();
            }
            for (decimal i = 0; i < lemonPurchased; i++)
                {
                inventory.lemons.Add(new Lemon());
                }
            balanceOfMoney = money.GetMoney() - (lemonPurchased * Lemon.cost);
                if (balanceOfMoney > 0)
                {
                Console.WriteLine("You have {0} left to spend.\n", balanceOfMoney);
                return true;
                }
                else
                {
                Console.WriteLine("Oops, you don't have enough money.\n");
                BuyLemons();
                return false;
                }

        }
        public bool BuySugarCubes()
        {
            try
            {
                Console.WriteLine("How many sugar cubes would you like to purchase?");
                sugarCubePurchased = decimal.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("PLEASE ENTER A NUMBER.");
                BuySugarCubes();
            }
            for (decimal i = 0; i < sugarCubePurchased; i++)
                {
                inventory.sugarCubes.Add(new SugarCube());
                }
            balanceOfMoney = balanceOfMoney - (sugarCubePurchased * SugarCube.cost);
                if (balanceOfMoney > 0)
                {
                Console.WriteLine("You have {0} left to spend.\n", balanceOfMoney);
                return true;
                }
                else
                {
                Console.WriteLine("Oops, you don't have enough money.\n");
                BuySugarCubes();
                return false;
                }
        }
        public bool BuyIceCubes()
        {
            try
            {
                Console.WriteLine("How many ice cubes would you like to purcahse?");
                iceCubePurchased = decimal.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("PLEASE ENTER A NUMBER.");
                BuyIceCubes();
            }
            for (decimal i = 0; i < iceCubePurchased; i++)
                {
                inventory.iceCubes.Add(new IceCube());
                }
            balanceOfMoney = balanceOfMoney - (iceCubePurchased * IceCube.cost);
                if (balanceOfMoney > 0)
                {
                Console.WriteLine("You have {0} left to spend.\n", balanceOfMoney);
                return true;
                }
                else
                {
                Console.WriteLine("Oops, you don't have enough money.\n");
                BuyIceCubes();
                return false;
                }
        }
        public bool BuyGallonsOfWater()
        {
            try
            {
                Console.WriteLine("How many gallons of water would you like to purchase?");
                gallonOfWaterPurchased = decimal.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("PLEASE ENTER A NUMBER.");
                BuyGallonsOfWater();
            }
            for (decimal i = 0; i < gallonOfWaterPurchased; i++)
                {                           
                inventory.gallonsOfWater.Add(new GallonOfWater());
                }
            balanceOfMoney = balanceOfMoney - (gallonOfWaterPurchased * GallonOfWater.cost);
                if (balanceOfMoney > 0)
                {
                Console.WriteLine("You have {0} left to spend.\n", balanceOfMoney);
                return true;
                }
                else
                {
                Console.WriteLine("Oops, you don't have enough money.\n");
                BuyGallonsOfWater();
                return false;
                }         
        }
        public bool BuyCups()
        {
            try
            {
                Console.WriteLine("How many cups would you like to purchase?");
                cupPurchased = decimal.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("PLEASE ENTER A NUMBER.");
                BuyCups();
            }
            for (decimal i = 0; i < cupPurchased; i++)
                {
                inventory.cups.Add(new Cup());
                }
            remainingBalanceOfMoney = balanceOfMoney - (cupPurchased * Cup.cost);
                if (balanceOfMoney > 0)
                {
                Console.WriteLine("You have {0} left to spend.\n", balanceOfMoney);
                return true;
                }
                else
                {
                Console.WriteLine("Oops, you don't have enough money.\n");
                BuyCups();
                return false;
                }
        }
        public void GetPlayerName()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Good luck {0}!\n", name);
            Console.ResetColor();
        }
    }
}
