using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame.cs
{
    class Game
    {
        List<Customer> customers = new List<Customer>();
        public Player player;
        public Store store;
        public Weather weather;
          
        public Game()
        {
            player = new Player();
            store = new Store();
            weather = new Weather();
        }
        public void StartGame()
        {
            Welcome();
            ShowInstructions();
            player.GetPlayerName();
            GetStartingBalnce();
            int days = 1;
                while (days < 8)
                {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("DAY {0}", days);
                Console.ResetColor();
                Console.WriteLine("GOOD LUCK!\n");
                weather.PickWeatherCondition();
                store.GoToStore();
                store.ShowStorePrices();
                player.ShowMoney();
                player.BuyIngridients();
                player.inventory.DisplaySupplies();
                player.MakeLemonade();
                Console.ReadLine();
                days++;
                }
        }
        public void AddCustomers()
        {
            Random rndcustomer = new Random();
            for (int i = 0; i < 150; i++)
            {
                customers.Add(new Customer());
            }
        }
        public void GetStartingBalnce()
        {
            Console.WriteLine("You saved up to $20 dollars to spend on your lemonade stand.\n");
        }
        public void ShowInstructions()
        {
            Console.WriteLine("There are no rules to the game, however, there are intsructions. You buy a certain amount of supplies with");
            Console.WriteLine("the amount of money you have. Make a recipe for your lemonade and sell lemonade. Try to make as much");
            Console.WriteLine("profit as you can, in 7 days. REMEMBER to keep track of the weather temperature! ENJOY!\n");
        }
        public void Welcome()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to the LEMONADE STAND GAME!\n");
            Console.ResetColor();
        }
    }
}
