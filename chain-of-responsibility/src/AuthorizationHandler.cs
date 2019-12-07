using System;

namespace chain_of_responsibility
{
    class AuthorizationHandler : BaseHandler
    {
        public override object Handle(object aArgs)
        {
            Console.WriteLine("checking authorization..");

            if (CheckAuthorization(aArgs))
            {
                Console.WriteLine("authorization granted!");
                return base.Handle(aArgs);
            }
            else
            {
                Console.WriteLine("authorization not granted!");
                return null;
            }
        }

        public bool CheckAuthorization(object aArgs)
        {
            return true;
        }
    }
}