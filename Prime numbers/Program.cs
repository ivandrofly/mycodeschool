using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prime_numbers
{
    class Program
    {
        // Ram
        private static bool IsPrimeRam(int n)
        {
            Console.WriteLine("Ram's prime number checker: ");
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        //Shyam
        private static bool IsPrimeShyam(int n)
        {
            Console.WriteLine("Shyam's prime number checker: ");
            // √24 = 4.8...
            // a number is prime if it can only be factorized betweein 1 and number its self.
            // e.g: 8 can be factorized in 1*8, 2*4, 4*2, 8*1 while 7 is a prime nume because it can only be factorized 1*7 and 7*2
            // Math.Sqrt: which number can
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            // Get input
            var x = int.Parse(Console.ReadLine());

            // Call the function
            Console.WriteLine(IsPrimeRam(x));
            Console.WriteLine(IsPrimeShyam(x));

            Console.ReadLine();
        }
    }
}
