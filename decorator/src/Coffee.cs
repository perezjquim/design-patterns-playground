using System;

namespace decorator
{
    class Coffee : Drink
    {
        public Coffee(Drink aDrink = null) : base(aDrink)
        { }
        public override void Make()
        {
            Console.WriteLine("Pouring coffee..");
        }
    }
}