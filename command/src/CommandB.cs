using System;

namespace command
{
    class CommandB : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("executing command B!");
        }
    }
}