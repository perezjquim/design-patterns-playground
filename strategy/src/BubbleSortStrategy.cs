using System;
using System.Collections.Generic;

namespace strategy
{
    class BubbleSortStrategy<T> : ISortStrategy<T>
    {
        public List<T> Sort(List<T> aList)
        {
            Console.WriteLine("sorted list using Bubble Sort!");
            return aList;
        }
    }
}