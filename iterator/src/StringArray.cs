using System.Collections.Generic;

namespace iterator
{
    class StringArray : IEnumerable
    {
        public List<string> mContent { get; set; }

        public StringArray()
        {
            mContent = new List<string>();
        }

        public List<string> Add(string aString)
        {
            mContent.Add(aString);
            return mContent;
        }

        public List<string> Remove(string aString)
        {
            mContent.Remove(aString);
            return mContent;
        }

        public IEnumerator GetEnumerator()
        {
            return new StringArrayEnumerator(this);
        }
    }
}