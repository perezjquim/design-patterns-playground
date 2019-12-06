using System;

namespace decorator
{
    class Sugar : Drink
    {
        public Sugar(Drink aDrink) : base(aDrink)
        { }

        public Sugar() : base()
        { }

        public override void Make()
        {
            Console.WriteLine("Pouring sugar..");
        }
    }
}