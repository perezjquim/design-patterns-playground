using System;

namespace observer
{
    class Program
    {
        static void Main(string[] args)
        {
            ISubject wp = new WeatherProvider();

            IObserver aw = new AndroidWeatherWidget();
            wp.RegisterObserver(aw);
            wp.Notify("test android"); 

            Console.WriteLine();

            IObserver ww = new WebWeatherWidget();
            wp.RegisterObserver(ww);
            wp.Notify("test android + web");    

            Console.WriteLine();                    

            IObserver iw = new IOSWeatherWidget();
            wp.RegisterObserver(iw);
            wp.Notify("test android + web + ios");

            Console.WriteLine();

            wp.UnregisterObserver(ww);
            wp.Notify("test android + ios");
         }
    }
}
