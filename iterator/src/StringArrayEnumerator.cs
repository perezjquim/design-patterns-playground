using System.Collections.Generic;

namespace iterator
{
    class StringArrayEnumerator : IEnumerator
    {
        private int mIndex = 0;
        private StringArray mEnumerable;

        public StringArrayEnumerator(StringArray aEnumerable)
        {
            mEnumerable = aEnumerable;
        }

        public bool HasNext()
        {
            return mIndex < mEnumerable.mContent.Count;
        }

        public object GetNext()
        {
            string next = mEnumerable.mContent.ToArray()[mIndex];
            mIndex++;
            return next;
        }
    }
}