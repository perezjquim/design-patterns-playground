using System;

namespace decorator
{
    class Sugar : Drink
    {
        public Sugar(Drink aDrink = null) : base(aDrink)
        { }
        public override void Make()
        {
            Console.WriteLine("Pouring sugar..");
        }
    }
}