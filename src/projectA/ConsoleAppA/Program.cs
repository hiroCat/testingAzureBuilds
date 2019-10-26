using ClassLibraryA;
using System;

namespace ConsoleAppA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of nugets");

            var n = Console.Read();
            var fN = Frier.DoFry(n);
            foreach (var item in fN)
                Console.WriteLine(item);
            foreach (var item in fN)
                Console.WriteLine(item);
            foreach (var item in fN)
                Console.WriteLine(item);
            foreach (var item in fN)
                Console.WriteLine(item);
        }
    }
}
