namespace Behavioral.Observer
{
    public class WeatherData : ISubject
    {
        private float Temprature;
        private float Humidity;

        protected override void NotifyObservers()
        {
            foreach (var observer in this.Observers)
            {
                observer.Update(this.Temprature, this.Humidity);
            }
        }

        public void SetMeasurement(float temprature, float humidity)
        {
            this.Temprature = temprature;
            this.Humidity = humidity;
            MeasurementChanged();
        }

        private void MeasurementChanged()
        {
            NotifyObservers();
        }
    }
}