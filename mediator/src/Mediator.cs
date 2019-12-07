using System;

namespace mediator
{
    class Mediator : IMediator
    {
        public void Notify(object aSender, string aEvent)
        {
            Console.WriteLine($"{aSender.ToString()} firing event '{aEvent}'");
        }
    }
}