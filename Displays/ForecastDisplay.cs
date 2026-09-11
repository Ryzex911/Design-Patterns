using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class ForecastDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private Subject weatherData;
        public ForecastDisplay(Subject weatherData) 
        { 
            // Set the field and register itself with the weatherdata subject
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        public void Update(float temp, float humidity, float pressure)
        {
            // Set the correct fields with the relevant parameters
            this.temperature = temp;
            this.humidity = humidity;
            Display();
        }

        public void Display()
        {
            // Print a forecast message based on the current temperature and humidity
            if (temperature > 80 && humidity < 50)
            {
                Console.WriteLine("Forecast: It's going to be hot and dry today.");
            }
            else if (temperature > 80 && humidity >= 50)
            {
                Console.WriteLine("Forecast: It's going to be hot and humid today.");
            }
            else if (temperature <= 80 && humidity < 50)
            {
                Console.WriteLine("Forecast: It's going to be cool and dry today.");
            }
            else
            {
                Console.WriteLine("Forecast: It's going to be cool and humid today.");
            }
        }
    }
}
