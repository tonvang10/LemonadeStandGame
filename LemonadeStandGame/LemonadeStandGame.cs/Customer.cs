using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame.cs
{
    class Customer
    {
        decimal priceOfLemonade;

        public decimal AskForPrice()
        {
            Console.WriteLine("Hi, I would like a cup of lemonade. How much are you selling it for?");
            priceOfLemonade = decimal.Parse(Console.ReadLine());
            return priceOfLemonade;
        }
    }
}
