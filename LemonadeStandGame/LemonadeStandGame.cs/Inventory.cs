using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame.cs
{
    public class Inventory
    {
        public List<Lemon> lemons = new List<Lemon>();
        public List<SugarCube> sugarCubes = new List<SugarCube>();
        public List<IceCube> iceCubes = new List<IceCube>();
        public List<GallonOfWater> gallonsOfWater = new List<GallonOfWater>();
        public List<Cup> cups = new List<Cup>();

        public void DisplaySupply()
        {
            ShowLemonStock();
            ShowSugarStock();
            ShowIceStock();
            ShowWaterStock();
            ShowCupStock();
        }
        public void ShowLemonStock()
        {
            Console.WriteLine("You have {0} lemons.", lemons.Count);
        }
        public void ShowSugarStock()
        {
            Console.WriteLine("You have {0} sugar cubes.", sugarCubes.Count);
        }
        public void ShowIceStock()
        {
            Console.WriteLine("You have {0} ice cubes.", iceCubes.Count);
        }
        public void ShowWaterStock()
        {
            Console.WriteLine("You have {0} gallons of water.", gallonsOfWater.Count);
        }
        public void ShowCupStock()
        {
            Console.WriteLine("You have {0} cups.\n", cups.Count);
        }
    }
}

      
               
         
       
