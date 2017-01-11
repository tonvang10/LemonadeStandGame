using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame.cs
{
    public class Player
    {
        public Money money;
        public Inventory inventory;
        public Recipe recipe;
        public Store store;
        public Customer customer;
        public string name;
        public decimal priceOfLemonade;

        public Player()
        {
            money = new Money();
            inventory = new Inventory();
            recipe = new Recipe();
            store = new Store();
            customer = new Customer();
        }
        public void BuyIngridient()
        {
            ShowMoney();
            store.AskToBuyLemon();
            BuyLemon();
            store.AskToBuySugarCube();
            BuySugarCube();
            store.AskToBuyIceCube();
            BuyIceCube();
            store.AskToBuyCup();
            BuyCup();
            inventory.DisplaySupply();
        }
        public void MakeLemonade()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nGreat, let's make lemonade.");
            Console.ResetColor();
            recipe.AskAmountOfLemonToUse();
            UseLemon();
            recipe.AskAmountOfSugarcubeToUse();
            UseSugarCube();
            recipe.AskAmountOfIceCubeToUse();
            UseIceCube();
            recipe.MixSupplies();
        }
        public void AddEarnings()
        {
            money.money = money.money + CaculateMoneyMade(0);
        }
        public decimal CaculateMoneyMade(decimal moneyMade)
        {
            moneyMade = customer.CustomersBuying * priceOfLemonade;
            return moneyMade;
        }
        public decimal CaculateItemsBought(decimal moneySpent)
        {
            decimal costOfLemons = store.lemonToPurchase * Lemon.cost;
            decimal costOfSugarCubes = store.sugarCubeToPurchase * SugarCube.cost;
            decimal costOfIceCubes = store.iceCubeToPurchase * IceCube.cost;
            decimal costOfCups = store.cupToPurchase * Cup.cost;
            moneySpent = (costOfLemons + costOfSugarCubes + costOfIceCubes + costOfCups);
            return moneySpent;
        }
        public decimal CaculateProfit()
        {
            decimal profit = CaculateMoneyMade(0) - CaculateItemsBought(0);
            Console.WriteLine("\nYou made {0} today. A profit of {1}.", CaculateMoneyMade(0), profit);
            return profit;
        }
        public void SetPriceOfLemonade()
        {
            try
            {
                Console.WriteLine("\nSet a price for your lemonade: xx.xx");
                priceOfLemonade = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("\nYour lemonade price is set to ${0}", priceOfLemonade);
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("\nPlease set a price for your lemonade: xx.xx");
                SetPriceOfLemonade();
            }
        }
        public bool UseLemon()
        {
            if (recipe.lemonUsed <= inventory.lemons.Count)
            {
                inventory.lemons.RemoveRange(0, recipe.lemonUsed);
                return true;
            }
            else
            {
                Console.WriteLine("Oops, you don't have enough. Please enter an amount you have.");
                recipe.AskAmountOfLemonToUse();
                return false;
            }
        }
        public bool UseSugarCube()
        {
            if (recipe.sugarCubeUsed <= inventory.sugarCubes.Count)
            {
                inventory.sugarCubes.RemoveRange(0, recipe.sugarCubeUsed);
                return true;
            }
            else
            {
                Console.WriteLine("Oops, you don't have enough. Please enter an amount you have.");
                recipe.AskAmountOfSugarcubeToUse();
                return false;
            }
        }
        public bool UseIceCube()
        {
            if (recipe.iceCubeUsed <= inventory.iceCubes.Count)
            {
                inventory.iceCubes.RemoveRange(0, recipe.iceCubeUsed);
                return true;
            }
            else
            {
                Console.WriteLine("Oops, you don't have enough. Please enter an amount you have.");
                recipe.AskAmountOfIceCubeToUse();
                return false;
            }
        }
        public bool UseCup()
        {
            if (inventory.cups.Count > customer.CustomersBuying)
            {
                inventory.cups.RemoveRange(0, customer.CustomersBuying);
                return true;
            }
            {
                Console.WriteLine("You ran out of cups.");
                return true;
            }
        }
        public bool BuyLemon()
        {
            if (money.money > store.lemonToPurchase * Lemon.cost)
            {
                for (decimal i = 0; i < store.lemonToPurchase; i++)
                {
                    inventory.lemons.Add(new Lemon());
                }
                money.money = money.money - (store.lemonToPurchase * Lemon.cost);
                Console.WriteLine("You have {0} left to spend.\n", money.money);
                return true;
            }
            else
            {
                Console.WriteLine("Oops, you don't have enough money.\n");
                ShowMoney();
                store.AskToBuyLemon();
            }
            return false;
        }
        public bool BuySugarCube()
        {
            if (money.money > 0)
            {
                for (decimal i = 0; i < store.sugarCubeToPurchase; i++)
                {
                    inventory.sugarCubes.Add(new SugarCube());
                }
                money.money = money.money - (store.sugarCubeToPurchase * SugarCube.cost);
                Console.WriteLine("You have {0} left to spend.\n", money.money);
                return true;
            }
            else
            {
                Console.WriteLine("Oops, you don't have enough money.\n");
                ShowMoney();
                store.AskToBuySugarCube();
                return false;
            }
        }
        public bool BuyIceCube()
        {
            if (money.money > 0)
            {
                for (decimal i = 0; i < store.iceCubeToPurchase; i++)
                {
                    inventory.iceCubes.Add(new IceCube());
                }
                money.money = money.money - (store.iceCubeToPurchase * IceCube.cost);
                Console.WriteLine("You have {0} left to spend.\n", money.money);
                return true;
            }
            else
            {
                Console.WriteLine("Oops, you don't have enough money.\n");
                ShowMoney();
                store.AskToBuyIceCube();
                return false;
            }
        }
        public bool BuyCup()
        {
            if (money.money > 0)
            {
                for (decimal i = 0; i < store.cupToPurchase; i++)
                {
                    inventory.cups.Add(new Cup());
                }
                money.money = money.money - (store.cupToPurchase * Cup.cost);
                Console.WriteLine("You have {0} left to spend.\n", money.money);
                return true;
            }
            else
            {
                Console.WriteLine("Oops, you don't have enough money.\n");
                ShowMoney();

                store.AskToBuyCup();
                return false;
            }
        }
        public void ShowMoney()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nYOUR MONEY: {0}\n", money.money);
            Console.ResetColor();
        }
        public void GoToStore()
        {
            Console.WriteLine("Let's go to the store.\nPress **ENTER** to enter");
            Console.ReadLine();
            store.ShowStorePrices();
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
