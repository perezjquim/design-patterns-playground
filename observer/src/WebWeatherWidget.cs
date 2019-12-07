using System;

namespace observer
{
    class WebWeatherWidget : IObserver
    {
        public void Display(object aObject)
        {
            Console.WriteLine($"WebWeatherWidget presents...{aObject.ToString()}");
        }

        public void OnNotified(object aObject = null)
        {
            this.Display(aObject);
        }   
    }
}