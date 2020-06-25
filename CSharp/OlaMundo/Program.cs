using System;

namespace OlaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            OlaMundo o = new OlaMundo();
            Console.WriteLine($"{o.Ola()}");
            Message m = new Message();
            Console.WriteLine($"{m.MensagemRetornada()}");
        }
    }
}
