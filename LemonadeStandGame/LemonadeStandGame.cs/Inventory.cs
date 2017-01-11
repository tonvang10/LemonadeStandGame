using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame.cs
{
    public class Inventory
    {
        public List<Lemon> lemons;
        public List<SugarCube> sugarCubes;
        public List<IceCube> iceCubes;
        public List<Cup> cups;

        public Inventory()
        {
            lemons = new List<Lemon>();
            sugarCubes = new List<SugarCube>();
            iceCubes = new List<IceCube>();
            cups = new List<Cup>();
        }
        public void DisplaySupply()
        {
            ShowLemonStock();
            ShowSugarStock();
            ShowIceStock();
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
        public void ShowCupStock()
        {
            Console.WriteLine("You have {0} cups.\n", cups.Count);
        }
    }
}

      
               
         
       
