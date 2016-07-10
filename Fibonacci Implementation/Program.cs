using System;

class Program
{
    public static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;

        // F is temp variable to help exchange the variable name
        int f1 = 0, f2 = 1, f = 0;

        // {0 + 1} { 1 + 1} { 1 + 2}
        // In N steps compute Fibonacci sequence iteratively.
        for (int i = 2; i <= n; i++)
        {
            /*f = f1;
            f1 = f2;
            f2 = f + f2;*/

            f = f1 + f2;
            f1 = f2;
            f2 = f;
        }
        return f;
    }

    static void Main()
    {
        // r = 8 if n = 6;
        var total = 0;

        var y = int.Parse(Console.ReadLine());
        Console.WriteLine("The result if: " + Fibonacci(y));
        Console.ReadLine();

        for (int i = 0; i < 15; i++)
        {
            var x = Fibonacci(i);
            total += x;
            Console.WriteLine(x);
        }
        Console.WriteLine(total);
    }
}