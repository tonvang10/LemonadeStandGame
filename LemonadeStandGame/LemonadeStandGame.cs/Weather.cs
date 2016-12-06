using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame.cs
{
    class Weather
    {
        string sunny;
        string cloudy;
        string rainy;
        string fair;
        string condition;

        public Weather()
        {

        }
        public void ShowWeatherCondition()
        {
            string[] condition = new string[4];
            condition[0] = "85 degees and sunny";
            condition[1] = "74 degrees and cloudy";
            condition[2] = "70 degrees and rainy";
            condition[3] = "77 degrees and fair";
            Random rnd = new Random();
            Console.WriteLine("The weather condition today is {0}\n", (condition[rnd.Next(0, 3)]));
        }
        //switch statement for weather with <>=- number of customers
    }
}
