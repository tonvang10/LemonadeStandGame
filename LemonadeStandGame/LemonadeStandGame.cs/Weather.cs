using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame.cs
{
    class Weather
    {
        decimal randomWeather;

        public Weather()
        { 
        }
        public void PickWeatherCondition()
        {
            Random rnd = new Random();
            string[] condition = new string[4];
            condition[0] = "92";
            condition[1] = "85";
            condition[2] = "71";
            condition[3] = "77";
            condition[4] = "68";
            condition[5] = "83";
            condition[6] = "69";
            condition[7] = "75";
            Console.WriteLine("The weather temperature today is {0}.\n", (condition[rnd.Next(0, 7)]));
            randomWeather = decimal.Parse(Console.ReadLine());
            if (randomWeather > 90)
            {
            }
            else if (randomWeather > 80 && randomWeather < 90)
            {
            }
            else if (randomWeather > 70 && randomWeather < 80)
            {
            }
            else if (randomWeather > 60 && randomWeather < 70)
            {
            }
        }
    }
}
