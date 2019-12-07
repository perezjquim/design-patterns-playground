using System;

namespace chain_of_responsibility
{
    class AuthenticationHandler : BaseHandler
    {
        public override object Handle(object aArgs)
        {


            if (aArgs.ToString() == "authentication")
            {
                Console.WriteLine("checking authentication..");

                if (CheckAuthentication(aArgs))
                {
                    Console.WriteLine("authentication OK!");
                    return "success!";
                }
                else
                {
                    Console.WriteLine("authentication failed!");
                    return "fail!";
                }
            }
            else
            {
                return base.Handle(aArgs);
            }
        }

        public bool CheckAuthentication(object aArgs)
        {
            return true;
        }
    }
}