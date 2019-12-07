using System;
using System.Collections.Generic;

namespace strategy
{
    class InsertionSortStrategy<T> : ISortStrategy<T>
    {
        public List<T> Sort(List<T> aList)
        {
            Console.WriteLine("sorted list using Insertion Sort!");
            return aList;
        }
    }
}