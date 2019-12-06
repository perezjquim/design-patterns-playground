using System;

namespace adapter
{
    class Carnivore : IAnimal
    {
        public void Eat()
        {
            Console.WriteLine("eating some meat..");
        }
    }
}