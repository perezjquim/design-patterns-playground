using System;

namespace template_method
{
    class AndroidBuilder : Builder
    {
        public override void lint()
        {
            Console.WriteLine("ANDROID SDK - LINT");
        }

        public override void minify()
        {
            Console.WriteLine("ANDROID SDK - MINIFY");
        }

        public override void build()
        {
            Console.WriteLine("ANDROID SDK - BUILD");
        }

        public override void install()
        {
            Console.WriteLine("ANDROID SDK - INSTALL");
        }
    }
}