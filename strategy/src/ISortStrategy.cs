using System.Collections.Generic;

namespace strategy
{
    interface ISortStrategy<T>
    {
        List<T> Sort(List<T> aList);
    }
}