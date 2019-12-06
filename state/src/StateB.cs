using System;

namespace state
{
    public class StateB : State
    {
        public override void onReceive(object aObject)
        {
            Console.WriteLine(">>>");
            Console.WriteLine("onReceive - state B");
            Console.WriteLine("state B --> state C");
            mContext.TransitionTo(new StateC());
            Console.WriteLine("<<<");

            Console.WriteLine();              
        }

        public override void onSend(object aObject)
        {
            Console.WriteLine(">>>");
            Console.WriteLine("onSend - state B");
            Console.WriteLine("state not changed");
            Console.WriteLine("<<<");

            Console.WriteLine();              
        }
    }
}