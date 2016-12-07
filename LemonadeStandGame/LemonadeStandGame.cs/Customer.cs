using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame.cs
{
    class Customer
    {
        List<string> customers = new List<string>();
        public Customer()
        {

        }
        public void DisplayCustomers()
        {
            foreach (string customernumber in customers)
            {
                Console.WriteLine(customernumber);
            }
        }   
        public void BuyLemonade()
        {
            //int i = 0;
            //while (i < 1)
            //{
            //}
            //++i;
        }
    }
}
