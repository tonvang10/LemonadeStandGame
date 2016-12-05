using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame.cs
{
    public class Player : Store
    {
        public string name;
        public decimal userInput;
        Store store = new Store();

        public void BuyIngridients()
        {
            int i = 0;
            while (i < 1)
            {
                store.BuyLemons();
                store.BuySugarCubes();
                store.BuyIceCubes();
                store.BuyGallonsOfWater();
                store.BuyCups();
                ++i;
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
