using System.Collections.Generic;

namespace composite
{
    class Folder : IContent
    {
        public string mName
        { get; set; }
        public Folder(string aName)
        {
            mName = aName;
            mContent = new List<IContent>();
        }
        public List<IContent> mContent { get; set; }

        public int GetSize()
        {
            int size = 0;
            foreach (IContent c in mContent)
            {
                size += c.GetSize();
            }
            return size;
        }

        public bool IsModified()
        {
            foreach (IContent c in mContent)
            {
                if(c.IsModified()) return true;
            }
            return false;
        }
        public Folder AddContent(IContent aData)
        {
            mContent.Add(aData);
            return this;
        }
    }
}