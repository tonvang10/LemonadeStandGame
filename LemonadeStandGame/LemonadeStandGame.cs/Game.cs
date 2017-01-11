using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame.cs
{
    public class Game
    {
        Player player;
        Store store;
        Day day;
        public Game()
        {
            player = new Player();
            store = new Store();
            day = new Day();
        }
        public void Intro()
        {
            Welcome();
            ShowInstructions();
            player.GetPlayerName();
            GetStartingBalnce();
        }
        public void StartGame()
        {
            int days = 1;
            while (days < 8)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("DAY {0}", days);
                Console.ResetColor();
                day.weather.DisplayWeather();
                player.GoToStore();
                player.inventory.DisplaySupply();
                player.BuyIngridient();
                AskToGoToStoreAgain();
                player.MakeLemonade();
                player.SetPriceOfLemonade();
                day.weather.AttractRandomCustomers();
                player.customer.ChoiceOfBuying(day.weather);
                player.UseCup();
                DisplayEarnings();
                Console.ReadLine();
                days++;
            }
            AskToPlayAgain();
        }
        public bool AskToPlayAgain()
        {
            Console.WriteLine("Would you like to play again?  (y|n)");
            string answer = Console.ReadLine().ToLower();
            if (answer == "y")
            {
                Console.Clear();
                StartGame();
            }
            if (answer == "n")
            {
                Console.WriteLine("THANKS FOR PLAYING!");
            }
            return false;
        }
        public void DisplayEarnings()
        {
            player.CaculateItemsBought(0);
            player.CaculateMoneyMade(0);
            Console.ReadLine();
            player.CaculateProfit();
            player.AddEarnings();
            Console.ReadLine();
            player.ShowMoney();
        }
        public bool AskToGoToStoreAgain()
        {
            Console.WriteLine("Do you still need supplies? Y | N");
            string userIput = Console.ReadLine().ToLower();
            if (userIput == "y")
            {
                player.BuyIngridient();
            }
            if (userIput == "n")
            {
                return false;
            }
            return true;
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
