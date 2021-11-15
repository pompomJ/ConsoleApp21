using System;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            do
            {
                Console.WriteLine(++i);
            }
            while (i < 5);
        }
    }
}
