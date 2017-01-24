using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame.cs
{
    public class Day
    {
        public List<Customer> customer;
        public Weather weather;
        public Day()
        {
            customer = new List<Customer>();
            weather = new Weather();
        }
    }
}
