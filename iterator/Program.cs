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

            IEnumerator<string> enumerator = enumerable.GetEnumerator();

            while(enumerator.HasNext())
            {
                Console.WriteLine(enumerator.GetNext());
            }
        }
    }
}
