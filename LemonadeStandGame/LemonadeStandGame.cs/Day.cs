using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame.cs
{
    public class Day
    {
        public Customer customer;
        public Weather weather;
        public Day()
        {
            customer = new Customer();
            weather = new Weather();
        }
    }
}
