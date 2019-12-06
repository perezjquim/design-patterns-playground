using System;

namespace adapter
{
    class Omnivore : IAnimal
    {
        public void Eat()
        {
            Console.WriteLine("eating some meat and some grass..");
        }
    }
}