using System;

namespace command
{
    class CommandC : ICommand
    {
        public IReceiver mReceiver { get; set; }
        public CommandC(IReceiver aReceiver = null)
        {
            mReceiver = aReceiver;
        }
        public void Execute()
        {
            Console.WriteLine("executing command C!");
            if (mReceiver != null)
            {
                mReceiver.Receive();
            }
        }
    }
}