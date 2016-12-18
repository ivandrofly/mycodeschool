using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Using_factorial
{
    class Program
    {
        static long Factorial(int n, bool verbose)
        {
            if (verbose)
            {
                Console.WriteLine("I am calculating F(" + n + ")\n");
            }
            if (n == 0)
            {
                return 1;
            }
            long f = n * Factorial(n - 1, verbose);
            if (verbose)
            {
                Console.WriteLine("Done! F(" + n + ") = " + f + "\r\n");
            }
            return f;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Give me an n: ");
            int n = int.Parse(Console.ReadLine());
            long result = Factorial(n, false);
            Console.WriteLine($"{n} factoral is equal to: {result}");
        }
    }
}
