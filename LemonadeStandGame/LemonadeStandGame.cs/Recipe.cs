using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame.cs
{
    public class Recipe : IMixable
    {
        public int lemonUsed;
        public int sugarCubeUsed;
        public int iceCubeUsed;
        public Recipe()
        {
        }
        public void AskAmountOfLemonToUse()
        {
            try
            {
                Console.WriteLine("How many lemons do you want to use?");
                lemonUsed = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("PLEASE ENTER A NUMBER.");
                AskAmountOfLemonToUse();
            }
        }
        public void AskAmountOfSugarcubeToUse()
        {
            try
            {
                Console.WriteLine("How many sugar cubes do you want to use?");
                sugarCubeUsed = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("PLEASE ENTER A NUMBER.");
                AskAmountOfSugarcubeToUse();
            }
        }
        public void AskAmountOfIceCubeToUse()
        {
            try
            {
                Console.WriteLine("How many ice cubes do you want to use?");
                iceCubeUsed = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("PLEASE ENTER A NUMBER.");
                AskAmountOfIceCubeToUse();
            }
        }
        public void MixSupplies()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nMixing up some yummy lemonade!\n");
            Console.ReadLine();
            Console.ResetColor();            
            Console.WriteLine("\nFINSIHED\n");
        }
    }
}
