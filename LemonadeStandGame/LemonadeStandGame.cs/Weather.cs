using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame.cs
{
    public class Weather : Day
    {
        public string sunny;
        public string cloudy;
        public string rainy;
        public string fair;
        public string condition;

        public void ShowWeather()
        {   
            Console.WriteLine("The weather condition today is {0}\n", condition);
        }
        public void WeatherCondition()
        {
        }
  }
}
