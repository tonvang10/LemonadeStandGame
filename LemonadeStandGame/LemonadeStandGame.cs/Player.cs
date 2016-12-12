using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame.cs
{
    public class Player
    {
        public Recipe recipe;
        public Inventory inventory;
        public Money money;
        public int lemonUsed;
        public int sugarCubeUsed;
        public int iceCubeUsed;
        public int gallonOfWaterUsed;
        public int cupUsed;
        public int lemonPurchased;
        public int sugarCubePurchased;
        public int iceCubePurchased;
        public int gallonOfWaterPurchased;
        public int cupPurchased;
        public decimal balanceOfMoney;
        public decimal remainingBalanceOfMoney;
        public string name;

        public Player()
        {
            money = new Money();
            recipe = new Recipe();
            inventory = new Inventory();
        }
        public void MakeLemonade()
        {
            AskAmountOfLemonToUse();
            UseLemon();
            AskAmountOfSugarcubeToUse();
            UseSugarCube();
            AskAmountOfIceCubeToUse();
            UseIceCube();
            AskAmountOfGallonOfWaterToUse();
            UseGallonOfWater();
            AskAmountOfCupToUse();
            UseCup();
            inventory.DisplaySupply();
            Console.WriteLine("Good luck!\n");
        }
        public void AskAmountOfLemonToUse()
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
        }
        public bool UseLemon()
        {
            inventory.lemons.RemoveRange(0, lemonUsed);
            if (lemonUsed < lemonPurchased)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Oops, you don't have enough. Please enter an amount you have.");
                UseLemon();
                return false;
            }
        }
        public void AskAmountOfSugarcubeToUse()
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
        }
        public bool UseSugarCube()
        {
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
        public void AskAmountOfIceCubeToUse()
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
        }
        public bool UseIceCube()
        {
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
        public void AskAmountOfGallonOfWaterToUse()
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
        }
        public bool UseGallonOfWater()
        {
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
        public void AskAmountOfCupToUse()
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
        }
        public bool UseCup()
        {
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
            GetLemonToBuy();
            BuyLemon();
            GetSugarCubeToBuy();
            BuySugarCube();
            GetIceCubeToBuy();
            BuyIceCube();
            GetGallonOfWaterToBuy();
            BuyGallonOfWater();
            GetCupToBuy();
            BuyCup();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Great, let's make lemonade.\n");
            Console.ResetColor();
        }
        public void GetLemonToBuy()
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
        }
        public bool BuyLemon()
        {
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
        public void GetSugarCubeToBuy()
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
        }
        public bool BuySugarCube()
        {
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
        public void GetIceCubeToBuy()
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
        }
        public bool BuyIceCube()
        {
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
        public void GetGallonOfWaterToBuy()
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
        }
        public bool BuyGallonOfWater()
        {
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
        public void GetCupToBuy()
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
        }
        public bool BuyCup()
        {
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
