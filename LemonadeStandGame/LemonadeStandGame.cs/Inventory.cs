using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame.cs
{
    class Inventory : Store 
    {
        public Store store;

        public Inventory()
        {
            store = new Store();
        }
        public void DisplaySupplies()
        {
            List<decimal> lemon = new List<decimal>();
            lemon.Add(store.GetLemons());
            Console.WriteLine("You have {0} lemons.", lemon);
            List<decimal> sugarCube = new List<decimal>();
            sugarCube.Add(store.GetSugarCubes());
            Console.WriteLine("You have {0} sugar cubes.", sugarCube);
            List<decimal> iceCube = new List<decimal>();
            iceCube.Add(store.GetIceCubes());
            Console.WriteLine("You have {0} ice cubes.", iceCube);
            List<decimal> gallonOfWater = new List<decimal>();
            gallonOfWater.Add(store.GetGallonsOfWater());
            Console.WriteLine("You have {0} gallons of water.", gallonOfWater);
            List<decimal> cup = new List<decimal>();
            cup.Add(store.GetCups());
            Console.WriteLine("You have {0} cups.\n", cup);
        }
    }
}
