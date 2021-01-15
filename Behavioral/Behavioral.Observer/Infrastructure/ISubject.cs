using System.Collections.Generic;
using System.Linq;

namespace Behavioral.Observer
{
    // you can use it as interface
    public abstract class ISubject
    {
        protected IList<IWeatherObserver> Observers = new List<IWeatherObserver>();

        protected abstract void NotifyObservers();

        public void RegisterObserver(IWeatherObserver observer)
        {
            if (this.Observers.Any(p => p.Equals(observer)) == false)
                this.Observers.Add(observer);
        }

        public void RemoveObserver(IWeatherObserver observer)
        {
            if (this.Observers.Any(p => p.Equals(observer)))
                this.Observers.Remove(observer);
        }
    }
}