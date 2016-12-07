using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame.cs
{
    class Customer : Weather
    {
        List<decimal> customers = new List<decimal>();
        decimal numberOfCustomers = 100;
        decimal priceOfLemonade;

        public Customer()
        {
            
        }
        public void AddCustomers()
        {
            customers.Add(numberOfCustomers);
        }   
        public decimal BuyLemonade()
        {
            Console.WriteLine("Hi, I would like a cup of lemonade. How much are you selling it for?");
            priceOfLemonade = decimal.Parse(Console.ReadLine());
            return priceOfLemonade;
        }
    }
}
