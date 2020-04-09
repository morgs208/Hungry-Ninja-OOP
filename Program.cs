using System;

namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet vegas = new Buffet();
            Console.WriteLine(vegas.Serve().Name);
        }
    }
}
