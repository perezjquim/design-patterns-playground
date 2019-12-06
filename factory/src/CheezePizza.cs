using System;

namespace factory
{
    class CheesePizza : IPizza
    {
        public void make()
        {
            Console.WriteLine("aqui vai uma pizza de queijo!");
        }
    }
}