using System;

namespace chain_of_responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            AuthenticationHandler authenticationHandler = new AuthenticationHandler();
            AuthorizationHandler authorizationHandler = new AuthorizationHandler();
            CacheHandler cacheHandler = new CacheHandler();
            ValidationHandler validationHandler = new ValidationHandler();

            authenticationHandler.SetNext(authorizationHandler).SetNext(cacheHandler).SetNext(validationHandler);
            authenticationHandler.Handle("dummy");
        }
    }
}
