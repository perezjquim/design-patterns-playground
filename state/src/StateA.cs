using System;

namespace state
{
    public class StateA : State
    {
        public override void onReceive(object aObject)
        {
            Console.WriteLine(">>>");
            Console.WriteLine("onReceive - state A");
            Console.WriteLine("state A --> state B");
            mContext.TransitionTo(new StateB());
            Console.WriteLine("<<<");        

            Console.WriteLine();    
        }

        public override void onSend(object aObject)
        {
            Console.WriteLine(">>>");            
            Console.WriteLine("onSend - state A");
            Console.WriteLine("state not changed"); 
            Console.WriteLine("<<<");        

            Console.WriteLine();                                  
        }        
    }
}