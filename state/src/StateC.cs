using System;

namespace state
{
    public class StateC : State
    {
        public override void onReceive(object aObject)
        {
            Console.WriteLine(">>>");            
            Console.WriteLine("onReceive - state C");
            Console.WriteLine("state not changed");
            Console.WriteLine("<<<");         

            Console.WriteLine();                 
        }

        public override void onSend(object aObject)
        {
            Console.WriteLine(">>>");            
            Console.WriteLine("onSend - state C");
            Console.WriteLine("state C --> state A");
            mContext.TransitionTo(new StateA());            
            Console.WriteLine("<<<");     

            Console.WriteLine();                     
        }
    }
}