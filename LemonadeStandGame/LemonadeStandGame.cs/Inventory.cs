using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame.cs
{
    class Inventory
    {
        public List<Lemon> lemons = new List<Lemon>();
        public List<SugarCube> sugarCubes = new List<SugarCube>();
        public List<IceCube> iceCubes = new List<IceCube>();
        public List<GallonOfWater> gallonsOfWater = new List<GallonOfWater>();
        public List<Cup> cups = new List<Cup>();
        public Inventory()
        { 
        }
        public void DisplaySupplies()
        {
            StockLemons();
            StockSugarCubes();
            StockIceCubes();
            StockGallonsOfWater();
            StockCups();
        }
        public void StockLemons()
        {
            Console.WriteLine("You have {0} lemons.", lemons.Count);
        }
        public void StockSugarCubes()
        {
            Console.WriteLine("You have {0} sugar cubes.", sugarCubes.Count);
        }
        public void StockIceCubes()
        {
            Console.WriteLine("You have {0} ice cubes.", iceCubes.Count);
        }
        public void StockGallonsOfWater()
        {
            Console.WriteLine("You have {0} gallons of water.", gallonsOfWater.Count);
        }
        public void StockCups()
        {
            Console.WriteLine("You have {0} cups.\n", cups.Count);
        }
    }
}

      
               
         
       
