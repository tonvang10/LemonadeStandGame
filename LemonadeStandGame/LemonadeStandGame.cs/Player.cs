using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame.cs
{
    class Player
    {
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
        }
        public void MakeLemonade()
        {
            UseLemon();
            UseSugarCube();
            UseIceCube();
            UseGallonOfWater();
            UseCup();
            Console.WriteLine("Good luck!\n");
        }
        public bool UseLemon()
        {
            try
            {
                Console.WriteLine("How many lemons do you want to use?");
                lemonUsed = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("PLEASE ENTER A NUMBER.");
                UseLemon();
            }
            inventory.lemons.RemoveRange(0, lemonUsed);
            if (lemonUsed < lemonPurchased)
            {
                return false;
            }
            else
            {
                Console.WriteLine("Oops, you don't have enough. Please enter an amount you have.");
                UseLemon();
                return true;
            }
        }
        public bool UseSugarCube()
        {
            try
            {
                Console.WriteLine("How many sugar cubes do you want to use?");
                sugarCubeUsed = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("PLEASE ENTER A NUMBER.");
                UseSugarCube();
            }
            inventory.sugarCubes.RemoveRange(0, sugarCubeUsed);
            if (sugarCubeUsed < sugarCubePurchased)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Oops, you don't have enough. Please enter an amount you have.");
                UseSugarCube();
                return false;
            }
        }
        public bool UseIceCube()
        {
            try
            {
                Console.WriteLine("How many ice cubes do you want to use?");
                iceCubeUsed = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("PLEASE ENTER A NUMBER.");
                UseIceCube();
            }
            inventory.iceCubes.RemoveRange(0, iceCubeUsed);
            if (iceCubeUsed < iceCubePurchased)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Oops, you don't have enough. Please enter an amount you have.");
                UseIceCube();
                return false;
            }
        }
        public bool UseGallonOfWater()
        {
            try
            {
                Console.WriteLine("How many gallons of water do you want to use?");
                gallonOfWaterUsed = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("PLEASE ENTER A NUMBER.");
                UseGallonOfWater();
            }
                inventory.gallonsOfWater.RemoveRange(0, gallonOfWaterUsed);
            if (gallonOfWaterUsed < gallonOfWaterPurchased)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Oops, you don't have enough. Please enter an amount you have.");
                UseGallonOfWater();
                return false;
            }
        }
        public bool UseCup()
        {
            try
            {
                Console.WriteLine("How many cups do you want to use?");
                cupUsed = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("PLEASE ENTER A NUMBER.");
                UseCup();
            }
            inventory.cups.RemoveRange(0, cupUsed);
            if (cupUsed < cupPurchased)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Oops, you don't have enough. Please enter an amount you have.");
                UseCup();
                return false;
            }
        }
        public void ShowMoney()
        {
            Console.WriteLine("Your money: {0} \n", money.GetMoney());
        }
        public void BuyIngridient()
        {
            BuyLemon();
            BuySugarCube();
            BuyIceCube();
            BuyGallonOfWater();
            BuyCup();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Great, let's make lemonade.\n");
            Console.ResetColor();
        }
        public bool BuyLemon()
        {
            try
            {
                Console.WriteLine("How many lemons would you like to purchase?");
                lemonPurchased = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("PLEASE ENTER A NUMBER.");
                BuyLemon();
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
                BuyLemon();
                return false;
                }
        }
        public bool BuySugarCube()
        {
            try
            {
                Console.WriteLine("How many sugar cubes would you like to purchase?");
                sugarCubePurchased = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("PLEASE ENTER A NUMBER.");
                BuySugarCube();
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
                BuySugarCube();
                return false;
                }
        }
        public bool BuyIceCube()
        {
            try
            {
                Console.WriteLine("How many ice cubes would you like to purcahse?");
                iceCubePurchased = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("PLEASE ENTER A NUMBER.");
                BuyIceCube();
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
                BuyIceCube();
                return false;
                }
        }
        public bool BuyGallonOfWater()
        {
            try
            {
                Console.WriteLine("How many gallons of water would you like to purchase?");
                gallonOfWaterPurchased = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("PLEASE ENTER A NUMBER.");
                BuyGallonOfWater();
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
                BuyGallonOfWater();
                return false;
                }         
        }
        public bool BuyCup()
        {
            try
            {
                Console.WriteLine("How many cups would you like to purchase?");
                cupPurchased = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("PLEASE ENTER A NUMBER.");
                BuyCup();
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
                BuyCup();
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
