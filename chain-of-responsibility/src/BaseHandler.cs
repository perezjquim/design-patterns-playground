namespace chain_of_responsibility
{
    abstract class BaseHandler : IHandler
    {
        private IHandler mNextHandler;

        public virtual object Handle(object aArgs)
        {
            if(mNextHandler != null)
            {
                return mNextHandler.Handle(aArgs);
            }
            else
            {
                return null;
            }
        }

        public IHandler SetNext(IHandler aNextHandler)
        {
            mNextHandler = aNextHandler;
            return mNextHandler;
        }
    }
}