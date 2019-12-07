using System;

namespace observer
{
    class AndroidWeatherWidget : IObserver
    {
        public void Display(object aObject)
        {
            Console.WriteLine($"AndroidWeatherWidget presents...{aObject.ToString()}");
        }

        public void OnNotified(object aObject = null)
        {
            this.Display(aObject);
        }   
    }
}