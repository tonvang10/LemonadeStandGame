using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame.cs
{
    class Weather
    {
        public string sunny;
        public string cloudy;
        public string rainy;
        public string fair;

        public void ShowWeather()
        {
            Console.WriteLine("The weather condition today is {0}");
        }
        //public string RandomWeather()
        //{
            //List<string> [] weatherCondition = new List<string>[3];
            //weatherCondition.sunny();
            //weatherCondition.cloudy();
            //weatherCondition.rainy();
            //weatherCondition.fair();
            //return weatherCondition;

            
        //}
    }
}
