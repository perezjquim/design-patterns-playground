using System;

namespace iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            StringArray enumerable = new StringArray();
            enumerable
                .Add("str1")
                .Add("str2");

            IEnumerator enumerator = enumerable.GetEnumerator();

            while(enumerator.HasNext())
            {
                Console.WriteLine(enumerator.GetNext());
            }
        }
    }
}
