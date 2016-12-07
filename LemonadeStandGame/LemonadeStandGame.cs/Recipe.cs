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
            try
            {
                Console.WriteLine("How many lemons do you want to use?");
                lemonUsed = decimal.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("PLEASE ENTER A NUMBER.");
                UseLemons();
            }
        }
        public void UseSugarCubes()
        {
            try
            {
                Console.WriteLine("How many sugar cubes do you want to use?");
                sugarCubeUsed = decimal.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("PLEASE ENTER A NUMBER.");
                UseSugarCubes();
            }
        }
        public void UseIceCubes()
        {
            try
            {
                Console.WriteLine("How many ice cubes do you want to use?");
                iceCubeUsed = decimal.Parse(Console.ReadLine());

            }
            catch (Exception)
            {
                Console.WriteLine("PLEASE ENTER A NUMBER.");
                UseIceCubes();
            }
        }
        public void UseGallonOfWater()
        {
            try
            {
                Console.WriteLine("How many gallons of water do you want to use?");
                gallonOfWaterUsed = decimal.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("PLEASE ENTER A NUMBER.");
                UseGallonOfWater();
            }
        }
        public void UseCup()
        {
            try
            {
                Console.WriteLine("How many cups do you want to use?");
                cupUsed = decimal.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("PLEASE ENTER A NUMBER.");
                UseCup();
            }
        }
    }
}
