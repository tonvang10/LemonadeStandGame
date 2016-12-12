using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame.cs
{
    public class Store
    { 
        public void GoToStore()
        {
            Console.WriteLine("Let's go to the store.\nPress **ENTER** to enter");
            Console.ReadLine();
        }
        public void ShowStorePrices()
        {
            Console.WriteLine("LEMONS cost .25 each.");
            Console.WriteLine("SUGAR CUBES cost .05 each cube.");
            Console.WriteLine("ICE CUBES cost .01 each cube.");
            Console.WriteLine("A GALLON OF WATER costs 1.00 each.");
            Console.WriteLine("CUPS cost .05 each.\n");
        }    
    }
}
