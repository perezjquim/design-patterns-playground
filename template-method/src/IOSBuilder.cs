using System;

namespace template_method
{
    class IOSBuilder : Builder
    {
        public override void lint()
        {
            Console.WriteLine("XCODE - LINT");
        }

        public override void minify()
        {
            Console.WriteLine("XCODE - MINIFY");
        }

        public override void build()
        {
            Console.WriteLine("XCODE - BUILD");
        }

        public override void install()
        {
            Console.WriteLine("XCODE - INSTALL");
        }
    }
}