using System;

namespace command
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoker ia = new Invoker();
            ICommand ca = new CommandA();
            ia.mCommand = ca;
            ia.Execute();            

            Invoker ib = new Invoker();
            ICommand cb = new CommandB();
            ib.mCommand = cb;
            ib.Execute();            

            Invoker ic = new Invoker();
            IReceiver rc = new ReceiverC();
            ICommand cc = new CommandC(rc);
            ic.mCommand = cc;
            ic.Execute();
        }
    }
}
