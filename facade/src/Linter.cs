using System;

namespace facade
{
    class Linter
    {
        public string mCode { get; set; }

        public Linter(string aCode)
        {
            mCode = aCode;
        }

        public bool Lint()
        {
            Console.WriteLine("linting code...");
            return true;
        }
    }
}