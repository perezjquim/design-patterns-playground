using System;
using System.Collections.Generic;

namespace strategy
{
    class QuickSortStrategy<T> : ISortStrategy<T>
    {
        public List<T> Sort(List<T> aList)
        {
            Console.WriteLine("sorted list using Quick Sort!");
            return aList;
        }
    }
}