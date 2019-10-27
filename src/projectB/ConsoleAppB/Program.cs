using ClassLibraryBB;
using System;

namespace ConsoleAppB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of steaks");

            var n = Console.Read();
            var fN = Pan.DoPutInThaPan(n);
            foreach (var item in fN)
                Console.WriteLine(item);
            foreach (var item in fN)
                Console.WriteLine(item);
        }
    }
}
