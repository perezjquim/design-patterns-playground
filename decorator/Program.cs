using System;

namespace decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">>> COFFEE + MILK + SUGAR");
            Drink d = new Coffee();
            d = new Milk(d);
            d = new Sugar(d);
            d.Finish();
            Console.WriteLine("<<< COFFEE + MILK + SUGAR");            

            Console.WriteLine();

            Console.WriteLine(">>> COFFEE + SUGAR");
            Drink d2 = new Coffee();
            d2 = new Sugar(d2);
            d2.Finish();
            Console.WriteLine("<<< COFFEE + SUGAR");     

            Console.WriteLine();                

            Console.WriteLine(">>> MILK");
            Drink d3 = new Milk();
            d3.Finish();
            Console.WriteLine("<<< MILK");                
        }
    }
}
