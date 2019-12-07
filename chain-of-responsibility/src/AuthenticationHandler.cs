using System;

namespace chain_of_responsibility
{
    class AuthenticationHandler : BaseHandler
    {
        public override object Handle(object aArgs)
        {
            Console.WriteLine("checking authentication..");

            if (CheckAuthentication(aArgs))
            {
                Console.WriteLine("authentication OK!");
                return base.Handle(aArgs);
            }
            else
            {
                Console.WriteLine("authentication failed!");
                return null;
            }
        }

        public bool CheckAuthentication(object aArgs)
        {
            return true;
        }
    }
}