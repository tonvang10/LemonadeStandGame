using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame.cs
{
    class Store
    {
        public string lemons;
        public string sugarCubes;
        public string iceCubes;
        public string gallonsOfWater;
        public decimal cost;


        public void ShowStorePrices()
        {
            Console.WriteLine("Lemons cost .25 each.");
            Console.WriteLine("Sugar cubes cost .05 each cube.");
            Console.WriteLine("Ice cubes cost .01 each cube");
            Console.WriteLine("A gallon of water costs 1.00 each");
        }
    }
}
