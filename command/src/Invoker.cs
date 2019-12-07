using System;

namespace command
{
    class Invoker
    {
        public ICommand mCommand { get; set; }

        public void Execute()
        {
            if(mCommand != null)
            {
                Console.WriteLine("executing command..");
                mCommand.Execute();
            }
        }
    }
}