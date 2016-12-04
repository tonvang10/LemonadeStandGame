using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame.cs
{
    public class Game
    {
        
        public void StartGame()
        {
            Welcome();
            ShowInstructions();
            Player getPlayerName = new Player();
            getPlayerName.GetPlayerName();
            Weather weather = new Weather();
            weather.WeatherCondition();
            weather.ShowWeather();
            Store purchase = new Store();
            ShowStorePrices();
            Day trackDays = new Day();
            trackDays.TrackDays();


        }
        public void ShowStorePrices()
        {
            Console.WriteLine("Lemons cost .25 each.");
            Console.WriteLine("Sugar cubes cost .05 each cube.");
            Console.WriteLine("Ice cubes cost .01 each cube.");
            Console.WriteLine("A gallon of water costs 1.00 each. 1 gallon makes 20 cups of lemonade");
            Console.WriteLine("Cups cost .05 each. ");
        }
        public void DisplayMoney()
        {
            Console.WriteLine("You saved up to $20 dollars to spend on your lemonade stand.");
        }
        public void ShowInstructions()
        {
            Console.WriteLine("There are no rules to the game, however, there are intsructions. You buy a certain amount of supplies with");
            Console.WriteLine("the amount of money you have. Make a recipe for your lemonade and sell lemonade. Try to make as much");
            Console.WriteLine("profit in the amount of days given. REMEMBER to keep track of the weather! ENJOY!\n");                  
        }
        public void Welcome()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to the LEMONADE STAND GAME!\n");
            Console.ResetColor();
        }
    }
}
