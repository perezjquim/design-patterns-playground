using System;

namespace mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Mediator m = new Mediator();
            ComponentA ca = new ComponentA(m);
            ComponentB cb = new ComponentB(m);
            ca.OnA();
            cb.OnB();
        }
    }
}
