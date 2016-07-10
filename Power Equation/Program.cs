using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Equation
{
    class Program
    {
        // O(n)
        static unsafe int AlbertPow(int* x, int n)
        {
            if (n == 0)
                return 1;
            else
                return *x * AlbertPow(x, n - 1);
        }

        // O(log(n))
        static unsafe int Pinto(int* x, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else if (n % 2 == 0)
            {
                var y = Pinto(x, n / 2);
                return y * y;
            }
            else
            {
                var r = Pinto(x, n - 1);
                //return *x * Pinto(x, n - 1);
                return *x * r;
            }
        }
        static unsafe void Main()
        {
            var x = 2;
            int* pt = &x;
            Console.Write("Pinto's: ");
            Console.WriteLine(Pinto(pt, 8));

            Console.WriteLine();

            Console.Write("Alber's: ");
            Console.WriteLine(AlbertPow(pt, 8));
            Console.ReadKey();
        }
    }
}
