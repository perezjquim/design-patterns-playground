using System;

namespace adapter
{
    class Herbivore : IAnimal
    {
        public void Eat()
        {
            Console.WriteLine("eating some grass..");
        }
    }
}