using System;

namespace observer
{
    class AndroidWeatherWidget : IObserver
    {
        public void Display(object aObject)
        {
            Console.WriteLine($"AndroidWeatherWidget presents...{aObject.ToString()}");
        }

        public void OnNotified(object aObject)
        {
            this.Display(aObject);
        }

        public void OnNotified()
        {
            this.Display("refreshhh");
        }        
    }
}