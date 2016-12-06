using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame.cs
{
    class Weather
    {
        //decimal randomWeather;

        public Weather()
        { 
        }
        public void PickWeatherCondition()
        {
            Random rnd = new Random();
            string[] condition = new string[8];
            condition[0] = "92" + " degrees";
            condition[1] = "85" + " degrees";
            condition[2] = "71" + " degrees";
            condition[3] = "77" + " degrees";
            condition[4] = "68" + " degrees";
            condition[5] = "83" + " degrees";
            condition[6] = "69" + " degrees";
            condition[7] = "75" + " degrees";
            Console.WriteLine("The weather temperature today is {0}.\n", (condition[rnd.Next(0, 7)]));
            //randomWeather = decimal.Parse(Console.ReadLine());
            //if (randomWeather > 90)
            //{
            //}
            //else if (randomWeather > 80 && randomWeather < 90)
            //{
            //}
            //else if (randomWeather > 70 && randomWeather < 80)
            //{
            //}
            //else if (randomWeather > 60 && randomWeather < 70)
            //{
            //}
        }
    }
}
