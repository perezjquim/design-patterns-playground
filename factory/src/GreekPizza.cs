using System;

namespace factory
{
    class GreekPizza : IPizza
    {
        public void make()
        {
            Console.WriteLine("aqui vai uma pizza grega!");
        }
    }
}