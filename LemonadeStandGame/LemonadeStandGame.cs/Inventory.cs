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
        decimal lemonStock;
        decimal sugarCubeStock;
        decimal iceCubeStock;
        decimal gallonOfWaterStock;
        decimal cupStock;

        public Inventory()
        {
            store = new Store();
        }
        public void DisplaySupplies()
        {
            GetLemons();
            GetSugarCubes();
            GetIceCubes();
            GetGallonsOfWater();
            GetCups();
        }
    }
}
