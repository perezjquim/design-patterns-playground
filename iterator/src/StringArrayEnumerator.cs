using System.Collections.Generic;

namespace iterator
{
    class StringArrayEnumerator : IEnumerator<string>
    {
        private int mIndex = 0;
        private List<string> mContent;

        public StringArrayEnumerator(List<string> aContent)
        {
            mContent = aContent;
        }

        public bool HasNext()
        {
            return mIndex < mContent.Count;
        }

        public string GetNext()
        {
            string next = mContent.ToArray()[mIndex];
            mIndex++;
            return next;
        }
    }
}