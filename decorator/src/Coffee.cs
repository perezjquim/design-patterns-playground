using System;

namespace decorator
{
    class Coffee : Drink
    {
        public Coffee(Drink aDrink) : base(aDrink)
        { }

        public Coffee() : base()
        { }

        public override void Make()
        {
            Console.WriteLine("Pouring coffee..");
        }
    }
}