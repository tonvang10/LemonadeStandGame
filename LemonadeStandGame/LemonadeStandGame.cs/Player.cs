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
        int lemonUsed;
        int sugarCubeUsed;
        int iceCubeUsed;
        int gallonOfWaterUsed;
        int cupUsed;
        int lemonPurchased;
        int sugarCubePurchased;
        int iceCubePurchased;
        int gallonOfWaterPurchased;
        int cupPurchased;
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
        public void MakeLemonade()
        {
            UseLemons();
            UseSugarCubes();
            UseIceCubes();
            UseGallonsOfWater();
            UseCups();
            Console.WriteLine("Good luck!\n");
        }
        public bool UseLemons()
        {
            try
            {
                Console.WriteLine("How many lemons do you want to use?");
                lemonUsed = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("PLEASE ENTER A NUMBER.");
                UseLemons();
            }
            inventory.lemons.RemoveRange(0, lemonUsed);
            if (lemonUsed < lemonPurchased)
            {
                return false;
            }
            else
            {
                Console.WriteLine("Oops, you don't have enough. Please enter an amount you have.");
                UseLemons();
                return true;
            }
        }
        public bool UseSugarCubes()
        {
            try
            {
                Console.WriteLine("How many sugar cubes do you want to use?");
                sugarCubeUsed = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("PLEASE ENTER A NUMBER.");
                UseSugarCubes();
            }
            inventory.sugarCubes.RemoveRange(0, sugarCubeUsed);
            if (sugarCubeUsed < sugarCubePurchased)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Oops, you don't have enough. Please enter an amount you have.");
                UseSugarCubes();
                return false;
            }
        }
        public bool UseIceCubes()
        {
            try
            {
                Console.WriteLine("How many ice cubes do you want to use?");
                iceCubeUsed = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("PLEASE ENTER A NUMBER.");
                UseIceCubes();
            }
            inventory.iceCubes.RemoveRange(0, iceCubeUsed);
            if (iceCubeUsed < iceCubePurchased)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Oops, you don't have enough. Please enter an amount you have.");
                UseIceCubes();
                return false;
            }
        }
        public bool UseGallonsOfWater()
        {
            try
            {
                Console.WriteLine("How many gallons of water do you want to use?");
                gallonOfWaterUsed = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("PLEASE ENTER A NUMBER.");
                UseGallonsOfWater();
            }
                inventory.gallonsOfWater.RemoveRange(0, gallonOfWaterUsed);
            if (gallonOfWaterUsed < gallonOfWaterPurchased)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Oops, you don't have enough. Please enter an amount you have.");
                UseGallonsOfWater();
                return false;
            }
        }
        public bool UseCups()
        {
            try
            {
                Console.WriteLine("How many cups do you want to use?");
                cupUsed = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("PLEASE ENTER A NUMBER.");
                UseCups();
            }
            inventory.cups.RemoveRange(0, cupUsed);
            if (cupUsed < cupPurchased)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Oops, you don't have enough. Please enter an amount you have.");
                UseCups();
                return false;
            }
        }
        public void ShowMoney()
        {
            Console.WriteLine("Your money: {0} \n", money.GetMoney());
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
                lemonPurchased = Convert.ToInt32(Console.ReadLine());
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
                sugarCubePurchased = Convert.ToInt32(Console.ReadLine());
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
                iceCubePurchased = Convert.ToInt32(Console.ReadLine());
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
                gallonOfWaterPurchased = Convert.ToInt32(Console.ReadLine());
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
                cupPurchased = Convert.ToInt32(Console.ReadLine());
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
