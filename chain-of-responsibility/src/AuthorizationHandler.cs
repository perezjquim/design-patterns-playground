using System;

namespace chain_of_responsibility
{
    class AuthorizationHandler : BaseHandler
    {
        public override object Handle(object aArgs)
        {
            if (aArgs.ToString() == "authorization")
            {
                Console.WriteLine("checking authorization..");
                if (CheckAuthorization(aArgs))
                {
                    Console.WriteLine("authorization granted!");
                    return "success!";
                }
                else
                {
                    Console.WriteLine("authorization not granted!");
                    return "fail!";
                }
            }
            else
            {
                return base.Handle(aArgs);
            }
        }

        public bool CheckAuthorization(object aArgs)
        {
            return true;
        }
    }
}