using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame.cs
{
    class Player : Game
    {

        public string name;


        //while (true)
        public void PurchaseLemons()
        {
            Console.WriteLine("How many lemons would you like to purchase?");
        }
        public void PurchaseSugarCubes()
        {
            Console.WriteLine("How many sugar cubes would you like to purchase?");
        }
        public void PurhcaseIceCubes()
        {
            Console.WriteLine("How many ice cubes woul you like to purcahse?");
        }
        public void PurchaseGallonsOfWater()
        {
            Console.WriteLine("How many gallons of water would you like to purchase?");
        }
        public void PurchaseCups()
        {
            Console.WriteLine("How many cups would you like to purchase?");
        }

        public void GetPlayerName()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Good luck {0}!\n", name);
        }
    }
}
