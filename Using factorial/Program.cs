using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Using_factorial
{
    class Program
    {
        static int Factorial(int n)
        {
            Console.WriteLine("I am calculating F(" + n + ")\n");
            if (n == 0)
            {
                return 1;
            }
            int f = n * Factorial(n - 1);
            Console.WriteLine("Done! F(" + n + ") = " + f + "\r\n");
            return f;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Give me an n: ");
            int n = int.Parse(Console.ReadLine());
            int result = Factorial(n);
            Console.WriteLine("\r\n" + result);
        }
    }
}
