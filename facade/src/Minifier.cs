using System;

namespace facade
{
    class Minifier
    {
        public string mCode { get; set; }

        public Minifier(string aCode)
        {
            mCode = aCode;
        }

        public string Minify()
        {
            Console.WriteLine("minifying code...");
            return mCode.ToLower();
        }
    }
}