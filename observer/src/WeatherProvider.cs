using System.Collections.Generic;

namespace observer
{
    class WeatherProvider : ISubject
    {
        public List<IObserver> mObservers { get; set; }

        public WeatherProvider()
        {
            mObservers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver aObserver)
        {
            mObservers.Add(aObserver);
        }

        public void UnregisterObserver(IObserver aObserver)
        {
            mObservers.Remove(aObserver);
        }

        public void Notify(object aObject = null)
        {
            foreach(IObserver observer in mObservers)
            {
                observer.OnNotified(aObject);
            }
        }     
    }
}