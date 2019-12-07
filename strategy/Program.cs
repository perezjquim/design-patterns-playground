using System.Collections.Generic;

namespace strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> l = new List<string>();
            l.Add("x");

            Sorter<string> s = new Sorter<string>(l);
            s.mStrategy = new BubbleSortStrategy<string>();
            s.Sort();

            l.Add("a");
            s.mStrategy = new QuickSortStrategy<string>();
            s.Sort();

            l.Add("c");
            s.mStrategy = new InsertionSortStrategy<string>();
            s.Sort();
        }
    }
}
