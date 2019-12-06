using System;

namespace proxy
{
    class CacheProxy : IProxy
    {
        public bool OnRequest()
        {
            Console.WriteLine("verifying cache...");
            Console.WriteLine("done!");
            return true;
        }
    }
}