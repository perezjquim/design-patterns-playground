using System.Collections.Generic;

namespace strategy
{
    class Sorter<T>
    {
        public List<T> mList { get; set; }
        public ISortStrategy<T> mStrategy { get; set; }
        public Sorter(List<T> aList)
        {
            mList = aList;
        }
        public void Sort()
        {
            mStrategy.Sort(mList);
        }
    }
}