using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame.cs
{
    class Inventory : Store
    {
        public decimal money = 20.00M;

        public void DisplayMoney()
        {
            Console.WriteLine("You saved up to $20 dollars to spend on your lemonade stand.");
        }
        public void track()
        {

        }
        public void TrackPlayerMoney()
        {
        }
    }
}
