using System;

namespace command
{
    class CommandA : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("executing command A!");
        }
    }
}