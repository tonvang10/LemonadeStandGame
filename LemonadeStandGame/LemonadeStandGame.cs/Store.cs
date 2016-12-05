using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame.cs
{
    class Store : Player
    {
        public decimal lemons;
        public decimal sugarCubes;
        public decimal iceCubes;
        public decimal gallonsOfWater;
        public decimal cups;
        public decimal cost;

        public void ShowStorePrices()
        {
            Console.WriteLine("Lemons cost .25 each.");
            Console.WriteLine("Sugar cubes cost .05 each cube.");
            Console.WriteLine("Ice cubes cost .01 each cube.");
            Console.WriteLine("A gallon of water costs 1.00 each.");
            Console.WriteLine("Cups cost .05 each. ");
        }
        public decimal GetTotalCost()
        {
            return lemons + sugarCubes;
        }
        public void CostOfLemon()
        {
            lemons = .25M;
        }
        public void CostOfSugerCube()
        {
            sugarCubes = .05M;
        }
        public void CostOfIceCube()
        {
            iceCubes = .01M;
        }
        public void CostOfGallon()
        {
            gallonsOfWater = 1.00M;
        }
        public void CostOfCup()
        {
            cups = .05M;
        }

        
    }
}
