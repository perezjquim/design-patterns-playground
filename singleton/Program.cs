using System;

namespace singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Application a = Application.mInstance;
            a.Test();

            Application b = Application.mInstance;
            b.Test();            
        }
    }
}
