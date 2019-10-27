using ClassLibraryBB;
using System;

namespace ConsoleAppB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of steaks yeah for real now ");

            var n = Console.Read();
            var fN = Pan.DoPutInThaPan(n);
            foreach (var item in fN)
                Console.WriteLine(item);
        }
    }
}
