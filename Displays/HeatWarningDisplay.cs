using System;
using ObserverPattern.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ObserverPattern.Displays
{

  internal class HeatWarningDisplay : Observer, DisplayElement
    {
        private float temperature;
        private Subject weatherData;
        public HeatWarningDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        public void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            Display();
        }
        public void Display()
        {
            if (temperature > 30)
            {
                Console.WriteLine("Heat Warning: It's extremely hot outside! Stay hydrated and avoid prolonged exposure to the sun");
            }
            else
            {
                Console.WriteLine("Heat Warning: No heat warning at the moment");
            }
        }
    }
}
