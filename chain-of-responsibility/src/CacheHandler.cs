using System;

namespace chain_of_responsibility
{
    class CacheHandler : BaseHandler
    {
        public override object Handle(object aArgs)
        {
            Console.WriteLine("checking cache..");

            if (CheckCache(aArgs))
            {
                Console.WriteLine("cache checked!");
                return base.Handle(aArgs);
            }
            else
            {
                Console.WriteLine("cache failed!");
                return null;
            }
        }

        public bool CheckCache(object aArgs)
        {
            return true;
        }
    }
}