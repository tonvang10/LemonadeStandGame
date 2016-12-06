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
        public Store store;
        string name;

       public Player()
        {
            recipe = new Recipe();
            store = new Store();
        }
        public void MakeLemonade()
        {
            recipe.UseLemons();
            recipe.UseSugarCubes();
            recipe.UseIceCubes();
            recipe.UseGallonOfWater();
            recipe.UseCup();
            Console.WriteLine("Good luck!");
        }
        public void BuyIngridients()
        {
            store.BuyLemons();
            store.BuySugarCubes();
            store.BuyIceCubes();
            store.BuyGallonsOfWater();
            store.BuyCups();
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
