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
            Console.WriteLine("Welcome to the LEMONADE STAND GAME!\n");
        }
    }
}
