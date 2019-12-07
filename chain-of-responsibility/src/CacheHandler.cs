using System;

namespace chain_of_responsibility
{
    class CacheHandler : BaseHandler
    {
        public override object Handle(object aArgs)
        {
            if (aArgs.ToString() == "cache")
            {
                Console.WriteLine("checking cache..");

                if (CheckCache(aArgs))
                {
                    Console.WriteLine("cache checked!");
                    return "success!";
                }
                else
                {
                    Console.WriteLine("cache failed!");
                    return "fail!";
                }
            }
            else
            {
                return base.Handle(aArgs);
            }
        }

        public bool CheckCache(object aArgs)
        {
            return true;
        }
    }
}