using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame.cs
{
    class Recipe : Inventory
    {
        public Store market;
        decimal lemonUsed;
        decimal sugarCubeUsed;
        decimal iceCubeUsed;
        decimal gallonOfWaterUsed;
        decimal cupUsed;
        
        public Recipe()
        {
            market = new Store();
        }
        public void UseLemons()
        {
            Console.WriteLine("How many lemons do you want to use?");
            lemonUsed = decimal.Parse(Console.ReadLine());
            lemonPurchased = lemonPurchased - lemonUsed;
            Console.WriteLine("You have {0} lemons left in stock.\n", market.GetLemons());
        }
        public void UseSugarCubes()
        {
            Console.WriteLine("How many sugar cubes do you want to use?");
            sugarCubeUsed = decimal.Parse(Console.ReadLine());
            sugarCubePurchased = sugarCubePurchased - sugarCubeUsed;
            Console.WriteLine("You have {0} sugar cubes left in stock.\n", market.GetSugarCubes());
        }
        public void UseIceCubes()
        {
            Console.WriteLine("How many ice cubes do you want to use?");
            iceCubeUsed = decimal.Parse(Console.ReadLine());
            iceCubePurchased = iceCubePurchased - iceCubeUsed;
            Console.WriteLine("You have {0} ice cubes left in stock.\n", market.GetIceCubes());
        }
        public void UseGallonOfWater()
        {
            Console.WriteLine("How many gallons of water do you want to use?");
            gallonOfWaterUsed = decimal.Parse(Console.ReadLine());
            gallonOfWaterPurchased = gallonOfWaterPurchased - gallonOfWaterUsed;
            Console.WriteLine("You have {0} gallons of water left in stock.\n", market.GetGallonsOfWater());
        }
        public void UseCup()
        {
            Console.WriteLine("How many cups do you want to use?");
            cupUsed = decimal.Parse(Console.ReadLine());
            cupPurchased = cupPurchased - cupUsed;
            Console.WriteLine("You have {0} cups left in stock.\n", market.GetCups());
        }
    }
}
