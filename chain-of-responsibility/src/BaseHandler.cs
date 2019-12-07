using System;

namespace chain_of_responsibility
{
    abstract class BaseHandler : IHandler
    {
        private IHandler mNextHandler;

        public virtual object Handle(object aArgs)
        {
            if(mNextHandler != null)
            {
                Console.WriteLine("passing to the next handler..");
                return mNextHandler.Handle(aArgs);
            }
            else
            {
                Console.WriteLine("unhandled :(");
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