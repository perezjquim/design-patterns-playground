using System;

namespace factory
{
    class BlandPizza : IPizza
    {
        public void make()
        {
            Console.WriteLine("aqui vai uma pizza básica!");
        }
    }
}