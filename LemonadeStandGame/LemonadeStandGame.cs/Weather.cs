using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame.cs
{
    public class Weather
    {
        Random random;
        string weatherCondition;
        int temperature;
        int numberOfCustomers;

        public Weather()
        {
            random = new Random();
        }
        public int NumberOfCustomers
        {
            get { return numberOfCustomers; }
            set { numberOfCustomers = value; }
        }
        public int Temperature
        {
            get { return temperature; }
            set { temperature = value; }
        }
        public int AttractRandomCustomers()
        {
            if (temperature > 90)
            {
                numberOfCustomers = random.Next(60, 80);
                Console.WriteLine("Today there were {0} customers that stopped by.", numberOfCustomers);
            }
            else if (temperature > 80 && temperature < 90)
            {
                numberOfCustomers = random.Next(40, 60);
                Console.WriteLine("Today there were {0} customers that stopped by.", numberOfCustomers);
            }
            else if (temperature > 70 && temperature < 80)
            {
                numberOfCustomers = random.Next(20, 40);
                Console.WriteLine("Today there were {0} customers that stopped by.", numberOfCustomers);
            }
            else if (temperature > 60 && temperature < 70)
            {
                numberOfCustomers = random.Next(5, 20);
                Console.WriteLine("Today there were {0} customers that stopped by.", numberOfCustomers);
            }
            return numberOfCustomers;
        }
        public string GetWeatherCondition()
        {
            string[] weather = new string[3] { "sunny", "cloudy", "rainy" };
            weatherCondition = weather[random.Next(0, 3)];
            return weatherCondition;
        }
        public int GetTemperature()
        {
            int[] condition = new int[8];
            condition[0] = 92;
            condition[1] = 85;
            condition[2] = 83;
            condition[3] = 77;
            condition[4] = 75;
            condition[5] = 71;
            condition[6] = 69;
            condition[7] = 68;
            temperature = condition[random.Next(0, 7)];
            return temperature;
        }
        public void DisplayWeather()
        {
            GetWeatherCondition();
            GetTemperature();
            Console.WriteLine("The weather temperature today is {0} degrees and {1}.\n", temperature, weatherCondition);
        }
    }
}
