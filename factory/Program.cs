using System;

namespace factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">>> FUNCHAL");
            IPizzaFactory ff = new FunchalPizzaFactory();
            ff.createPizza("greek").make();
            ff.createPizza("cheese").make();
            ff.createPizza("vegetarian").make();
            Console.WriteLine("<<< FUNCHAL");

            Console.WriteLine();

            Console.WriteLine(">>> LISBON");
            IPizzaFactory lf = new LisbonPizzaFactory();
            lf.createPizza("greek").make();
            lf.createPizza("cheese").make();
            lf.createPizza("vegetarian").make();
            Console.WriteLine("<<< LISBON");            
        }
    }
}
