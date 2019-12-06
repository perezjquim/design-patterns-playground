using System;

namespace proxy
{
    class AuthProxy : IProxy
    {
        public IProxy mProxy { get; set; }
        public AuthProxy(IProxy aProxy)
        {
            mProxy = aProxy;
        }

        public AuthProxy() { }

        public bool OnRequest()
        {
            Console.WriteLine("verifying auth..");
            if (this.IsAuthenticated())
            {
                Console.WriteLine("authenticated!");
                if (mProxy != null)
                {
                    mProxy.OnRequest();
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsAuthenticated()
        {
            return true;
        }
    }
}