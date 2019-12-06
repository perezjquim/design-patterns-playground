using System;

namespace facade
{
    class Facade
    {
        public string mCode { get; set; }

        public Facade(string aCode)
        {
            mCode = aCode;
        }

        public void Execute()
        {
            Linter l = new Linter(mCode);
            bool isLintSuccessful = l.Lint();
            if(!isLintSuccessful) 
            {
                Console.WriteLine("error at linting");
                return;
            }

            Minifier m = new Minifier(mCode);
            string minifiedCode = m.Minify();

            Compiler c = new Compiler(minifiedCode);
            bool isCompileSuccessful = c.Compile();
            if(!isCompileSuccessful)
            {
                Console.WriteLine("error at compiling");
                return;
            }

            c.Execute();
        }
    }
}