using System;

namespace decorator
{
    class Milk : Drink
    {
        public Milk(Drink aDrink = null) : base(aDrink)
        { }
        public override void Make()
        {
            Console.WriteLine("Pouring milk..");
        }
    }
}