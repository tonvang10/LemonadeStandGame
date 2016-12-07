using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame.cs
{
    class Weather
    {
        public Weather()
        { 
        }
        public void PickWeatherCondition()
        {
            Random temperatures = new Random();
            string[] condition = new string[8];
            condition[0] = "92" + " degrees";
            condition[1] = "85" + " degrees";
            condition[2] = "71" + " degrees";
            condition[3] = "77" + " degrees";
            condition[4] = "68" + " degrees";
            condition[5] = "83" + " degrees";
            condition[6] = "69" + " degrees";
            condition[7] = "75" + " degrees";
            Console.WriteLine("The weather temperature today is {0}.\n", (condition[temperatures.Next(0, 7)]));
        }
    }
}
