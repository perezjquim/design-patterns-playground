using System;

namespace chain_of_responsibility
{
    class ValidationHandler : BaseHandler
    {
        public override object Handle(object aArgs)
        {
            Console.WriteLine("validating..");

            if (Validate(aArgs))
            {
                Console.WriteLine("validated!");
                return base.Handle(aArgs);
            }
            else
            {
                Console.WriteLine("validation failed!");
                return null;
            }
        }

        public bool Validate(object aArgs)
        {
            return true;
        }
    }
}