using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame.cs
{
    public class Customer
    {
        int customersBuying;
        public Customer()
        {
        }
        public int CustomersBuying
        {
            get { return customersBuying; }
            set { customersBuying = value; }
        }
        public int ChoiceOfBuying(Weather weather)
        {
            Random rndChance = new Random();
            if (weather.Temperature > 90)
            {
                customersBuying = rndChance.Next(55, 75);
                Console.WriteLine("Out of {0} customers, you sold {1} cups of lemonade.", weather.NumberOfCustomers, customersBuying);
            }
            else if (weather.Temperature > 80 && weather.Temperature < 90)
            {
                customersBuying = rndChance.Next(35, 55);
                Console.WriteLine("Out of {0} customers, you sold {1} cups of lemonade.", weather.NumberOfCustomers, customersBuying);
            }
            else if (weather.Temperature > 70 && weather.Temperature < 80)
            {
                customersBuying = rndChance.Next(20, 35);
                Console.WriteLine("Out of {0} customers, you sold {1} cups of lemonade.", weather.NumberOfCustomers, customersBuying);
            }
            else if (weather.Temperature > 60 && weather.Temperature < 70)
            {
                customersBuying = rndChance.Next(1, 20);
                Console.WriteLine("Out of {0} customers, you sold {1} cups of lemonade.", weather.NumberOfCustomers, customersBuying);
            }
            return customersBuying;
        }
    }
}
