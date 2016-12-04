using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame.cs
{
    class Day : Weather
    {
        //public string days;

        public void TrackDays()
        {
            int days = 1;
            while (days < 8)
            {
                Console.WriteLine("DAY {0}, good luck!", days);
                days++;
            }

        }
    }
}
