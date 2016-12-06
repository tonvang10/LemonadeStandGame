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
        }
        public void GetLemonStock()
        {
            List<decimal> lemon = new List<decimal>();
            lemon.Add(store.GetLemons());
            Console.WriteLine("You have {0} lemons.", lemon);
        }
        public void GetSugarCubeStock()
        {
            List<decimal> sugarCube = new List<decimal>();
            sugarCube.Add(store.GetSugarCubes());
            Console.WriteLine("You have {0} sugar cubes.", sugarCube);
        }
        public void GetIceCubeStock()
        {
            List<decimal> iceCube = new List<decimal>();
            iceCube.Add(store.GetIceCubes());
            Console.WriteLine("You have {0} ice cubes.", iceCube);
        }
        public void WaterStock()
        {
            List<decimal> gallonOfWater = new List<decimal>();
            gallonOfWater.Add(store.GetGallonsOfWater());
            Console.WriteLine("You have {0} gallons of water.", gallonOfWater);
        }
        public void GetCupStock()
        {
            List<decimal> cup = new List<decimal>();
            cup.Add(store.GetCups());
            Console.WriteLine("You have {0} cups.\n", cup);
        }
        
    }
}
