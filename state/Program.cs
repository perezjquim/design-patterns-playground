using System;

namespace state
{
    class Program
    {
        static void Main(string[] args)
        {
            Context c = new Context(new StateA());
            c.onReceive("qualquer coisa");
            c.onSend("qualquer coisa");
            c.onSend("qualquer coisa");
            c.onReceive("qualquer coisa");
            c.onReceive("qualquer coisa");
            c.onReceive("qualquer coisa");
            c.onSend("qualquer coisa");
            c.onReceive("qualquer coisa");            
        }
    }
}
