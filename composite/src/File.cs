namespace composite
{
    class File : IContent
    {
        public bool mIsModified
        { get; set; }

        public string mName
        { get; set; }

        public int mSize 
        { get; set; }

        public File(string aName, int aSize)
        {
            mName = aName;
            mSize = aSize;
            mIsModified = false;
        }

        public int GetSize()
        {
            return mSize;
        }

        public bool IsModified()
        {
            return mIsModified;
        }
    }
}