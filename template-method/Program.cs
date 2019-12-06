using System;

namespace template_method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">>> IOS");
            IOSBuilder ib = new IOSBuilder();
            ib.run();
            Console.WriteLine("<<< IOS");

            Console.WriteLine();

            Console.WriteLine(">>> ANDROID");
            AndroidBuilder ab = new AndroidBuilder();
            ab.run();
            Console.WriteLine("<<< ANDROID");            
        }
    }
}
