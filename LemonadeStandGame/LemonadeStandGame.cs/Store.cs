using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame.cs
{
    public class Store
    {
        public int lemonToPurchase;
        public int sugarCubeToPurchase;
        public int iceCubeToPurchase;
        public int cupToPurchase;
        public Store()
        {
        }
        public void AskToBuyLemon()
        {
            try
            {
                Console.WriteLine("How many lemons would you like to purchase?");
                lemonToPurchase = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("PLEASE ENTER A NUMBER.");
                AskToBuyLemon();
            }
        }
        public void AskToBuySugarCube()
        {
            try
            {
                Console.WriteLine("How many sugar cubes would you like to purchase?");
                sugarCubeToPurchase = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("PLEASE ENTER A NUMBER.");
                AskToBuySugarCube();
            }
        }
        public void AskToBuyIceCube()
        {
            try
            {
                Console.WriteLine("How many ice cubes would you like to purcahse?");
                iceCubeToPurchase = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("PLEASE ENTER A NUMBER.");
                AskToBuyIceCube();
            }
        }
        public void AskToBuyCup()
        {
            try
            {
                Console.WriteLine("How many cups would you like to purchase?");
                cupToPurchase = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("PLEASE ENTER A NUMBER.");
                AskToBuyCup();
            }
        }
        public void ShowStorePrices()
        {
            Console.WriteLine("****LEMONS cost .25 each.");
            Console.WriteLine("****SUGAR CUBES cost .05 each cube.");
            Console.WriteLine("****ICE CUBES cost .01 each cube.");
            Console.WriteLine("****CUPS cost .05 each.\n");
        }
    }
}
