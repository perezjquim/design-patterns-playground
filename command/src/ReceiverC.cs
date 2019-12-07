using System;

namespace command
{
    class ReceiverC : IReceiver
    {
        public void Receive()
        {
            Console.WriteLine("command C received!");
        }
    }
}