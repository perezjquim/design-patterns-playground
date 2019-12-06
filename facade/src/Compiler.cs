using System;

namespace facade
{
    class Compiler
    {
        public string mCode { get; set; }

        public Compiler(string aCode)
        {
            mCode = aCode;
        }

        public bool Compile()
        {
            Console.WriteLine("compiling code...");
            return true;
        }

        public void Execute()
        {
            Console.WriteLine("executing code...");
        }
    }
}