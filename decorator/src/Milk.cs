using System;

namespace decorator
{
    class Milk : Drink
    {
        public Milk(Drink aDrink) : base(aDrink)
        { }

        public Milk() : base()
        { }

        public override void Make()
        {
            Console.WriteLine("Pouring milk..");
        }
    }
}