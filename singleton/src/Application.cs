using System;

namespace singleton
{
    sealed class Application
    {
        public static Application mInstance { get; } = new Application(); 
        private Application() {}
        public void Test()
        {
            Console.WriteLine("great success!");
        }
    }
}