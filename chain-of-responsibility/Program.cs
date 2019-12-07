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

            authenticationHandler
                .SetNext(authorizationHandler)
                .SetNext(cacheHandler)
                .SetNext(validationHandler);

            Console.WriteLine(">>> CACHE");
            authenticationHandler.Handle("cache");
            Console.WriteLine("<<< CACHE");
            Console.WriteLine();

            Console.WriteLine(">>> VALIDATION");
            authenticationHandler.Handle("validation");
            Console.WriteLine("<<< VALIDATION");
            Console.WriteLine();

            Console.WriteLine(">>> NONE");
            authenticationHandler.Handle("none");
            Console.WriteLine("<<< NONE");
            Console.WriteLine();

            Console.WriteLine(">>> AUTHENTICATION");
            authenticationHandler.Handle("authentication");
            Console.WriteLine("<<< AUTHENTICATION");
            Console.WriteLine();

            Console.WriteLine(">>> AUTHORIZATION");
            authenticationHandler.Handle("authorization");
            Console.WriteLine("<<< AUTHORIZATION");
            Console.WriteLine();
        }
    }
}
