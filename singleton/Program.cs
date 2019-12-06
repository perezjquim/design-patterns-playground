using System;

namespace singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Application a = Application.GetInstance();
            a.Test();

            Application b = Application.GetInstance();
            b.Test();            
        }
    }
}
