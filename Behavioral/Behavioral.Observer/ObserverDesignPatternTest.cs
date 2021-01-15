using System;
using Xunit;

namespace Behavioral.Observer
{
    public class ObserverDesignPatternTest
    {
        [Fact]
        public void Test1()
        {
            // arrange 
            WeatherData weatherData = new WeatherData();
            CurrentConditionDisplay currentConditionDisplay = new CurrentConditionDisplay(weatherData);

            // act 
            weatherData.SetMeasurement(45, 50);

            // assert 
            Assert.Equal(45, currentConditionDisplay.temp);
            Assert.Equal(50, currentConditionDisplay.humidity);
        }
    }
}
