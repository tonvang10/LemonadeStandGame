using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame.cs
{
    class Game : Player
    {
        public Player player;
        public Weather weather;
        public Store store;
        public Inventory inventory;

        public Game()
        {
            player = new Player();
            weather = new Weather();
            store = new Store();
            inventory = new Inventory();
        }
        public void StartGame()
        {
            Welcome();
            ShowInstructions();          
            player.GetPlayerName();          
            GetStartingBalnce();
            weather.ShowWeatherCondition();
            store.GoToStore();
            store.ShowStorePrices();
            player.BuyIngridients();
            inventory.DisplayLemons();   
        }
           public void GetStartingBalnce()
        {
            Console.WriteLine("You saved up to $20 dollars to spend on your lemonade stand.\n");
        }
        public void ShowInstructions()
        {
            Console.WriteLine("There are no rules to the game, however, there are intsructions. You buy a certain amount of supplies with");
            Console.WriteLine("the amount of money you have. Make a recipe for your lemonade and sell lemonade. Try to make as much");
            Console.WriteLine("profit as you can, in 7 days. REMEMBER to keep track of the weather! ENJOY!\n");
        }
        public void Welcome()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to the LEMONADE STAND GAME!\n");
            Console.ResetColor();
        }
    }
}
