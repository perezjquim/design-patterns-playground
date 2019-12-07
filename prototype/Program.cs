using System;

namespace prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal(12,"Dog","Teco");
            
            Animal b  = a.Clone();
            b.mRace = "Cat";

            Console.WriteLine($"A -> {a.mDesc}");
            Console.WriteLine($"B -> {b.mDesc}");
        }
    }
}
