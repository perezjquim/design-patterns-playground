using System;

namespace proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            CacheProxy cp = new CacheProxy();
            AuthProxy ap = new AuthProxy(cp);
            ap.OnRequest();
        }
    }
}
