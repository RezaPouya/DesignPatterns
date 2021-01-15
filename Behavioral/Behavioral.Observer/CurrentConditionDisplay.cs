using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.Observer
{
    public class CurrentConditionDisplay : IWeatherObserver, IWeatherDisplayElement
    {

        internal float temp;
        internal float humidity;

        private ISubject weatherData;

        public CurrentConditionDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            this.weatherData.RegisterObserver(this);
        }

        public string Display()
        {
            return $"Temprature : {temp} , Humidity : {humidity}";
        }

        public void Update(float temp, float humidity)
        {
            this.temp = temp;
            this.humidity = humidity;
            Display();
        }
    }
}
