using System;

namespace chain_of_responsibility
{
    class ValidationHandler : BaseHandler
    {
        public override object Handle(object aArgs)
        {
            if (aArgs.ToString() == "validation")
            {
                Console.WriteLine("validating..");

                if (Validate(aArgs))
                {
                    Console.WriteLine("validated!");
                    return "success!";
                }
                else
                {
                    Console.WriteLine("validation failed!");
                    return "failed!";
                }
            }
            else
            {
                return base.Handle(aArgs);
            }

        }

        public bool Validate(object aArgs)
        {
            return true;
        }
    }
}