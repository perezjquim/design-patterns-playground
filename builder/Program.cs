using System;

namespace builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">> BK");
            BKBuilder bk = new BKBuilder();
            bk
                .AddBread()
                .AddLettuce()
                .AddCondiments()
                .AddMeat()
                .AddOnions();
            Burger hbk = bk.Build();
            Console.WriteLine("<< BK");

            Console.WriteLine();

            Console.WriteLine(">> MC");
            MCBuilder mc = new MCBuilder();
            mc
                .AddBread()
                .AddLettuce()
                .AddCondiments()
                .AddMeat()
                .AddOnions();
            Burger hmc = mc.Build();
            Console.WriteLine("<< MC");
        }
    }
}
