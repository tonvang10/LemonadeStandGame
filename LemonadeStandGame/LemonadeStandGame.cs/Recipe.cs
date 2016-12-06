using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame.cs
{
    class Recipe : Inventory
    {
        decimal lemonUsed;
        decimal sugarCubeUsed;
        decimal iceCubeUsed;
        decimal gallonOfWaterUsed;
        decimal cupUsed;
        
        public Recipe()
        {

        }
        public void UseLemons()
        {
            Console.WriteLine("How many lemons do you want to use?");
            lemonUsed = decimal.Parse(Console.ReadLine());
            lemonStock = lemonStock - lemonUsed;
            Console.WriteLine("You have {0} lemons left in stock.");
        }
        public void UseSugarCubes()
        {
            Console.WriteLine("How many sugar cubes do you want to use?");
            sugarCubeUsed = decimal.Parse(Console.ReadLine());
            sugarCubeStock = sugarCubeStock - sugarCubeUsed;
            Console.WriteLine("You have {0} sugar cubes left in stock.");
        }
        public void UseIceCubes()
        {
            Console.WriteLine("How many ice cubes do you want to use?");
            iceCubeUsed = decimal.Parse(Console.ReadLine());
            iceCubeStock = iceCubeStock - iceCubeUsed;
            Console.WriteLine("You have {0} ice cubes left in stock.");
        }
        public void UseGallonOfWater()
        {
            Console.WriteLine("How many gallons of water do you want to use?");
            gallonOfWaterUsed = decimal.Parse(Console.ReadLine());
            gallonOfWaterStock = gallonOfWaterStock - gallonOfWaterUsed;
            Console.WriteLine("You have {0} gallons of water left in stock.");
        }
        public void UseCup()
        {
            Console.WriteLine("How many cups do you want to use?");
            cupUsed = decimal.Parse(Console.ReadLine());
            cupStock = cupStock - cupUsed;
            Console.WriteLine("You have {0} cups left in stock.");
        }
    }
}
