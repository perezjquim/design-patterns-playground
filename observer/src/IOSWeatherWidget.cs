using System;

namespace observer
{
    class IOSWeatherWidget : IObserver
    {
        public void Display(object aObject)
        {
            Console.WriteLine($"IOSWeatherWidget presents...{aObject.ToString()}");
        }

        public void OnNotified(object aObject = null)
        {
            this.Display(aObject);
        }
    }
}